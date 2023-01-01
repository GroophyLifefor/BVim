using BVim.Responsive;
using H.Hooks;
using System.Runtime.InteropServices;

namespace BVim
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            WinApi.AllocConsole();
            Console.WriteLine("init");

            MouseHandle.Init();
            BVim.Responsive.MoveForm moveForm = new MoveForm(this, MenuBar);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Resizer resizer = new Resizer();
            resizer.FormResizer(this);
            resizer.ResizeDelegate(this);
        }
    }
}