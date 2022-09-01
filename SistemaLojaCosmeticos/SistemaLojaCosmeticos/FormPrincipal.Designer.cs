
namespace SistemaLojaCosmeticos
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menucadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bt_funcionarios = new System.Windows.Forms.ToolStripButton();
            this.bt_clientes = new System.Windows.Forms.ToolStripButton();
            this.bt_vendas = new System.Windows.Forms.ToolStripButton();
            this.bt_sair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bt_mensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_principal = new System.Windows.Forms.Timer(this.components);
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menucadastro,
            this.MenuVendas,
            this.MenuConsultas,
            this.MenuRelatorios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menucadastro
            // 
            this.Menucadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCategoria,
            this.MenuCargos,
            this.MenuClientes,
            this.MenuMarcas,
            this.MenuProdutos,
            this.MenuFuncionarios});
            this.Menucadastro.Image = ((System.Drawing.Image)(resources.GetObject("Menucadastro.Image")));
            this.Menucadastro.Name = "Menucadastro";
            this.Menucadastro.Size = new System.Drawing.Size(106, 36);
            this.Menucadastro.Text = "Cadastro";
            // 
            // MenuCategoria
            // 
            this.MenuCategoria.Name = "MenuCategoria";
            this.MenuCategoria.Size = new System.Drawing.Size(196, 38);
            this.MenuCategoria.Text = "Categorias";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(196, 38);
            this.MenuCargos.Text = "Cargos";
            // 
            // MenuClientes
            // 
            this.MenuClientes.Image = ((System.Drawing.Image)(resources.GetObject("MenuClientes.Image")));
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.MenuClientes.Size = new System.Drawing.Size(196, 38);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuMarcas
            // 
            this.MenuMarcas.Name = "MenuMarcas";
            this.MenuMarcas.Size = new System.Drawing.Size(196, 38);
            this.MenuMarcas.Text = "Marcas";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.MenuProdutos.Size = new System.Drawing.Size(196, 38);
            this.MenuProdutos.Text = "Produtos";
            this.MenuProdutos.Click += new System.EventHandler(this.MenuProdutos_Click);
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(196, 38);
            this.MenuFuncionarios.Text = "Funcionários";
            // 
            // MenuVendas
            // 
            this.MenuVendas.Image = ((System.Drawing.Image)(resources.GetObject("MenuVendas.Image")));
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(97, 36);
            this.MenuVendas.Text = "Vendas";
            // 
            // MenuConsultas
            // 
            this.MenuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.MenuConsultas.Image = ((System.Drawing.Image)(resources.GetObject("MenuConsultas.Image")));
            this.MenuConsultas.Name = "MenuConsultas";
            this.MenuConsultas.Size = new System.Drawing.Size(112, 36);
            this.MenuConsultas.Text = "Consultas";
            this.MenuConsultas.Click += new System.EventHandler(this.MenuConsultas_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.MenuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatorios.Image")));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(114, 36);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuSair
            // 
            this.MenuSair.Image = ((System.Drawing.Image)(resources.GetObject("MenuSair.Image")));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(75, 36);
            this.MenuSair.Text = "Sair";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bt_funcionarios,
            this.bt_clientes,
            this.bt_vendas,
            this.bt_sair});
            this.toolStrip1.Location = new System.Drawing.Point(717, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(80, 510);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 15);
            this.toolStripLabel1.Text = "Cadastros";
            // 
            // bt_funcionarios
            // 
            this.bt_funcionarios.Image = ((System.Drawing.Image)(resources.GetObject("bt_funcionarios.Image")));
            this.bt_funcionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_funcionarios.Name = "bt_funcionarios";
            this.bt_funcionarios.Size = new System.Drawing.Size(77, 67);
            this.bt_funcionarios.Text = "Funcionários";
            this.bt_funcionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bt_clientes
            // 
            this.bt_clientes.Image = ((System.Drawing.Image)(resources.GetObject("bt_clientes.Image")));
            this.bt_clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(77, 67);
            this.bt_clientes.Text = "Clientes";
            this.bt_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bt_vendas
            // 
            this.bt_vendas.Image = ((System.Drawing.Image)(resources.GetObject("bt_vendas.Image")));
            this.bt_vendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_vendas.Name = "bt_vendas";
            this.bt_vendas.Size = new System.Drawing.Size(77, 67);
            this.bt_vendas.Text = "Vendas";
            this.bt_vendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bt_sair
            // 
            this.bt_sair.Image = ((System.Drawing.Image)(resources.GetObject("bt_sair.Image")));
            this.bt_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(77, 67);
            this.bt_sair.Text = "Sair";
            this.bt_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_mensagem,
            this.lb_data,
            this.lb_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(717, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bt_mensagem
            // 
            this.bt_mensagem.Name = "bt_mensagem";
            this.bt_mensagem.Size = new System.Drawing.Size(142, 17);
            this.bt_mensagem.Text = "Bem Vindo (a) ao Sistema";
            // 
            // lb_data
            // 
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(31, 17);
            this.lb_data.Text = "Data";
            // 
            // lb_hora
            // 
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(33, 17);
            this.lb_hora.Text = "Hora";
            // 
            // Timer_principal
            // 
            this.Timer_principal.Enabled = true;
            this.Timer_principal.Tick += new System.EventHandler(this.Timer_principal_Tick);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Outlook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "FormPrincipal";
            this.Text = ".";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menucadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcas;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton bt_funcionarios;
        private System.Windows.Forms.ToolStripButton bt_clientes;
        private System.Windows.Forms.ToolStripButton bt_vendas;
        private System.Windows.Forms.ToolStripButton bt_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel bt_mensagem;
        private System.Windows.Forms.ToolStripStatusLabel lb_data;
        private System.Windows.Forms.ToolStripStatusLabel lb_hora;
        private System.Windows.Forms.Timer Timer_principal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
    }
}

