using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BusnessEntity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Library
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام خانوادگی نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("کدملی نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام کاربری نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                employee emp1 = new employee();
                emp1.name = textBox1.Text;
                emp1.family = textBox2.Text;
                emp1.national_code = textBox3.Text.Trim();
                emp1.username = textBox4.Text.Trim();
                blemployee emp2 = new blemployee();
                bool emp_isin = emp2.emp_isin(emp1);
                if (emp_isin)
                {
                    Form4 frm4 = new Form4();
                    frm4.national_code = textBox3.Text.Trim();
                    foreach (var item in Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                        {
                            (item as TextBox).Clear();
                        }
                    }
                    textBox1.Focus();
                    this.Hide();
                    frm4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("چنین فردی ثبت نام نشده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "نام نمیتواند خالی باشد");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(textBox2, "نام خانوادگی نمیتواند خالی باشد");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim().Length == 0)
            {
                errorProvider3.SetError(textBox3, "کد ملی نمیتواند خالی باشد");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim().Length == 0)
            {
                errorProvider4.SetError(textBox4, "نام کاربری نمیتواند خالی باشد");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "با زدن دکمه Enter گذرواژه تان را بازیابی کنید");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا در قسمت نام فقط حرف وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا در قسمت نام خانوادگی فقط حرف وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا در قسمت کد ملی فقط عدد وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1_Click(null, null);
            }

        }
    }
}
