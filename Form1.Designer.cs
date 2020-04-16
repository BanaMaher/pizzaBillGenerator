namespace pizza_project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstBill = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.chkMashroom = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkPeporoni = new System.Windows.Forms.CheckBox();
            this.chkMargerita = new System.Windows.Forms.CheckBox();
            this.chkSeafood = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name please:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 37);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 26);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lstBill
            // 
            this.lstBill.FormattingEnabled = true;
            this.lstBill.ItemHeight = 20;
            this.lstBill.Location = new System.Drawing.Point(438, 37);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(340, 324);
            this.lstBill.TabIndex = 2;
            this.lstBill.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(30, 331);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 36);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Location = new System.Drawing.Point(38, 100);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(140, 24);
            this.radRegular.TabIndex = 5;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular (RM5)";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(38, 150);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(134, 24);
            this.radLarge.TabIndex = 6;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large (RM20)";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // chkMashroom
            // 
            this.chkMashroom.AutoSize = true;
            this.chkMashroom.Location = new System.Drawing.Point(199, 100);
            this.chkMashroom.Name = "chkMashroom";
            this.chkMashroom.Size = new System.Drawing.Size(162, 24);
            this.chkMashroom.TabIndex = 7;
            this.chkMashroom.Text = "Mashroom (RM1)";
            this.chkMashroom.UseVisualStyleBackColor = true;
            this.chkMashroom.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(199, 220);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(169, 24);
            this.chkPineapple.TabIndex = 9;
            this.chkPineapple.Text = "Pineapple (RM0.5)";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkPeporoni
            // 
            this.chkPeporoni.AutoSize = true;
            this.chkPeporoni.Location = new System.Drawing.Point(199, 190);
            this.chkPeporoni.Name = "chkPeporoni";
            this.chkPeporoni.Size = new System.Drawing.Size(147, 24);
            this.chkPeporoni.TabIndex = 10;
            this.chkPeporoni.Text = "peperoni (RM3)";
            this.chkPeporoni.UseVisualStyleBackColor = true;
            // 
            // chkMargerita
            // 
            this.chkMargerita.AutoSize = true;
            this.chkMargerita.Location = new System.Drawing.Point(199, 160);
            this.chkMargerita.Name = "chkMargerita";
            this.chkMargerita.Size = new System.Drawing.Size(154, 24);
            this.chkMargerita.TabIndex = 11;
            this.chkMargerita.Text = "Margerita (RM2)";
            this.chkMargerita.UseVisualStyleBackColor = true;
            // 
            // chkSeafood
            // 
            this.chkSeafood.AutoSize = true;
            this.chkSeafood.Location = new System.Drawing.Point(199, 130);
            this.chkSeafood.Name = "chkSeafood";
            this.chkSeafood.Size = new System.Drawing.Size(149, 24);
            this.chkSeafood.TabIndex = 12;
            this.chkSeafood.Text = "SeaFood (RM1)";
            this.chkSeafood.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.chkSeafood);
            this.Controls.Add(this.chkMargerita);
            this.Controls.Add(this.chkPeporoni);
            this.Controls.Add(this.chkPineapple);
            this.Controls.Add(this.chkMashroom);
            this.Controls.Add(this.radLarge);
            this.Controls.Add(this.radRegular);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pizza Shop Bill Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstBill;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.CheckBox chkMashroom;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkPeporoni;
        private System.Windows.Forms.CheckBox chkMargerita;
        private System.Windows.Forms.CheckBox chkSeafood;
    }
}

