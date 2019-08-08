using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label3.Text = "O Botao ENTER foi acionado !!!";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            label4.Text = "Selected Item Text: " + selectedItem.ToString() + "\n" +
                    "Index: " + selectedIndex.ToString();
        }

        
        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

      
        //private void Button4_Click(object sender, EventArgs e)
        //{
        //    txtTelefone.Text = GetRandomTelNo();
        //    txtPhone2.Text = GetRandomTelNo();
        //    comboBox1.Text = "Motivo";
        //    label3.Text = "";
        //    label4.Text = "";
        //}

        static Random rand = new Random();

        static string GetRandomTelNo()
        {
            StringBuilder telNo = new StringBuilder(12);
            int number;
            for (int i = 0; i < 3; i++)
            {
                number = rand.Next(0, 8); // digit between 0 (incl) and 8 (excl)
                telNo = telNo.Append(number.ToString());
            }
            telNo = telNo.Append("-");
            number = rand.Next(0, 743); // number between 0 (incl) and 743 (excl)
            telNo = telNo.Append(String.Format("{0:D3}", number));
            telNo = telNo.Append("-");
            number = rand.Next(0, 10000); // number between 0 (incl) and 10000 (excl)
            telNo = telNo.Append(String.Format("{0:D4}", number));
            return telNo.ToString();
        }
    }
}
