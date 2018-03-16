using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonivalintaPeli
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int kysymys = 0;
        List<Image> kuvalista = new List<Image>();
        string[] oikeatvastausket = new string[] {"stop","Väistämisvelvollisuus","joo","asda" };
        Point sijainti1=Point()





        public Form1()
        {
            InitializeComponent();

            try
            {
                    foreach (string fileName in Directory.GetFiles(@"C:\Users\p119992\Documents\visual studio 2015\Projects\MonivalintaPeli\MonivalintaPeli\images"))
                    {
                        kuvalista.Add(Image.FromFile(fileName));

                    }

          

                }
            
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


            kuvaBox.Image = kuvalista[0];

            radioRight.Text = oikeatvastausket[0];
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioRight.Checked == true)
            {
                radioRight.Checked = false;
              

                kuvaBox.Image = kuvalista[kysymys];


                lblRightCounter.Text = counter.ToString();
                radioRight.Text = oikeatvastausket[kysymys];
                counter++;
                kysymys++;
            }
            else
            {
                radioRight.Checked = false;
                kysymys++;
            }
        }

        private void kuvaBox_Click(object sender, EventArgs e)
        {

        }
    }
}
