namespace Praktikum___Rae_Kenneth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            string x = textBoxKalimat.Text;
            string result = "";
            for (int i = 0; i < x.Length; i++)
            {
                char huruf = x[i];
                if (huruf % 2 == 0)
                {
                    huruf--;
                }
                else
                {
                    huruf++;
                }
                result += huruf;
            }
            textBoxKalimat.Text = result;
            labelResult.Text = textBoxKalimat.Text;
        }

        private void textBoxHuruf_TextChanged(object sender, EventArgs e)
        {
            var replacements = new Dictionary<char, string>();
            replacements.Add('a', "b");
            replacements.Add('b', "a");
            var inputString = "abc";
            var String = "bac";
        }

        private void textBoxMenjadi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMenjadi.Text.Contains("a"))
            {
                textBoxMenjadi.Text = textBoxKalimat.Text.Replace("a","b");
            }
            if (textBoxMenjadi.Text.Contains("b"))
            {
                textBoxMenjadi.Text = textBoxKalimat.Text.Replace("b", "a");
            }
        }
    }
}