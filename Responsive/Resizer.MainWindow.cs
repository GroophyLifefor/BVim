using H.Hooks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BVim.Responsive
{
    internal class Resizer
    {
        public void ResizeDelegate(MainWindow mw) => mw.SizeChanged += (s, e) =>
        {
            int firstScintillaLocX = 0;
            int firstScintillaLocY = mw.MenuBar.Height + mw.HelpBar.Height + mw.DocumentBar.Height;
            int firstScintillaSizeX = mw.Width / 2 - 5;
            int firstScintillaSizeY = mw.StatusBar.Location.Y - firstScintillaLocY;

            mw.BCode.Location = new Point(firstScintillaLocX, firstScintillaLocY);
            mw.BCode.Size = new Size(firstScintillaSizeX, firstScintillaSizeY);

            int secondScintillaLocX = firstScintillaSizeX + 5;
            int secondScintillaLocY = mw.MenuBar.Height + mw.HelpBar.Height + mw.DocumentBar.Height;
            int secondScintillaSizeX = mw.Width / 2 - 5;
            int secondScintillaSizeY = mw.StatusBar.Location.Y - secondScintillaLocY;

            mw.Code.Location = new Point(secondScintillaLocX, secondScintillaLocY);
            mw.Code.Size = new Size(secondScintillaSizeX, secondScintillaSizeY);
        };

        public void FormResizer(MainWindow mw)
        {
            frm = mw;

            MouseHandle.Init();
            MouseHandle.addDownRule(delegate (Point downPosition, Point lpPoint)
            {
                if (downPosition.X > frm.Location.X + frm.Size.Width - 8 &&
                        downPosition.X < frm.Location.X + frm.Size.Width + 2 &&
                        downPosition.Y > frm.Location.Y &&
                        downPosition.Y < frm.Location.Y + frm.Size.Height - 28)
                {
                    if (!isHorizontalResize)
                    {
                        isHorizontalResize = true;
                    }
                }
                if (isHorizontalResize)
                {
                    lock (frm.Cursor) frm.Cursor = Cursors.SizeWE;

                    frm.Size = new Size(
                        lpPoint.X - frm.Location.X + 2,
                        frm.Size.Height
                        );
                }
            });
            MouseHandle.addDownRule(delegate (Point downPosition, Point lpPoint)
            {
                if (downPosition.X > frm.Location.X &&
                        downPosition.X < frm.Location.X + frm.Size.Width - 28 &&
                        downPosition.Y > frm.Location.Y + frm.Size.Height - 8 &&
                        downPosition.Y < frm.Location.Y + frm.Size.Height + 2)
                {
                    if (!isVerticalResize)
                    {
                        isVerticalResize = true;
                    }
                }
                if (isVerticalResize)
                {
                    lock (frm.Cursor) frm.Cursor = Cursors.SizeNS;

                    frm.Size = new Size(
                        frm.Size.Width,
                        lpPoint.Y - frm.Location.Y + 2
                        );
                }
            });
            MouseHandle.addDownRule(delegate (Point downPosition, Point lpPoint)
            {
                if (downPosition.X > frm.Location.X + frm.Size.Width - 28 &&
                        downPosition.X < frm.Location.X + frm.Size.Width &&
                        downPosition.Y > frm.Location.Y + frm.Size.Height - 28 &&
                        downPosition.Y < frm.Location.Y + frm.Size.Height)
                {
                    if (!isFullResize)
                    {
                        isFullResize = true;
                    }
                }
                if (isFullResize)
                {
                    lock (frm.Cursor) frm.Cursor = Cursors.SizeNS;

                    frm.Size = new Size(
                        lpPoint.X - frm.Location.X + 2,
                        lpPoint.Y - frm.Location.Y + 2
                        );
                }
            });

            MouseHandle.addRule(delegate (Point lpPoint)
            {
                if (lpPoint.X > frm.Location.X + frm.Size.Width - 8 &&
                        lpPoint.X < frm.Location.X + frm.Size.Width + 2 &&
                        lpPoint.Y > frm.Location.Y &&
                        lpPoint.Y < frm.Location.Y + frm.Size.Height - 28)
                    lock (frm.Cursor) frm.Cursor = Cursors.SizeWE;
            });
            MouseHandle.addRule(delegate (Point lpPoint)
            {
                if (lpPoint.X > frm.Location.X &&
                        lpPoint.X < frm.Location.X + frm.Size.Width - 28 &&
                        lpPoint.Y > frm.Location.Y + frm.Size.Height - 8 &&
                        lpPoint.Y < frm.Location.Y + frm.Size.Height + 2)
                    lock (frm.Cursor) frm.Cursor = Cursors.SizeNS;
            });
            MouseHandle.addRule(delegate (Point lpPoint)
            {
                if (lpPoint.X > frm.Location.X + frm.Size.Width - 28 &&
                        lpPoint.X < frm.Location.X + frm.Size.Width &&
                        lpPoint.Y > frm.Location.Y + frm.Size.Height - 28 &&
                        lpPoint.Y < frm.Location.Y + frm.Size.Height)
                    lock (frm.Cursor) frm.Cursor = Cursors.SizeNWSE;
            });
            MouseHandle.addRule(delegate (Point lpPoint)
            {
                if (isHorizontalResize)
                {
                    isHorizontalResize = false;
                    lock (frm.Cursor) frm.Cursor = Cursors.Default;
                }
            });
            MouseHandle.addRule(delegate (Point lpPoint)
            {
                if (isVerticalResize)
                {
                    isVerticalResize = false;
                    lock (frm.Cursor) frm.Cursor = Cursors.Default;
                }
            });
            MouseHandle.addRule(delegate (Point lpPoint)
            {
                if (isFullResize)
                {
                    isFullResize = false;
                    lock (frm.Cursor) frm.Cursor = Cursors.Default;
                }
            });
        }


        static MainWindow frm { get; set; }
        static bool isHorizontalResize { get; set; } = false;
        static bool isVerticalResize { get; set; } = false;
        static bool isFullResize { get; set; } = false;
    }
}
