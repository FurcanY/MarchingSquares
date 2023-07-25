namespace MarchingSquares
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
            button1 = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            button3 = new Button();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(29, 313);
            button1.Name = "button1";
            button1.Size = new Size(241, 45);
            button1.TabIndex = 0;
            button1.Text = "Goruntuyu Olustur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(29, 382);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 274);
            listBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(900, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 699);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(29, 267);
            button3.Name = "button3";
            button3.Size = new Size(241, 38);
            button3.TabIndex = 5;
            button3.Text = "Degisiklikleri Kaydet";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 135);
            label5.Name = "label5";
            label5.Size = new Size(163, 23);
            label5.TabIndex = 3;
            label5.Text = "Y Ekseni Nokta Sayisi";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(29, 227);
            button2.Name = "button2";
            button2.Size = new Size(163, 23);
            button2.TabIndex = 4;
            button2.Text = "Kalem Rengi Degistir.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Red;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(198, 227);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 3;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 195);
            label7.Name = "label7";
            label7.Size = new Size(163, 23);
            label7.TabIndex = 3;
            label7.Text = "Kalem Kalinligi";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 166);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 3;
            label4.Text = "X Ekseni Nokta Sayisi";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 108);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 3;
            label3.Text = "Noktalar Arasi Uzaklik";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 3;
            label2.Text = "Baslangic Noktasi Y";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(163, 23);
            label1.TabIndex = 3;
            label1.Text = "Baslangic Noktasi X";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(198, 195);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(72, 23);
            textBox6.TabIndex = 2;
            textBox6.Text = "2";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(198, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(72, 23);
            textBox5.TabIndex = 2;
            textBox5.Text = "40";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(198, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(72, 23);
            textBox4.TabIndex = 2;
            textBox4.Text = "40";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "20";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(72, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "0";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(198, 18);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(72, 23);
            textBox7.TabIndex = 2;
            textBox7.Text = "50";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(29, 18);
            label8.Name = "label8";
            label8.Size = new Size(163, 23);
            label8.TabIndex = 3;
            label8.Text = "Sıklık Oranı";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1190, 699);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Marching Squares Algoritmasi";
            Paint += Form1_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label7;
        private Button button3;
        private Label label8;
        private TextBox textBox7;
    }
}