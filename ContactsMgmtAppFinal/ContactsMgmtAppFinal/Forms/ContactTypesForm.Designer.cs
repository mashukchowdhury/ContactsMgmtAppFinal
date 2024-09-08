
namespace ContactsMgmtAppFinal.Forms
{
    partial class ContactTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTypesForm));
            this.contactTypeDGV = new System.Windows.Forms.DataGridView();
            this.ContactTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTypeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContactType = new System.Windows.Forms.BindingSource(this.components);
            this.contactTypeMS = new System.Windows.Forms.MenuStrip();
            this.editContactType = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.contactTypeBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnAdd = new System.Windows.Forms.ToolStripButton();
            this.bnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContactType)).BeginInit();
            this.contactTypeMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBN)).BeginInit();
            this.contactTypeBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactTypeDGV
            // 
            this.contactTypeDGV.AutoGenerateColumns = false;
            this.contactTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactTypeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactTypeID,
            this.ContactTypeDesc});
            this.contactTypeDGV.DataSource = this.bsContactType;
            this.contactTypeDGV.Location = new System.Drawing.Point(16, 130);
            this.contactTypeDGV.Name = "contactTypeDGV";
            this.contactTypeDGV.RowHeadersWidth = 62;
            this.contactTypeDGV.RowTemplate.Height = 28;
            this.contactTypeDGV.Size = new System.Drawing.Size(658, 243);
            this.contactTypeDGV.TabIndex = 0;
            // 
            // ContactTypeID
            // 
            this.ContactTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ContactTypeID.DataPropertyName = "ContactTypeID";
            this.ContactTypeID.HeaderText = "Contact Type ID";
            this.ContactTypeID.MinimumWidth = 8;
            this.ContactTypeID.Name = "ContactTypeID";
            this.ContactTypeID.ReadOnly = true;
            this.ContactTypeID.Width = 132;
            // 
            // ContactTypeDesc
            // 
            this.ContactTypeDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ContactTypeDesc.DataPropertyName = "ContactTypeDesc";
            this.ContactTypeDesc.HeaderText = "Description";
            this.ContactTypeDesc.MinimumWidth = 8;
            this.ContactTypeDesc.Name = "ContactTypeDesc";
            this.ContactTypeDesc.Width = 125;
            // 
            // contactTypeMS
            // 
            this.contactTypeMS.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.contactTypeMS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contactTypeMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editContactType});
            this.contactTypeMS.Location = new System.Drawing.Point(0, 0);
            this.contactTypeMS.Name = "contactTypeMS";
            this.contactTypeMS.Size = new System.Drawing.Size(924, 33);
            this.contactTypeMS.TabIndex = 1;
            this.contactTypeMS.Text = "ContactTypeMS";
            // 
            // editContactType
            // 
            this.editContactType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.editContactType.Name = "editContactType";
            this.editContactType.Size = new System.Drawing.Size(58, 29);
            this.editContactType.Text = "Edit";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Contact Type to Edit";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(16, 408);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(107, 36);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // contactTypeBN
            // 
            this.contactTypeBN.AddNewItem = this.bnAdd;
            this.contactTypeBN.BindingSource = this.bsContactType;
            this.contactTypeBN.CountItem = this.bindingNavigatorCountItem;
            this.contactTypeBN.DeleteItem = this.bnDelete;
            this.contactTypeBN.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contactTypeBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bnAdd,
            this.bnDelete});
            this.contactTypeBN.Location = new System.Drawing.Point(0, 33);
            this.contactTypeBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactTypeBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactTypeBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactTypeBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactTypeBN.Name = "contactTypeBN";
            this.contactTypeBN.PositionItem = this.bindingNavigatorPositionItem;
            this.contactTypeBN.Size = new System.Drawing.Size(924, 33);
            this.contactTypeBN.TabIndex = 6;
            this.contactTypeBN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bnAdd
            // 
            this.bnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnAdd.Image")));
            this.bnAdd.Name = "bindingNavigatorAddNewItem";
            this.bnAdd.RightToLeftAutoMirrorImage = true;
            this.bnAdd.Size = new System.Drawing.Size(34, 28);
            this.bnAdd.Text = "Add new";
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnDelete
            // 
            this.bnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnDelete.Image = ((System.Drawing.Image)(resources.GetObject("bnDelete.Image")));
            this.bnDelete.Name = "bindingNavigatorDeleteItem";
            this.bnDelete.RightToLeftAutoMirrorImage = true;
            this.bnDelete.Size = new System.Drawing.Size(34, 28);
            this.bnDelete.Text = "Delete";
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // ContactTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 616);
            this.Controls.Add(this.contactTypeBN);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactTypeDGV);
            this.Controls.Add(this.contactTypeMS);
            this.MainMenuStrip = this.contactTypeMS;
            this.Name = "ContactTypesForm";
            this.Text = "ContactTypesForm";
            this.Load += new System.EventHandler(this.ContactTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContactType)).EndInit();
            this.contactTypeMS.ResumeLayout(false);
            this.contactTypeMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBN)).EndInit();
            this.contactTypeBN.ResumeLayout(false);
            this.contactTypeBN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contactTypeDGV;
        private System.Windows.Forms.MenuStrip contactTypeMS;
        private System.Windows.Forms.ToolStripMenuItem editContactType;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsContactType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTypeDesc;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.BindingNavigator contactTypeBN;
        private System.Windows.Forms.ToolStripButton bnAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bnDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}