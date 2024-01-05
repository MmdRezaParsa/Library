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
using DAL;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام کاربری نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("گذرواژه نمیتواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                employee_login employee1 = new employee_login();
                employee1.username = textBox1.Text.Trim();
                employee1.password = textBox2.Text.Trim();
                blemployee_login ble = new blemployee_login();
                bool emp_check = ble.login(employee1);
                if (emp_check)
                {
                    if (checkBox1.Checked)
                    {
                        remember_me rem1 = new remember_me();
                        rem1.rem_user = textBox1.Text.Trim();
                        rem1.rem_pass = textBox2.Text.Trim();
                        blremember_me blrem = new blremember_me();
                        blrem.remember(rem1);
                    }
                    else if (checkBox1.Checked == false)
                    {
                        blremember_me blrem = new blremember_me();
                        string str1 = textBox1.Text.Trim();
                        string str2 = textBox2.Text.Trim();
                        blrem.rem_del(str1, str2);
                    }
                    foreach (var item in Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                        {
                            (item as TextBox).Clear();
                        }
                        if (item.GetType().ToString() == "System.Windows.Forms.RadioButton")
                        {
                            (item as RadioButton).Checked = false;
                        }
                    }
                    textBox1.Focus();
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("فردی با همچین مشخصاتی یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید گذرواژه خود را بازیابی کنید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "نام کاربری نمیتواند خالی باشد");
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
                errorProvider2.SetError(textBox2, "گذرواژه نمیتواند خالی باشد");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "با زدن دکمه Enter وارد شوید ");
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            blremember_me blrem = new blremember_me();
            remember_me rem1 = blrem.read_rem();
            textBox1.Text = rem1.rem_user;
            textBox2.Text = rem1.rem_pass;
            if (rem1.rem_user != string.Empty)
            {
                checkBox1.Checked = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

        }
    }
}
