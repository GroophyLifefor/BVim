namespace BVim.Responsive
{
    internal class MoveForm
    {
        public MoveForm(Form form, Control panel)
        {
            frm = form;
            panel.MouseDown += MouseDown;
            panel.MouseMove += MouseMove;
            panel.MouseUp += MouseUp;
        }

        private bool arrastando = false;
        private Point pontoinicial = new Point(0, 0);
        private Form frm;

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            arrastando = true;
            pontoinicial = new Point(e.X, e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando)
            {
                Point p = frm.PointToScreen(e.Location);
                frm.Location = new Point(
                    p.X - this.pontoinicial.X,
                    p.Y - this.pontoinicial.Y);
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (arrastando) arrastando = false;
        }
    }
}
