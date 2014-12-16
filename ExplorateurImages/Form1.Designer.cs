namespace ExplorateurImages
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImageNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWidth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmd5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataImg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCnx = new DevExpress.XtraEditors.SimpleButton();
            this.cbBdd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btLoad = new DevExpress.XtraEditors.SimpleButton();
            this.lbBdd = new DevExpress.XtraEditors.LabelControl();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.lbServer = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.brCnx = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(808, 470);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImageNum,
            this.colImageId,
            this.colImageCategoryId,
            this.colWidth,
            this.colHeight,
            this.colFileName,
            this.colInFile,
            this.colmd5,
            this.colDataImg,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 150;
            // 
            // colImageNum
            // 
            this.colImageNum.FieldName = "ImageNum";
            this.colImageNum.Name = "colImageNum";
            this.colImageNum.OptionsColumn.AllowEdit = false;
            this.colImageNum.OptionsColumn.ReadOnly = true;
            this.colImageNum.Visible = true;
            this.colImageNum.VisibleIndex = 0;
            // 
            // colImageId
            // 
            this.colImageId.FieldName = "ImageId";
            this.colImageId.Name = "colImageId";
            this.colImageId.OptionsColumn.AllowEdit = false;
            this.colImageId.OptionsColumn.ReadOnly = true;
            this.colImageId.Visible = true;
            this.colImageId.VisibleIndex = 1;
            // 
            // colImageCategoryId
            // 
            this.colImageCategoryId.FieldName = "ImageCategoryId";
            this.colImageCategoryId.Name = "colImageCategoryId";
            this.colImageCategoryId.OptionsColumn.AllowEdit = false;
            this.colImageCategoryId.OptionsColumn.ReadOnly = true;
            this.colImageCategoryId.Visible = true;
            this.colImageCategoryId.VisibleIndex = 2;
            // 
            // colWidth
            // 
            this.colWidth.FieldName = "Width";
            this.colWidth.Name = "colWidth";
            this.colWidth.ToolTip = "Taille de la marge en haut";
            this.colWidth.Visible = true;
            this.colWidth.VisibleIndex = 3;
            // 
            // colHeight
            // 
            this.colHeight.FieldName = "Height";
            this.colHeight.Name = "colHeight";
            this.colHeight.ToolTip = "Taille de la marge en bas";
            this.colHeight.Visible = true;
            this.colHeight.VisibleIndex = 4;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            // 
            // colInFile
            // 
            this.colInFile.FieldName = "InFile";
            this.colInFile.Name = "colInFile";
            // 
            // colmd5
            // 
            this.colmd5.FieldName = "md5";
            this.colmd5.Name = "colmd5";
            // 
            // colDataImg
            // 
            this.colDataImg.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colDataImg.FieldName = "DataImg";
            this.colDataImg.Name = "colDataImg";
            this.colDataImg.Visible = true;
            this.colDataImg.VisibleIndex = 5;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Visible = true;
            this.colDateUpdated.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCnx);
            this.panel1.Controls.Add(this.cbBdd);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btLoad);
            this.panel1.Controls.Add(this.lbBdd);
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Controls.Add(this.lbServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 47);
            this.panel1.TabIndex = 1;
            // 
            // btCnx
            // 
            this.btCnx.Location = new System.Drawing.Point(240, 8);
            this.btCnx.Name = "btCnx";
            this.btCnx.Size = new System.Drawing.Size(75, 23);
            this.btCnx.TabIndex = 7;
            this.btCnx.Text = "Connexion";
            this.btCnx.Click += new System.EventHandler(this.btCnx_Click);
            // 
            // cbBdd
            // 
            this.cbBdd.Enabled = false;
            this.cbBdd.Location = new System.Drawing.Point(420, 9);
            this.cbBdd.Name = "cbBdd";
            this.cbBdd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBdd.Properties.Sorted = true;
            this.cbBdd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbBdd.Size = new System.Drawing.Size(214, 20);
            this.cbBdd.TabIndex = 6;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(721, 8);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Enregistrer";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Enabled = false;
            this.btLoad.Location = new System.Drawing.Point(640, 8);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 4;
            this.btLoad.Text = "Charger";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // lbBdd
            // 
            this.lbBdd.Location = new System.Drawing.Point(323, 12);
            this.lbBdd.Name = "lbBdd";
            this.lbBdd.Size = new System.Drawing.Size(89, 13);
            this.lbBdd.TabIndex = 2;
            this.lbBdd.Text = "Base de données :";
            // 
            // txtServer
            // 
            this.txtServer.EditValue = "SQLSRV01";
            this.txtServer.Location = new System.Drawing.Point(63, 9);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(171, 20);
            this.txtServer.TabIndex = 1;
            // 
            // lbServer
            // 
            this.lbServer.Location = new System.Drawing.Point(12, 12);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(45, 13);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Serveur :";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(420, 9);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(214, 20);
            this.comboBoxEdit1.TabIndex = 6;
            // 
            // brCnx
            // 
            this.brCnx.Location = new System.Drawing.Point(240, 8);
            this.brCnx.Name = "brCnx";
            this.brCnx.Size = new System.Drawing.Size(75, 23);
            this.brCnx.TabIndex = 7;
            this.brCnx.Text = "Connexion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 517);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNum;
        private DevExpress.XtraGrid.Columns.GridColumn colImageId;
        private DevExpress.XtraGrid.Columns.GridColumn colImageCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colWidth;
        private DevExpress.XtraGrid.Columns.GridColumn colHeight;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colInFile;
        private DevExpress.XtraGrid.Columns.GridColumn colmd5;
        private DevExpress.XtraGrid.Columns.GridColumn colDataImg;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbBdd;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btLoad;
        private DevExpress.XtraEditors.LabelControl lbBdd;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.LabelControl lbServer;
        private DevExpress.XtraEditors.SimpleButton btCnx;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton brCnx;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}

