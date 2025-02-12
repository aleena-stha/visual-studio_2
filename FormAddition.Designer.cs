namespace MyFirstDesktop
{
    partial class FormAddition
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the First Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(466, 63);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNumber.TabIndex = 1;
            this.txtFirstNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Second number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(466, 116);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNumber.TabIndex = 4;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(274, 165);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(28, 13);
            this.Sum.TabIndex = 5;
            this.Sum.Text = "Sum";
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(466, 162);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 6;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(347, 233);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(117, 23);
            this.btnAddition.TabIndex = 7;
            this.btnAddition.Text = "Click To sum";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormAddition";
            this.RightToLeftLayout = true;
            this.Text = "FrmAddition";
            this.Load += new System.EventHandler(this.FormAddition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnAddition;
    }
}