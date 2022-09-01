
namespace SistemaLojaCosmeticos
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.lb_cadastro_cliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mask_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.mask_rg = new System.Windows.Forms.MaskedTextBox();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.mask_residencial = new System.Windows.Forms.MaskedTextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.check_status = new System.Windows.Forms.CheckBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_celular = new System.Windows.Forms.Label();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.label_sexo = new System.Windows.Forms.Label();
            this.box_email = new System.Windows.Forms.TextBox();
            this.label_data_cadastro = new System.Windows.Forms.Label();
            this.box_codcli = new System.Windows.Forms.TextBox();
            this.label_nascimento = new System.Windows.Forms.Label();
            this.label_rg = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.label_codcli = new System.Windows.Forms.Label();
            this.label_residencial = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_cpf = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mask_cep = new System.Windows.Forms.MaskedTextBox();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.box_complemento = new System.Windows.Forms.TextBox();
            this.label_cidade = new System.Windows.Forms.Label();
            this.box_numero = new System.Windows.Forms.TextBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.label_complemento = new System.Windows.Forms.Label();
            this.combo_estado = new System.Windows.Forms.ComboBox();
            this.label_estado = new System.Windows.Forms.Label();
            this.box_bairro = new System.Windows.Forms.TextBox();
            this.box_endereço = new System.Windows.Forms.TextBox();
            this.label_cep = new System.Windows.Forms.Label();
            this.label_bairro = new System.Windows.Forms.Label();
            this.label_endereço = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_cadastro_cliente
            // 
            this.lb_cadastro_cliente.AutoSize = true;
            this.lb_cadastro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro_cliente.Location = new System.Drawing.Point(302, 13);
            this.lb_cadastro_cliente.Name = "lb_cadastro_cliente";
            this.lb_cadastro_cliente.Size = new System.Drawing.Size(166, 18);
            this.lb_cadastro_cliente.TabIndex = 0;
            this.lb_cadastro_cliente.Text = "Cadastro de Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mask_nascimento);
            this.groupBox1.Controls.Add(this.mask_rg);
            this.groupBox1.Controls.Add(this.mask_celular);
            this.groupBox1.Controls.Add(this.mask_residencial);
            this.groupBox1.Controls.Add(this.mask_cpf);
            this.groupBox1.Controls.Add(this.check_status);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label_celular);
            this.groupBox1.Controls.Add(this.radio_masculino);
            this.groupBox1.Controls.Add(this.radio_feminino);
            this.groupBox1.Controls.Add(this.label_sexo);
            this.groupBox1.Controls.Add(this.box_email);
            this.groupBox1.Controls.Add(this.label_data_cadastro);
            this.groupBox1.Controls.Add(this.box_codcli);
            this.groupBox1.Controls.Add(this.label_nascimento);
            this.groupBox1.Controls.Add(this.label_rg);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.box_nome);
            this.groupBox1.Controls.Add(this.label_codcli);
            this.groupBox1.Controls.Add(this.label_residencial);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.label_cpf);
            this.groupBox1.Controls.Add(this.label_nome);
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mask_nascimento
            // 
            this.mask_nascimento.Location = new System.Drawing.Point(573, 100);
            this.mask_nascimento.Mask = "00/00/0000";
            this.mask_nascimento.Name = "mask_nascimento";
            this.mask_nascimento.Size = new System.Drawing.Size(100, 20);
            this.mask_nascimento.TabIndex = 27;
            this.mask_nascimento.ValidatingType = typeof(System.DateTime);

            // 
            // mask_rg
            // 
            this.mask_rg.Location = new System.Drawing.Point(296, 100);
            this.mask_rg.Mask = "00,000,000-A";
            this.mask_rg.Name = "mask_rg";
            this.mask_rg.Size = new System.Drawing.Size(100, 20);
            this.mask_rg.TabIndex = 26;
            // 
            // mask_celular
            // 
            this.mask_celular.Location = new System.Drawing.Point(312, 192);
            this.mask_celular.Mask = "(99)-00000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(100, 20);
            this.mask_celular.TabIndex = 25;
            // 
            // mask_residencial
            // 
            this.mask_residencial.Location = new System.Drawing.Point(90, 191);
            this.mask_residencial.Mask = "(99)-0000-0000";
            this.mask_residencial.Name = "mask_residencial";
            this.mask_residencial.Size = new System.Drawing.Size(100, 20);
            this.mask_residencial.TabIndex = 24;
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(90, 100);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 20);
            this.mask_cpf.TabIndex = 23;
            // 
            // check_status
            // 
            this.check_status.AutoSize = true;
            this.check_status.Location = new System.Drawing.Point(586, 236);
            this.check_status.Name = "check_status";
            this.check_status.Size = new System.Drawing.Size(50, 17);
            this.check_status.TabIndex = 22;
            this.check_status.Text = "Ativo";
            this.check_status.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(520, 236);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(60, 13);
            this.label_status.TabIndex = 21;
            this.label_status.Text = "* Status :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(493, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "*Preencher pelo menos um telefone!!!";
            // 
            // label_celular
            // 
            this.label_celular.AutoSize = true;
            this.label_celular.Location = new System.Drawing.Point(250, 198);
            this.label_celular.Name = "label_celular";
            this.label_celular.Size = new System.Drawing.Size(39, 13);
            this.label_celular.TabIndex = 18;
            this.label_celular.Text = "Celular";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Location = new System.Drawing.Point(611, 151);
            this.radio_masculino.Name = "radio_masculino";
            this.radio_masculino.Size = new System.Drawing.Size(73, 17);
            this.radio_masculino.TabIndex = 16;
            this.radio_masculino.TabStop = true;
            this.radio_masculino.Text = "Masculino";
            this.radio_masculino.UseVisualStyleBackColor = true;
            // 
            // radio_feminino
            // 
            this.radio_feminino.AutoSize = true;
            this.radio_feminino.Location = new System.Drawing.Point(520, 151);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.radio_feminino.TabIndex = 15;
            this.radio_feminino.TabStop = true;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Location = new System.Drawing.Point(450, 149);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(31, 13);
            this.label_sexo.TabIndex = 14;
            this.label_sexo.Text = "Sexo";
            // 
            // box_email
            // 
            this.box_email.Location = new System.Drawing.Point(90, 143);
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(322, 20);
            this.box_email.TabIndex = 13;
            // 
            // label_data_cadastro
            // 
            this.label_data_cadastro.AutoSize = true;
            this.label_data_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_cadastro.Location = new System.Drawing.Point(293, 233);
            this.label_data_cadastro.Name = "label_data_cadastro";
            this.label_data_cadastro.Size = new System.Drawing.Size(97, 13);
            this.label_data_cadastro.TabIndex = 12;
            this.label_data_cadastro.Text = "* Data Cadastro";
            // 
            // box_codcli
            // 
            this.box_codcli.Location = new System.Drawing.Point(126, 233);
            this.box_codcli.Name = "box_codcli";
            this.box_codcli.Size = new System.Drawing.Size(100, 20);
            this.box_codcli.TabIndex = 11;
            // 
            // label_nascimento
            // 
            this.label_nascimento.AutoSize = true;
            this.label_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nascimento.Location = new System.Drawing.Point(447, 107);
            this.label_nascimento.Name = "label_nascimento";
            this.label_nascimento.Size = new System.Drawing.Size(111, 13);
            this.label_nascimento.TabIndex = 9;
            this.label_nascimento.Text = "* Data nascimento";
            // 
            // label_rg
            // 
            this.label_rg.AutoSize = true;
            this.label_rg.Location = new System.Drawing.Point(250, 107);
            this.label_rg.Name = "label_rg";
            this.label_rg.Size = new System.Drawing.Size(23, 13);
            this.label_rg.TabIndex = 7;
            this.label_rg.Text = "RG";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // box_nome
            // 
            this.box_nome.Location = new System.Drawing.Point(90, 46);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(474, 20);
            this.box_nome.TabIndex = 5;
            // 
            // label_codcli
            // 
            this.label_codcli.AutoSize = true;
            this.label_codcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codcli.Location = new System.Drawing.Point(22, 236);
            this.label_codcli.Name = "label_codcli";
            this.label_codcli.Size = new System.Drawing.Size(98, 13);
            this.label_codcli.TabIndex = 4;
            this.label_codcli.Text = "* Código Cliente";
            // 
            // label_residencial
            // 
            this.label_residencial.AutoSize = true;
            this.label_residencial.Location = new System.Drawing.Point(26, 195);
            this.label_residencial.Name = "label_residencial";
            this.label_residencial.Size = new System.Drawing.Size(49, 13);
            this.label_residencial.TabIndex = 3;
            this.label_residencial.Text = "Telefone";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(26, 151);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(46, 13);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "* Email";
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cpf.Location = new System.Drawing.Point(26, 107);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(39, 13);
            this.label_cpf.TabIndex = 1;
            this.label_cpf.Text = "* CPF";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(23, 53);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(48, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "* Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mask_cep);
            this.groupBox2.Controls.Add(this.box_cidade);
            this.groupBox2.Controls.Add(this.box_complemento);
            this.groupBox2.Controls.Add(this.label_cidade);
            this.groupBox2.Controls.Add(this.box_numero);
            this.groupBox2.Controls.Add(this.label_numero);
            this.groupBox2.Controls.Add(this.label_complemento);
            this.groupBox2.Controls.Add(this.combo_estado);
            this.groupBox2.Controls.Add(this.label_estado);
            this.groupBox2.Controls.Add(this.box_bairro);
            this.groupBox2.Controls.Add(this.box_endereço);
            this.groupBox2.Controls.Add(this.label_cep);
            this.groupBox2.Controls.Add(this.label_bairro);
            this.groupBox2.Controls.Add(this.label_endereço);
            this.groupBox2.Location = new System.Drawing.Point(12, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // mask_cep
            // 
            this.mask_cep.Location = new System.Drawing.Point(73, 138);
            this.mask_cep.Mask = "00000-000";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(75, 20);
            this.mask_cep.TabIndex = 25;
            // 
            // box_cidade
            // 
            this.box_cidade.Location = new System.Drawing.Point(426, 91);
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(265, 20);
            this.box_cidade.TabIndex = 13;
            // 
            // box_complemento
            // 
            this.box_complemento.Location = new System.Drawing.Point(426, 138);
            this.box_complemento.Name = "box_complemento";
            this.box_complemento.Size = new System.Drawing.Size(265, 20);
            this.box_complemento.TabIndex = 12;
            // 
            // label_cidade
            // 
            this.label_cidade.AutoSize = true;
            this.label_cidade.Location = new System.Drawing.Point(366, 95);
            this.label_cidade.Name = "label_cidade";
            this.label_cidade.Size = new System.Drawing.Size(46, 13);
            this.label_cidade.TabIndex = 11;
            this.label_cidade.Text = "Cidade :";
            // 
            // box_numero
            // 
            this.box_numero.Location = new System.Drawing.Point(639, 52);
            this.box_numero.Name = "box_numero";
            this.box_numero.Size = new System.Drawing.Size(52, 20);
            this.box_numero.TabIndex = 10;
            this.box_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_numero_KeyPress);
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.Location = new System.Drawing.Point(574, 55);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(59, 13);
            this.label_numero.TabIndex = 9;
            this.label_numero.Text = "* Número";
            // 
            // label_complemento
            // 
            this.label_complemento.AutoSize = true;
            this.label_complemento.Location = new System.Drawing.Point(335, 141);
            this.label_complemento.Name = "label_complemento";
            this.label_complemento.Size = new System.Drawing.Size(77, 13);
            this.label_complemento.TabIndex = 8;
            this.label_complemento.Text = "Complemento :";
            // 
            // combo_estado
            // 
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Location = new System.Drawing.Point(230, 137);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(59, 21);
            this.combo_estado.TabIndex = 7;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(186, 141);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(43, 13);
            this.label_estado.TabIndex = 6;
            this.label_estado.Text = "Estado:";
            // 
            // box_bairro
            // 
            this.box_bairro.Location = new System.Drawing.Point(73, 92);
            this.box_bairro.Name = "box_bairro";
            this.box_bairro.Size = new System.Drawing.Size(200, 20);
            this.box_bairro.TabIndex = 4;
            // 
            // box_endereço
            // 
            this.box_endereço.Location = new System.Drawing.Point(73, 52);
            this.box_endereço.Name = "box_endereço";
            this.box_endereço.Size = new System.Drawing.Size(395, 20);
            this.box_endereço.TabIndex = 3;
            // 
            // label_cep
            // 
            this.label_cep.AutoSize = true;
            this.label_cep.Location = new System.Drawing.Point(10, 141);
            this.label_cep.Name = "label_cep";
            this.label_cep.Size = new System.Drawing.Size(31, 13);
            this.label_cep.TabIndex = 2;
            this.label_cep.Text = "CEP:";
            // 
            // label_bairro
            // 
            this.label_bairro.AutoSize = true;
            this.label_bairro.Location = new System.Drawing.Point(10, 92);
            this.label_bairro.Name = "label_bairro";
            this.label_bairro.Size = new System.Drawing.Size(40, 13);
            this.label_bairro.TabIndex = 1;
            this.label_bairro.Text = "Bairro :";
            // 
            // label_endereço
            // 
            this.label_endereço.AutoSize = true;
            this.label_endereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endereço.Location = new System.Drawing.Point(2, 55);
            this.label_endereço.Name = "label_endereço";
            this.label_endereço.Size = new System.Drawing.Size(70, 13);
            this.label_endereço.TabIndex = 0;
            this.label_endereço.Text = "* Endereço";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(435, 578);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(250, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Todos os campos com * são obrigigatórios!";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cadastrar.Image")));
            this.bt_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cadastrar.Location = new System.Drawing.Point(37, 597);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(95, 42);
            this.bt_cadastrar.TabIndex = 4;
            this.bt_cadastrar.Text = "         Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_atualizar.Image")));
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(230, 597);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(93, 42);
            this.bt_atualizar.TabIndex = 5;
            this.bt_atualizar.Text = "         Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Image = ((System.Drawing.Image)(resources.GetObject("bt_excluir.Image")));
            this.bt_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excluir.Location = new System.Drawing.Point(417, 597);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(98, 42);
            this.bt_excluir.TabIndex = 6;
            this.bt_excluir.Text = "   Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            // 
            // bt_sair
            // 
            this.bt_sair.Image = ((System.Drawing.Image)(resources.GetObject("bt_sair.Image")));
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.Location = new System.Drawing.Point(608, 594);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(88, 45);
            this.bt_sair.TabIndex = 7;
            this.bt_sair.Text = "        Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 651);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_cadastro_cliente);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cadastro_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_celular;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.Label label_nascimento;
        private System.Windows.Forms.Label label_rg;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_codcli;
        private System.Windows.Forms.Label label_residencial;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_cidade;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.Label label_complemento;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Label label_cep;
        private System.Windows.Forms.Label label_bairro;
        private System.Windows.Forms.Label label_endereço;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
        public System.Windows.Forms.CheckBox check_status;
        public System.Windows.Forms.RadioButton radio_masculino;
        public System.Windows.Forms.RadioButton radio_feminino;
        public System.Windows.Forms.TextBox box_email;
        public System.Windows.Forms.Label label_data_cadastro;
        public System.Windows.Forms.TextBox box_codcli;
        public System.Windows.Forms.TextBox box_nome;
        public System.Windows.Forms.TextBox box_cidade;
        public System.Windows.Forms.TextBox box_complemento;
        public System.Windows.Forms.TextBox box_numero;
        public System.Windows.Forms.ComboBox combo_estado;
        public System.Windows.Forms.TextBox box_bairro;
        public System.Windows.Forms.TextBox box_endereço;
        public System.Windows.Forms.MaskedTextBox mask_nascimento;
        public System.Windows.Forms.MaskedTextBox mask_rg;
        public System.Windows.Forms.MaskedTextBox mask_celular;
        public System.Windows.Forms.MaskedTextBox mask_residencial;
        public System.Windows.Forms.MaskedTextBox mask_cpf;
        public System.Windows.Forms.MaskedTextBox mask_cep;
    }
}