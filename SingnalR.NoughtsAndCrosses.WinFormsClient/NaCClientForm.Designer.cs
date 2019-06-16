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
            this.btnConnect = new System.Windows.Forms.Button();
            this.tcTables = new System.Windows.Forms.TabControl();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnConnect.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.Location = new System.Drawing.Point(3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 38);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // tcTables
            // 
            this.tcTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTables.Enabled = false;
            this.tcTables.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcTables.Location = new System.Drawing.Point(3, 75);
            this.tcTables.Name = "tcTables";
            this.tcTables.SelectedIndex = 0;
            this.tcTables.Size = new System.Drawing.Size(1062, 572);
            this.tcTables.TabIndex = 1;
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 2;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContainer.Controls.Add(this.tcTables, 0, 1);
            this.tlpContainer.Controls.Add(this.btnConnect, 0, 0);
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
            // NaCClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1335, 723);
            this.Controls.Add(this.tlpContainer);
            this.Name = "NaCClientForm";
            this.Text = "Kółko i krzyżyk";
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabControl tcTables;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
    }
}