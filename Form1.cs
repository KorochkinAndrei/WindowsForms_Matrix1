using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Matrix1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a11;
        int a12;
        int a13;
        int a21;
        int a22;
        int a23;
        int a31;
        int a32;
        int a33;
        double detA;
        bool Error_enter11;
        bool Error_enter12;
        bool Error_enter13;
        bool Error_enter21;
        bool Error_enter22;
        bool Error_enter23;
        bool Error_enter31;
        bool Error_enter32;
        bool Error_enter33;


        private void button1_Click(object sender, EventArgs e)
        {
            if (Box11.Text != "" && Box12.Text != "" && Box13.Text != ""
                && Box21.Text != "" && Box22.Text != "" && Box23.Text != ""
                && Box31.Text != "" && Box32.Text != "" && Box33.Text != "")
            {
                label2.Text = "";
                if (Error_enter11 != true && Error_enter12 != true && Error_enter13 != true &&
                    Error_enter21 != true && Error_enter22 != true && Error_enter23 != true &&
                    Error_enter31 != true && Error_enter32 != true && Error_enter33 != true)
                {
                    detA = a11 * a22 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a13 * a22 * a31 - a12 * a21 * a33 - a11 * a23 * a32;

                    Answer.Text = "Определитель матрицы равен: " + detA.ToString();
                }
                else
                {
                    erorr_Mes.Text = "Вводите числа";
                    Answer.Text = "";
                }

            }
            else { label2.Text = "заполните матрицу полностью"; }
        }


        public void TextScan11(object sender, EventArgs e)
        {
            string _a11 = Box11.Text;
            if (Box11.Text != "")
            {
                try
                {
                    a11 = int.Parse(_a11);
                    erorr_Mes.Text = "";
                    Error_enter11 = false;

                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter11 = true; }
            }
        }

        public void TextScan12(object sender, EventArgs e)
        {
            string _a12 = Box12.Text;
            if (Box12.Text != "")
            {
                try
                {
                    a12 = int.Parse(_a12);
                    erorr_Mes.Text = "";
                    Error_enter12 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter12 = true; }
            }
        }

        public void TextScan13(object sender, EventArgs e)
        {
            string _a13 = Box13.Text;
            if (Box13.Text != "")
            {
                try
                {
                    a13 = int.Parse(_a13);
                    erorr_Mes.Text = "";
                    Error_enter13 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter13 = true; }
            }
        }

        public void TextScan21(object sender, EventArgs e)
        {
            string _a21 = Box21.Text;
            if (Box21.Text != "")
            {
                try
                {
                    a21 = int.Parse(_a21);
                    erorr_Mes.Text = "";
                    Error_enter21 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter21 = true; }
            }
        }

        public void TextScan22(object sender, EventArgs e)
        {
            string _a22 = Box22.Text;
            if (Box22.Text != "")
            {
                try
                {
                    a22 = int.Parse(_a22);
                    erorr_Mes.Text = "";
                    Error_enter22 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter22 = true; }
            }
        }

        public void TextScan23(object sender, EventArgs e)
        {
            string _a23 = Box23.Text;
            if (Box23.Text != "")
            {
                try
                {
                    a23 = int.Parse(_a23);
                    erorr_Mes.Text = "";
                    Error_enter23 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter23 = true; }
            }
        }

        public void TextScan31(object sender, EventArgs e)
        {
            string _a31 = Box31.Text;
            if (Box31.Text != "")
            {
                try
                {
                    a31 = int.Parse(_a31);
                    erorr_Mes.Text = "";
                    Error_enter31 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter31 = true; }
            }
        }

        public void TextScan32(object sender, EventArgs e)
        {
            string _a32 = Box32.Text;
            if (Box32.Text != "")
            {
                try
                {
                    a32 = int.Parse(_a32);
                    erorr_Mes.Text = "";
                    Error_enter32 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter32 = true; }
            }
        }

        public void TextScan33(object sender, EventArgs e)
        {
            string _a33 = Box33.Text;
            if (Box33.Text != "")
            {
                try
                {
                    a33 = int.Parse(_a33);
                    erorr_Mes.Text = "";
                    Error_enter33 = false;
                }
                catch { erorr_Mes.Text = "Вводите числа"; Error_enter33 = true; }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
