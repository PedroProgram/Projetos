
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
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
            this.box_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_data_cadastro = new System.Windows.Forms.Label();
            this.check_ativo = new System.Windows.Forms.CheckBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_cod_cli = new System.Windows.Forms.Label();
            this.box_cod_cli = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.lb_cadastro_cliente = new System.Windows.Forms.Label();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ajuda = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_nome.Location = new System.Drawing.Point(10, 33);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(52, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "* Nome:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_cpf.Location = new System.Drawing.Point(15, 89);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(43, 13);
            this.lb_cpf.TabIndex = 1;
            this.lb_cpf.Text = "* CPF:";
            // 
            // lb_rg
            // 
            this.lb_rg.AutoSize = true;
            this.lb_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_rg.Location = new System.Drawing.Point(174, 85);
            this.lb_rg.Name = "lb_rg";
            this.lb_rg.Size = new System.Drawing.Size(38, 13);
            this.lb_rg.TabIndex = 2;
            this.lb_rg.Text = "* RG:";
            // 
            // box_nome
            // 
            this.box_nome.BackColor = System.Drawing.Color.AliceBlue;
            this.box_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome.Location = new System.Drawing.Point(66, 29);
            this.box_nome.MaxLength = 50;
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(385, 20);
            this.box_nome.TabIndex = 3;
            // 
            // lb_nascimento
            // 
            this.lb_nascimento.AutoSize = true;
            this.lb_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_nascimento.Location = new System.Drawing.Point(462, 33);
            this.lb_nascimento.Name = "lb_nascimento";
            this.lb_nascimento.Size = new System.Drawing.Size(113, 13);
            this.lb_nascimento.TabIndex = 7;
            this.lb_nascimento.Text = "* Data Nascimento";
            // 
            // lb_residencial
            // 
            this.lb_residencial.AutoSize = true;
            this.lb_residencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_residencial.Location = new System.Drawing.Point(319, 85);
            this.lb_residencial.Name = "lb_residencial";
            this.lb_residencial.Size = new System.Drawing.Size(74, 13);
            this.lb_residencial.TabIndex = 9;
            this.lb_residencial.Text = "* Telefone :";
            // 
            // lb_celular
            // 
            this.lb_celular.AutoSize = true;
            this.lb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_celular.Location = new System.Drawing.Point(496, 85);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(63, 13);
            this.lb_celular.TabIndex = 10;
            this.lb_celular.Text = "* Celular :";
            // 
            // mask_cpf
            // 
            this.mask_cpf.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(66, 81);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(105, 20);
            this.mask_cpf.TabIndex = 12;
            // 
            // mask_rg
            // 
            this.mask_rg.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_rg.Location = new System.Drawing.Point(218, 81);
            this.mask_rg.Mask = "00,000,000-A";
            this.mask_rg.Name = "mask_rg";
            this.mask_rg.Size = new System.Drawing.Size(88, 20);
            this.mask_rg.TabIndex = 13;
            // 
            // mask_nascimento
            // 
            this.mask_nascimento.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_nascimento.Location = new System.Drawing.Point(578, 29);
            this.mask_nascimento.Mask = "00/00/0000";
            this.mask_nascimento.Name = "mask_nascimento";
            this.mask_nascimento.Size = new System.Drawing.Size(83, 20);
            this.mask_nascimento.TabIndex = 14;
            this.mask_nascimento.ValidatingType = typeof(System.DateTime);
            this.mask_nascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mask_nascimento_TypeValidationCompleted);
            // 
            // radio_feminino
            // 
            this.radio_feminino.AutoSize = true;
            this.radio_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_feminino.Location = new System.Drawing.Point(426, 136);
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
            this.radio_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_masculino.Location = new System.Drawing.Point(501, 136);
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(372, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "* Sexo :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mask_celular);
            this.groupBox1.Controls.Add(this.mask_residencial);
            this.groupBox1.Controls.Add(this.box_email);
            this.groupBox1.Controls.Add(this.label9);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 184);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações pessoais";
            // 
            // mask_celular
            // 
            this.mask_celular.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_celular.Location = new System.Drawing.Point(569, 81);
            this.mask_celular.Mask = "(99)-00000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(92, 20);
            this.mask_celular.TabIndex = 27;
            // 
            // mask_residencial
            // 
            this.mask_residencial.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_residencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_residencial.Location = new System.Drawing.Point(393, 82);
            this.mask_residencial.Mask = "(99)-0000-0000";
            this.mask_residencial.Name = "mask_residencial";
            this.mask_residencial.Size = new System.Drawing.Size(96, 20);
            this.mask_residencial.TabIndex = 26;
            // 
            // box_email
            // 
            this.box_email.BackColor = System.Drawing.Color.AliceBlue;
            this.box_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_email.Location = new System.Drawing.Point(66, 134);
            this.box_email.MaxLength = 40;
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(294, 20);
            this.box_email.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(9, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "* Email :";
            // 
            // lb_data_cadastro
            // 
            this.lb_data_cadastro.AutoSize = true;
            this.lb_data_cadastro.Enabled = false;
            this.lb_data_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_cadastro.Location = new System.Drawing.Point(385, 27);
            this.lb_data_cadastro.Name = "lb_data_cadastro";
            this.lb_data_cadastro.Size = new System.Drawing.Size(75, 13);
            this.lb_data_cadastro.TabIndex = 25;
            this.lb_data_cadastro.Text = "Data Cadastro";
            // 
            // check_ativo
            // 
            this.check_ativo.AutoSize = true;
            this.check_ativo.Enabled = false;
            this.check_ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_ativo.Location = new System.Drawing.Point(611, 25);
            this.check_ativo.Name = "check_ativo";
            this.check_ativo.Size = new System.Drawing.Size(50, 17);
            this.check_ativo.TabIndex = 24;
            this.check_ativo.Text = "Ativo";
            this.check_ativo.UseVisualStyleBackColor = true;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_status.Location = new System.Drawing.Point(548, 27);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(51, 13);
            this.lb_status.TabIndex = 23;
            this.lb_status.Text = "Status :";
            // 
            // lb_cod_cli
            // 
            this.lb_cod_cli.AutoSize = true;
            this.lb_cod_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_cod_cli.Location = new System.Drawing.Point(9, 27);
            this.lb_cod_cli.Name = "lb_cod_cli";
            this.lb_cod_cli.Size = new System.Drawing.Size(97, 13);
            this.lb_cod_cli.TabIndex = 19;
            this.lb_cod_cli.Text = "Código Cliente :";
            // 
            // box_cod_cli
            // 
            this.box_cod_cli.BackColor = System.Drawing.Color.AliceBlue;
            this.box_cod_cli.Enabled = false;
            this.box_cod_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cod_cli.Location = new System.Drawing.Point(112, 23);
            this.box_cod_cli.Name = "box_cod_cli";
            this.box_cod_cli.Size = new System.Drawing.Size(105, 20);
            this.box_cod_cli.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(13, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 224);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(187, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "* Pressione TAB Para Concluir O Preenchimento Do Endereço";
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_complemento.Location = new System.Drawing.Point(9, 136);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(90, 13);
            this.lb_complemento.TabIndex = 15;
            this.lb_complemento.Text = "Complemento :";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_cidade.Location = new System.Drawing.Point(5, 188);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(63, 13);
            this.lb_cidade.TabIndex = 13;
            this.lb_cidade.Text = "* Cidade :";
            // 
            // box_complemento
            // 
            this.box_complemento.BackColor = System.Drawing.Color.AliceBlue;
            this.box_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_complemento.Location = new System.Drawing.Point(110, 132);
            this.box_complemento.MaxLength = 30;
            this.box_complemento.Name = "box_complemento";
            this.box_complemento.Size = new System.Drawing.Size(236, 20);
            this.box_complemento.TabIndex = 12;
            // 
            // box_cidade
            // 
            this.box_cidade.BackColor = System.Drawing.Color.AliceBlue;
            this.box_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cidade.Location = new System.Drawing.Point(79, 184);
            this.box_cidade.MaxLength = 30;
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(221, 20);
            this.box_cidade.TabIndex = 11;
            // 
            // combo_estado
            // 
            this.combo_estado.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Location = new System.Drawing.Point(390, 184);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(59, 21);
            this.combo_estado.TabIndex = 9;
            // 
            // box_numero
            // 
            this.box_numero.BackColor = System.Drawing.Color.AliceBlue;
            this.box_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_numero.Location = new System.Drawing.Point(578, 79);
            this.box_numero.MaxLength = 5;
            this.box_numero.Name = "box_numero";
            this.box_numero.Size = new System.Drawing.Size(70, 20);
            this.box_numero.TabIndex = 8;
            this.box_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_numero_KeyPress);
            // 
            // mask_cep
            // 
            this.mask_cep.BackColor = System.Drawing.Color.AliceBlue;
            this.mask_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cep.Location = new System.Drawing.Point(79, 37);
            this.mask_cep.Mask = "00000-000";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(82, 20);
            this.mask_cep.TabIndex = 7;
            this.mask_cep.Leave += new System.EventHandler(this.mask_cep_Leave);
            // 
            // box_bairro
            // 
            this.box_bairro.BackColor = System.Drawing.Color.AliceBlue;
            this.box_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_bairro.Location = new System.Drawing.Point(431, 132);
            this.box_bairro.MaxLength = 25;
            this.box_bairro.Name = "box_bairro";
            this.box_bairro.Size = new System.Drawing.Size(230, 20);
            this.box_bairro.TabIndex = 6;
            // 
            // box_rua
            // 
            this.box_rua.BackColor = System.Drawing.Color.AliceBlue;
            this.box_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_rua.Location = new System.Drawing.Point(78, 79);
            this.box_rua.MaxLength = 30;
            this.box_rua.Name = "box_rua";
            this.box_rua.Size = new System.Drawing.Size(373, 20);
            this.box_rua.TabIndex = 5;
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_estado.Location = new System.Drawing.Point(325, 188);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(63, 13);
            this.lb_estado.TabIndex = 4;
            this.lb_estado.Text = "* Estado :";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_numero.Location = new System.Drawing.Point(508, 83);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(67, 13);
            this.lb_numero.TabIndex = 3;
            this.lb_numero.Text = "* Número :";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_cep.Location = new System.Drawing.Point(12, 40);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(48, 13);
            this.lb_cep.TabIndex = 2;
            this.lb_cep.Text = "* CEP :";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_bairro.Location = new System.Drawing.Point(377, 136);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(57, 13);
            this.lb_bairro.TabIndex = 1;
            this.lb_bairro.Text = "* Bairro :";
            // 
            // lb_rua
            // 
            this.lb_rua.AutoSize = true;
            this.lb_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_rua.Location = new System.Drawing.Point(13, 83);
            this.lb_rua.Name = "lb_rua";
            this.lb_rua.Size = new System.Drawing.Size(47, 13);
            this.lb_rua.TabIndex = 0;
            this.lb_rua.Text = "* Rua :";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cadastrar.Image")));
            this.bt_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cadastrar.Location = new System.Drawing.Point(8, 545);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(126, 49);
            this.bt_cadastrar.TabIndex = 20;
            this.bt_cadastrar.Text = "  Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_cadastro_cliente
            // 
            this.lb_cadastro_cliente.AutoSize = true;
            this.lb_cadastro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro_cliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_cadastro_cliente.Location = new System.Drawing.Point(235, 16);
            this.lb_cadastro_cliente.Name = "lb_cadastro_cliente";
            this.lb_cadastro_cliente.Size = new System.Drawing.Size(245, 29);
            this.lb_cadastro_cliente.TabIndex = 29;
            this.lb_cadastro_cliente.Text = "Cadastro de Cliente";
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_atualizar.Image")));
            this.bt_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_atualizar.Location = new System.Drawing.Point(290, 545);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(126, 49);
            this.bt_atualizar.TabIndex = 30;
            this.bt_atualizar.Text = "   Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bt_excluir.Image = ((System.Drawing.Image)(resources.GetObject("bt_excluir.Image")));
            this.bt_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excluir.Location = new System.Drawing.Point(572, 545);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(126, 49);
            this.bt_excluir.TabIndex = 31;
            this.bt_excluir.Text = "  Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_sair.Location = new System.Drawing.Point(687, -4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(35, 32);
            this.bt_sair.TabIndex = 32;
            this.bt_sair.Text = "X";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_data);
            this.groupBox3.Controls.Add(this.lb_data_cadastro);
            this.groupBox3.Controls.Add(this.box_cod_cli);
            this.groupBox3.Controls.Add(this.lb_cod_cli);
            this.groupBox3.Controls.Add(this.check_ativo);
            this.groupBox3.Controls.Add(this.lb_status);
            this.groupBox3.Location = new System.Drawing.Point(13, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 59);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_data.Location = new System.Drawing.Point(280, 27);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(42, 13);
            this.lb_data.TabIndex = 26;
            this.lb_data.Text = "Data :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sistema Papelaria Humanas";
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ajuda.Location = new System.Drawing.Point(662, -1);
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(19, 19);
            this.bt_ajuda.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_ajuda.TabIndex = 35;
            this.bt_ajuda.Text = " ?";
            this.bt_ajuda.UseSelectable = true;
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(718, 612);
            this.Controls.Add(this.bt_ajuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.lb_cadastro_cliente);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelaria Humanas";
            this.Load += new System.EventHandler(this.FormCliente_Load);
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

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_rg;
        private System.Windows.Forms.Label lb_nascimento;
        private System.Windows.Forms.Label lb_residencial;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
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
        public System.Windows.Forms.Label lb_data_cadastro;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton bt_ajuda;
    }
}