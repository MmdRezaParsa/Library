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

namespace Library
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string national_code;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("گذرواژه جدید نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("تکرار گذرواژه جدید نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                if (textBox1.Text.Trim() == textBox2.Text.Trim())
                {
                    employee emp1 = new employee();
                    emp1.password = textBox1.Text.Trim();
                    Form3 frm3 = new Form3();
                    blemployee blemp1 = new blemployee();
                    bool is_change = blemp1.change_pass(emp1, national_code);
                    if (is_change)
                    {
                        MessageBox.Show(textBox1.Text.Trim() + "گذرواژه شما تغیر کرد به :");
                        foreach (var item in Controls)
                        {
                            if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                            {
                                (item as TextBox).Clear();
                            }
                        }
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("گذرواژه شما تغییر نکرد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "گذرواژه جدید نمیتواند خالی باشد");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1_Click(null, null);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(textBox2, "تکرار گذرواژه جدید نمیتواند خالی باشد");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}
