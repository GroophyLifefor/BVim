using H.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVim.Responsive
{
    internal class MouseHandle
    {
        public static void Init()
        {
            var mouseHook = new LowLevelMouseHook();
            Thread t = new Thread(MouseMove);

            //Configure delegates
            mouseHook.Down += (sender, _) => { downPosition = _.Position; isDownMove = true; };
            mouseHook.Up += (sender, _) => { downPosition = Point.Empty; isDownMove = false; };

            //Start it
            mouseHook.Start();
            t.Start();
        }

        public static void addDownRule(Action<Point, Point> action)
        {
            while (isDownRulesRunning) { }
            DownRules.Add(action);
        }
        public static void addRule(Action<Point> action)
        {
            while (isRulesRunning) { }
            Rules.Add(action);
        }
        
        private static void MouseMove()
        {
            for (; ; )
            {
                Point lpPoint;
                WinApi.GetCursorPos(out lpPoint);
                if (isDownMove)
                {
                    isRulesRunning = true;
                    for (int i = 0; i < DownRules.Count; i++) DownRules[i](downPosition, lpPoint);
                    isRulesRunning = false;
                }
                else // every moment
                {
                    isRulesRunning = true;
                    for (int i = 0;i < Rules.Count;i++) Rules[i](lpPoint);
                    isRulesRunning = false;
                }
            }
        }

        static List<Action<Point, Point>> DownRules = new List<Action<Point, Point>>();
        static bool isDownRulesRunning = false;
        static List<Action<Point>> Rules = new List<Action<Point>>();
        static bool isRulesRunning = false;

        static Point downPosition = Point.Empty;
        static bool isDownMove = false;
    }
}
