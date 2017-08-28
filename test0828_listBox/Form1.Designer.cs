namespace test0828_listBox
{
    partial class AddItemText
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
            this.components = new System.ComponentModel.Container();
            this.area = new System.Windows.Forms.ListBox();
            this.NewItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.itemCountValue = new System.Windows.Forms.TextBox();
            this.itemCount = new System.Windows.Forms.Label();
            this.RemoveAreaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NewItemButtonArea = new System.Windows.Forms.Button();
            this.NewItemArea = new System.Windows.Forms.TextBox();
            this.TimeShow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // area
            // 
            this.area.FormattingEnabled = true;
            this.area.ItemHeight = 21;
            this.area.Items.AddRange(new object[] {
            "信義鄉",
            "仁愛鄉",
            "埔里鎮",
            "魚池鄉",
            "水里鄉",
            "鹿谷鄉",
            "竹山鎮  ",
            "國姓鄉",
            "中寮鄉",
            "集集鎮",
            "名間鄉",
            "南投市",
            "草屯鎮 "});
            this.area.Location = new System.Drawing.Point(79, 58);
            this.area.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(217, 319);
            this.area.TabIndex = 0;
            // 
            // NewItemButton
            // 
            this.NewItemButton.Location = new System.Drawing.Point(369, 58);
            this.NewItemButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NewItemButton.Name = "NewItemButton";
            this.NewItemButton.Size = new System.Drawing.Size(217, 40);
            this.NewItemButton.TabIndex = 1;
            this.NewItemButton.Text = "增加1個員林鎮";
            this.NewItemButton.UseVisualStyleBackColor = true;
            this.NewItemButton.Click += new System.EventHandler(this.NewItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(369, 108);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(217, 40);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "刪除最後1個項目";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // itemCountValue
            // 
            this.itemCountValue.Location = new System.Drawing.Point(716, 55);
            this.itemCountValue.Name = "itemCountValue";
            this.itemCountValue.Size = new System.Drawing.Size(75, 33);
            this.itemCountValue.TabIndex = 4;
            // 
            // itemCount
            // 
            this.itemCount.AutoSize = true;
            this.itemCount.Location = new System.Drawing.Point(632, 58);
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(78, 21);
            this.itemCount.TabIndex = 5;
            this.itemCount.Text = "總共有:";
            // 
            // RemoveAreaButton
            // 
            this.RemoveAreaButton.Location = new System.Drawing.Point(369, 158);
            this.RemoveAreaButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RemoveAreaButton.Name = "RemoveAreaButton";
            this.RemoveAreaButton.Size = new System.Drawing.Size(217, 40);
            this.RemoveAreaButton.TabIndex = 6;
            this.RemoveAreaButton.Text = "刪除選取項目";
            this.RemoveAreaButton.UseVisualStyleBackColor = true;
            this.RemoveAreaButton.Click += new System.EventHandler(this.RemoveAreaButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "第1個項目後加上文字";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewItemButtonArea
            // 
            this.NewItemButtonArea.Location = new System.Drawing.Point(369, 296);
            this.NewItemButtonArea.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NewItemButtonArea.Name = "NewItemButtonArea";
            this.NewItemButtonArea.Size = new System.Drawing.Size(106, 40);
            this.NewItemButtonArea.TabIndex = 8;
            this.NewItemButtonArea.Text = "新增項目";
            this.NewItemButtonArea.UseVisualStyleBackColor = true;
            this.NewItemButtonArea.Click += new System.EventHandler(this.NewItemButtonArea_Click);
            // 
            // NewItemArea
            // 
            this.NewItemArea.Location = new System.Drawing.Point(369, 344);
            this.NewItemArea.Name = "NewItemArea";
            this.NewItemArea.Size = new System.Drawing.Size(217, 33);
            this.NewItemArea.TabIndex = 9;
            // 
            // TimeShow
            // 
            this.TimeShow.AutoSize = true;
            this.TimeShow.Location = new System.Drawing.Point(79, 13);
            this.TimeShow.Name = "TimeShow";
            this.TimeShow.Size = new System.Drawing.Size(25, 21);
            this.TimeShow.TabIndex = 10;
            this.TimeShow.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(759, 345);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 32);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "離開";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "個項目";
            // 
            // AddItemText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TimeShow);
            this.Controls.Add(this.NewItemArea);
            this.Controls.Add(this.NewItemButtonArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveAreaButton);
            this.Controls.Add(this.itemCount);
            this.Controls.Add(this.itemCountValue);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.NewItemButton);
            this.Controls.Add(this.area);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AddItemText";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox area;
        private System.Windows.Forms.Button NewItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.TextBox itemCountValue;
        private System.Windows.Forms.Label itemCount;
        private System.Windows.Forms.Button RemoveAreaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewItemButtonArea;
        private System.Windows.Forms.TextBox NewItemArea;
        private System.Windows.Forms.Label TimeShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
    }
}

