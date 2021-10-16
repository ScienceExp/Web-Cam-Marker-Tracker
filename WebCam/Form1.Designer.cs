namespace WebCam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMarker1 = new System.Windows.Forms.Label();
            this.lblMarker2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webCapture1 = new WebCam.WebCapture();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMarker1
            // 
            this.lblMarker1.AutoSize = true;
            this.lblMarker1.ForeColor = System.Drawing.Color.Black;
            this.lblMarker1.Location = new System.Drawing.Point(82, 254);
            this.lblMarker1.Name = "lblMarker1";
            this.lblMarker1.Size = new System.Drawing.Size(22, 13);
            this.lblMarker1.TabIndex = 3;
            this.lblMarker1.Text = "0,0";
            // 
            // lblMarker2
            // 
            this.lblMarker2.AutoSize = true;
            this.lblMarker2.ForeColor = System.Drawing.Color.Black;
            this.lblMarker2.Location = new System.Drawing.Point(256, 254);
            this.lblMarker2.Name = "lblMarker2";
            this.lblMarker2.Size = new System.Drawing.Size(22, 13);
            this.lblMarker2.TabIndex = 4;
            this.lblMarker2.Text = "0,0";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webCapture1
            // 
            this.webCapture1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webCapture1.BackColor = System.Drawing.Color.Black;
            this.webCapture1.CaptureFPS = 30;
            this.webCapture1.CaptureHeight = 240;
            this.webCapture1.CaptureWidth = 320;
            this.webCapture1.Location = new System.Drawing.Point(2, 2);
            this.webCapture1.Name = "webCapture1";
            this.webCapture1.ShowTrackerDebug = true;
            this.webCapture1.Size = new System.Drawing.Size(320, 240);
            this.webCapture1.TabIndex = 2;
            this.webCapture1.TrackerMarkerSize = 8;
            this.webCapture1.TrackerMinimumMatch = 0.3F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top Marker:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(173, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bottom Marker:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMarker2);
            this.Controls.Add(this.lblMarker1);
            this.Controls.Add(this.webCapture1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Marker Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WebCapture webCapture1;
        private System.Windows.Forms.Label lblMarker1;
        private System.Windows.Forms.Label lblMarker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

