namespace firstTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button = new Button();
            button.Text = "CLick";
            //button.Click += (o, e) => MessageBox.Show("Hello User");
            button.Click += click;
            button.Size = new Size() { Height = 50, Width = 160 };
            button.Location = new Point(100, 100);
            this.Controls.Add(button);
        }
        private void click(object o , EventArgs e)
        {
            var form = new Form2(this);
            form.Show();
            form.FormClosed += (o, e) => this.BackColor = Color.DarkBlue;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
