namespace SWE_PP_Bsp3_Polygon
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
            pic = new PictureBox();
            label1 = new Label();
            cbEcken = new ComboBox();
            chkDiagonalen = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic.BackColor = Color.White;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Location = new Point(12, 98);
            pic.Name = "pic";
            pic.Size = new Size(911, 890);
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.Resize += pic_Resize;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 1;
            label1.Text = "Anzahl Ecken:";
            // 
            // cbEcken
            // 
            cbEcken.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEcken.FormattingEnabled = true;
            cbEcken.Location = new Point(208, 36);
            cbEcken.Name = "cbEcken";
            cbEcken.Size = new Size(108, 40);
            cbEcken.TabIndex = 2;
            cbEcken.SelectedIndexChanged += cbEcken_SelectedIndexChanged;
            // 
            // chkDiagonalen
            // 
            chkDiagonalen.AutoSize = true;
            chkDiagonalen.CheckAlign = ContentAlignment.MiddleRight;
            chkDiagonalen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkDiagonalen.Location = new Point(653, 40);
            chkDiagonalen.Name = "chkDiagonalen";
            chkDiagonalen.Size = new Size(184, 36);
            chkDiagonalen.TabIndex = 3;
            chkDiagonalen.Text = "Diagonalen:";
            chkDiagonalen.TextAlign = ContentAlignment.TopRight;
            chkDiagonalen.UseVisualStyleBackColor = true;
            chkDiagonalen.CheckedChanged += chkDiagonalen_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 1000);
            Controls.Add(chkDiagonalen);
            Controls.Add(cbEcken);
            Controls.Add(label1);
            Controls.Add(pic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic;
        private Label label1;
        private ComboBox cbEcken;
        private CheckBox chkDiagonalen;
    }
}
