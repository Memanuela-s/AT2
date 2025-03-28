namespace AT2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textTel = new TextBox();
            tel = new Label();
            textNome = new TextBox();
            nome = new Label();
            Lista = new TabPage();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            Lista.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(219, 274);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(Lista);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(289, 237);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.SteelBlue;
            tabPage1.Controls.Add(textTel);
            tabPage1.Controls.Add(tel);
            tabPage1.Controls.Add(textNome);
            tabPage1.Controls.Add(nome);
            tabPage1.ForeColor = SystemColors.ButtonHighlight;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(281, 209);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            tabPage1.Click += tabPage1_Click;
            // 
            // textTel
            // 
            textTel.Location = new Point(0, 92);
            textTel.Name = "textTel";
            textTel.Size = new Size(166, 23);
            textTel.TabIndex = 7;
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new Point(0, 74);
            tel.Name = "tel";
            tel.Size = new Size(51, 15);
            tel.TabIndex = 6;
            tel.Text = "Telefone";
            // 
            // textNome
            // 
            textNome.Location = new Point(0, 27);
            textNome.Name = "textNome";
            textNome.Size = new Size(282, 23);
            textNome.TabIndex = 5;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(0, 9);
            nome.Name = "nome";
            nome.Size = new Size(40, 15);
            nome.TabIndex = 4;
            nome.Text = "Nome";
            // 
            // Lista
            // 
            Lista.Controls.Add(listView1);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(281, 209);
            Lista.TabIndex = 1;
            Lista.Text = "Lista";
            Lista.UseVisualStyleBackColor = true;
            Lista.Click += tabPage2_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.GradientActiveCaption;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.GridLines = true;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(275, 206);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Telefone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(313, 345);
            Controls.Add(tabControl1);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Cadastro de Usuários";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Lista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalvar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Lista;
        private TextBox textTel;
        private Label tel;
        private TextBox textNome;
        private Label nome;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
