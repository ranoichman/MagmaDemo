namespace MagmaDemo
{
    partial class Login
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
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Lbl_Pass = new System.Windows.Forms.Label();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Lbl_Inst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Lang = new System.Windows.Forms.ComboBox();
            this.magmaDataSet5 = new MagmaDemo.MagmaDataSet5();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languagesTableAdapter = new MagmaDemo.MagmaDataSet5TableAdapters.LanguagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_Title.Location = new System.Drawing.Point(119, 26);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(89, 33);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Login";
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_User.Location = new System.Drawing.Point(41, 98);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(121, 23);
            this.Lbl_User.TabIndex = 1;
            this.Lbl_User.Text = "User Name:";
            // 
            // Lbl_Pass
            // 
            this.Lbl_Pass.AutoSize = true;
            this.Lbl_Pass.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_Pass.Location = new System.Drawing.Point(41, 140);
            this.Lbl_Pass.Name = "Lbl_Pass";
            this.Lbl_Pass.Size = new System.Drawing.Size(109, 23);
            this.Lbl_Pass.TabIndex = 2;
            this.Lbl_Pass.Text = "Password:";
            // 
            // Txt_User
            // 
            this.Txt_User.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_User.Location = new System.Drawing.Point(168, 95);
            this.Txt_User.MaxLength = 10;
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(118, 26);
            this.Txt_User.TabIndex = 3;
            this.Txt_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_User_KeyPress);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pass.Location = new System.Drawing.Point(168, 139);
            this.Txt_Pass.MaxLength = 10;
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.Size = new System.Drawing.Size(118, 26);
            this.Txt_Pass.TabIndex = 4;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(99, 223);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(131, 28);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Lbl_Inst
            // 
            this.Lbl_Inst.AutoSize = true;
            this.Lbl_Inst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_Inst.Location = new System.Drawing.Point(42, 79);
            this.Lbl_Inst.Name = "Lbl_Inst";
            this.Lbl_Inst.Size = new System.Drawing.Size(188, 13);
            this.Lbl_Inst.TabIndex = 6;
            this.Lbl_Inst.Text = "Please enter your credentials to log in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(41, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password:";
            // 
            // CB_Lang
            // 
            this.CB_Lang.DataSource = this.languagesBindingSource;
            this.CB_Lang.DisplayMember = "Lang_Desc";
            this.CB_Lang.FormattingEnabled = true;
            this.CB_Lang.Location = new System.Drawing.Point(168, 180);
            this.CB_Lang.Name = "CB_Lang";
            this.CB_Lang.Size = new System.Drawing.Size(118, 21);
            this.CB_Lang.TabIndex = 8;
            this.CB_Lang.ValueMember = "Lang_Code";
            // 
            // magmaDataSet5
            // 
            this.magmaDataSet5.DataSetName = "MagmaDataSet5";
            this.magmaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataMember = "Languages";
            this.languagesBindingSource.DataSource = this.magmaDataSet5;
            // 
            // languagesTableAdapter
            // 
            this.languagesTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 263);
            this.Controls.Add(this.CB_Lang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Inst);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_User);
            this.Controls.Add(this.Lbl_Pass);
            this.Controls.Add(this.Lbl_User);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Label Lbl_Pass;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label Lbl_Inst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Lang;
        private MagmaDataSet5 magmaDataSet5;
        private System.Windows.Forms.BindingSource languagesBindingSource;
        private MagmaDataSet5TableAdapters.LanguagesTableAdapter languagesTableAdapter;
    }
}