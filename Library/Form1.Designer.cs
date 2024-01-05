namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            settingsBindingSource = new BindingSource(components);
            button4 = new Button();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Mitra", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(80, 247);
            button1.Name = "button1";
            button1.Size = new Size(178, 48);
            button1.TabIndex = 2;
            button1.Text = "ورود";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // label1
            // 
            label1.Font = new Font("Mitra", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(228, 42);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 1;
            label1.Text = "نام کاربری";
            // 
            // label2
            // 
            label2.Font = new Font("Mitra", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(241, 138);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 2;
            label2.Text = "گذرواژه";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(345, 68);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 369);
            panel1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(185, 202);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "مرا به خاطر بسپار";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Mitra", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(32, 312);
            button2.Name = "button2";
            button2.Size = new Size(275, 39);
            button2.TabIndex = 0;
            button2.Text = "بازیابی گذرواژه";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Bisque;
            textBox2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(58, 135);
            textBox2.MaxLength = 120;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(136, 33);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Font = new Font("Mitra", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(58, 39);
            textBox1.MaxLength = 100;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 33);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // settingsBindingSource
            // 
            settingsBindingSource.DataSource = typeof(Properties.Settings);
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.BackgroundImage = Properties.Resources.photo_2023_12_12_20_17_21;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Mitra", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ImageKey = "(none)";
            button4.Location = new Point(12, 10);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._213_2134772_open_books_png;
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(0, 464);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1034, 147);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "توضیحات";
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Mitra", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(900, 10);
            button3.Name = "button3";
            button3.Size = new Size(122, 45);
            button3.TabIndex = 6;
            button3.Text = "ثبت کاربر";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Peru;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1034, 611);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private CheckBox checkBox1;
        private Button button4;
        private PictureBox pictureBox2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private BindingSource settingsBindingSource;
        private Button button3;
    }
}