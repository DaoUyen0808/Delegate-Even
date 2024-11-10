namespace Delegates
{
    partial class Form
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
            this.txtNumberOfButtons = new System.Windows.Forms.TextBox();
            this.btnCreateButtons = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng nút";
            // 
            // txtNumberOfButtons
            // 
            this.txtNumberOfButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfButtons.Location = new System.Drawing.Point(44, 76);
            this.txtNumberOfButtons.Name = "txtNumberOfButtons";
            this.txtNumberOfButtons.Size = new System.Drawing.Size(197, 27);
            this.txtNumberOfButtons.TabIndex = 1;
            // 
            // btnCreateButtons
            // 
            this.btnCreateButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.btnCreateButtons.ForeColor = System.Drawing.Color.White;
            this.btnCreateButtons.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateButtons.Location = new System.Drawing.Point(265, 76);
            this.btnCreateButtons.Name = "btnCreateButtons";
            this.btnCreateButtons.Size = new System.Drawing.Size(75, 27);
            this.btnCreateButtons.TabIndex = 2;
            this.btnCreateButtons.Text = "Tạo nút";
            this.btnCreateButtons.UseVisualStyleBackColor = false;
            this.btnCreateButtons.Click += new System.EventHandler(this.btnCreateButtons_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.AutoScroll = true;
            this.panelButtons.Location = new System.Drawing.Point(44, 132);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(296, 181);
            this.panelButtons.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(382, 378);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.btnCreateButtons);
            this.Controls.Add(this.txtNumberOfButtons);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form";
            this.Text = "Tạo tự động số lượng nút";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfButtons;
        private System.Windows.Forms.Button btnCreateButtons;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
    }
}

