namespace ThePermuterator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Backwards = new System.Windows.Forms.Button();
            this.button_Forwards = new System.Windows.Forms.Button();
            this.radioButton_lexicographical = new System.Windows.Forms.RadioButton();
            this.radioButton_numerical = new System.Windows.Forms.RadioButton();
            this.textBox_items = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_Backwards);
            this.splitContainer1.Panel1.Controls.Add(this.button_Forwards);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_lexicographical);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_numerical);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_items);
            this.splitContainer1.Size = new System.Drawing.Size(284, 262);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_Backwards
            // 
            this.button_Backwards.Location = new System.Drawing.Point(3, 79);
            this.button_Backwards.Name = "button_Backwards";
            this.button_Backwards.Size = new System.Drawing.Size(89, 23);
            this.button_Backwards.TabIndex = 3;
            this.button_Backwards.Text = "Backwards!";
            this.button_Backwards.UseVisualStyleBackColor = true;
            this.button_Backwards.Click += new System.EventHandler(this.button_Backwards_Click);
            // 
            // button_Forwards
            // 
            this.button_Forwards.Location = new System.Drawing.Point(3, 50);
            this.button_Forwards.Name = "button_Forwards";
            this.button_Forwards.Size = new System.Drawing.Size(89, 23);
            this.button_Forwards.TabIndex = 2;
            this.button_Forwards.Text = "Forwards!";
            this.button_Forwards.UseVisualStyleBackColor = true;
            this.button_Forwards.Click += new System.EventHandler(this.button_Forwards_Click);
            // 
            // radioButton_lexicographical
            // 
            this.radioButton_lexicographical.AutoSize = true;
            this.radioButton_lexicographical.Location = new System.Drawing.Point(3, 27);
            this.radioButton_lexicographical.Name = "radioButton_lexicographical";
            this.radioButton_lexicographical.Size = new System.Drawing.Size(57, 17);
            this.radioButton_lexicographical.TabIndex = 1;
            this.radioButton_lexicographical.Text = "Strings";
            this.radioButton_lexicographical.UseVisualStyleBackColor = true;
            this.radioButton_lexicographical.CheckedChanged += new System.EventHandler(this.radioButton_lexicographical_CheckedChanged);
            // 
            // radioButton_numerical
            // 
            this.radioButton_numerical.AutoSize = true;
            this.radioButton_numerical.Checked = true;
            this.radioButton_numerical.Location = new System.Drawing.Point(3, 4);
            this.radioButton_numerical.Name = "radioButton_numerical";
            this.radioButton_numerical.Size = new System.Drawing.Size(67, 17);
            this.radioButton_numerical.TabIndex = 0;
            this.radioButton_numerical.TabStop = true;
            this.radioButton_numerical.Text = "Numbers";
            this.radioButton_numerical.UseVisualStyleBackColor = true;
            this.radioButton_numerical.CheckedChanged += new System.EventHandler(this.radioButton_numerical_CheckedChanged);
            // 
            // textBox_items
            // 
            this.textBox_items.Location = new System.Drawing.Point(3, 3);
            this.textBox_items.Multiline = true;
            this.textBox_items.Name = "textBox_items";
            this.textBox_items.Size = new System.Drawing.Size(179, 256);
            this.textBox_items.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "The Permuterator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Backwards;
        private System.Windows.Forms.Button button_Forwards;
        private System.Windows.Forms.RadioButton radioButton_lexicographical;
        private System.Windows.Forms.RadioButton radioButton_numerical;
        private System.Windows.Forms.TextBox textBox_items;
    }
}

