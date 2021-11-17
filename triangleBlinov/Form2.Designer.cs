namespace triangleBlinov
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.aBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ravno = new System.Windows.Forms.RadioButton();
            this.twosides = new System.Windows.Forms.RadioButton();
            this.razno = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(12, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 125);
            this.button1.TabIndex = 20;
            this.button1.Text = "ПУСК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(560, 51);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(196, 20);
            this.aBox.TabIndex = 21;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(228, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 215);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Поле";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 155;
            // 
            // hBox
            // 
            this.hBox.Location = new System.Drawing.Point(560, 89);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(196, 20);
            this.hBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "h";
            // 
            // ravno
            // 
            this.ravno.AutoSize = true;
            this.ravno.Location = new System.Drawing.Point(583, 174);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(109, 17);
            this.ravno.TabIndex = 27;
            this.ravno.TabStop = true;
            this.ravno.Text = "Равносторонний";
            this.ravno.UseVisualStyleBackColor = true;
            // 
            // twosides
            // 
            this.twosides.AutoSize = true;
            this.twosides.Location = new System.Drawing.Point(583, 151);
            this.twosides.Name = "twosides";
            this.twosides.Size = new System.Drawing.Size(112, 17);
            this.twosides.TabIndex = 28;
            this.twosides.TabStop = true;
            this.twosides.Text = "Равнобедренный";
            this.twosides.UseVisualStyleBackColor = true;
            // 
            // razno
            // 
            this.razno.AutoSize = true;
            this.razno.Location = new System.Drawing.Point(583, 197);
            this.razno.Name = "razno";
            this.razno.Size = new System.Drawing.Size(109, 17);
            this.razno.TabIndex = 29;
            this.razno.TabStop = true;
            this.razno.Text = "Разносторонний";
            this.razno.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(583, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 17);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Прямоугольный";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::triangleBlinov.Properties.Resources.triangle_isosceles_height_and_sides_b;
            this.pictureBox2.Location = new System.Drawing.Point(26, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 170);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.razno);
            this.Controls.Add(this.twosides);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Myform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox hBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ravno;
        private System.Windows.Forms.RadioButton twosides;
        private System.Windows.Forms.RadioButton razno;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}