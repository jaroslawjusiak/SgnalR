using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SingnalR.NoughtsAndCrosses.WinFormsClient
{
    public partial class NaCForm : Form
    {
        private TableLayoutPanel tlpMainPanel;
        private TableLayoutPanel tlpLoginPanel;
        private TableLayoutPanel tlpChatPanel;
        private TableLayoutPanel tlpChatButtonsPanel;

        public NaCForm()
        {
            InitializeComponent();
            SetUpForm();
        }

        private void SetUpForm()
        {
            //Login panel
            tlpLoginPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset,
                ColumnCount = 3,
                RowCount = 1,
                BackColor = SystemColors.GrayText
            };
            tlpLoginPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            tlpLoginPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tlpLoginPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));


            //Main Panel
            tlpMainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble,
                ColumnCount = 2,
                RowCount = 3,
                BackColor = SystemColors.ActiveCaption
            };
            tlpMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));
            tlpMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            tlpMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            tlpMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
            tlpMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            tlpMainPanel.Controls.Add(tlpLoginPanel, 0, 0);

            //Form
            Text = "Kółko i krzyżyk";
            Controls.Add(tlpMainPanel);
        }
    }
}
