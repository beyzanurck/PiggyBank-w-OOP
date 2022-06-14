namespace PiggyBank
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
            this.progressOfVolume = new System.Windows.Forms.ProgressBar();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.btnFoldMoney = new System.Windows.Forms.Button();
            this.btnShakeBox = new System.Windows.Forms.Button();
            this.btnBreakBox = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pctFixedOne = new System.Windows.Forms.PictureBox();
            this.pctBrokenOne = new System.Windows.Forms.PictureBox();
            this.pctTheBox = new System.Windows.Forms.PictureBox();
            this.cmbSelectMoney = new System.Windows.Forms.ComboBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFixedOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrokenOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTheBox)).BeginInit();
            this.SuspendLayout();
            // 
            // progressOfVolume
            // 
            this.progressOfVolume.Location = new System.Drawing.Point(190, 12);
            this.progressOfVolume.Name = "progressOfVolume";
            this.progressOfVolume.Size = new System.Drawing.Size(138, 23);
            this.progressOfVolume.TabIndex = 0;
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(44, 194);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(75, 23);
            this.btnAddMoney.TabIndex = 2;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // btnFoldMoney
            // 
            this.btnFoldMoney.Location = new System.Drawing.Point(158, 194);
            this.btnFoldMoney.Name = "btnFoldMoney";
            this.btnFoldMoney.Size = new System.Drawing.Size(75, 23);
            this.btnFoldMoney.TabIndex = 2;
            this.btnFoldMoney.Text = "Fold Money";
            this.btnFoldMoney.UseVisualStyleBackColor = true;
            this.btnFoldMoney.Click += new System.EventHandler(this.btnFoldMoney_Click);
            // 
            // btnShakeBox
            // 
            this.btnShakeBox.Location = new System.Drawing.Point(267, 194);
            this.btnShakeBox.Name = "btnShakeBox";
            this.btnShakeBox.Size = new System.Drawing.Size(91, 23);
            this.btnShakeBox.TabIndex = 2;
            this.btnShakeBox.Text = "Shake The Box";
            this.btnShakeBox.UseVisualStyleBackColor = true;
            this.btnShakeBox.Click += new System.EventHandler(this.btnShakeBox_Click);
            // 
            // btnBreakBox
            // 
            this.btnBreakBox.Location = new System.Drawing.Point(392, 194);
            this.btnBreakBox.Name = "btnBreakBox";
            this.btnBreakBox.Size = new System.Drawing.Size(88, 23);
            this.btnBreakBox.TabIndex = 2;
            this.btnBreakBox.Text = "Break The Box";
            this.btnBreakBox.UseVisualStyleBackColor = true;
            this.btnBreakBox.Click += new System.EventHandler(this.btnBreakBox_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pctFixedOne);
            this.panel.Controls.Add(this.pctBrokenOne);
            this.panel.Controls.Add(this.pctTheBox);
            this.panel.Location = new System.Drawing.Point(192, 54);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(136, 118);
            this.panel.TabIndex = 3;
            // 
            // pctFixedOne
            // 
            this.pctFixedOne.Image = global::PiggyBank.Properties.Resources.fixedBox;
            this.pctFixedOne.Location = new System.Drawing.Point(150, 3);
            this.pctFixedOne.Name = "pctFixedOne";
            this.pctFixedOne.Size = new System.Drawing.Size(130, 112);
            this.pctFixedOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFixedOne.TabIndex = 2;
            this.pctFixedOne.TabStop = false;
            // 
            // pctBrokenOne
            // 
            this.pctBrokenOne.Image = global::PiggyBank.Properties.Resources.brokenBox;
            this.pctBrokenOne.Location = new System.Drawing.Point(-150, 3);
            this.pctBrokenOne.Name = "pctBrokenOne";
            this.pctBrokenOne.Size = new System.Drawing.Size(130, 112);
            this.pctBrokenOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBrokenOne.TabIndex = 1;
            this.pctBrokenOne.TabStop = false;
            // 
            // pctTheBox
            // 
            this.pctTheBox.Image = global::PiggyBank.Properties.Resources.addMoney;
            this.pctTheBox.Location = new System.Drawing.Point(3, 3);
            this.pctTheBox.Name = "pctTheBox";
            this.pctTheBox.Size = new System.Drawing.Size(130, 112);
            this.pctTheBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTheBox.TabIndex = 0;
            this.pctTheBox.TabStop = false;
            // 
            // cmbSelectMoney
            // 
            this.cmbSelectMoney.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectMoney.ForeColor = System.Drawing.Color.Black;
            this.cmbSelectMoney.FormattingEnabled = true;
            this.cmbSelectMoney.Location = new System.Drawing.Point(190, 233);
            this.cmbSelectMoney.Name = "cmbSelectMoney";
            this.cmbSelectMoney.Size = new System.Drawing.Size(154, 23);
            this.cmbSelectMoney.TabIndex = 4;
            this.cmbSelectMoney.Text = "Please Select Money";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 276);
            this.Controls.Add(this.cmbSelectMoney);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnBreakBox);
            this.Controls.Add(this.btnShakeBox);
            this.Controls.Add(this.btnFoldMoney);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.progressOfVolume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctFixedOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrokenOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTheBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressOfVolume;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Button btnFoldMoney;
        private System.Windows.Forms.Button btnShakeBox;
        private System.Windows.Forms.Button btnBreakBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pctFixedOne;
        private System.Windows.Forms.PictureBox pctBrokenOne;
        private System.Windows.Forms.PictureBox pctTheBox;
        private System.Windows.Forms.ComboBox cmbSelectMoney;
    }
}

