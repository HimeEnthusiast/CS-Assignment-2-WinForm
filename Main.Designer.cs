namespace Piantoni_Isabella_991392679_Assignment2
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PlayerDeleteBtn = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.GroupBox();
            this.PlayerEditBtn = new System.Windows.Forms.Button();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SportName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgePicker = new System.Windows.Forms.NumericUpDown();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.PlayerViewBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Age.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgePicker)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(438, 378);
            this.tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PlayerDeleteBtn);
            this.tabPage1.Controls.Add(this.Age);
            this.tabPage1.Controls.Add(this.PlayerViewBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PlayerDeleteBtn
            // 
            this.PlayerDeleteBtn.Location = new System.Drawing.Point(18, 69);
            this.PlayerDeleteBtn.Name = "PlayerDeleteBtn";
            this.PlayerDeleteBtn.Size = new System.Drawing.Size(96, 43);
            this.PlayerDeleteBtn.TabIndex = 14;
            this.PlayerDeleteBtn.Text = "Delete";
            this.PlayerDeleteBtn.UseVisualStyleBackColor = true;
            this.PlayerDeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Age
            // 
            this.Age.Controls.Add(this.PlayerEditBtn);
            this.Age.Controls.Add(this.CreatePlayerButton);
            this.Age.Controls.Add(this.label4);
            this.Age.Controls.Add(this.SportName);
            this.Age.Controls.Add(this.LastName);
            this.Age.Controls.Add(this.label3);
            this.Age.Controls.Add(this.label2);
            this.Age.Controls.Add(this.label1);
            this.Age.Controls.Add(this.AgePicker);
            this.Age.Controls.Add(this.FirstName);
            this.Age.Location = new System.Drawing.Point(138, 6);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(273, 325);
            this.Age.TabIndex = 12;
            this.Age.TabStop = false;
            this.Age.Text = "Create a player";
            // 
            // PlayerEditBtn
            // 
            this.PlayerEditBtn.Location = new System.Drawing.Point(109, 274);
            this.PlayerEditBtn.Name = "PlayerEditBtn";
            this.PlayerEditBtn.Size = new System.Drawing.Size(84, 30);
            this.PlayerEditBtn.TabIndex = 16;
            this.PlayerEditBtn.Text = "Edit";
            this.PlayerEditBtn.UseVisualStyleBackColor = true;
            this.PlayerEditBtn.Click += new System.EventHandler(this.PlayerEditBtn_Click);
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.Location = new System.Drawing.Point(19, 274);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(84, 30);
            this.CreatePlayerButton.TabIndex = 15;
            this.CreatePlayerButton.Text = "Create";
            this.CreatePlayerButton.UseVisualStyleBackColor = true;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Age:";
            // 
            // SportName
            // 
            this.SportName.Location = new System.Drawing.Point(19, 235);
            this.SportName.Name = "SportName";
            this.SportName.Size = new System.Drawing.Size(222, 20);
            this.SportName.TabIndex = 12;
            this.SportName.TextChanged += new System.EventHandler(this.SportName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(19, 124);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(222, 20);
            this.LastName.TabIndex = 11;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "First name:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // AgePicker
            // 
            this.AgePicker.Location = new System.Drawing.Point(19, 180);
            this.AgePicker.Name = "AgePicker";
            this.AgePicker.Size = new System.Drawing.Size(222, 20);
            this.AgePicker.TabIndex = 7;
            this.AgePicker.ValueChanged += new System.EventHandler(this.AgePicker_ValueChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(19, 62);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(222, 20);
            this.FirstName.TabIndex = 3;
            this.FirstName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // PlayerViewBtn
            // 
            this.PlayerViewBtn.Location = new System.Drawing.Point(18, 20);
            this.PlayerViewBtn.Name = "PlayerViewBtn";
            this.PlayerViewBtn.Size = new System.Drawing.Size(96, 43);
            this.PlayerViewBtn.TabIndex = 0;
            this.PlayerViewBtn.Text = "View";
            this.PlayerViewBtn.UseVisualStyleBackColor = true;
            this.PlayerViewBtn.Click += new System.EventHandler(this.PlayerViewBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 43);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Location = new System.Drawing.Point(139, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 325);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create a match";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(19, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 30);
            this.button8.TabIndex = 17;
            this.button8.Text = "Create";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(19, 235);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(222, 20);
            this.numericUpDown3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Points";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rank:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Player";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(19, 180);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(222, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 43);
            this.button6.TabIndex = 15;
            this.button6.Text = "View";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(430, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 19);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "by Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 19);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "by ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(21, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 35);
            this.button9.TabIndex = 11;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Look up";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(173, 19);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.vScrollBar2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Size = new System.Drawing.Size(238, 312);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 1;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(216, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(22, 102);
            this.vScrollBar2.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(216, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 206);
            this.vScrollBar1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 405);
            this.Controls.Add(this.tabs);
            this.Name = "Main";
            this.Text = "Sheridan Sports Database";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Age.ResumeLayout(false);
            this.Age.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgePicker)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button PlayerDeleteBtn;
        private System.Windows.Forms.GroupBox Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AgePicker;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button PlayerViewBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SportName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button CreatePlayerButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button PlayerEditBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

