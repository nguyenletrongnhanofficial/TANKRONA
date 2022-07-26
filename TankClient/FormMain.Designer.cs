﻿namespace CrazyTank
{
    partial class FormMain
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.GameStage = new System.Windows.Forms.PictureBox();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.lblState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picTank = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameStage)).BeginInit();
            this.pnlConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            this.SuspendLayout();
            // 
            // GameStage
            // 
            this.GameStage.Location = new System.Drawing.Point(0, 0);
            this.GameStage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameStage.Name = "GameStage";
            this.GameStage.Size = new System.Drawing.Size(640, 512);
            this.GameStage.TabIndex = 0;
            this.GameStage.TabStop = false;
            this.GameStage.Paint += new System.Windows.Forms.PaintEventHandler(this.GameStage_Paint);
            // 
            // pnlConnect
            // 
            this.pnlConnect.BackColor = System.Drawing.Color.White;
            this.pnlConnect.Controls.Add(this.label4);
            this.pnlConnect.Controls.Add(this.txtName);
            this.pnlConnect.Controls.Add(this.trbBlue);
            this.pnlConnect.Controls.Add(this.trbGreen);
            this.pnlConnect.Controls.Add(this.trbRed);
            this.pnlConnect.Controls.Add(this.lblState);
            this.pnlConnect.Controls.Add(this.label3);
            this.pnlConnect.Controls.Add(this.btnConnect);
            this.pnlConnect.Controls.Add(this.txtPort);
            this.pnlConnect.Controls.Add(this.label2);
            this.pnlConnect.Controls.Add(this.txtIP);
            this.pnlConnect.Controls.Add(this.label1);
            this.pnlConnect.Controls.Add(this.picTank);
            this.pnlConnect.Location = new System.Drawing.Point(195, 83);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(281, 354);
            this.pnlConnect.TabIndex = 1;
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(167, 138);
            this.trbBlue.Maximum = 100;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(104, 56);
            this.trbBlue.TabIndex = 15;
            this.trbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBlue.Scroll += new System.EventHandler(this.trbAll_Scroll);
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(167, 105);
            this.trbGreen.Maximum = 100;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(104, 56);
            this.trbGreen.TabIndex = 15;
            this.trbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbGreen.Scroll += new System.EventHandler(this.trbAll_Scroll);
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(167, 71);
            this.trbRed.Maximum = 100;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(104, 56);
            this.trbRed.TabIndex = 15;
            this.trbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbRed.Scroll += new System.EventHandler(this.trbAll_Scroll);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(74, 316);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 16);
            this.lblState.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tank color:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(77, 307);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 25);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(111, 233);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(85, 22);
            this.txtPort.TabIndex = 11;
            this.txtPort.Text = "7776";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "port:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(111, 199);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(102, 22);
            this.txtIP.TabIndex = 9;
            this.txtIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "server IP:";
            // 
            // picTank
            // 
            this.picTank.BackColor = System.Drawing.Color.Black;
            this.picTank.Location = new System.Drawing.Point(33, 50);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(128, 137);
            this.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTank.TabIndex = 7;
            this.picTank.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 270);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 556);
            this.Controls.Add(this.pnlConnect);
            this.Controls.Add(this.GameStage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "tankrona";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.GameStage)).EndInit();
            this.pnlConnect.ResumeLayout(false);
            this.pnlConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox GameStage;
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
    }
}

