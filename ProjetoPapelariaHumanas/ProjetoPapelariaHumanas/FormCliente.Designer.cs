
namespace ProjetoPapelariaHumanas
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_rg = new System.Windows.Forms.Label();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.lb_nascimento = new System.Windows.Forms.Label();
            this.lb_residencial = new System.Windows.Forms.Label();
            this.lb_celular = new System.Windows.Forms.Label();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mask_rg = new System.Windows.Forms.MaskedTextBox();
            this.mask_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.mask_residencial = new System.Windows.Forms.MaskedTextBox();
            this.lb_cadastro = new System.Windows.Forms.Label();
            this.check_ativo = new System.Windows.Forms.CheckBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.box_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_cod_cli = new System.Windows.Forms.Label();
            this.box_cod_cli = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_complemento = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.box_complemento = new System.Windows.Forms.TextBox();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.combo_estado = new System.Windows.Forms.ComboBox();
            this.box_numero = new System.Windows.Forms.TextBox();
            this.mask_cep = new System.Windows.Forms.MaskedTextBox();
            this.box_bairro = new System.Windows.Forms.TextBox();
            this.box_rua = new System.Windows.Forms.TextBox();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_cep = new System.Windows.Forms.Label();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.lb_rua = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.lb_cadastro_cliente = new System.Windows.Forms.Label();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(6, 22);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(43, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(6, 74);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(34, 13);
            this.lb_cpf.TabIndex = 1;
            this.lb_cpf.Text = "CPF:";
            // 
            // lb_rg
            // 
            this.lb_rg.AutoSize = true;
            this.lb_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rg.Location = new System.Drawing.Point(164, 74);
            this.lb_rg.Name = "lb_rg";
            this.lb_rg.Size = new System.Drawing.Size(29, 13);
            this.lb_rg.TabIndex = 2;
            this.lb_rg.Text = "RG:";
            // 
            // box_nome
            // 
            this.box_nome.Location = new System.Drawing.Point(52, 19);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(380, 20);
            this.box_nome.TabIndex = 3;
            // 
            // lb_nascimento
            // 
            this.lb_nascimento.AutoSize = true;
            this.lb_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nascimento.Location = new System.Drawing.Point(468, 22);
            this.lb_nascimento.Name = "lb_nascimento";
            this.lb_nascimento.Size = new System.Drawing.Size(104, 13);
            this.lb_nascimento.TabIndex = 7;
            this.lb_nascimento.Text = "Data Nascimento";
            // 
            // lb_residencial
            // 
            this.lb_residencial.AutoSize = true;
            this.lb_residencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_residencial.Location = new System.Drawing.Point(319, 74);
            this.lb_residencial.Name = "lb_residencial";
            this.lb_residencial.Size = new System.Drawing.Size(65, 13);
            this.lb_residencial.TabIndex = 9;
            this.lb_residencial.Text = "Telefone :";
            // 
            // lb_celular
            // 
            this.lb_celular.AutoSize = true;
            this.lb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celular.Location = new System.Drawing.Point(496, 74);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(54, 13);
            this.lb_celular.TabIndex = 10;
            this.lb_celular.Text = "Celular :";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(46, 67);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 20);
            this.mask_cpf.TabIndex = 12;
            // 
            // mask_rg
            // 
            this.mask_rg.Location = new System.Drawing.Point(196, 67);
            this.mask_rg.Mask = "00,000,000-A";
            this.mask_rg.Name = "mask_rg";
            this.mask_rg.Size = new System.Drawing.Size(100, 20);
            this.mask_rg.TabIndex = 13;
            // 
            // mask_nascimento
            // 
            this.mask_nascimento.Location = new System.Drawing.Point(578, 19);
            this.mask_nascimento.Mask = "00/00/0000";
            this.mask_nascimento.Name = "mask_nascimento";
            this.mask_nascimento.Size = new System.Drawing.Size(78, 20);
            this.mask_nascimento.TabIndex = 14;
            this.mask_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // radio_feminino
            // 
            this.radio_feminino.AutoSize = true;
            this.radio_feminino.Location = new System.Drawing.Point(390, 114);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.radio_feminino.TabIndex = 15;
            this.radio_feminino.TabStop = true;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Location = new System.Drawing.Point(477, 116);
            this.radio_masculino.Name = "radio_masculino";
            this.radio_masculino.Size = new System.Drawing.Size(73, 17);
            this.radio_masculino.TabIndex = 16;
            this.radio_masculino.TabStop = true;
            this.radio_masculino.Text = "Masculino";
            this.radio_masculino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sexo :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mask_celular);
            this.groupBox1.Controls.Add(this.mask_residencial);
            this.groupBox1.Controls.Add(this.lb_cadastro);
            this.groupBox1.Controls.Add(this.check_ativo);
            this.groupBox1.Controls.Add(this.lb_status);
            this.groupBox1.Controls.Add(this.box_email);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_cod_cli);
            this.groupBox1.Controls.Add(this.box_cod_cli);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Controls.Add(this.radio_masculino);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radio_feminino);
            this.groupBox1.Controls.Add(this.box_nome);
            this.groupBox1.Controls.Add(this.lb_nascimento);
            this.groupBox1.Controls.Add(this.mask_nascimento);
            this.groupBox1.Controls.Add(this.mask_rg);
            this.groupBox1.Controls.Add(this.lb_celular);
            this.groupBox1.Controls.Add(this.lb_cpf);
            this.groupBox1.Controls.Add(this.lb_residencial);
            this.groupBox1.Controls.Add(this.mask_cpf);
            this.groupBox1.Controls.Add(this.lb_rg);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 228);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações pessoais";
            // 
            // mask_celular
            // 
            this.mask_celular.Location = new System.Drawing.Point(556, 71);
            this.mask_celular.Mask = "(99)-00000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(100, 20);
            this.mask_celular.TabIndex = 27;
            // 
            // mask_residencial
            // 
            this.mask_residencial.Location = new System.Drawing.Point(386, 71);
            this.mask_residencial.Mask = "(99)-0000-0000";
            this.mask_residencial.Name = "mask_residencial";
            this.mask_residencial.Size = new System.Drawing.Size(100, 20);
            this.mask_residencial.TabIndex = 26;
            // 
            // lb_cadastro
            // 
            this.lb_cadastro.AutoSize = true;
            this.lb_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro.Location = new System.Drawing.Point(244, 171);
            this.lb_cadastro.Name = "lb_cadastro";
            this.lb_cadastro.Size = new System.Drawing.Size(88, 13);
            this.lb_cadastro.TabIndex = 25;
            this.lb_cadastro.Text = "Data Cadastro";
            // 
            // check_ativo
            // 
            this.check_ativo.AutoSize = true;
            this.check_ativo.Location = new System.Drawing.Point(438, 171);
            this.check_ativo.Name = "check_ativo";
            this.check_ativo.Size = new System.Drawing.Size(50, 17);
            this.check_ativo.TabIndex = 24;
            this.check_ativo.Text = "Ativo";
            this.check_ativo.UseVisualStyleBackColor = true;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(381, 171);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(51, 13);
            this.lb_status.TabIndex = 23;
            this.lb_status.Text = "Status :";
            // 
            // box_email
            // 
            this.box_email.Location = new System.Drawing.Point(52, 116);
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(244, 20);
            this.box_email.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email :";
            // 
            // lb_cod_cli
            // 
            this.lb_cod_cli.AutoSize = true;
            this.lb_cod_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod_cli.Location = new System.Drawing.Point(6, 171);
            this.lb_cod_cli.Name = "lb_cod_cli";
            this.lb_cod_cli.Size = new System.Drawing.Size(97, 13);
            this.lb_cod_cli.TabIndex = 19;
            this.lb_cod_cli.Text = "Código Cliente :";
            // 
            // box_cod_cli
            // 
            this.box_cod_cli.Location = new System.Drawing.Point(109, 168);
            this.box_cod_cli.Name = "box_cod_cli";
            this.box_cod_cli.Size = new System.Drawing.Size(100, 20);
            this.box_cod_cli.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_complemento);
            this.groupBox2.Controls.Add(this.lb_cidade);
            this.groupBox2.Controls.Add(this.box_complemento);
            this.groupBox2.Controls.Add(this.box_cidade);
            this.groupBox2.Controls.Add(this.combo_estado);
            this.groupBox2.Controls.Add(this.box_numero);
            this.groupBox2.Controls.Add(this.mask_cep);
            this.groupBox2.Controls.Add(this.box_bairro);
            this.groupBox2.Controls.Add(this.box_rua);
            this.groupBox2.Controls.Add(this.lb_estado);
            this.groupBox2.Controls.Add(this.lb_numero);
            this.groupBox2.Controls.Add(this.lb_cep);
            this.groupBox2.Controls.Add(this.lb_bairro);
            this.groupBox2.Controls.Add(this.lb_rua);
            this.groupBox2.Location = new System.Drawing.Point(13, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 223);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_complemento.Location = new System.Drawing.Point(42, 105);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(90, 13);
            this.lb_complemento.TabIndex = 15;
            this.lb_complemento.Text = "Complemento :";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade.Location = new System.Drawing.Point(49, 171);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(54, 13);
            this.lb_cidade.TabIndex = 13;
            this.lb_cidade.Text = "Cidade :";
            // 
            // box_complemento
            // 
            this.box_complemento.Location = new System.Drawing.Point(138, 102);
            this.box_complemento.Name = "box_complemento";
            this.box_complemento.Size = new System.Drawing.Size(182, 20);
            this.box_complemento.TabIndex = 12;
            // 
            // box_cidade
            // 
            this.box_cidade.Location = new System.Drawing.Point(128, 168);
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(155, 20);
            this.box_cidade.TabIndex = 11;
            // 
            // combo_estado
            // 
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Location = new System.Drawing.Point(382, 163);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(50, 21);
            this.combo_estado.TabIndex = 9;
            // 
            // box_numero
            // 
            this.box_numero.Location = new System.Drawing.Point(592, 46);
            this.box_numero.Name = "box_numero";
            this.box_numero.Size = new System.Drawing.Size(65, 20);
            this.box_numero.TabIndex = 8;
            // 
            // mask_cep
            // 
            this.mask_cep.Location = new System.Drawing.Point(517, 163);
            this.mask_cep.Mask = "00000-000";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(77, 20);
            this.mask_cep.TabIndex = 7;
            // 
            // box_bairro
            // 
            this.box_bairro.Location = new System.Drawing.Point(441, 101);
            this.box_bairro.Name = "box_bairro";
            this.box_bairro.Size = new System.Drawing.Size(215, 20);
            this.box_bairro.TabIndex = 6;
            // 
            // box_rua
            // 
            this.box_rua.Location = new System.Drawing.Point(97, 46);
            this.box_rua.Name = "box_rua";
            this.box_rua.Size = new System.Drawing.Size(391, 20);
            this.box_rua.TabIndex = 5;
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(308, 168);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(54, 13);
            this.lb_estado.TabIndex = 4;
            this.lb_estado.Text = "Estado :";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(514, 49);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(58, 13);
            this.lb_numero.TabIndex = 3;
            this.lb_numero.Text = "Número :";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Location = new System.Drawing.Point(474, 166);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(34, 13);
            this.lb_cep.TabIndex = 2;
            this.lb_cep.Text = "CEP :";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro.Location = new System.Drawing.Point(387, 101);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(48, 13);
            this.lb_bairro.TabIndex = 1;
            this.lb_bairro.Text = "Bairro :";
            // 
            // lb_rua
            // 
            this.lb_rua.AutoSize = true;
            this.lb_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rua.Location = new System.Drawing.Point(42, 46);
            this.lb_rua.Name = "lb_rua";
            this.lb_rua.Size = new System.Drawing.Size(38, 13);
            this.lb_rua.TabIndex = 0;
            this.lb_rua.Text = "Rua :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(432, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(271, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Todos os campos em negrito são obrigatórios!!";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(13, 516);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(84, 35);
            this.bt_cadastrar.TabIndex = 20;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_cadastro_cliente
            // 
            this.lb_cadastro_cliente.AutoSize = true;
            this.lb_cadastro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro_cliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_cadastro_cliente.Location = new System.Drawing.Point(237, 8);
            this.lb_cadastro_cliente.Name = "lb_cadastro_cliente";
            this.lb_cadastro_cliente.Size = new System.Drawing.Size(245, 29);
            this.lb_cadastro_cliente.TabIndex = 29;
            this.lb_cadastro_cliente.Text = "Cadastro de Cliente";
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(209, 517);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_atualizar.TabIndex = 30;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(335, 517);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 31;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(681, -3);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 28);
            this.bt_sair.TabIndex = 32;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 567);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.lb_cadastro_cliente);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "Papelaria Humanas";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_rg;
        private System.Windows.Forms.Label lb_nascimento;
        private System.Windows.Forms.Label lb_residencial;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_cod_cli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_complemento;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_cep;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.Label lb_rua;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label lb_cadastro_cliente;
        public System.Windows.Forms.TextBox box_nome;
        public System.Windows.Forms.MaskedTextBox mask_cpf;
        public System.Windows.Forms.MaskedTextBox mask_rg;
        public System.Windows.Forms.MaskedTextBox mask_nascimento;
        public System.Windows.Forms.RadioButton radio_feminino;
        public System.Windows.Forms.RadioButton radio_masculino;
        public System.Windows.Forms.MaskedTextBox mask_celular;
        public System.Windows.Forms.MaskedTextBox mask_residencial;
        public System.Windows.Forms.Label lb_cadastro;
        public System.Windows.Forms.CheckBox check_ativo;
        public System.Windows.Forms.TextBox box_email;
        public System.Windows.Forms.TextBox box_cod_cli;
        public System.Windows.Forms.TextBox box_complemento;
        public System.Windows.Forms.TextBox box_cidade;
        public System.Windows.Forms.ComboBox combo_estado;
        public System.Windows.Forms.TextBox box_numero;
        public System.Windows.Forms.MaskedTextBox mask_cep;
        public System.Windows.Forms.TextBox box_bairro;
        public System.Windows.Forms.TextBox box_rua;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
    }
}