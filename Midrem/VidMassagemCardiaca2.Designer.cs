namespace n_sei_mais_o_que_fazer
{
    partial class VidMassagemCardiaca2
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbVideo = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbVideo
            // 
            this.wbVideo.Location = new System.Drawing.Point(11, 45);
            this.wbVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVideo.Name = "wbVideo";
            this.wbVideo.Size = new System.Drawing.Size(794, 399);
            this.wbVideo.TabIndex = 3;
            this.wbVideo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbVideo_DocumentCompleted);
            // 
            // VidMassagemCardiaca2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.wbVideo);
            this.Name = "VidMassagemCardiaca2";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.VidMassagemCardiaca2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbVideo;
    }
}
