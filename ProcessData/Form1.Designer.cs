namespace ProcessData
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
            btnProcesar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(117, 146);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(104, 57);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "Process";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(576, 30);
            label1.TabIndex = 1;
            label1.Text = "In this code, the ProcessData function receives the arrays of different dimensions and calculates the average,\r\n sum and multiplication of the elements of each array.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnProcesar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcesar;
        private Label label1;
    }
}
