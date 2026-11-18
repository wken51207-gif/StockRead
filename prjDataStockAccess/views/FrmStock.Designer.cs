namespace prjDataStockAccess.views
{
    partial class FrmStock
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sAccount = new prjDataStockAccess.views.FieldBox();
            this.sShare = new prjDataStockAccess.views.FieldBox();
            this.sBuyPrice = new prjDataStockAccess.views.FieldBox();
            this.sMarket = new prjDataStockAccess.views.FieldBox();
            this.sStockCode = new prjDataStockAccess.views.FieldBox();
            this.sBuyDate = new prjDataStockAccess.views.FieldBox();
            this.sCurrentPrice = new prjDataStockAccess.views.FieldBox();
            this.sCategory = new prjDataStockAccess.views.FieldBox();
            this.sName = new prjDataStockAccess.views.FieldBox();
            this.sId = new prjDataStockAccess.views.FieldBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "重整";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 450);
            this.listBox1.TabIndex = 24;
            // 
            // sAccount
            // 
            this.sAccount.fieldName = "交易帳號";
            this.sAccount.fieldValue = "";
            this.sAccount.Location = new System.Drawing.Point(491, 246);
            this.sAccount.Name = "sAccount";
            this.sAccount.Size = new System.Drawing.Size(174, 47);
            this.sAccount.TabIndex = 34;
            // 
            // sShare
            // 
            this.sShare.fieldName = "持股股票";
            this.sShare.fieldValue = "";
            this.sShare.Location = new System.Drawing.Point(491, 193);
            this.sShare.Name = "sShare";
            this.sShare.Size = new System.Drawing.Size(174, 47);
            this.sShare.TabIndex = 33;
            // 
            // sBuyPrice
            // 
            this.sBuyPrice.fieldName = "買進價格";
            this.sBuyPrice.fieldValue = "";
            this.sBuyPrice.Location = new System.Drawing.Point(491, 127);
            this.sBuyPrice.Name = "sBuyPrice";
            this.sBuyPrice.Size = new System.Drawing.Size(174, 47);
            this.sBuyPrice.TabIndex = 32;
            // 
            // sMarket
            // 
            this.sMarket.fieldName = "市場別";
            this.sMarket.fieldValue = "";
            this.sMarket.Location = new System.Drawing.Point(491, 65);
            this.sMarket.Name = "sMarket";
            this.sMarket.Size = new System.Drawing.Size(174, 47);
            this.sMarket.TabIndex = 31;
            // 
            // sStockCode
            // 
            this.sStockCode.fieldName = "股票代號";
            this.sStockCode.fieldValue = "";
            this.sStockCode.Location = new System.Drawing.Point(491, 12);
            this.sStockCode.Name = "sStockCode";
            this.sStockCode.Size = new System.Drawing.Size(174, 47);
            this.sStockCode.TabIndex = 30;
            // 
            // sBuyDate
            // 
            this.sBuyDate.fieldName = "買進日期(YYYY-MM-DD)";
            this.sBuyDate.fieldValue = "";
            this.sBuyDate.Location = new System.Drawing.Point(287, 246);
            this.sBuyDate.Name = "sBuyDate";
            this.sBuyDate.Size = new System.Drawing.Size(198, 47);
            this.sBuyDate.TabIndex = 29;
            // 
            // sCurrentPrice
            // 
            this.sCurrentPrice.fieldName = "目前價格";
            this.sCurrentPrice.fieldValue = "";
            this.sCurrentPrice.Location = new System.Drawing.Point(287, 193);
            this.sCurrentPrice.Name = "sCurrentPrice";
            this.sCurrentPrice.Size = new System.Drawing.Size(174, 47);
            this.sCurrentPrice.TabIndex = 28;
            // 
            // sCategory
            // 
            this.sCategory.fieldName = "產業類別";
            this.sCategory.fieldValue = "";
            this.sCategory.Location = new System.Drawing.Point(287, 127);
            this.sCategory.Name = "sCategory";
            this.sCategory.Size = new System.Drawing.Size(174, 47);
            this.sCategory.TabIndex = 27;
            // 
            // sName
            // 
            this.sName.fieldName = "股票名稱";
            this.sName.fieldValue = "";
            this.sName.Location = new System.Drawing.Point(287, 65);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(174, 47);
            this.sName.TabIndex = 26;
            // 
            // sId
            // 
            this.sId.fieldName = "編號";
            this.sId.fieldValue = "";
            this.sId.Location = new System.Drawing.Point(287, 12);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(174, 47);
            this.sId.TabIndex = 25;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sAccount);
            this.Controls.Add(this.sShare);
            this.Controls.Add(this.sBuyPrice);
            this.Controls.Add(this.sMarket);
            this.Controls.Add(this.sStockCode);
            this.Controls.Add(this.sBuyDate);
            this.Controls.Add(this.sCurrentPrice);
            this.Controls.Add(this.sCategory);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.sId);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private FieldBox sId;
        private FieldBox sName;
        private FieldBox sCategory;
        private FieldBox sCurrentPrice;
        private FieldBox sBuyDate;
        private FieldBox sAccount;
        private FieldBox sShare;
        private FieldBox sBuyPrice;
        private FieldBox sMarket;
        private FieldBox sStockCode;
    }
}