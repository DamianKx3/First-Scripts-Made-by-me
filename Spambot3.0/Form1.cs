using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spambot_3._0
{
    public partial class Form1 : Form
    {
        public int state = 0;
        public int dealy = 1;
        public int count;

        public Form1()
        {

            InitializeComponent();
        }

        private void inputtest(object sender, EventArgs e)
        {

            if (state == 1)
            {
                inputtester.Interval = dealy;
                count++;
                displaynum.Text = count.ToString();
                Random random = new Random();
                int rand = random.Next(0, list.Items.Count);
                if (list.Items[rand].ToString() != "%")
                {
                    Clipboard.SetText(list.Items[rand].ToString());
                }
 
                SendKeys.Send("^{v}");
                SendKeys.Send("{Enter}");

            }
        }

        private void escapepressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                state = 0;
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Debug.Text = "if '%' on list that means ctrl + v";
            if(list.Items.Count >= 1)
            {
                if (state == 0)
                {
                    count = 0;
                    wait();
                }
            }
            else
            {
                Debug.Text = "list cannot be empty";
            }


        }
        public async void wait()
        {
            displaynum.Text = "3";
            await Task.Delay(1000);
            displaynum.Text = "2";
            await Task.Delay(1000);
            displaynum.Text = "1";
            await Task.Delay(1000);
            displaynum.Text = "0";
            await Task.Delay(1000);
            if (int.TryParse(inputbox.Text,out int dupa))
            {
                dealy = int.Parse(inputbox.Text);
                state = 1;
            }
            else
            {
                Debug.Text = "cant parse to integer";
            }

        }

        private void test1(object sender, KeyEventArgs e)
        {
   
            if(e.KeyData == Keys.Escape)
            {
                state = 0;
                Debug.Text = "program stopped";
            }
        }

        private void Addtolist(object sender, EventArgs e)
        {
            list.Items.Add(itemname.Text);
            itemname.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Items.Remove(itemname.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }
    }
}
