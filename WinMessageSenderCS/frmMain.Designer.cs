namespace WinMessageSenderCS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStripMain = new System.Windows.Forms.ToolStrip();
            this.tolBtnListCtl = new System.Windows.Forms.ToolStripSplitButton();
            this.tolMnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tolMnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tolMnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tolMnuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tolMnuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tolBtnSendMsg = new System.Windows.Forms.ToolStripButton();
            this.tolBtnPostMsgA = new System.Windows.Forms.ToolStripButton();
            this.tolBtnPostMsgW = new System.Windows.Forms.ToolStripButton();
            this.lstMessages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxClearItems = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDuplicateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripMain.SuspendLayout();
            this.tolStripMain.SuspendLayout();
            this.ctxListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripMain
            // 
            this.mnuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStripMain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMain.Name = "mnuStripMain";
            this.mnuStripMain.Size = new System.Drawing.Size(660, 24);
            this.mnuStripMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tolStripMain
            // 
            this.tolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolBtnListCtl,
            this.tolBtnSendMsg,
            this.tolBtnPostMsgA,
            this.tolBtnPostMsgW});
            this.tolStripMain.Location = new System.Drawing.Point(0, 24);
            this.tolStripMain.Name = "tolStripMain";
            this.tolStripMain.Size = new System.Drawing.Size(660, 25);
            this.tolStripMain.TabIndex = 1;
            this.tolStripMain.Text = "toolStrip1";
            // 
            // tolBtnListCtl
            // 
            this.tolBtnListCtl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolBtnListCtl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolMnuAdd,
            this.tolMnuClear,
            this.tolMnuRemove,
            this.toolStripSeparator1,
            this.tolMnuMoveUp,
            this.tolMnuMoveDown});
            this.tolBtnListCtl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tolBtnListCtl.Image = ((System.Drawing.Image)(resources.GetObject("tolBtnListCtl.Image")));
            this.tolBtnListCtl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolBtnListCtl.Name = "tolBtnListCtl";
            this.tolBtnListCtl.Size = new System.Drawing.Size(86, 22);
            this.tolBtnListCtl.Text = "list_controls";
            this.tolBtnListCtl.ToolTipText = "List controls";
            this.tolBtnListCtl.ButtonClick += new System.EventHandler(this.TolBtnListCtl_ButtonClick);
            this.tolBtnListCtl.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TolBtnListCtl_DropDownItemClicked);
            // 
            // tolMnuAdd
            // 
            this.tolMnuAdd.Name = "tolMnuAdd";
            this.tolMnuAdd.Size = new System.Drawing.Size(218, 22);
            this.tolMnuAdd.Text = "Add Item";
            // 
            // tolMnuClear
            // 
            this.tolMnuClear.Name = "tolMnuClear";
            this.tolMnuClear.Size = new System.Drawing.Size(218, 22);
            this.tolMnuClear.Text = "Clear list";
            // 
            // tolMnuRemove
            // 
            this.tolMnuRemove.Name = "tolMnuRemove";
            this.tolMnuRemove.Size = new System.Drawing.Size(218, 22);
            this.tolMnuRemove.Text = "Remove item (selected)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // tolMnuMoveUp
            // 
            this.tolMnuMoveUp.Name = "tolMnuMoveUp";
            this.tolMnuMoveUp.Size = new System.Drawing.Size(218, 22);
            this.tolMnuMoveUp.Text = "Move item up (selected)";
            // 
            // tolMnuMoveDown
            // 
            this.tolMnuMoveDown.Name = "tolMnuMoveDown";
            this.tolMnuMoveDown.Size = new System.Drawing.Size(218, 22);
            this.tolMnuMoveDown.Text = "Move item down (selected)";
            // 
            // tolBtnSendMsg
            // 
            this.tolBtnSendMsg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tolBtnSendMsg.Image = ((System.Drawing.Image)(resources.GetObject("tolBtnSendMsg.Image")));
            this.tolBtnSendMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolBtnSendMsg.Name = "tolBtnSendMsg";
            this.tolBtnSendMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tolBtnSendMsg.Size = new System.Drawing.Size(115, 22);
            this.tolBtnSendMsg.Text = "Send Message(s)";
            this.tolBtnSendMsg.Click += new System.EventHandler(this.TolBtnSendMsg_Click);
            // 
            // tolBtnPostMsgA
            // 
            this.tolBtnPostMsgA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tolBtnPostMsgA.Image = ((System.Drawing.Image)(resources.GetObject("tolBtnPostMsgA.Image")));
            this.tolBtnPostMsgA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolBtnPostMsgA.Name = "tolBtnPostMsgA";
            this.tolBtnPostMsgA.Size = new System.Drawing.Size(117, 22);
            this.tolBtnPostMsgA.Text = "PostMessageA(s)";
            this.tolBtnPostMsgA.Click += new System.EventHandler(this.TolBtnPostMsgA_Click);
            // 
            // tolBtnPostMsgW
            // 
            this.tolBtnPostMsgW.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tolBtnPostMsgW.Image = ((System.Drawing.Image)(resources.GetObject("tolBtnPostMsgW.Image")));
            this.tolBtnPostMsgW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolBtnPostMsgW.Name = "tolBtnPostMsgW";
            this.tolBtnPostMsgW.Size = new System.Drawing.Size(120, 22);
            this.tolBtnPostMsgW.Text = "PostMessageW(s)";
            this.tolBtnPostMsgW.Click += new System.EventHandler(this.TolBtnPostMsgW_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.CheckBoxes = true;
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstMessages.ContextMenuStrip = this.ctxListMenu;
            this.lstMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.GridLines = true;
            this.lstMessages.HideSelection = false;
            this.lstMessages.Location = new System.Drawing.Point(0, 49);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(660, 334);
            this.lstMessages.TabIndex = 2;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            this.lstMessages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstMessages_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "hWnd";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Msg";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "wParam";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "lParam";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Result";
            // 
            // ctxListMenu
            // 
            this.ctxListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxAddItem,
            this.ctxRemoveItem,
            this.ctxClearItems,
            this.ctxDuplicateItem,
            this.ctxMoveUp,
            this.ctxMoveDown});
            this.ctxListMenu.Name = "ctxListMenu";
            this.ctxListMenu.Size = new System.Drawing.Size(181, 158);
            this.ctxListMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CtxListMenu_ItemClicked);
            // 
            // ctxAddItem
            // 
            this.ctxAddItem.Name = "ctxAddItem";
            this.ctxAddItem.Size = new System.Drawing.Size(180, 22);
            this.ctxAddItem.Text = "Add item";
            // 
            // ctxRemoveItem
            // 
            this.ctxRemoveItem.Name = "ctxRemoveItem";
            this.ctxRemoveItem.Size = new System.Drawing.Size(180, 22);
            this.ctxRemoveItem.Text = "Remove item";
            // 
            // ctxClearItems
            // 
            this.ctxClearItems.Name = "ctxClearItems";
            this.ctxClearItems.Size = new System.Drawing.Size(180, 22);
            this.ctxClearItems.Text = "Clear Items";
            // 
            // ctxDuplicateItem
            // 
            this.ctxDuplicateItem.Name = "ctxDuplicateItem";
            this.ctxDuplicateItem.Size = new System.Drawing.Size(180, 22);
            this.ctxDuplicateItem.Text = "Duplicate item";
            // 
            // ctxMoveUp
            // 
            this.ctxMoveUp.Name = "ctxMoveUp";
            this.ctxMoveUp.Size = new System.Drawing.Size(180, 22);
            this.ctxMoveUp.Text = "Move up";
            // 
            // ctxMoveDown
            // 
            this.ctxMoveDown.Name = "ctxMoveDown";
            this.ctxMoveDown.Size = new System.Drawing.Size(180, 22);
            this.ctxMoveDown.Text = "Move down";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 383);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.tolStripMain);
            this.Controls.Add(this.mnuStripMain);
            this.MainMenuStrip = this.mnuStripMain;
            this.Name = "frmMain";
            this.Text = "Window Message Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuStripMain.ResumeLayout(false);
            this.mnuStripMain.PerformLayout();
            this.tolStripMain.ResumeLayout(false);
            this.tolStripMain.PerformLayout();
            this.ctxListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tolStripMain;
        private System.Windows.Forms.ToolStripSplitButton tolBtnListCtl;
        private System.Windows.Forms.ToolStripMenuItem tolMnuAdd;
        private System.Windows.Forms.ToolStripMenuItem tolMnuClear;
        private System.Windows.Forms.ToolStripMenuItem tolMnuRemove;
        private System.Windows.Forms.ToolStripMenuItem tolMnuMoveUp;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tolMnuMoveDown;
        private System.Windows.Forms.ToolStripButton tolBtnSendMsg;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripButton tolBtnPostMsgA;
        private System.Windows.Forms.ToolStripButton tolBtnPostMsgW;
        private System.Windows.Forms.ContextMenuStrip ctxListMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxAddItem;
        private System.Windows.Forms.ToolStripMenuItem ctxRemoveItem;
        private System.Windows.Forms.ToolStripMenuItem ctxClearItems;
        private System.Windows.Forms.ToolStripMenuItem ctxDuplicateItem;
        private System.Windows.Forms.ToolStripMenuItem ctxMoveUp;
        private System.Windows.Forms.ToolStripMenuItem ctxMoveDown;
    }
}

