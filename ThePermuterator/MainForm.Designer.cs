namespace ThePermuterator
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalInput = new System.Windows.Forms.NumericUpDown();
            this.checkBox_animate = new System.Windows.Forms.CheckBox();
            this.button_Backwards = new System.Windows.Forms.Button();
            this.button_Forwards = new System.Windows.Forms.Button();
            this.radioButton_lexicographical = new System.Windows.Forms.RadioButton();
            this.radioButton_numerical = new System.Windows.Forms.RadioButton();
            this.textBox_items = new System.Windows.Forms.TextBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalInput)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button_stop);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.intervalInput);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_animate);
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
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(6, 175);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(86, 23);
            this.button_stop.TabIndex = 7;
            this.button_stop.Text = "Stop Animation";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Interval (ms):";
            // 
            // intervalInput
            // 
            this.intervalInput.Location = new System.Drawing.Point(12, 148);
            this.intervalInput.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.intervalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalInput.Name = "intervalInput";
            this.intervalInput.Size = new System.Drawing.Size(80, 20);
            this.intervalInput.TabIndex = 5;
            this.intervalInput.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.intervalInput.ValueChanged += new System.EventHandler(this.intervalInput_ValueChanged);
            // 
            // checkBox_animate
            // 
            this.checkBox_animate.AutoSize = true;
            this.checkBox_animate.Location = new System.Drawing.Point(3, 108);
            this.checkBox_animate.Name = "checkBox_animate";
            this.checkBox_animate.Size = new System.Drawing.Size(64, 17);
            this.checkBox_animate.TabIndex = 4;
            this.checkBox_animate.Text = "Animate";
            this.checkBox_animate.UseVisualStyleBackColor = true;
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
            // animationTimer
            // 
            this.animationTimer.Interval = 200;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "The Permuterator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Backwards;
        private System.Windows.Forms.Button button_Forwards;
        private System.Windows.Forms.RadioButton radioButton_lexicographical;
        private System.Windows.Forms.RadioButton radioButton_numerical;
        private System.Windows.Forms.TextBox textBox_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalInput;
        private System.Windows.Forms.CheckBox checkBox_animate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer animationTimer;
    }
}

