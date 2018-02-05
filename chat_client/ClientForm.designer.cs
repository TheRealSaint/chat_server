namespace chat_client
{
    partial class ClientForm
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
            this.tb_ip_adress = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tb_chat_text = new System.Windows.Forms.TextBox();
            this.tb_your_name = new System.Windows.Forms.TextBox();
            this.lbl_server_tb = new System.Windows.Forms.Label();
            this.lbl_your_name = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.chlb_chat_partner = new System.Windows.Forms.CheckedListBox();
            this.lbl_chat_partner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ip_adress
            // 
            this.tb_ip_adress.Location = new System.Drawing.Point(133, 12);
            this.tb_ip_adress.Name = "tb_ip_adress";
            this.tb_ip_adress.Size = new System.Drawing.Size(120, 20);
            this.tb_ip_adress.TabIndex = 0;
            this.tb_ip_adress.Text = "127.0.0.1";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(2, 379);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.Location = new System.Drawing.Point(2, 120);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(358, 225);
            this.lbMessage.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(259, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tb_chat_text
            // 
            this.tb_chat_text.Location = new System.Drawing.Point(2, 353);
            this.tb_chat_text.Name = "tb_chat_text";
            this.tb_chat_text.Size = new System.Drawing.Size(358, 20);
            this.tb_chat_text.TabIndex = 5;
            this.tb_chat_text.Text = "Enter Text here";
            this.tb_chat_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_chat_text_KeyDown);
            // 
            // tb_your_name
            // 
            this.tb_your_name.Location = new System.Drawing.Point(133, 38);
            this.tb_your_name.Name = "tb_your_name";
            this.tb_your_name.Size = new System.Drawing.Size(120, 20);
            this.tb_your_name.TabIndex = 6;
            this.tb_your_name.Text = "Enter your name here";
            // 
            // lbl_server_tb
            // 
            this.lbl_server_tb.AutoSize = true;
            this.lbl_server_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_server_tb.Location = new System.Drawing.Point(13, 13);
            this.lbl_server_tb.Name = "lbl_server_tb";
            this.lbl_server_tb.Size = new System.Drawing.Size(114, 17);
            this.lbl_server_tb.TabIndex = 4;
            this.lbl_server_tb.Text = "Server IP Adress";
            // 
            // lbl_your_name
            // 
            this.lbl_your_name.AutoSize = true;
            this.lbl_your_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_your_name.Location = new System.Drawing.Point(13, 38);
            this.lbl_your_name.Name = "lbl_your_name";
            this.lbl_your_name.Size = new System.Drawing.Size(79, 17);
            this.lbl_your_name.TabIndex = 7;
            this.lbl_your_name.Text = "Your Name";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(259, 36);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(101, 23);
            this.btn_disconnect.TabIndex = 8;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            // 
            // chlb_chat_partner
            // 
            this.chlb_chat_partner.FormattingEnabled = true;
            this.chlb_chat_partner.Location = new System.Drawing.Point(133, 65);
            this.chlb_chat_partner.Name = "chlb_chat_partner";
            this.chlb_chat_partner.Size = new System.Drawing.Size(227, 49);
            this.chlb_chat_partner.Sorted = true;
            this.chlb_chat_partner.TabIndex = 9;
            // 
            // lbl_chat_partner
            // 
            this.lbl_chat_partner.AutoSize = true;
            this.lbl_chat_partner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chat_partner.Location = new System.Drawing.Point(13, 65);
            this.lbl_chat_partner.Name = "lbl_chat_partner";
            this.lbl_chat_partner.Size = new System.Drawing.Size(88, 17);
            this.lbl_chat_partner.TabIndex = 10;
            this.lbl_chat_partner.Text = "Chat Partner";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 409);
            this.Controls.Add(this.lbl_chat_partner);
            this.Controls.Add(this.chlb_chat_partner);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.lbl_your_name);
            this.Controls.Add(this.tb_your_name);
            this.Controls.Add(this.tb_chat_text);
            this.Controls.Add(this.lbl_server_tb);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_ip_adress);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ip_adress;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tb_chat_text;
        private System.Windows.Forms.TextBox tb_your_name;
        private System.Windows.Forms.Label lbl_server_tb;
        private System.Windows.Forms.Label lbl_your_name;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.CheckedListBox chlb_chat_partner;
        private System.Windows.Forms.Label lbl_chat_partner;
    }
}