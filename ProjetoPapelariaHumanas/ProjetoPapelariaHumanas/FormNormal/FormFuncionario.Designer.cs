namespace ProjetoPapelariaHumanas
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.lb_codigo_fun = new System.Windows.Forms.Label();
            this.lb_nome_funcionario = new System.Windows.Forms.Label();
            this.lb_nascimento_funcionario = new System.Windows.Forms.Label();
            this.lb_CPF = new System.Windows.Forms.Label();
            this.lb_RG = new System.Windows.Forms.Label();
            this.lb_celular = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_tipo = new System.Windows.Forms.Label();
            this.lb_rua = new System.Windows.Forms.Label();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_cep = new System.Windows.Forms.Label();
            this.lb_complemento = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_data_cadastro = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.box_nome_funcionario = new System.Windows.Forms.TextBox();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.mask_RG = new System.Windows.Forms.MaskedTextBox();
            this.mask_CPF = new System.Windows.Forms.MaskedTextBox();
            this.box_email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_cargo = new System.Windows.Forms.ComboBox();
            this.mask_nascimento_fun = new System.Windows.Forms.MaskedTextBox();
            this.combo_acesso = new System.Windows.Forms.ComboBox();
            this.box_senha = new System.Windows.Forms.TextBox();
            this.box_login = new System.Windows.Forms.TextBox();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.box_codigo_fun = new System.Windows.Forms.TextBox();
            this.check_ativo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.combo_estado = new System.Windows.Forms.ComboBox();
            this.mask_cep = new System.Windows.Forms.MaskedTextBox();
            this.box_complemento = new System.Windows.Forms.TextBox();
            this.box_bairro = new System.Windows.Forms.TextBox();
            this.box_rua = new System.Windows.Forms.TextBox();
            this.box_numero = new System.Windows.Forms.TextBox();
            this.label_funcionario = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_codigo_fun
            // 
            this.lb_codigo_fun.AutoSize = true;
            this.lb_codigo_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo_fun.Location = new System.Drawing.Point(15, 22);
            this.lb_codigo_fun.Name = "lb_codigo_fun";
            this.lb_codigo_fun.Size = new System.Drawing.Size(124, 13);
            this.lb_codigo_fun.TabIndex = 0;
            this.lb_codigo_fun.Text = "Código Funcionário :";
            // 
            // lb_nome_funcionario
            // 
            this.lb_nome_funcionario.AutoSize = true;
            this.lb_nome_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_funcionario.Location = new System.Drawing.Point(6, 25);
            this.lb_nome_funcionario.Name = "lb_nome_funcionario";
            this.lb_nome_funcionario.Size = new System.Drawing.Size(56, 13);
            this.lb_nome_funcionario.TabIndex = 1;
            this.lb_nome_funcionario.Text = "* Nome :";
            // 
            // lb_nascimento_funcionario
            // 
            this.lb_nascimento_funcionario.AutoSize = true;
            this.lb_nascimento_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nascimento_funcionario.Location = new System.Drawing.Point(358, 25);
            this.lb_nascimento_funcionario.Name = "lb_nascimento_funcionario";
            this.lb_nascimento_funcionario.Size = new System.Drawing.Size(121, 13);
            this.lb_nascimento_funcionario.TabIndex = 2;
            this.lb_nascimento_funcionario.Text = "* Data Nascimento :";
            // 
            // lb_CPF
            // 
            this.lb_CPF.AutoSize = true;
            this.lb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CPF.Location = new System.Drawing.Point(11, 76);
            this.lb_CPF.Name = "lb_CPF";
            this.lb_CPF.Size = new System.Drawing.Size(47, 13);
            this.lb_CPF.TabIndex = 3;
            this.lb_CPF.Text = "* CPF :";
            // 
            // lb_RG
            // 
            this.lb_RG.AutoSize = true;
            this.lb_RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RG.Location = new System.Drawing.Point(176, 76);
            this.lb_RG.Name = "lb_RG";
            this.lb_RG.Size = new System.Drawing.Size(42, 13);
            this.lb_RG.TabIndex = 4;
            this.lb_RG.Text = "* RG :";
            // 
            // lb_celular
            // 
            this.lb_celular.AutoSize = true;
            this.lb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celular.Location = new System.Drawing.Point(358, 76);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(117, 13);
            this.lb_celular.TabIndex = 5;
            this.lb_celular.Text = "* Telefone Celular :";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sexo.Location = new System.Drawing.Point(358, 128);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(52, 13);
            this.lb_sexo.TabIndex = 6;
            this.lb_sexo.Text = "* Sexo :";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(7, 124);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 13);
            this.lb_email.TabIndex = 7;
            this.lb_email.Text = "* Email :";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(6, 182);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(55, 13);
            this.lb_login.TabIndex = 8;
            this.lb_login.Text = "* Login :";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(358, 182);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(60, 13);
            this.lb_senha.TabIndex = 9;
            this.lb_senha.Text = "* Senha :";
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipo.Location = new System.Drawing.Point(11, 230);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(112, 13);
            this.lb_tipo.TabIndex = 10;
            this.lb_tipo.Text = "* Tipo de Acesso :";
            // 
            // lb_rua
            // 
            this.lb_rua.AutoSize = true;
            this.lb_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rua.Location = new System.Drawing.Point(15, 67);
            this.lb_rua.Name = "lb_rua";
            this.lb_rua.Size = new System.Drawing.Size(47, 13);
            this.lb_rua.TabIndex = 11;
            this.lb_rua.Text = "* Rua :";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro.Location = new System.Drawing.Point(389, 112);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(57, 13);
            this.lb_bairro.TabIndex = 12;
            this.lb_bairro.Text = "* Bairro :";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade.Location = new System.Drawing.Point(185, 155);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(63, 13);
            this.lb_cidade.TabIndex = 13;
            this.lb_cidade.Text = "* Cidade :";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(15, 155);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(63, 13);
            this.lb_estado.TabIndex = 14;
            this.lb_estado.Text = "* Estado :";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Location = new System.Drawing.Point(15, 30);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(48, 13);
            this.lb_cep.TabIndex = 15;
            this.lb_cep.Text = "* CEP :";
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Location = new System.Drawing.Point(6, 112);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(90, 13);
            this.lb_complemento.TabIndex = 16;
            this.lb_complemento.Text = "Complemento :";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(389, 67);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(67, 13);
            this.lb_numero.TabIndex = 18;
            this.lb_numero.Text = "* Número :";
            // 
            // lb_data_cadastro
            // 
            this.lb_data_cadastro.AutoSize = true;
            this.lb_data_cadastro.Enabled = false;
            this.lb_data_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_cadastro.Location = new System.Drawing.Point(340, 22);
            this.lb_data_cadastro.Name = "lb_data_cadastro";
            this.lb_data_cadastro.Size = new System.Drawing.Size(78, 13);
            this.lb_data_cadastro.TabIndex = 19;
            this.lb_data_cadastro.Text = "Data Cadastro ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(618, 644);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 15);
            this.label21.TabIndex = 20;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(452, 22);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(51, 13);
            this.lb_status.TabIndex = 21;
            this.lb_status.Text = "Status :";
            // 
            // box_nome_funcionario
            // 
            this.box_nome_funcionario.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_funcionario.Location = new System.Drawing.Point(63, 22);
            this.box_nome_funcionario.MaxLength = 50;
            this.box_nome_funcionario.Name = "box_nome_funcionario";
            this.box_nome_funcionario.Size = new System.Drawing.Size(266, 20);
            this.box_nome_funcionario.TabIndex = 22;
            // 
            // mask_celular
            // 
            this.mask_celular.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_celular.Location = new System.Drawing.Point(481, 72);
            this.mask_celular.Mask = "(99)-00000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(84, 20);
            this.mask_celular.TabIndex = 24;
            // 
            // mask_RG
            // 
            this.mask_RG.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_RG.Location = new System.Drawing.Point(236, 73);
            this.mask_RG.Mask = "00,000,000-A";
            this.mask_RG.Name = "mask_RG";
            this.mask_RG.Size = new System.Drawing.Size(91, 20);
            this.mask_RG.TabIndex = 25;
            // 
            // mask_CPF
            // 
            this.mask_CPF.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_CPF.Location = new System.Drawing.Point(63, 72);
            this.mask_CPF.Mask = "000,000,000-00";
            this.mask_CPF.Name = "mask_CPF";
            this.mask_CPF.Size = new System.Drawing.Size(100, 20);
            this.mask_CPF.TabIndex = 26;
            // 
            // box_email
            // 
            this.box_email.BackColor = System.Drawing.Color.AliceBlue;
            this.box_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_email.Location = new System.Drawing.Point(63, 121);
            this.box_email.MaxLength = 40;
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(264, 20);
            this.box_email.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_cargo);
            this.groupBox1.Controls.Add(this.mask_nascimento_fun);
            this.groupBox1.Controls.Add(this.combo_acesso);
            this.groupBox1.Controls.Add(this.box_senha);
            this.groupBox1.Controls.Add(this.box_login);
            this.groupBox1.Controls.Add(this.radio_masculino);
            this.groupBox1.Controls.Add(this.radio_feminino);
            this.groupBox1.Controls.Add(this.box_nome_funcionario);
            this.groupBox1.Controls.Add(this.mask_celular);
            this.groupBox1.Controls.Add(this.mask_RG);
            this.groupBox1.Controls.Add(this.box_email);
            this.groupBox1.Controls.Add(this.lb_nome_funcionario);
            this.groupBox1.Controls.Add(this.mask_CPF);
            this.groupBox1.Controls.Add(this.lb_CPF);
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.lb_RG);
            this.groupBox1.Controls.Add(this.lb_tipo);
            this.groupBox1.Controls.Add(this.lb_celular);
            this.groupBox1.Controls.Add(this.lb_senha);
            this.groupBox1.Controls.Add(this.lb_nascimento_funcionario);
            this.groupBox1.Controls.Add(this.lb_login);
            this.groupBox1.Controls.Add(this.lb_sexo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 264);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "* Cargo :";
            // 
            // combo_cargo
            // 
            this.combo_cargo.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_cargo.FormattingEnabled = true;
            this.combo_cargo.Location = new System.Drawing.Point(358, 227);
            this.combo_cargo.Name = "combo_cargo";
            this.combo_cargo.Size = new System.Drawing.Size(121, 21);
            this.combo_cargo.TabIndex = 35;
            // 
            // mask_nascimento_fun
            // 
            this.mask_nascimento_fun.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_nascimento_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_nascimento_fun.Location = new System.Drawing.Point(481, 22);
            this.mask_nascimento_fun.Mask = "00/00/0000";
            this.mask_nascimento_fun.Name = "mask_nascimento_fun";
            this.mask_nascimento_fun.Size = new System.Drawing.Size(84, 20);
            this.mask_nascimento_fun.TabIndex = 34;
            this.mask_nascimento_fun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mask_nascimento_fun.ValidatingType = typeof(System.DateTime);
            this.mask_nascimento_fun.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mask_nascimento_fun_TypeValidationCompleted);
            // 
            // combo_acesso
            // 
            this.combo_acesso.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_acesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_acesso.FormattingEnabled = true;
            this.combo_acesso.Location = new System.Drawing.Point(130, 227);
            this.combo_acesso.Name = "combo_acesso";
            this.combo_acesso.Size = new System.Drawing.Size(98, 21);
            this.combo_acesso.TabIndex = 32;
            // 
            // box_senha
            // 
            this.box_senha.BackColor = System.Drawing.Color.AliceBlue;
            this.box_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_senha.Location = new System.Drawing.Point(424, 179);
            this.box_senha.MaxLength = 20;
            this.box_senha.Name = "box_senha";
            this.box_senha.Size = new System.Drawing.Size(141, 20);
            this.box_senha.TabIndex = 31;
            // 
            // box_login
            // 
            this.box_login.BackColor = System.Drawing.Color.AliceBlue;
            this.box_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_login.Location = new System.Drawing.Point(63, 179);
            this.box_login.MaxLength = 60;
            this.box_login.Name = "box_login";
            this.box_login.Size = new System.Drawing.Size(264, 20);
            this.box_login.TabIndex = 30;
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_masculino.Location = new System.Drawing.Point(491, 127);
            this.radio_masculino.Name = "radio_masculino";
            this.radio_masculino.Size = new System.Drawing.Size(73, 17);
            this.radio_masculino.TabIndex = 29;
            this.radio_masculino.TabStop = true;
            this.radio_masculino.Text = "Masculino";
            this.radio_masculino.UseVisualStyleBackColor = true;
            // 
            // radio_feminino
            // 
            this.radio_feminino.AutoSize = true;
            this.radio_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_feminino.Location = new System.Drawing.Point(415, 127);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.radio_feminino.TabIndex = 28;
            this.radio_feminino.TabStop = true;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // box_codigo_fun
            // 
            this.box_codigo_fun.BackColor = System.Drawing.Color.AliceBlue;
            this.box_codigo_fun.Enabled = false;
            this.box_codigo_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_codigo_fun.Location = new System.Drawing.Point(141, 18);
            this.box_codigo_fun.Name = "box_codigo_fun";
            this.box_codigo_fun.Size = new System.Drawing.Size(100, 20);
            this.box_codigo_fun.TabIndex = 37;
            // 
            // check_ativo
            // 
            this.check_ativo.AutoSize = true;
            this.check_ativo.Enabled = false;
            this.check_ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_ativo.Location = new System.Drawing.Point(521, 20);
            this.check_ativo.Name = "check_ativo";
            this.check_ativo.Size = new System.Drawing.Size(50, 17);
            this.check_ativo.TabIndex = 33;
            this.check_ativo.Text = "Ativo";
            this.check_ativo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.box_cidade);
            this.groupBox2.Controls.Add(this.combo_estado);
            this.groupBox2.Controls.Add(this.mask_cep);
            this.groupBox2.Controls.Add(this.box_complemento);
            this.groupBox2.Controls.Add(this.box_bairro);
            this.groupBox2.Controls.Add(this.box_rua);
            this.groupBox2.Controls.Add(this.box_numero);
            this.groupBox2.Controls.Add(this.lb_rua);
            this.groupBox2.Controls.Add(this.lb_cidade);
            this.groupBox2.Controls.Add(this.lb_bairro);
            this.groupBox2.Controls.Add(this.lb_numero);
            this.groupBox2.Controls.Add(this.lb_estado);
            this.groupBox2.Controls.Add(this.lb_cep);
            this.groupBox2.Controls.Add(this.lb_complemento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 182);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(154, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "* Pressione TAB Para Concluir O Preenchimento Do Endereço";
            // 
            // box_cidade
            // 
            this.box_cidade.BackColor = System.Drawing.Color.AliceBlue;
            this.box_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cidade.Location = new System.Drawing.Point(254, 152);
            this.box_cidade.MaxLength = 30;
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(204, 20);
            this.box_cidade.TabIndex = 26;
            // 
            // combo_estado
            // 
            this.combo_estado.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Location = new System.Drawing.Point(90, 152);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(65, 21);
            this.combo_estado.TabIndex = 25;
            // 
            // mask_cep
            // 
            this.mask_cep.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cep.Location = new System.Drawing.Point(71, 27);
            this.mask_cep.Mask = "00000-000";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(64, 20);
            this.mask_cep.TabIndex = 24;
            this.mask_cep.Leave += new System.EventHandler(this.mask_cep_Leave);
            // 
            // box_complemento
            // 
            this.box_complemento.BackColor = System.Drawing.Color.AliceBlue;
            this.box_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_complemento.Location = new System.Drawing.Point(102, 109);
            this.box_complemento.MaxLength = 30;
            this.box_complemento.Name = "box_complemento";
            this.box_complemento.Size = new System.Drawing.Size(269, 20);
            this.box_complemento.TabIndex = 23;
            // 
            // box_bairro
            // 
            this.box_bairro.BackColor = System.Drawing.Color.AliceBlue;
            this.box_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_bairro.Location = new System.Drawing.Point(448, 109);
            this.box_bairro.MaxLength = 25;
            this.box_bairro.Name = "box_bairro";
            this.box_bairro.Size = new System.Drawing.Size(152, 20);
            this.box_bairro.TabIndex = 21;
            // 
            // box_rua
            // 
            this.box_rua.BackColor = System.Drawing.Color.AliceBlue;
            this.box_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_rua.Location = new System.Drawing.Point(71, 64);
            this.box_rua.MaxLength = 30;
            this.box_rua.Name = "box_rua";
            this.box_rua.Size = new System.Drawing.Size(300, 20);
            this.box_rua.TabIndex = 20;
            // 
            // box_numero
            // 
            this.box_numero.BackColor = System.Drawing.Color.AliceBlue;
            this.box_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_numero.Location = new System.Drawing.Point(462, 64);
            this.box_numero.MaxLength = 5;
            this.box_numero.Name = "box_numero";
            this.box_numero.Size = new System.Drawing.Size(73, 20);
            this.box_numero.TabIndex = 19;
            this.box_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_numero_KeyPress);
            // 
            // label_funcionario
            // 
            this.label_funcionario.AutoSize = true;
            this.label_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_funcionario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_funcionario.Location = new System.Drawing.Point(178, 21);
            this.label_funcionario.Name = "label_funcionario";
            this.label_funcionario.Size = new System.Drawing.Size(313, 29);
            this.label_funcionario.TabIndex = 31;
            this.label_funcionario.Text = "Cadastro de Funcionários";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cadastrar.Image")));
            this.bt_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cadastrar.Location = new System.Drawing.Point(12, 556);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(107, 53);
            this.bt_cadastrar.TabIndex = 32;
            this.bt_cadastrar.Text = "       Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_atualizar.Image")));
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(266, 556);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(107, 53);
            this.bt_atualizar.TabIndex = 33;
            this.bt_atualizar.Text = "       Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_excluir.Image = ((System.Drawing.Image)(resources.GetObject("bt_excluir.Image")));
            this.bt_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excluir.Location = new System.Drawing.Point(511, 556);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(107, 53);
            this.bt_excluir.TabIndex = 34;
            this.bt_excluir.Text = " Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.Location = new System.Drawing.Point(614, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(31, 32);
            this.bt_sair.TabIndex = 35;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(254, 22);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(38, 13);
            this.lb_data.TabIndex = 38;
            this.lb_data.Text = "Data:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_data);
            this.groupBox3.Controls.Add(this.lb_status);
            this.groupBox3.Controls.Add(this.box_codigo_fun);
            this.groupBox3.Controls.Add(this.lb_codigo_fun);
            this.groupBox3.Controls.Add(this.lb_data_cadastro);
            this.groupBox3.Controls.Add(this.check_ativo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 50);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(589, 0);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 40;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(641, 618);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label_funcionario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label21);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelaria Humanas";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigo_fun;
        private System.Windows.Forms.Label lb_nome_funcionario;
        private System.Windows.Forms.Label lb_nascimento_funcionario;
        private System.Windows.Forms.Label lb_CPF;
        private System.Windows.Forms.Label lb_RG;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_tipo;
        private System.Windows.Forms.Label lb_rua;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_cep;
        private System.Windows.Forms.Label lb_complemento;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_data_cadastro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_funcionario;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox box_nome_funcionario;
        public System.Windows.Forms.MaskedTextBox mask_celular;
        public System.Windows.Forms.MaskedTextBox mask_RG;
        public System.Windows.Forms.MaskedTextBox mask_CPF;
        public System.Windows.Forms.TextBox box_email;
        public System.Windows.Forms.CheckBox check_ativo;
        public System.Windows.Forms.ComboBox combo_acesso;
        public System.Windows.Forms.TextBox box_senha;
        public System.Windows.Forms.TextBox box_login;
        public System.Windows.Forms.RadioButton radio_masculino;
        public System.Windows.Forms.RadioButton radio_feminino;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox box_bairro;
        public System.Windows.Forms.TextBox box_rua;
        public System.Windows.Forms.TextBox box_numero;
        public System.Windows.Forms.TextBox box_complemento;
        public System.Windows.Forms.MaskedTextBox mask_cep;
        public System.Windows.Forms.TextBox box_cidade;
        public System.Windows.Forms.ComboBox combo_estado;
        public System.Windows.Forms.MaskedTextBox mask_nascimento_fun;
        public System.Windows.Forms.ComboBox combo_cargo;
        public System.Windows.Forms.TextBox box_codigo_fun;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}