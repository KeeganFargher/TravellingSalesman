﻿namespace TravellingSalesman
{
    partial class TravellingSalesForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.trackBarCircleSize = new System.Windows.Forms.TrackBar();
            this.trackBarCities = new System.Windows.Forms.TrackBar();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCircleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCities)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.LightGray;
            this.panelSidebar.Controls.Add(this.trackBarCircleSize);
            this.panelSidebar.Controls.Add(this.trackBarCities);
            this.panelSidebar.Controls.Add(this.buttonUpdate);
            this.panelSidebar.Controls.Add(this.label2);
            this.panelSidebar.Controls.Add(this.buttonStart);
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSidebar.Location = new System.Drawing.Point(745, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(232, 450);
            this.panelSidebar.TabIndex = 0;
            // 
            // trackBarCircleSize
            // 
            this.trackBarCircleSize.Location = new System.Drawing.Point(7, 98);
            this.trackBarCircleSize.Maximum = 40;
            this.trackBarCircleSize.Minimum = 2;
            this.trackBarCircleSize.Name = "trackBarCircleSize";
            this.trackBarCircleSize.Size = new System.Drawing.Size(213, 45);
            this.trackBarCircleSize.TabIndex = 9;
            this.trackBarCircleSize.Value = 2;
            this.trackBarCircleSize.ValueChanged += new System.EventHandler(this.TrackBarCircleSize_ValueChanged);
            // 
            // trackBarCities
            // 
            this.trackBarCities.Location = new System.Drawing.Point(7, 33);
            this.trackBarCities.Maximum = 2000;
            this.trackBarCities.Minimum = 2;
            this.trackBarCities.Name = "trackBarCities";
            this.trackBarCities.Size = new System.Drawing.Size(213, 45);
            this.trackBarCities.TabIndex = 8;
            this.trackBarCities.Value = 2;
            this.trackBarCities.ValueChanged += new System.EventHandler(this.TrackBarCities_ValueChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(7, 368);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(213, 32);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Circle Size";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(7, 406);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(213, 32);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Cities";
            // 
            // TravellingSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.panelSidebar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TravellingSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travelling Salesman";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TravellingSalesForm_Paint);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCircleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarCities;
        private System.Windows.Forms.TrackBar trackBarCircleSize;
    }
}

