namespace WindowsFormsApplication1
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
            this.lblH = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.lblCM = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblDV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblH.Location = new System.Drawing.Point(12, 38);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(115, 22);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "Your Height:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblW.Location = new System.Drawing.Point(12, 95);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(120, 22);
            this.lblW.TabIndex = 1;
            this.lblW.Text = "Your Weight:";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(133, 33);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(127, 32);
            this.txtH.TabIndex = 2;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(133, 90);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(127, 32);
            this.txtW.TabIndex = 3;
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(89, 144);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(149, 38);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute BMI";
            this.btnCompute.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your BMI:";
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(133, 216);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(127, 32);
            this.txtBMI.TabIndex = 6;
            this.txtBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Location = new System.Drawing.Point(266, 36);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(37, 24);
            this.lblCM.TabIndex = 7;
            this.lblCM.Text = "cm";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(266, 93);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(32, 24);
            this.lblKG.TabIndex = 8;
            this.lblKG.Text = "kg";
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(266, 219);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(55, 24);
            this.lblDV.TabIndex = 9;
            this.lblDV.Text = "kg/m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 259);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.lblKG);
            this.Controls.Add(this.lblCM);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblH);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Calculate Your Body Mass Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label lblDV;
    }
}

