namespace GUI.MenuPrincipal
{
    partial class PnlMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PnlMenuPrincipal));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.tabConsultas = new System.Windows.Forms.RibbonTab();
            this.tabRelatorios = new System.Windows.Forms.RibbonTab();
            this.abaConsultas = new System.Windows.Forms.RibbonPanel();
            this.btnProdutos = new System.Windows.Forms.RibbonButton();
            this.btnFichaTecnica = new System.Windows.Forms.RibbonButton();
            this.btnOrdemProducao = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(800, 183);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.tabConsultas);
            this.ribbon1.Tabs.Add(this.tabRelatorios);
            this.ribbon1.Text = "ribbon1";
            // 
            // tabConsultas
            // 
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Panels.Add(this.abaConsultas);
            this.tabConsultas.Text = "Consultas";
            // 
            // tabRelatorios
            // 
            this.tabRelatorios.Name = "tabRelatorios";
            this.tabRelatorios.Text = "Relatórios";
            // 
            // abaConsultas
            // 
            this.abaConsultas.Items.Add(this.btnProdutos);
            this.abaConsultas.Items.Add(this.btnFichaTecnica);
            this.abaConsultas.Items.Add(this.btnOrdemProducao);
            this.abaConsultas.Name = "abaConsultas";
            this.abaConsultas.Text = "Consultas";
            // 
            // btnProdutos
            // 
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.LargeImage")));
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.SmallImage")));
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // btnFichaTecnica
            // 
            this.btnFichaTecnica.Image = ((System.Drawing.Image)(resources.GetObject("btnFichaTecnica.Image")));
            this.btnFichaTecnica.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFichaTecnica.LargeImage")));
            this.btnFichaTecnica.Name = "btnFichaTecnica";
            this.btnFichaTecnica.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFichaTecnica.SmallImage")));
            this.btnFichaTecnica.Text = "Ficha Técnica";
            this.btnFichaTecnica.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // btnOrdemProducao
            // 
            this.btnOrdemProducao.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdemProducao.Image")));
            this.btnOrdemProducao.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOrdemProducao.LargeImage")));
            this.btnOrdemProducao.Name = "btnOrdemProducao";
            this.btnOrdemProducao.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOrdemProducao.SmallImage")));
            this.btnOrdemProducao.Text = "Ordens de Produção";
            this.btnOrdemProducao.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // PnlMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PnlMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integração WisePCP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PnlMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab tabConsultas;
        private System.Windows.Forms.RibbonTab tabRelatorios;
        private System.Windows.Forms.RibbonPanel abaConsultas;
        private System.Windows.Forms.RibbonButton btnProdutos;
        private System.Windows.Forms.RibbonButton btnFichaTecnica;
        private System.Windows.Forms.RibbonButton btnOrdemProducao;
    }
}