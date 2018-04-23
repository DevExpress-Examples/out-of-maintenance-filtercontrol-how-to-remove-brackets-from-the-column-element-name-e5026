namespace Q264421 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.textEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.spinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.filterControl = new DXSample.MyFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEdit,
            this.spinEdit});
            // 
            // textEdit
            // 
            this.textEdit.Name = "textEdit";
            // 
            // spinEdit
            // 
            this.spinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit.Name = "spinEdit";
            // 
            // filterControl
            // 
            this.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl.Location = new System.Drawing.Point(0, 0);
            this.filterControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterControl.Name = "filterControl";
            this.filterControl.Size = new System.Drawing.Size(477, 366);
            this.filterControl.TabIndex = 0;
            this.filterControl.Text = "myFilterControl1";
           // this.filterControl.CustomDrawFilterLabel += new DXSample.CustomDrawFilterLabelEventHandler(this.OnFilterControlCustomDrawFilterLabel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 366);
            this.Controls.Add(this.filterControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyFilterControl filterControl;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEdit;

    }
}

