namespace Cash_Register_Project
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.meadLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.muttonLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.recieptButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.meadInput = new System.Windows.Forms.NumericUpDown();
            this.muttonInput = new System.Windows.Forms.NumericUpDown();
            this.mealInput = new System.Windows.Forms.NumericUpDown();
            this.tenderedInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.meadInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muttonInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderedInput)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Gabriola", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.titleLabel.ForeColor = System.Drawing.Color.Gold;
            this.titleLabel.Location = new System.Drawing.Point(187, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(376, 90);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Broken Drum Inn";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold);
            this.sloganLabel.ForeColor = System.Drawing.Color.Gold;
            this.sloganLabel.Location = new System.Drawing.Point(291, 64);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(152, 50);
            this.sloganLabel.TabIndex = 1;
            this.sloganLabel.Text = "Can\'t be beat!";
            this.sloganLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meadLabel
            // 
            this.meadLabel.AutoSize = true;
            this.meadLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.meadLabel.ForeColor = System.Drawing.Color.Gold;
            this.meadLabel.Location = new System.Drawing.Point(25, 150);
            this.meadLabel.Name = "meadLabel";
            this.meadLabel.Size = new System.Drawing.Size(62, 42);
            this.meadLabel.TabIndex = 2;
            this.meadLabel.Text = "Mead";
            this.meadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.mealLabel.ForeColor = System.Drawing.Color.Gold;
            this.mealLabel.Location = new System.Drawing.Point(25, 220);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(56, 42);
            this.mealLabel.TabIndex = 3;
            this.mealLabel.Text = "Meal";
            this.mealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muttonLabel
            // 
            this.muttonLabel.AutoSize = true;
            this.muttonLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.muttonLabel.ForeColor = System.Drawing.Color.Gold;
            this.muttonLabel.Location = new System.Drawing.Point(25, 185);
            this.muttonLabel.Name = "muttonLabel";
            this.muttonLabel.Size = new System.Drawing.Size(76, 42);
            this.muttonLabel.TabIndex = 4;
            this.muttonLabel.Text = "Mutton";
            this.muttonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalButton
            // 
            this.totalButton.FlatAppearance.BorderSize = 3;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.Color.Gold;
            this.totalButton.Location = new System.Drawing.Point(15, 260);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(208, 47);
            this.totalButton.TabIndex = 5;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.subtotalLabel.ForeColor = System.Drawing.Color.Gold;
            this.subtotalLabel.Location = new System.Drawing.Point(25, 320);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(85, 42);
            this.subtotalLabel.TabIndex = 6;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.taxLabel.ForeColor = System.Drawing.Color.Gold;
            this.taxLabel.Location = new System.Drawing.Point(25, 355);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(96, 42);
            this.taxLabel.TabIndex = 7;
            this.taxLabel.Text = "Kings Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.totalLabel.ForeColor = System.Drawing.Color.Gold;
            this.totalLabel.Location = new System.Drawing.Point(25, 390);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 42);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(325, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.Gold;
            this.lineLabel.Location = new System.Drawing.Point(15, 425);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(208, 10);
            this.lineLabel.TabIndex = 10;
            this.lineLabel.Text = " ";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.tenderedLabel.ForeColor = System.Drawing.Color.Gold;
            this.tenderedLabel.Location = new System.Drawing.Point(25, 440);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(91, 42);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeButton
            // 
            this.changeButton.FlatAppearance.BorderSize = 3;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Gold;
            this.changeButton.Location = new System.Drawing.Point(15, 485);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(208, 47);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.changeLabel.ForeColor = System.Drawing.Color.Gold;
            this.changeLabel.Location = new System.Drawing.Point(25, 535);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(79, 42);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recieptButton
            // 
            this.recieptButton.FlatAppearance.BorderSize = 3;
            this.recieptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieptButton.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptButton.ForeColor = System.Drawing.Color.Gold;
            this.recieptButton.Location = new System.Drawing.Point(15, 580);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(208, 47);
            this.recieptButton.TabIndex = 14;
            this.recieptButton.Text = "Print Reciept";
            this.recieptButton.UseVisualStyleBackColor = true;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Bold);
            this.subtotalOutput.ForeColor = System.Drawing.Color.Gold;
            this.subtotalOutput.Location = new System.Drawing.Point(150, 320);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(60, 35);
            this.subtotalOutput.TabIndex = 18;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutput
            // 
            this.taxOutput.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Bold);
            this.taxOutput.ForeColor = System.Drawing.Color.Gold;
            this.taxOutput.Location = new System.Drawing.Point(150, 355);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(60, 35);
            this.taxOutput.TabIndex = 19;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Bold);
            this.totalOutput.ForeColor = System.Drawing.Color.Gold;
            this.totalOutput.Location = new System.Drawing.Point(150, 390);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(60, 35);
            this.totalOutput.TabIndex = 20;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Bold);
            this.changeOutput.ForeColor = System.Drawing.Color.Gold;
            this.changeOutput.Location = new System.Drawing.Point(150, 535);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(60, 35);
            this.changeOutput.TabIndex = 21;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meadInput
            // 
            this.meadInput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meadInput.Location = new System.Drawing.Point(156, 157);
            this.meadInput.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.meadInput.Name = "meadInput";
            this.meadInput.Size = new System.Drawing.Size(50, 30);
            this.meadInput.TabIndex = 22;
            // 
            // muttonInput
            // 
            this.muttonInput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muttonInput.Location = new System.Drawing.Point(156, 192);
            this.muttonInput.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.muttonInput.Name = "muttonInput";
            this.muttonInput.Size = new System.Drawing.Size(50, 30);
            this.muttonInput.TabIndex = 23;
            // 
            // mealInput
            // 
            this.mealInput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealInput.Location = new System.Drawing.Point(156, 227);
            this.mealInput.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.mealInput.Name = "mealInput";
            this.mealInput.Size = new System.Drawing.Size(50, 30);
            this.mealInput.TabIndex = 24;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(131, 447);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(75, 30);
            this.tenderedInput.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.mealInput);
            this.Controls.Add(this.muttonInput);
            this.Controls.Add(this.meadInput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.muttonLabel);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.meadLabel);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.meadInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muttonInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderedInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label meadLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Label muttonLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.NumericUpDown meadInput;
        private System.Windows.Forms.NumericUpDown muttonInput;
        private System.Windows.Forms.NumericUpDown mealInput;
        private System.Windows.Forms.NumericUpDown tenderedInput;
    }
}

