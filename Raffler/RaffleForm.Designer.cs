namespace Raffler
{
    partial class RaffleForm
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
            this.BtnOpenCsv = new System.Windows.Forms.Button();
            this.textBoxOpenedFile = new System.Windows.Forms.TextBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.listViewWinners = new System.Windows.Forms.ListView();
            this.btnStartRaffle = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblStartRaffle = new System.Windows.Forms.Label();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenCsv
            // 
            this.BtnOpenCsv.Location = new System.Drawing.Point(12, 28);
            this.BtnOpenCsv.Name = "BtnOpenCsv";
            this.BtnOpenCsv.Size = new System.Drawing.Size(159, 41);
            this.BtnOpenCsv.TabIndex = 0;
            this.BtnOpenCsv.Text = "Open CSV";
            this.BtnOpenCsv.UseVisualStyleBackColor = true;
            this.BtnOpenCsv.Click += new System.EventHandler(this.BtnOpenCsv_Click);
            // 
            // textBoxOpenedFile
            // 
            this.textBoxOpenedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpenedFile.Location = new System.Drawing.Point(178, 31);
            this.textBoxOpenedFile.Multiline = true;
            this.textBoxOpenedFile.Name = "textBoxOpenedFile";
            this.textBoxOpenedFile.ReadOnly = true;
            this.textBoxOpenedFile.Size = new System.Drawing.Size(588, 35);
            this.textBoxOpenedFile.TabIndex = 1;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResults.Controls.Add(this.lblStartRaffle);
            this.groupBoxResults.Controls.Add(this.listViewWinners);
            this.groupBoxResults.Location = new System.Drawing.Point(12, 152);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(760, 641);
            this.groupBoxResults.TabIndex = 2;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // listViewWinners
            // 
            this.listViewWinners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewWinners.HideSelection = false;
            this.listViewWinners.Location = new System.Drawing.Point(6, 30);
            this.listViewWinners.Name = "listViewWinners";
            this.listViewWinners.Size = new System.Drawing.Size(748, 605);
            this.listViewWinners.TabIndex = 0;
            this.listViewWinners.UseCompatibleStateImageBehavior = false;
            this.listViewWinners.Visible = false;
            // 
            // btnStartRaffle
            // 
            this.btnStartRaffle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartRaffle.Location = new System.Drawing.Point(12, 90);
            this.btnStartRaffle.Name = "btnStartRaffle";
            this.btnStartRaffle.Size = new System.Drawing.Size(760, 41);
            this.btnStartRaffle.TabIndex = 3;
            this.btnStartRaffle.Text = "Start Raffle";
            this.btnStartRaffle.UseVisualStyleBackColor = true;
            this.btnStartRaffle.Click += new System.EventHandler(this.btnStartRaffle_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblStartRaffle
            // 
            this.lblStartRaffle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartRaffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartRaffle.Location = new System.Drawing.Point(6, 27);
            this.lblStartRaffle.Name = "lblStartRaffle";
            this.lblStartRaffle.Size = new System.Drawing.Size(748, 608);
            this.lblStartRaffle.TabIndex = 1;
            this.lblStartRaffle.Text = "Start Raffle First";
            this.lblStartRaffle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartRaffle.Visible = false;
            // 
            // RaffleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 805);
            this.Controls.Add(this.btnStartRaffle);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.textBoxOpenedFile);
            this.Controls.Add(this.BtnOpenCsv);
            this.Name = "RaffleForm";
            this.Text = "Raffler";
            this.groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenCsv;
        private System.Windows.Forms.TextBox textBoxOpenedFile;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Button btnStartRaffle;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView listViewWinners;
        private System.Windows.Forms.Label lblStartRaffle;
    }
}

