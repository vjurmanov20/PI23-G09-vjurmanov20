﻿namespace Evaluation_Manager {
    partial class FrmFinalReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGenerateEvaluationReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(100, 60);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(606, 340);
            this.dgvResults.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(668, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenerateEvaluationReport
            // 
            this.btnGenerateEvaluationReport.Location = new System.Drawing.Point(31, 412);
            this.btnGenerateEvaluationReport.Name = "btnGenerateEvaluationReport";
            this.btnGenerateEvaluationReport.Size = new System.Drawing.Size(114, 28);
            this.btnGenerateEvaluationReport.TabIndex = 2;
            this.btnGenerateEvaluationReport.Text = "Generiraj Izvještaj";
            this.btnGenerateEvaluationReport.UseVisualStyleBackColor = true;
            this.btnGenerateEvaluationReport.Click += new System.EventHandler(this.btnGenerateEvaluationReport_Click);
            // 
            // FrmFinalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateEvaluationReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvResults);
            this.Name = "FrmFinalReport";
            this.Text = "Završni izvještaj kontinuiranog praćenja";
            this.Load += new System.EventHandler(this.FrmFinalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGenerateEvaluationReport;
    }
}