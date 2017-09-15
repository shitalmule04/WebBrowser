namespace Miniproj
{
    partial class signupform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.malerbtn = new System.Windows.Forms.RadioButton();
            this.femalerbtn = new System.Windows.Forms.RadioButton();
            this.conformpasstxt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.usernameerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.conpasserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.maleerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passequalerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conpasserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maleerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passequalerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.conformpasstxt);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.usernametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.Cancel_btn);
            this.groupBox1.Controls.Add(this.submit_btn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(191, 195);
            this.maskedTextBox1.Mask = "0000/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(246, 24);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.malerbtn);
            this.groupBox2.Controls.Add(this.femalerbtn);
            this.groupBox2.Location = new System.Drawing.Point(22, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // malerbtn
            // 
            this.malerbtn.AutoSize = true;
            this.malerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malerbtn.Location = new System.Drawing.Point(66, 21);
            this.malerbtn.Name = "malerbtn";
            this.malerbtn.Size = new System.Drawing.Size(58, 22);
            this.malerbtn.TabIndex = 12;
            this.malerbtn.TabStop = true;
            this.malerbtn.Text = "Male";
            this.malerbtn.UseVisualStyleBackColor = true;
            // 
            // femalerbtn
            // 
            this.femalerbtn.AutoSize = true;
            this.femalerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalerbtn.Location = new System.Drawing.Point(267, 21);
            this.femalerbtn.Name = "femalerbtn";
            this.femalerbtn.Size = new System.Drawing.Size(75, 22);
            this.femalerbtn.TabIndex = 13;
            this.femalerbtn.TabStop = true;
            this.femalerbtn.Text = "Female";
            this.femalerbtn.UseVisualStyleBackColor = true;
            // 
            // conformpasstxt
            // 
            this.conformpasstxt.Location = new System.Drawing.Point(191, 142);
            this.conformpasstxt.Name = "conformpasstxt";
            this.conformpasstxt.PasswordChar = '*';
            this.conformpasstxt.Size = new System.Drawing.Size(246, 24);
            this.conformpasstxt.TabIndex = 9;
            this.conformpasstxt.TextChanged += new System.EventHandler(this.conformpasstxt_TextChanged);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(191, 92);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(246, 24);
            this.password_txt.TabIndex = 8;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(193, 41);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(244, 24);
            this.usernametxt.TabIndex = 7;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Date Of Birth:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conform Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter User Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(362, 337);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 29);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(191, 337);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 29);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(22, 333);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 33);
            this.submit_btn.TabIndex = 0;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // usernameerrorProvider
            // 
            this.usernameerrorProvider.ContainerControl = this;
            // 
            // passerrorProvider
            // 
            this.passerrorProvider.ContainerControl = this;
            // 
            // conpasserrorProvider
            // 
            this.conpasserrorProvider.ContainerControl = this;
            // 
            // dateerrorProvider
            // 
            this.dateerrorProvider.ContainerControl = this;
            // 
            // maleerrorProvider
            // 
            this.maleerrorProvider.ContainerControl = this;
            // 
            // passequalerrorProvider
            // 
            this.passequalerrorProvider.ContainerControl = this;
            // 
            // signupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 427);
            this.Controls.Add(this.groupBox1);
            this.Name = "signupform";
            this.Text = "SIGN UP";
            this.Load += new System.EventHandler(this.signupform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conpasserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maleerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passequalerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton malerbtn;
        private System.Windows.Forms.RadioButton femalerbtn;
        private System.Windows.Forms.TextBox conformpasstxt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.ErrorProvider usernameerrorProvider;
        private System.Windows.Forms.ErrorProvider passerrorProvider;
        private System.Windows.Forms.ErrorProvider conpasserrorProvider;
        private System.Windows.Forms.ErrorProvider dateerrorProvider;
        private System.Windows.Forms.ErrorProvider maleerrorProvider;
        private System.Windows.Forms.ErrorProvider passequalerrorProvider;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}