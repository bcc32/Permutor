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
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.repeatTimes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalInput = new System.Windows.Forms.NumericUpDown();
            this.checkBox_animate = new System.Windows.Forms.CheckBox();
            this.button_Backwards = new System.Windows.Forms.Button();
            this.button_Forwards = new System.Windows.Forms.Button();
            this.radioButton_lexicographical = new System.Windows.Forms.RadioButton();
            this.radioButton_numerical = new System.Windows.Forms.RadioButton();
            this.textBox_items = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.repeatTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 200;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // repeatTimes
            // 
            this.repeatTimes.Location = new System.Drawing.Point(6, 234);
            this.repeatTimes.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.repeatTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatTimes.Name = "repeatTimes";
            this.repeatTimes.Size = new System.Drawing.Size(89, 20);
            this.repeatTimes.TabIndex = 20;
            this.repeatTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Repeat:";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(9, 192);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(89, 23);
            this.button_stop.TabIndex = 18;
            this.button_stop.Text = "Stop Animation";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Interval (ms):";
            // 
            // intervalInput
            // 
            this.intervalInput.Location = new System.Drawing.Point(6, 166);
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
            this.intervalInput.Size = new System.Drawing.Size(89, 20);
            this.intervalInput.TabIndex = 16;
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
            this.checkBox_animate.Location = new System.Drawing.Point(6, 123);
            this.checkBox_animate.Name = "checkBox_animate";
            this.checkBox_animate.Size = new System.Drawing.Size(64, 17);
            this.checkBox_animate.TabIndex = 15;
            this.checkBox_animate.Text = "Animate";
            this.checkBox_animate.UseVisualStyleBackColor = true;
            // 
            // button_Backwards
            // 
            this.button_Backwards.Location = new System.Drawing.Point(6, 94);
            this.button_Backwards.Name = "button_Backwards";
            this.button_Backwards.Size = new System.Drawing.Size(89, 23);
            this.button_Backwards.TabIndex = 14;
            this.button_Backwards.Text = "Backwards!";
            this.button_Backwards.UseVisualStyleBackColor = true;
            this.button_Backwards.Click += new System.EventHandler(this.button_Backwards_Click);
            // 
            // button_Forwards
            // 
            this.button_Forwards.Location = new System.Drawing.Point(6, 65);
            this.button_Forwards.Name = "button_Forwards";
            this.button_Forwards.Size = new System.Drawing.Size(89, 23);
            this.button_Forwards.TabIndex = 13;
            this.button_Forwards.Text = "Forwards!";
            this.button_Forwards.UseVisualStyleBackColor = true;
            this.button_Forwards.Click += new System.EventHandler(this.button_Forwards_Click);
            // 
            // radioButton_lexicographical
            // 
            this.radioButton_lexicographical.AutoSize = true;
            this.radioButton_lexicographical.Location = new System.Drawing.Point(6, 42);
            this.radioButton_lexicographical.Name = "radioButton_lexicographical";
            this.radioButton_lexicographical.Size = new System.Drawing.Size(57, 17);
            this.radioButton_lexicographical.TabIndex = 12;
            this.radioButton_lexicographical.Text = "Strings";
            this.radioButton_lexicographical.UseVisualStyleBackColor = true;
            this.radioButton_lexicographical.CheckedChanged += new System.EventHandler(this.radioButton_lexicographical_CheckedChanged);
            // 
            // radioButton_numerical
            // 
            this.radioButton_numerical.AutoSize = true;
            this.radioButton_numerical.Checked = true;
            this.radioButton_numerical.Location = new System.Drawing.Point(6, 19);
            this.radioButton_numerical.Name = "radioButton_numerical";
            this.radioButton_numerical.Size = new System.Drawing.Size(67, 17);
            this.radioButton_numerical.TabIndex = 10;
            this.radioButton_numerical.TabStop = true;
            this.radioButton_numerical.Text = "Numbers";
            this.radioButton_numerical.CheckedChanged += new System.EventHandler(this.radioButton_numerical_CheckedChanged);
            // 
            // textBox_items
            // 
            this.textBox_items.Location = new System.Drawing.Point(124, 12);
            this.textBox_items.Multiline = true;
            this.textBox_items.Name = "textBox_items";
            this.textBox_items.Size = new System.Drawing.Size(307, 276);
            this.textBox_items.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_numerical);
            this.groupBox1.Controls.Add(this.repeatTimes);
            this.groupBox1.Controls.Add(this.radioButton_lexicographical);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Forwards);
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_Backwards);
            this.groupBox1.Controls.Add(this.intervalInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox_animate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 276);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_items);
            this.Name = "MainForm";
            this.Text = "The Permuterator";
            ((System.ComponentModel.ISupportInitialize)(this.repeatTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.NumericUpDown repeatTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalInput;
        private System.Windows.Forms.CheckBox checkBox_animate;
        private System.Windows.Forms.Button button_Backwards;
        private System.Windows.Forms.Button button_Forwards;
        private System.Windows.Forms.RadioButton radioButton_lexicographical;
        private System.Windows.Forms.RadioButton radioButton_numerical;
        private System.Windows.Forms.TextBox textBox_items;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

