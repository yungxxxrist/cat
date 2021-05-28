namespace Catalog
{
    partial class Catalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Поршень");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Распредвал");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Коленвал");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Впускной коллектор");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Выпускной коллектор");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Радиатор");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Свеча зажигания", 0, 0);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Двигатель", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Маховик сцепления", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Первичный вал", 1, 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Нажимная муфта", 1, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Вторичный вал", 1, 1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Вал переключения передач", 1, 1);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Нажимной диск", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Ведомый диск", 1, 1);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Трансмиссия", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Сайлентблок", 2, 2);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Поворотный кулак", 2, 2);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Ступица", 2, 2);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Стойка стабилизатора", 2, 2);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Рулевая тяга", 2, 2);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Рулевая рейка", 2, 2);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Стойка амортизатора", 2, 2);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Пружина амортизатора", 2, 2);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Подвеска", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.Pages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ManualButton = new System.Windows.Forms.Button();
            this.FindDetailText = new System.Windows.Forms.Label();
            this.CarGroup = new System.Windows.Forms.GroupBox();
            this.CarModels = new System.Windows.Forms.ComboBox();
            this.CarBrands = new System.Windows.Forms.ComboBox();
            this.ChoosseCarButton = new System.Windows.Forms.Button();
            this.ModelText = new System.Windows.Forms.Label();
            this.BrandText = new System.Windows.Forms.Label();
            this.FindDetail = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.ListView();
            this.PartsChoose = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InterPartsList = new System.Windows.Forms.DataGridView();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Pages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CarGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterPartsList)).BeginInit();
            this.SuspendLayout();
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.tabPage1);
            this.Pages.Controls.Add(this.tabPage2);
            this.Pages.Location = new System.Drawing.Point(1, 1);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(627, 416);
            this.Pages.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ManualButton);
            this.tabPage1.Controls.Add(this.FindDetailText);
            this.tabPage1.Controls.Add(this.CarGroup);
            this.tabPage1.Controls.Add(this.FindDetail);
            this.tabPage1.Controls.Add(this.View);
            this.tabPage1.Controls.Add(this.PartsChoose);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Каталог";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ManualButton
            // 
            this.ManualButton.Location = new System.Drawing.Point(463, 270);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(139, 51);
            this.ManualButton.TabIndex = 17;
            this.ManualButton.Text = "Инструкция пользования";
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButtonClick);
            // 
            // FindDetailText
            // 
            this.FindDetailText.AutoSize = true;
            this.FindDetailText.Location = new System.Drawing.Point(15, 345);
            this.FindDetailText.Name = "FindDetailText";
            this.FindDetailText.Size = new System.Drawing.Size(103, 17);
            this.FindDetailText.TabIndex = 3;
            this.FindDetailText.Text = "Найти деталь:";
            // 
            // CarGroup
            // 
            this.CarGroup.Controls.Add(this.CarModels);
            this.CarGroup.Controls.Add(this.CarBrands);
            this.CarGroup.Controls.Add(this.ChoosseCarButton);
            this.CarGroup.Controls.Add(this.ModelText);
            this.CarGroup.Controls.Add(this.BrandText);
            this.CarGroup.Location = new System.Drawing.Point(7, 251);
            this.CarGroup.Name = "CarGroup";
            this.CarGroup.Size = new System.Drawing.Size(439, 79);
            this.CarGroup.TabIndex = 16;
            this.CarGroup.TabStop = false;
            this.CarGroup.Text = "Машина";
            // 
            // CarModels
            // 
            this.CarModels.Enabled = false;
            this.CarModels.FormattingEnabled = true;
            this.CarModels.Location = new System.Drawing.Point(137, 38);
            this.CarModels.Name = "CarModels";
            this.CarModels.Size = new System.Drawing.Size(121, 24);
            this.CarModels.TabIndex = 20;
            this.CarModels.SelectedIndexChanged += new System.EventHandler(this.CarModelsSelectedIndexChanged);
            // 
            // CarBrands
            // 
            this.CarBrands.FormattingEnabled = true;
            this.CarBrands.Location = new System.Drawing.Point(9, 38);
            this.CarBrands.Name = "CarBrands";
            this.CarBrands.Size = new System.Drawing.Size(121, 24);
            this.CarBrands.TabIndex = 19;
            this.CarBrands.SelectedIndexChanged += new System.EventHandler(this.CarBrandsSelectedIndexChanged);
            // 
            // ChoosseCarButton
            // 
            this.ChoosseCarButton.Enabled = false;
            this.ChoosseCarButton.Location = new System.Drawing.Point(264, 18);
            this.ChoosseCarButton.Name = "ChoosseCarButton";
            this.ChoosseCarButton.Size = new System.Drawing.Size(161, 52);
            this.ChoosseCarButton.TabIndex = 18;
            this.ChoosseCarButton.Text = "Выбрать автомобиль";
            this.ChoosseCarButton.UseVisualStyleBackColor = true;
            this.ChoosseCarButton.Click += new System.EventHandler(this.CarClick);
            // 
            // ModelText
            // 
            this.ModelText.AutoSize = true;
            this.ModelText.Location = new System.Drawing.Point(134, 18);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(58, 17);
            this.ModelText.TabIndex = 7;
            this.ModelText.Text = "Модель";
            // 
            // BrandText
            // 
            this.BrandText.AutoSize = true;
            this.BrandText.Location = new System.Drawing.Point(8, 18);
            this.BrandText.Name = "BrandText";
            this.BrandText.Size = new System.Drawing.Size(54, 17);
            this.BrandText.TabIndex = 12;
            this.BrandText.Text = "Марка ";
            // 
            // FindDetail
            // 
            this.FindDetail.Enabled = false;
            this.FindDetail.Location = new System.Drawing.Point(122, 342);
            this.FindDetail.Name = "FindDetail";
            this.FindDetail.Size = new System.Drawing.Size(124, 22);
            this.FindDetail.TabIndex = 2;
            this.FindDetail.TextChanged += new System.EventHandler(this.FindDetailTextChanged);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.Linen;
            this.View.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.View.ForeColor = System.Drawing.SystemColors.WindowText;
            this.View.HideSelection = false;
            this.View.Location = new System.Drawing.Point(318, 6);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(297, 239);
            this.View.TabIndex = 1;
            this.View.UseCompatibleStateImageBehavior = false;
            this.View.View = System.Windows.Forms.View.List;
            this.View.ItemActivate += new System.EventHandler(this.ViewItemActivate);
            // 
            // PartsChoose
            // 
            this.PartsChoose.BackColor = System.Drawing.SystemColors.Window;
            this.PartsChoose.Enabled = false;
            this.PartsChoose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartsChoose.ImageIndex = 0;
            this.PartsChoose.ImageList = this.imageList1;
            this.PartsChoose.Location = new System.Drawing.Point(7, 6);
            this.PartsChoose.Name = "PartsChoose";
            treeNode1.Name = "Узел2";
            treeNode1.Text = "Поршень";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "Распредвал";
            treeNode3.Name = "Узел52";
            treeNode3.Text = "Коленвал";
            treeNode4.Name = "Узел53";
            treeNode4.Text = "Впускной коллектор";
            treeNode5.Name = "Узел55";
            treeNode5.Text = "Выпускной коллектор";
            treeNode6.Name = "Узел56";
            treeNode6.Text = "Радиатор";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "Узел0";
            treeNode7.SelectedImageIndex = 0;
            treeNode7.Text = "Свеча зажигания";
            treeNode8.ImageKey = "104943.png";
            treeNode8.Name = "Узел0";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Двигатель";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Узел42";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Маховик сцепления";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "Узел43";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "Первичный вал";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "Узел0";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "Нажимная муфта";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "Узел1";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "Вторичный вал";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "Узел1";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "Вал переключения передач";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "Узел2";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Нажимной диск";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "Узел3";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "Ведомый диск";
            treeNode16.ImageIndex = 1;
            treeNode16.Name = "Узел37";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "Трансмиссия";
            treeNode17.ImageIndex = 2;
            treeNode17.Name = "Узел44";
            treeNode17.SelectedImageIndex = 2;
            treeNode17.Text = "Сайлентблок";
            treeNode18.ImageIndex = 2;
            treeNode18.Name = "Узел45";
            treeNode18.SelectedImageIndex = 2;
            treeNode18.Text = "Поворотный кулак";
            treeNode19.ImageIndex = 2;
            treeNode19.Name = "Узел2";
            treeNode19.SelectedImageIndex = 2;
            treeNode19.Text = "Ступица";
            treeNode20.ImageIndex = 2;
            treeNode20.Name = "Узел4";
            treeNode20.SelectedImageIndex = 2;
            treeNode20.Text = "Стойка стабилизатора";
            treeNode21.ImageIndex = 2;
            treeNode21.Name = "Узел5";
            treeNode21.SelectedImageIndex = 2;
            treeNode21.Text = "Рулевая тяга";
            treeNode22.ImageIndex = 2;
            treeNode22.Name = "Узел6";
            treeNode22.SelectedImageIndex = 2;
            treeNode22.Text = "Рулевая рейка";
            treeNode23.ImageIndex = 2;
            treeNode23.Name = "Узел7";
            treeNode23.SelectedImageIndex = 2;
            treeNode23.Text = "Стойка амортизатора";
            treeNode24.ImageIndex = 2;
            treeNode24.Name = "Узел8";
            treeNode24.SelectedImageIndex = 2;
            treeNode24.Text = "Пружина амортизатора";
            treeNode25.ImageIndex = 2;
            treeNode25.Name = "Узел38";
            treeNode25.SelectedImageIndex = 2;
            treeNode25.Text = "Подвеска";
            this.PartsChoose.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode16,
            treeNode25});
            this.PartsChoose.SelectedImageIndex = 0;
            this.PartsChoose.Size = new System.Drawing.Size(305, 239);
            this.PartsChoose.TabIndex = 0;
            this.PartsChoose.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PartsChooseNodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Двигатель.png");
            this.imageList1.Images.SetKeyName(1, "Трансмиссия.png");
            this.imageList1.Images.SetKeyName(2, "Подвеска.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InterPartsList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список взаимозаменямых запчастей в каталоге";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InterPartsList
            // 
            this.InterPartsList.AllowUserToDeleteRows = false;
            this.InterPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InterPartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unit,
            this.Node,
            this.Part,
            this.From,
            this.To});
            this.InterPartsList.Location = new System.Drawing.Point(16, 15);
            this.InterPartsList.Name = "InterPartsList";
            this.InterPartsList.RowTemplate.Height = 24;
            this.InterPartsList.Size = new System.Drawing.Size(539, 304);
            this.InterPartsList.TabIndex = 0;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Агрегат";
            this.Unit.Name = "Unit";
            // 
            // Node
            // 
            this.Node.HeaderText = "Узел";
            this.Node.Name = "Node";
            // 
            // Part
            // 
            this.Part.HeaderText = "Деталь";
            this.Part.Name = "Part";
            // 
            // From
            // 
            this.From.HeaderText = "Откуда";
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.HeaderText = "Куда";
            this.To.Name = "To";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(30, 30);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 424);
            this.Controls.Add(this.Pages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Catalog";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.CatalogLoad);
            this.Pages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CarGroup.ResumeLayout(false);
            this.CarGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InterPartsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView PartsChoose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView View;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label FindDetailText;
        private System.Windows.Forms.TextBox FindDetail;
        private System.Windows.Forms.Label ModelText;
        private System.Windows.Forms.GroupBox CarGroup;
        private System.Windows.Forms.Label BrandText;
        private System.Windows.Forms.DataGridView InterPartsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Node;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.Button ChoosseCarButton;
        private System.Windows.Forms.ComboBox CarBrands;
        private System.Windows.Forms.ComboBox CarModels;
        private System.Windows.Forms.Button ManualButton;
    }
}

