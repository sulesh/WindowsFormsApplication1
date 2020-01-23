using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Math;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Console.WriteLine("Hi Sulesh");

            MessageBox.Show("SS");

            Program1 xxx = new Program1();
            xxx.abc(5);

                        
        }

       public class Program1
        {
           public  void abc(int a)
            {
                Console.WriteLine(a);
            }
          
            
        }

   

    }
}
