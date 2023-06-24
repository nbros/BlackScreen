namespace BlackScreen {
    public partial class BlackForm : Form {
        public BlackForm() {
            InitializeComponent();
        }

        private void BlackForm_DoubleClick(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BlackForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Application.Exit();
            }
        }
    }
}