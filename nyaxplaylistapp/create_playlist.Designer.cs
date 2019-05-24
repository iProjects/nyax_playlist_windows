namespace nyaxplaylistapp
{
    partial class create_playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_playlist));
            this.lblmediatype = new System.Windows.Forms.Label();
            this.cbomediatype = new System.Windows.Forms.ComboBox();
            this.lblbuildversion = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lbldatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltimelapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btngenerate_playlist_json = new System.Windows.Forms.Button();
            this.notifyIconntharene = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblprogresscounta = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmediatype
            // 
            this.lblmediatype.AutoSize = true;
            this.lblmediatype.BackColor = System.Drawing.Color.Transparent;
            this.lblmediatype.Location = new System.Drawing.Point(16, 129);
            this.lblmediatype.Name = "lblmediatype";
            this.lblmediatype.Size = new System.Drawing.Size(58, 13);
            this.lblmediatype.TabIndex = 1;
            this.lblmediatype.Text = "media type";
            // 
            // cbomediatype
            // 
            this.cbomediatype.BackColor = System.Drawing.Color.Black;
            this.cbomediatype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomediatype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbomediatype.ForeColor = System.Drawing.Color.Lime;
            this.cbomediatype.FormattingEnabled = true;
            this.cbomediatype.Location = new System.Drawing.Point(80, 126);
            this.cbomediatype.Name = "cbomediatype";
            this.cbomediatype.Size = new System.Drawing.Size(242, 21);
            this.cbomediatype.TabIndex = 2;
            // 
            // lblbuildversion
            // 
            this.lblbuildversion.AutoSize = true;
            this.lblbuildversion.BackColor = System.Drawing.Color.Transparent;
            this.lblbuildversion.Location = new System.Drawing.Point(14, 164);
            this.lblbuildversion.Name = "lblbuildversion";
            this.lblbuildversion.Size = new System.Drawing.Size(66, 13);
            this.lblbuildversion.TabIndex = 3;
            this.lblbuildversion.Text = "build version";
            // 
            // txtlog
            // 
            this.txtlog.BackColor = System.Drawing.Color.Black;
            this.txtlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtlog.ForeColor = System.Drawing.Color.Lime;
            this.txtlog.Location = new System.Drawing.Point(0, 0);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlog.Size = new System.Drawing.Size(357, 117);
            this.txtlog.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.lbldatetime,
            this.lbltimelapsed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(357, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lbldatetime
            // 
            this.lbldatetime.BackColor = System.Drawing.Color.Transparent;
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(31, 17);
            this.lbldatetime.Text = "time";
            // 
            // lbltimelapsed
            // 
            this.lbltimelapsed.Name = "lbltimelapsed";
            this.lbltimelapsed.Size = new System.Drawing.Size(74, 17);
            this.lbltimelapsed.Text = "time elapsed";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblprogresscounta);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btngenerate_playlist_json);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(234, 19);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "&exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btngenerate_playlist_json
            // 
            this.btngenerate_playlist_json.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate_playlist_json.Location = new System.Drawing.Point(6, 19);
            this.btngenerate_playlist_json.Name = "btngenerate_playlist_json";
            this.btngenerate_playlist_json.Size = new System.Drawing.Size(168, 23);
            this.btngenerate_playlist_json.TabIndex = 0;
            this.btngenerate_playlist_json.Text = "generate playlist json";
            this.btngenerate_playlist_json.UseVisualStyleBackColor = true;
            this.btngenerate_playlist_json.Click += new System.EventHandler(this.btngenerate_playlist_json_Click);
            // 
            // notifyIconntharene
            // 
            this.notifyIconntharene.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconntharene.Icon")));
            this.notifyIconntharene.Visible = true;
            // 
            // lblprogresscounta
            // 
            this.lblprogresscounta.AutoSize = true;
            this.lblprogresscounta.BackColor = System.Drawing.Color.Black;
            this.lblprogresscounta.ForeColor = System.Drawing.Color.Lime;
            this.lblprogresscounta.Location = new System.Drawing.Point(4, 48);
            this.lblprogresscounta.Name = "lblprogresscounta";
            this.lblprogresscounta.Size = new System.Drawing.Size(83, 13);
            this.lblprogresscounta.TabIndex = 4;
            this.lblprogresscounta.Text = "progress counta";
            // 
            // create_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nyaxplaylistapp.Properties.Resources.powermage;
            this.ClientSize = new System.Drawing.Size(357, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.lblbuildversion);
            this.Controls.Add(this.cbomediatype);
            this.Controls.Add(this.lblmediatype);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "create_playlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "playlist manager";
            this.Load += new System.EventHandler(this.create_playlist_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmediatype;
        private System.Windows.Forms.ComboBox cbomediatype;
        private System.Windows.Forms.Label lblbuildversion;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btngenerate_playlist_json;
        private System.Windows.Forms.ToolStripStatusLabel lbldatetime;
        private System.Windows.Forms.NotifyIcon notifyIconntharene;
        private System.Windows.Forms.ToolStripStatusLabel lbltimelapsed;
        private System.Windows.Forms.Label lblprogresscounta;

    }
}

