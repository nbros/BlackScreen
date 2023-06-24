namespace BlackScreen {
    public partial class BlackForm : Form {

        private bool CursorVisible = true;

        public BlackForm() {
            InitializeComponent();
            HideCursor();
        }

        private void HideCursor() {
            if (CursorVisible) {
                Cursor.Hide();
                CursorVisible = false;
                Timer.Stop();
            }
        }

        private void ShowCursor() {
            if (!CursorVisible) {
                Cursor.Show();
                CursorVisible = true;
                Timer.Interval = 2000;
                Timer.Start();
            }
        }

        private void BlackForm_DoubleClick(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BlackForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Application.Exit();
            }
        }

        private void BlackForm_MouseMove(object sender, MouseEventArgs e) {
            ShowCursor();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            HideCursor();
        }
    }
}