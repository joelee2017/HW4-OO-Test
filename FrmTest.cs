using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace OOTest_CSharp
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            A a = new A();

            a.M1();
            a.M2();


            Debug.WriteLine("===================================");
            B b = new B();
            b.M1();
            b.M2();
          

            Debug.WriteLine("===================================");
            A x = b;
            x.M1();
            x.M2();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("===================================");
            C c = new C();
            c.M1();

            c.M2();  //遮蔽
            c.M2(100);
          


            Debug.WriteLine("===================================");
            A x = c;
            x.M1();
            x.M2();

        }

      
    }
}