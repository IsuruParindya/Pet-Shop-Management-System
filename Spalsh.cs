namespace Pet_Shop_Management_System
{
    public partial class Spalsh : Form
    {
        public Spalsh()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            Myprogress.Value = startP;
            PercentageLbl.Text = startP + "%";
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
