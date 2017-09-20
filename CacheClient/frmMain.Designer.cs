namespace CacheClient
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSetCacheName = new System.Windows.Forms.Label();
            this.txtSetCacheName = new System.Windows.Forms.TextBox();
            this.txtSetCacheValue = new System.Windows.Forms.TextBox();
            this.lblGetCache = new System.Windows.Forms.Label();
            this.txtGetCacheName = new System.Windows.Forms.TextBox();
            this.lblClearCache = new System.Windows.Forms.Label();
            this.txtClearCache = new System.Windows.Forms.TextBox();
            this.btnSetCache = new System.Windows.Forms.Button();
            this.btnGetCache = new System.Windows.Forms.Button();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblSetCacheValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSetCacheName
            // 
            this.lblSetCacheName.AutoSize = true;
            this.lblSetCacheName.Location = new System.Drawing.Point(12, 15);
            this.lblSetCacheName.Name = "lblSetCacheName";
            this.lblSetCacheName.Size = new System.Drawing.Size(64, 12);
            this.lblSetCacheName.TabIndex = 0;
            this.lblSetCacheName.Text = "Cache Name";
            // 
            // txtSetCacheName
            // 
            this.txtSetCacheName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSetCacheName.Location = new System.Drawing.Point(82, 12);
            this.txtSetCacheName.Name = "txtSetCacheName";
            this.txtSetCacheName.Size = new System.Drawing.Size(302, 22);
            this.txtSetCacheName.TabIndex = 1;
            // 
            // txtSetCacheValue
            // 
            this.txtSetCacheValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSetCacheValue.Location = new System.Drawing.Point(82, 40);
            this.txtSetCacheValue.Name = "txtSetCacheValue";
            this.txtSetCacheValue.Size = new System.Drawing.Size(302, 22);
            this.txtSetCacheValue.TabIndex = 1;
            // 
            // lblGetCache
            // 
            this.lblGetCache.AutoSize = true;
            this.lblGetCache.Location = new System.Drawing.Point(12, 83);
            this.lblGetCache.Name = "lblGetCache";
            this.lblGetCache.Size = new System.Drawing.Size(64, 12);
            this.lblGetCache.TabIndex = 2;
            this.lblGetCache.Text = "Cache Name";
            // 
            // txtGetCacheName
            // 
            this.txtGetCacheName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetCacheName.Location = new System.Drawing.Point(82, 80);
            this.txtGetCacheName.Name = "txtGetCacheName";
            this.txtGetCacheName.Size = new System.Drawing.Size(302, 22);
            this.txtGetCacheName.TabIndex = 3;
            // 
            // lblClearCache
            // 
            this.lblClearCache.AutoSize = true;
            this.lblClearCache.Location = new System.Drawing.Point(12, 119);
            this.lblClearCache.Name = "lblClearCache";
            this.lblClearCache.Size = new System.Drawing.Size(64, 12);
            this.lblClearCache.TabIndex = 4;
            this.lblClearCache.Text = "Cache Name";
            // 
            // txtClearCache
            // 
            this.txtClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClearCache.Location = new System.Drawing.Point(82, 116);
            this.txtClearCache.Name = "txtClearCache";
            this.txtClearCache.Size = new System.Drawing.Size(302, 22);
            this.txtClearCache.TabIndex = 5;
            // 
            // btnSetCache
            // 
            this.btnSetCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCache.Location = new System.Drawing.Point(390, 40);
            this.btnSetCache.Name = "btnSetCache";
            this.btnSetCache.Size = new System.Drawing.Size(75, 23);
            this.btnSetCache.TabIndex = 6;
            this.btnSetCache.Text = "Set Cache";
            this.btnSetCache.UseVisualStyleBackColor = true;
            this.btnSetCache.Click += new System.EventHandler(this.btnSetCache_Click);
            // 
            // btnGetCache
            // 
            this.btnGetCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetCache.Location = new System.Drawing.Point(390, 78);
            this.btnGetCache.Name = "btnGetCache";
            this.btnGetCache.Size = new System.Drawing.Size(75, 23);
            this.btnGetCache.TabIndex = 7;
            this.btnGetCache.Text = "Get Cache";
            this.btnGetCache.UseVisualStyleBackColor = true;
            this.btnGetCache.Click += new System.EventHandler(this.btnGetCache_Click);
            // 
            // btnClearCache
            // 
            this.btnClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCache.Location = new System.Drawing.Point(390, 114);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(75, 23);
            this.btnClearCache.TabIndex = 8;
            this.btnClearCache.Text = "Clear Cache";
            this.btnClearCache.UseVisualStyleBackColor = true;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(14, 144);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(451, 119);
            this.txtResult.TabIndex = 9;
            // 
            // lblSetCacheValue
            // 
            this.lblSetCacheValue.AutoSize = true;
            this.lblSetCacheValue.Location = new System.Drawing.Point(12, 43);
            this.lblSetCacheValue.Name = "lblSetCacheValue";
            this.lblSetCacheValue.Size = new System.Drawing.Size(64, 12);
            this.lblSetCacheValue.TabIndex = 0;
            this.lblSetCacheValue.Text = "Cache Value";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 275);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClearCache);
            this.Controls.Add(this.btnGetCache);
            this.Controls.Add(this.btnSetCache);
            this.Controls.Add(this.txtClearCache);
            this.Controls.Add(this.lblClearCache);
            this.Controls.Add(this.txtGetCacheName);
            this.Controls.Add(this.lblGetCache);
            this.Controls.Add(this.txtSetCacheValue);
            this.Controls.Add(this.txtSetCacheName);
            this.Controls.Add(this.lblSetCacheValue);
            this.Controls.Add(this.lblSetCacheName);
            this.Name = "frmMain";
            this.Text = "Cache Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetCacheName;
        private System.Windows.Forms.TextBox txtSetCacheName;
        private System.Windows.Forms.TextBox txtSetCacheValue;
        private System.Windows.Forms.Label lblGetCache;
        private System.Windows.Forms.TextBox txtGetCacheName;
        private System.Windows.Forms.Label lblClearCache;
        private System.Windows.Forms.TextBox txtClearCache;
        private System.Windows.Forms.Button btnSetCache;
        private System.Windows.Forms.Button btnGetCache;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblSetCacheValue;
    }
}

