namespace 工具栏
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnAccept = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txttoolKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnSubmet = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnAccept,
            this.toolBtnEdit,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txttoolKeyword,
            this.toolBtnSubmet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnAdd.Image")));
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(52, 22);
            this.toolBtnAdd.Text = "新增";
            // 
            // toolBtnAccept
            // 
            this.toolBtnAccept.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnAccept.Image")));
            this.toolBtnAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAccept.Name = "toolBtnAccept";
            this.toolBtnAccept.Size = new System.Drawing.Size(52, 22);
            this.toolBtnAccept.Text = "接受";
            // 
            // toolBtnEdit
            // 
            this.toolBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnEdit.Image")));
            this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new System.Drawing.Size(52, 22);
            this.toolBtnEdit.Text = "编辑";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon-01.png");
            this.imageList1.Images.SetKeyName(1, "icon-02.png");
            this.imageList1.Images.SetKeyName(2, "icon-03.png");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "输入关键字";
            // 
            // txttoolKeyword
            // 
            this.txttoolKeyword.Name = "txttoolKeyword";
            this.txttoolKeyword.Size = new System.Drawing.Size(100, 25);
            // 
            // toolBtnSubmet
            // 
            this.toolBtnSubmet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSubmet.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSubmet.Image")));
            this.toolBtnSubmet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSubmet.Name = "toolBtnSubmet";
            this.toolBtnSubmet.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSubmet.Text = "提交";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnAdd;
        private System.Windows.Forms.ToolStripButton toolBtnAccept;
        private System.Windows.Forms.ToolStripButton toolBtnEdit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txttoolKeyword;
        private System.Windows.Forms.ToolStripButton toolBtnSubmet;
    }
}

