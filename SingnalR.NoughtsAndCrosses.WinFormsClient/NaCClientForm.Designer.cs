namespace SingnalR.NoughtsAndCrosses.WinFormsClient
{
    partial class NaCClientForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "16:48:27 Mietek dołączył do gry."}, -1, System.Drawing.Color.DarkOliveGreen, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "16:48:39 Zenek dołączył do gry."}, -1, System.Drawing.Color.Blue, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))));
            this.btnConnect = new System.Windows.Forms.Button();
            this.tcTables = new System.Windows.Forms.TabControl();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBoard = new System.Windows.Forms.TableLayoutPanel();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.lblMoveMark1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChatHistory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tcTables.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.tlpBoard.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.Location = new System.Drawing.Point(11, 14);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 38);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // tcTables
            // 
            this.tcTables.Controls.Add(this.tb1);
            this.tcTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTables.Enabled = false;
            this.tcTables.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcTables.Location = new System.Drawing.Point(3, 75);
            this.tcTables.Name = "tcTables";
            this.tcTables.Padding = new System.Drawing.Point(0, 0);
            this.tcTables.SelectedIndex = 0;
            this.tcTables.Size = new System.Drawing.Size(861, 572);
            this.tcTables.TabIndex = 1;
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 2;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpContainer.Controls.Add(this.tcTables, 0, 1);
            this.tlpContainer.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpContainer.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tlpContainer.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 3;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpContainer.Size = new System.Drawing.Size(1335, 723);
            this.tlpContainer.TabIndex = 3;
            // 
            // tlpBoard
            // 
            this.tlpBoard.BackColor = System.Drawing.Color.LightGray;
            this.tlpBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBoard.ColumnCount = 3;
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBoard.Controls.Add(this.lblMoveMark1, 1, 1);
            this.tlpBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBoard.Location = new System.Drawing.Point(10, 10);
            this.tlpBoard.Name = "tlpBoard";
            this.tlpBoard.RowCount = 3;
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBoard.Size = new System.Drawing.Size(831, 514);
            this.tlpBoard.TabIndex = 2;
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.Tan;
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1.Controls.Add(this.tlpBoard);
            this.tb1.Location = new System.Drawing.Point(4, 32);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(10);
            this.tb1.Size = new System.Drawing.Size(853, 536);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Stół 1";
            // 
            // lblMoveMark1
            // 
            this.lblMoveMark1.AutoSize = true;
            this.lblMoveMark1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMoveMark1.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoveMark1.Location = new System.Drawing.Point(280, 171);
            this.lblMoveMark1.Name = "lblMoveMark1";
            this.lblMoveMark1.Size = new System.Drawing.Size(269, 169);
            this.lblMoveMark1.TabIndex = 0;
            this.lblMoveMark1.Text = "X";
            this.lblMoveMark1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 66);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbUsername, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(123, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(364, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(19, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(160, 60);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nazwa użytkownika:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(185, 17);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(176, 26);
            this.tbUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.Location = new System.Drawing.Point(505, 10);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Zaloguj się";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblChatHistory, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(870, 75);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(462, 572);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lblChatHistory
            // 
            this.lblChatHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChatHistory.AutoSize = true;
            this.lblChatHistory.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChatHistory.Location = new System.Drawing.Point(161, 13);
            this.lblChatHistory.Name = "lblChatHistory";
            this.lblChatHistory.Size = new System.Drawing.Size(139, 23);
            this.lblChatHistory.TabIndex = 0;
            this.lblChatHistory.Text = "Historia rozmowy";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(158, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Napisz wiadomość:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(3, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 324);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Location = new System.Drawing.Point(3, 433);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 136);
            this.textBox1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnSendMessage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClearMessage, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(870, 653);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(462, 67);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearMessage.BackColor = System.Drawing.Color.Bisque;
            this.btnClearMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMessage.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearMessage.Location = new System.Drawing.Point(20, 14);
            this.btnClearMessage.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(98, 38);
            this.btnClearMessage.TabIndex = 1;
            this.btnClearMessage.Text = "Wyczyść";
            this.btnClearMessage.UseVisualStyleBackColor = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSendMessage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSendMessage.Location = new System.Drawing.Point(344, 14);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(98, 38);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Wyślij";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            // 
            // NaCClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1335, 723);
            this.Controls.Add(this.tlpContainer);
            this.Name = "NaCClientForm";
            this.Text = "Kółko i krzyżyk";
            this.tcTables.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.tlpBoard.ResumeLayout(false);
            this.tlpBoard.PerformLayout();
            this.tb1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabControl tcTables;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TableLayoutPanel tlpBoard;
        private System.Windows.Forms.Label lblMoveMark1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblChatHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnClearMessage;
    }
}