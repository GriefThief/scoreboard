using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCounter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String[] teamNames = this.teamNamesTxt.Text.Split('\n');
            if (teamNames[0].Length >= 1)
            {
                foreach (String name in teamNames)
                {
                    if (name.Length >= 1)
                    {
                        Form2 form2 = new Form2(this, name);
                        form2.Show();
                    }
                }
                this.Hide();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.teamNamesTxt.Text = "";
        }
    }
}
