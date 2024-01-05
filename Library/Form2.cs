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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            employee emp1 = new employee();

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("لطفا جنسیت خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton1.Checked)
            {
                emp1.gender = false;
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else if (textBox2.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام  خانوادگی  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }
                else if (textBox3.Text.Trim().Length == 0)
                {
                    MessageBox.Show("کد ملی  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                }
                else if (textBox4.Text.Trim().Length == 0)
                {
                    MessageBox.Show("رمز عبور  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();
                }
                else if (textBox5.Text.Trim().Length == 0)
                {
                    MessageBox.Show(" تکرار  رمز عبور  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Focus();
                }
                else if (textBox6.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام کاربری  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus();
                }
                else if (textBox4.Text != textBox5.Text)
                {
                    MessageBox.Show("  رمز  عبور یکسان نیست ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    employee emp2 = new employee();
                    emp2.name = textBox1.Text;
                    emp2.family = textBox2.Text;
                    emp2.national_code = textBox3.Text.Trim();
                    emp2.gender = emp1.gender;
                    emp2.password = textBox5.Text.Trim();
                    emp2.username = textBox6.Text.Trim();
                    blemployee blemp1 = new blemployee();
                    bool is_regestered = blemp1.regester(emp2);
                    if (is_regestered)
                    {
                        MessageBox.Show("با موفقیت ثبت نام شد", "", MessageBoxButtons.OK);
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
                    }
                    else if (!is_regestered)
                    {
                        MessageBox.Show("فردی با همچین مشخصاتی قبلا ثبت شده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if (radioButton2.Checked)
            {
                emp1.gender = true;
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else if (textBox2.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام  خانوادگی  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }
                else if (textBox3.Text.Trim().Length == 0)
                {
                    MessageBox.Show("کد ملی  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                }
                else if (textBox4.Text.Trim().Length == 0)
                {
                    MessageBox.Show("رمز عبور  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();
                }
                else if (textBox5.Text.Trim().Length == 0)
                {
                    MessageBox.Show(" تکرار  رمز عبور  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Focus();
                }
                else if (textBox6.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام کاربری  نمی نواتد  خالی باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus();
                }
                else if (textBox4.Text != textBox5.Text)
                {
                    MessageBox.Show("  رمز  عبور یکسان نیست ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    employee emp2 = new employee();
                    emp2.name = textBox1.Text;
                    emp2.family = textBox2.Text;
                    emp2.national_code = textBox3.Text.Trim();
                    emp2.gender = emp1.gender;
                    emp2.password = textBox5.Text.Trim();
                    emp2.username = textBox6.Text.Trim();
                    blemployee blemp1 = new blemployee();
                    bool is_regestered = blemp1.regester(emp2);
                    if (is_regestered)
                    {
                        MessageBox.Show("با موفقیت ثبت نام شد", "", MessageBoxButtons.OK);
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
                    }
                    else if (!is_regestered)
                    {
                        MessageBox.Show("فردی با همچین مشخصاتی قبلا ثبت شده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }

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
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1_Click_1(null, null);
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
                errorProvider3.SetError(textBox3, "کدملی نمیتواند خالی باشد");
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
                errorProvider4.SetError(textBox4, "رمزعبور نمیتواند خالی باشد");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim().Length == 0)
            {
                errorProvider5.SetError(textBox5, "تکرار رمزعبور نمیتواند خالی باشد");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Trim().Length == 0)
            {
                errorProvider6.SetError(textBox6, "نام کاربری نمیتواند خالی باشد");
            }
            else
            {
                errorProvider6.Clear();
            }
        }
    }
}
