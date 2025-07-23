namespace n_sei_mais_o_que_fazer
{
    partial class VidMassagemCardiaca
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.chkAutoplay = new System.Windows.Forms.CheckBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lvlVideos = new System.Windows.Forms.ListView();
            this.wbVideo = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lvlVideos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.wbVideo, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.txtUrl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkAutoplay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCarregar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Location = new System.Drawing.Point(3, 3);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(549, 33);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkAutoplay
            // 
            this.chkAutoplay.AutoSize = true;
            this.chkAutoplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAutoplay.Location = new System.Drawing.Point(558, 3);
            this.chkAutoplay.Name = "chkAutoplay";
            this.chkAutoplay.Size = new System.Drawing.Size(152, 33);
            this.chkAutoplay.TabIndex = 2;
            this.chkAutoplay.Text = "checkBox1";
            this.chkAutoplay.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCarregar.Location = new System.Drawing.Point(716, 3);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 33);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "button1";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lvlVideos
            // 
            this.lvlVideos.HideSelection = false;
            this.lvlVideos.Location = new System.Drawing.Point(3, 48);
            this.lvlVideos.Name = "lvlVideos";
            this.lvlVideos.Size = new System.Drawing.Size(794, 84);
            this.lvlVideos.TabIndex = 1;
            this.lvlVideos.UseCompatibleStateImageBehavior = false;
            // 
            // wbVideo
            // 
            this.wbVideo.Location = new System.Drawing.Point(3, 138);
            this.wbVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVideo.Name = "wbVideo";
            this.wbVideo.Size = new System.Drawing.Size(794, 309);
            this.wbVideo.TabIndex = 2;
            // 
            // VidMassagemCardiaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VidMassagemCardiaca";
            this.Text = "VidMassagemCardiaca";
            this.Load += new System.EventHandler(this.VidMassagemCardiaca_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.CheckBox chkAutoplay;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListView lvlVideos;
        private System.Windows.Forms.WebBrowser wbVideo;
    }
}