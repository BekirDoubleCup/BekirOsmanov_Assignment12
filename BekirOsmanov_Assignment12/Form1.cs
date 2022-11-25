namespace BekirOsmanov_Assignment12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int id = Convert.ToInt32(idBox.Text);
            int shift = Convert.ToInt32(shiftBox.Text);
            decimal pay = Convert.ToDecimal(dollarBox.Text);

            Worker worker = new Worker(name, id, shift, pay);
            outputBox.Text =  worker.ToString();
        }
    }
}