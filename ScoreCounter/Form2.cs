using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ScoreCounter
{
    public partial class Form2 : Form
    {
        private Form form1;
        private String[] scores = { "£0", "£100", "£250", "£500", "£750", "£1,000" };
        private int pos = 0;
        public Form2(Form form1, String teamName)
        {
            this.form1 = form1;
            InitializeComponent();

            this.Text = teamName;
            this.label3.Text = teamName;

            Closing += Form2_Closing;
        }

        private void Form2_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Are you SURE you want to close WITHOUT SAVING?", "Scoreboard", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form1.Close();
            } else
            {
                e.Cancel = true;
            }
        }

        private void submitPnts_Click(object sender, EventArgs e)
        {
            if (pos < 4)
            {
                pos++;
                this.pot.Text = scores[pos];
            } else if (pos == 4)
            {
                pos++;
                this.pot.Text = scores[pos];
                this.winBtn.Enabled = false;
            }
        }

        private void bankBtn_Click(object sender, EventArgs e)
        {
            String score = scores[pos].Trim('£').Replace(",", "");

            String bankText = this.bank.Text;
            bankText = bankText.Trim('£');
            bankText = bankText.Replace(",", "");

            int n1 = Int32.Parse(bankText);
            int n2 = Int32.Parse(score);
            int a = n1 + n2;

            String final = a.ToString("C0");

            this.bank.Text = final;
            pos = 0;
            this.pot.Text = scores[pos];
            this.winBtn.Enabled = true;
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitPnts_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void loseBtn_Click(object sender, EventArgs e)
        {
            pos = 0;
            this.pot.Text = scores[pos];
            this.winBtn.Enabled = true;
        }
    }
}
