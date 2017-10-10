namespace Homework_WF
{
    partial class GasolineStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasolineStation));
            this.gasStation = new System.Windows.Forms.GroupBox();
            this.toPayGasStation = new System.Windows.Forms.GroupBox();
            this.tgOrLiterLabel = new System.Windows.Forms.Label();
            this.fuelToPayValue = new System.Windows.Forms.Label();
            this.tgLabel = new System.Windows.Forms.Label();
            this.liter = new System.Windows.Forms.Label();
            this.moneyValue = new System.Windows.Forms.TextBox();
            this.amountOfFuelValue = new System.Windows.Forms.TextBox();
            this.calculationOption = new System.Windows.Forms.Panel();
            this.money = new System.Windows.Forms.RadioButton();
            this.amountOfFuel = new System.Windows.Forms.RadioButton();
            this.priceValue = new System.Windows.Forms.Label();
            this.tg = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.typesOfFuel = new System.Windows.Forms.ComboBox();
            this.gazoline = new System.Windows.Forms.Label();
            this.miniCafe = new System.Windows.Forms.GroupBox();
            this.productCheckBoxPanel = new System.Windows.Forms.Panel();
            this.CocaColaCheckBox = new System.Windows.Forms.CheckBox();
            this.FrenchFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.hamburgerСheckBox = new System.Windows.Forms.CheckBox();
            this.hotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.productPricePanel = new System.Windows.Forms.Panel();
            this.cocaColaPrice = new System.Windows.Forms.Label();
            this.frenchFriesPrice = new System.Windows.Forms.Label();
            this.hamburgerPrice = new System.Windows.Forms.Label();
            this.hotDogPrice = new System.Windows.Forms.Label();
            this.productCountPanel = new System.Windows.Forms.Panel();
            this.hotDogCount = new System.Windows.Forms.TextBox();
            this.hamburgerCount = new System.Windows.Forms.TextBox();
            this.frenchFriesCount = new System.Windows.Forms.TextBox();
            this.cocaColaCount = new System.Windows.Forms.TextBox();
            this.toPayMiniCafe = new System.Windows.Forms.GroupBox();
            this.literOrTgLabel = new System.Windows.Forms.Label();
            this.miniCafeToPayValue = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.toPayTutorial = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.dollarImage = new System.Windows.Forms.PictureBox();
            this.calculate = new System.Windows.Forms.Button();
            this.tengeLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.bLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.bTrackBar = new System.Windows.Forms.TrackBar();
            this.gTrackBar = new System.Windows.Forms.TrackBar();
            this.rTrackBar = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayOfWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gasStation.SuspendLayout();
            this.toPayGasStation.SuspendLayout();
            this.calculationOption.SuspendLayout();
            this.miniCafe.SuspendLayout();
            this.productCheckBoxPanel.SuspendLayout();
            this.productPricePanel.SuspendLayout();
            this.productCountPanel.SuspendLayout();
            this.toPayMiniCafe.SuspendLayout();
            this.toPayTutorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dollarImage)).BeginInit();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gasStation
            // 
            this.gasStation.Controls.Add(this.toPayGasStation);
            this.gasStation.Controls.Add(this.tgLabel);
            this.gasStation.Controls.Add(this.liter);
            this.gasStation.Controls.Add(this.moneyValue);
            this.gasStation.Controls.Add(this.amountOfFuelValue);
            this.gasStation.Controls.Add(this.calculationOption);
            this.gasStation.Controls.Add(this.priceValue);
            this.gasStation.Controls.Add(this.tg);
            this.gasStation.Controls.Add(this.price);
            this.gasStation.Controls.Add(this.typesOfFuel);
            this.gasStation.Controls.Add(this.gazoline);
            this.gasStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasStation.Location = new System.Drawing.Point(12, 12);
            this.gasStation.Name = "gasStation";
            this.gasStation.Size = new System.Drawing.Size(287, 266);
            this.gasStation.TabIndex = 0;
            this.gasStation.TabStop = false;
            this.gasStation.Text = "Автозаправка";
            // 
            // toPayGasStation
            // 
            this.toPayGasStation.Controls.Add(this.tgOrLiterLabel);
            this.toPayGasStation.Controls.Add(this.fuelToPayValue);
            this.toPayGasStation.Location = new System.Drawing.Point(20, 170);
            this.toPayGasStation.Name = "toPayGasStation";
            this.toPayGasStation.Size = new System.Drawing.Size(261, 90);
            this.toPayGasStation.TabIndex = 11;
            this.toPayGasStation.TabStop = false;
            this.toPayGasStation.Text = "К оплате";
            // 
            // tgOrLiterLabel
            // 
            this.tgOrLiterLabel.AutoSize = true;
            this.tgOrLiterLabel.Location = new System.Drawing.Point(217, 62);
            this.tgOrLiterLabel.Name = "tgOrLiterLabel";
            this.tgOrLiterLabel.Size = new System.Drawing.Size(24, 17);
            this.tgOrLiterLabel.TabIndex = 12;
            this.tgOrLiterLabel.Text = "тг.";
            // 
            // fuelToPayValue
            // 
            this.fuelToPayValue.AutoSize = true;
            this.fuelToPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelToPayValue.Location = new System.Drawing.Point(50, 27);
            this.fuelToPayValue.Name = "fuelToPayValue";
            this.fuelToPayValue.Size = new System.Drawing.Size(42, 46);
            this.fuelToPayValue.TabIndex = 0;
            this.fuelToPayValue.Text = "0";
            // 
            // tgLabel
            // 
            this.tgLabel.AutoSize = true;
            this.tgLabel.Location = new System.Drawing.Point(241, 141);
            this.tgLabel.Name = "tgLabel";
            this.tgLabel.Size = new System.Drawing.Size(24, 17);
            this.tgLabel.TabIndex = 10;
            this.tgLabel.Text = "тг.";
            // 
            // liter
            // 
            this.liter.AutoSize = true;
            this.liter.Location = new System.Drawing.Point(241, 106);
            this.liter.Name = "liter";
            this.liter.Size = new System.Drawing.Size(20, 17);
            this.liter.TabIndex = 9;
            this.liter.Text = "л.";
            // 
            // moneyValue
            // 
            this.moneyValue.BackColor = System.Drawing.Color.Azure;
            this.moneyValue.Location = new System.Drawing.Point(148, 134);
            this.moneyValue.Name = "moneyValue";
            this.moneyValue.Size = new System.Drawing.Size(87, 23);
            this.moneyValue.TabIndex = 8;
            this.moneyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moneyValue.TextChanged += new System.EventHandler(this.MoneyValue_TextChanged);
            this.moneyValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountOfFuelValue_KeyPress);
            // 
            // amountOfFuelValue
            // 
            this.amountOfFuelValue.BackColor = System.Drawing.Color.Azure;
            this.amountOfFuelValue.Location = new System.Drawing.Point(187, 99);
            this.amountOfFuelValue.MaxLength = 2;
            this.amountOfFuelValue.Name = "amountOfFuelValue";
            this.amountOfFuelValue.ReadOnly = true;
            this.amountOfFuelValue.Size = new System.Drawing.Size(48, 23);
            this.amountOfFuelValue.TabIndex = 7;
            this.amountOfFuelValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountOfFuelValue.TextChanged += new System.EventHandler(this.AmountOfFuelValue_TextChanged);
            this.amountOfFuelValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountOfFuelValue_KeyPress);
            // 
            // calculationOption
            // 
            this.calculationOption.Controls.Add(this.money);
            this.calculationOption.Controls.Add(this.amountOfFuel);
            this.calculationOption.Location = new System.Drawing.Point(19, 88);
            this.calculationOption.Name = "calculationOption";
            this.calculationOption.Size = new System.Drawing.Size(122, 75);
            this.calculationOption.TabIndex = 6;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Checked = true;
            this.money.Location = new System.Drawing.Point(12, 46);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(68, 21);
            this.money.TabIndex = 1;
            this.money.TabStop = true;
            this.money.Text = "Сумма";
            this.money.UseVisualStyleBackColor = true;
            // 
            // amountOfFuel
            // 
            this.amountOfFuel.AutoSize = true;
            this.amountOfFuel.Location = new System.Drawing.Point(12, 14);
            this.amountOfFuel.Name = "amountOfFuel";
            this.amountOfFuel.Size = new System.Drawing.Size(104, 21);
            this.amountOfFuel.TabIndex = 0;
            this.amountOfFuel.Text = "Количество";
            this.amountOfFuel.UseVisualStyleBackColor = true;
            this.amountOfFuel.CheckedChanged += new System.EventHandler(this.AmountOfFuel_CheckedChanged);
            // 
            // priceValue
            // 
            this.priceValue.AutoSize = true;
            this.priceValue.Location = new System.Drawing.Point(211, 60);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(32, 17);
            this.priceValue.TabIndex = 5;
            this.priceValue.Text = "147";
            // 
            // tg
            // 
            this.tg.AutoSize = true;
            this.tg.Location = new System.Drawing.Point(240, 61);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(24, 17);
            this.tg.TabIndex = 4;
            this.tg.Text = "тг.";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(17, 57);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(43, 17);
            this.price.TabIndex = 2;
            this.price.Text = "Цена";
            // 
            // typesOfFuel
            // 
            this.typesOfFuel.BackColor = System.Drawing.Color.Azure;
            this.typesOfFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesOfFuel.FormattingEnabled = true;
            this.typesOfFuel.IntegralHeight = false;
            this.typesOfFuel.Location = new System.Drawing.Point(126, 26);
            this.typesOfFuel.Name = "typesOfFuel";
            this.typesOfFuel.Size = new System.Drawing.Size(155, 24);
            this.typesOfFuel.TabIndex = 1;
            this.typesOfFuel.SelectedIndexChanged += new System.EventHandler(this.TypesOfFuel_SelectedIndexChanged);
            // 
            // gazoline
            // 
            this.gazoline.AutoSize = true;
            this.gazoline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gazoline.Location = new System.Drawing.Point(17, 26);
            this.gazoline.Name = "gazoline";
            this.gazoline.Size = new System.Drawing.Size(56, 17);
            this.gazoline.TabIndex = 0;
            this.gazoline.Text = "Бензин";
            // 
            // miniCafe
            // 
            this.miniCafe.Controls.Add(this.productCheckBoxPanel);
            this.miniCafe.Controls.Add(this.productPricePanel);
            this.miniCafe.Controls.Add(this.productCountPanel);
            this.miniCafe.Controls.Add(this.toPayMiniCafe);
            this.miniCafe.Controls.Add(this.productCount);
            this.miniCafe.Controls.Add(this.productPrice);
            this.miniCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.miniCafe.Location = new System.Drawing.Point(305, 12);
            this.miniCafe.Name = "miniCafe";
            this.miniCafe.Size = new System.Drawing.Size(278, 266);
            this.miniCafe.TabIndex = 1;
            this.miniCafe.TabStop = false;
            this.miniCafe.Text = "Мини-Кафе";
            // 
            // productCheckBoxPanel
            // 
            this.productCheckBoxPanel.Controls.Add(this.CocaColaCheckBox);
            this.productCheckBoxPanel.Controls.Add(this.FrenchFriesCheckBox);
            this.productCheckBoxPanel.Controls.Add(this.hamburgerСheckBox);
            this.productCheckBoxPanel.Controls.Add(this.hotDogCheckBox);
            this.productCheckBoxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCheckBoxPanel.Location = new System.Drawing.Point(3, 44);
            this.productCheckBoxPanel.Name = "productCheckBoxPanel";
            this.productCheckBoxPanel.Size = new System.Drawing.Size(128, 117);
            this.productCheckBoxPanel.TabIndex = 20;
            // 
            // CocaColaCheckBox
            // 
            this.CocaColaCheckBox.AutoSize = true;
            this.CocaColaCheckBox.Location = new System.Drawing.Point(4, 89);
            this.CocaColaCheckBox.Name = "CocaColaCheckBox";
            this.CocaColaCheckBox.Size = new System.Drawing.Size(85, 19);
            this.CocaColaCheckBox.TabIndex = 17;
            this.CocaColaCheckBox.Text = "Кока-кола";
            this.CocaColaCheckBox.UseVisualStyleBackColor = true;
            this.CocaColaCheckBox.CheckedChanged += new System.EventHandler(this.CocaColaCheckBox_CheckedChanged);
            // 
            // FrenchFriesCheckBox
            // 
            this.FrenchFriesCheckBox.AutoSize = true;
            this.FrenchFriesCheckBox.Location = new System.Drawing.Point(4, 62);
            this.FrenchFriesCheckBox.Name = "FrenchFriesCheckBox";
            this.FrenchFriesCheckBox.Size = new System.Drawing.Size(123, 19);
            this.FrenchFriesCheckBox.TabIndex = 16;
            this.FrenchFriesCheckBox.Text = "Картофель-фри";
            this.FrenchFriesCheckBox.UseVisualStyleBackColor = true;
            this.FrenchFriesCheckBox.CheckedChanged += new System.EventHandler(this.FrenchFriesCheckBox_CheckedChanged);
            // 
            // hamburgerСheckBox
            // 
            this.hamburgerСheckBox.AutoSize = true;
            this.hamburgerСheckBox.Location = new System.Drawing.Point(4, 34);
            this.hamburgerСheckBox.Name = "hamburgerСheckBox";
            this.hamburgerСheckBox.Size = new System.Drawing.Size(87, 19);
            this.hamburgerСheckBox.TabIndex = 15;
            this.hamburgerСheckBox.Text = "Гамбургер";
            this.hamburgerСheckBox.UseVisualStyleBackColor = true;
            this.hamburgerСheckBox.CheckedChanged += new System.EventHandler(this.HamburgerСheckBox_CheckedChanged);
            // 
            // hotDogCheckBox
            // 
            this.hotDogCheckBox.AutoSize = true;
            this.hotDogCheckBox.Location = new System.Drawing.Point(4, 8);
            this.hotDogCheckBox.Name = "hotDogCheckBox";
            this.hotDogCheckBox.Size = new System.Drawing.Size(71, 19);
            this.hotDogCheckBox.TabIndex = 14;
            this.hotDogCheckBox.Text = "Хот-дог";
            this.hotDogCheckBox.UseVisualStyleBackColor = true;
            this.hotDogCheckBox.CheckedChanged += new System.EventHandler(this.HotDogCheckBox_CheckedChanged);
            // 
            // productPricePanel
            // 
            this.productPricePanel.Controls.Add(this.cocaColaPrice);
            this.productPricePanel.Controls.Add(this.frenchFriesPrice);
            this.productPricePanel.Controls.Add(this.hamburgerPrice);
            this.productPricePanel.Controls.Add(this.hotDogPrice);
            this.productPricePanel.Location = new System.Drawing.Point(135, 49);
            this.productPricePanel.Name = "productPricePanel";
            this.productPricePanel.Size = new System.Drawing.Size(68, 113);
            this.productPricePanel.TabIndex = 19;
            // 
            // cocaColaPrice
            // 
            this.cocaColaPrice.AutoSize = true;
            this.cocaColaPrice.Location = new System.Drawing.Point(19, 83);
            this.cocaColaPrice.Name = "cocaColaPrice";
            this.cocaColaPrice.Size = new System.Drawing.Size(32, 17);
            this.cocaColaPrice.TabIndex = 15;
            this.cocaColaPrice.Text = "200";
            // 
            // frenchFriesPrice
            // 
            this.frenchFriesPrice.AutoSize = true;
            this.frenchFriesPrice.Location = new System.Drawing.Point(19, 57);
            this.frenchFriesPrice.Name = "frenchFriesPrice";
            this.frenchFriesPrice.Size = new System.Drawing.Size(32, 17);
            this.frenchFriesPrice.TabIndex = 14;
            this.frenchFriesPrice.Text = "400";
            // 
            // hamburgerPrice
            // 
            this.hamburgerPrice.AutoSize = true;
            this.hamburgerPrice.Location = new System.Drawing.Point(19, 29);
            this.hamburgerPrice.Name = "hamburgerPrice";
            this.hamburgerPrice.Size = new System.Drawing.Size(32, 17);
            this.hamburgerPrice.TabIndex = 13;
            this.hamburgerPrice.Text = "700";
            // 
            // hotDogPrice
            // 
            this.hotDogPrice.AutoSize = true;
            this.hotDogPrice.Location = new System.Drawing.Point(19, 3);
            this.hotDogPrice.Name = "hotDogPrice";
            this.hotDogPrice.Size = new System.Drawing.Size(32, 17);
            this.hotDogPrice.TabIndex = 12;
            this.hotDogPrice.Text = "500";
            // 
            // productCountPanel
            // 
            this.productCountPanel.Controls.Add(this.hotDogCount);
            this.productCountPanel.Controls.Add(this.hamburgerCount);
            this.productCountPanel.Controls.Add(this.frenchFriesCount);
            this.productCountPanel.Controls.Add(this.cocaColaCount);
            this.productCountPanel.Location = new System.Drawing.Point(205, 47);
            this.productCountPanel.Name = "productCountPanel";
            this.productCountPanel.Size = new System.Drawing.Size(72, 115);
            this.productCountPanel.TabIndex = 18;
            // 
            // hotDogCount
            // 
            this.hotDogCount.BackColor = System.Drawing.Color.Azure;
            this.hotDogCount.Enabled = false;
            this.hotDogCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotDogCount.Location = new System.Drawing.Point(4, 5);
            this.hotDogCount.MaxLength = 2;
            this.hotDogCount.Name = "hotDogCount";
            this.hotDogCount.Size = new System.Drawing.Size(63, 21);
            this.hotDogCount.TabIndex = 13;
            this.hotDogCount.Text = "0";
            this.hotDogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hotDogCount.TextChanged += new System.EventHandler(this.ProductCount_TextChanged);
            this.hotDogCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductCount_KeyPress);
            // 
            // hamburgerCount
            // 
            this.hamburgerCount.BackColor = System.Drawing.Color.Azure;
            this.hamburgerCount.Enabled = false;
            this.hamburgerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hamburgerCount.Location = new System.Drawing.Point(4, 31);
            this.hamburgerCount.MaxLength = 2;
            this.hamburgerCount.Name = "hamburgerCount";
            this.hamburgerCount.Size = new System.Drawing.Size(63, 21);
            this.hamburgerCount.TabIndex = 12;
            this.hamburgerCount.Text = "0";
            this.hamburgerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hamburgerCount.TextChanged += new System.EventHandler(this.ProductCount_TextChanged);
            this.hamburgerCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductCount_KeyPress);
            // 
            // frenchFriesCount
            // 
            this.frenchFriesCount.BackColor = System.Drawing.Color.Azure;
            this.frenchFriesCount.Enabled = false;
            this.frenchFriesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frenchFriesCount.Location = new System.Drawing.Point(4, 59);
            this.frenchFriesCount.MaxLength = 2;
            this.frenchFriesCount.Name = "frenchFriesCount";
            this.frenchFriesCount.Size = new System.Drawing.Size(63, 21);
            this.frenchFriesCount.TabIndex = 10;
            this.frenchFriesCount.Text = "0";
            this.frenchFriesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frenchFriesCount.TextChanged += new System.EventHandler(this.ProductCount_TextChanged);
            this.frenchFriesCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductCount_KeyPress);
            // 
            // cocaColaCount
            // 
            this.cocaColaCount.BackColor = System.Drawing.Color.Azure;
            this.cocaColaCount.Enabled = false;
            this.cocaColaCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cocaColaCount.Location = new System.Drawing.Point(4, 85);
            this.cocaColaCount.MaxLength = 2;
            this.cocaColaCount.Name = "cocaColaCount";
            this.cocaColaCount.Size = new System.Drawing.Size(63, 21);
            this.cocaColaCount.TabIndex = 8;
            this.cocaColaCount.Text = "0";
            this.cocaColaCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cocaColaCount.TextChanged += new System.EventHandler(this.ProductCount_TextChanged);
            this.cocaColaCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductCount_KeyPress);
            // 
            // toPayMiniCafe
            // 
            this.toPayMiniCafe.Controls.Add(this.literOrTgLabel);
            this.toPayMiniCafe.Controls.Add(this.miniCafeToPayValue);
            this.toPayMiniCafe.Location = new System.Drawing.Point(6, 170);
            this.toPayMiniCafe.Name = "toPayMiniCafe";
            this.toPayMiniCafe.Size = new System.Drawing.Size(261, 90);
            this.toPayMiniCafe.TabIndex = 13;
            this.toPayMiniCafe.TabStop = false;
            this.toPayMiniCafe.Text = "К оплате";
            // 
            // literOrTgLabel
            // 
            this.literOrTgLabel.AutoSize = true;
            this.literOrTgLabel.Location = new System.Drawing.Point(217, 62);
            this.literOrTgLabel.Name = "literOrTgLabel";
            this.literOrTgLabel.Size = new System.Drawing.Size(24, 17);
            this.literOrTgLabel.TabIndex = 12;
            this.literOrTgLabel.Text = "тг.";
            // 
            // miniCafeToPayValue
            // 
            this.miniCafeToPayValue.AutoSize = true;
            this.miniCafeToPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.miniCafeToPayValue.Location = new System.Drawing.Point(52, 27);
            this.miniCafeToPayValue.Name = "miniCafeToPayValue";
            this.miniCafeToPayValue.Size = new System.Drawing.Size(42, 46);
            this.miniCafeToPayValue.TabIndex = 0;
            this.miniCafeToPayValue.Text = "0";
            // 
            // productCount
            // 
            this.productCount.AutoSize = true;
            this.productCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCount.Location = new System.Drawing.Point(201, 24);
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(76, 15);
            this.productCount.TabIndex = 5;
            this.productCount.Text = "Количество";
            // 
            // productPrice
            // 
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPrice.Location = new System.Drawing.Point(151, 25);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(47, 18);
            this.productPrice.TabIndex = 4;
            this.productPrice.Text = "Цена";
            // 
            // toPayTutorial
            // 
            this.toPayTutorial.Controls.Add(this.clearButton);
            this.toPayTutorial.Controls.Add(this.dollarImage);
            this.toPayTutorial.Controls.Add(this.calculate);
            this.toPayTutorial.Controls.Add(this.tengeLabel);
            this.toPayTutorial.Controls.Add(this.total);
            this.toPayTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayTutorial.Location = new System.Drawing.Point(12, 293);
            this.toPayTutorial.Name = "toPayTutorial";
            this.toPayTutorial.Size = new System.Drawing.Size(571, 154);
            this.toPayTutorial.TabIndex = 14;
            this.toPayTutorial.TabStop = false;
            this.toPayTutorial.Text = "К оплате";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(117, 83);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 47);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // dollarImage
            // 
            this.dollarImage.Image = global::WindowsFormsApp4.Properties.Resources.cash_;
            this.dollarImage.Location = new System.Drawing.Point(31, 53);
            this.dollarImage.Name = "dollarImage";
            this.dollarImage.Size = new System.Drawing.Size(44, 47);
            this.dollarImage.TabIndex = 14;
            this.dollarImage.TabStop = false;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(117, 23);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(97, 47);
            this.calculate.TabIndex = 13;
            this.calculate.Text = "Рассчет";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // tengeLabel
            // 
            this.tengeLabel.AutoSize = true;
            this.tengeLabel.Location = new System.Drawing.Point(521, 113);
            this.tengeLabel.Name = "tengeLabel";
            this.tengeLabel.Size = new System.Drawing.Size(24, 17);
            this.tengeLabel.TabIndex = 12;
            this.tengeLabel.Text = "тг.";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total.Location = new System.Drawing.Point(291, 49);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(49, 54);
            this.total.TabIndex = 0;
            this.total.Text = "0";
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Yellow;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Controls.Add(this.okButton);
            this.colorPanel.Controls.Add(this.bLabel);
            this.colorPanel.Controls.Add(this.gLabel);
            this.colorPanel.Controls.Add(this.rLabel);
            this.colorPanel.Controls.Add(this.bTrackBar);
            this.colorPanel.Controls.Add(this.gTrackBar);
            this.colorPanel.Controls.Add(this.rTrackBar);
            this.colorPanel.Location = new System.Drawing.Point(258, 239);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(194, 195);
            this.colorPanel.TabIndex = 16;
            this.colorPanel.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(55, 158);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Принять";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(15, 120);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(14, 13);
            this.bLabel.TabIndex = 5;
            this.bLabel.Text = "B";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(15, 70);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(15, 13);
            this.gLabel.TabIndex = 4;
            this.gLabel.Text = "G";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(15, 17);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(15, 13);
            this.rLabel.TabIndex = 3;
            this.rLabel.Text = "R";
            // 
            // bTrackBar
            // 
            this.bTrackBar.Location = new System.Drawing.Point(52, 116);
            this.bTrackBar.Maximum = 255;
            this.bTrackBar.Name = "bTrackBar";
            this.bTrackBar.Size = new System.Drawing.Size(128, 45);
            this.bTrackBar.TabIndex = 2;
            this.bTrackBar.ValueChanged += new System.EventHandler(this.AllTrackBar_ValueChanged);
            // 
            // gTrackBar
            // 
            this.gTrackBar.Location = new System.Drawing.Point(52, 65);
            this.gTrackBar.Maximum = 255;
            this.gTrackBar.Name = "gTrackBar";
            this.gTrackBar.Size = new System.Drawing.Size(128, 45);
            this.gTrackBar.TabIndex = 1;
            this.gTrackBar.ValueChanged += new System.EventHandler(this.AllTrackBar_ValueChanged);
            // 
            // rTrackBar
            // 
            this.rTrackBar.Location = new System.Drawing.Point(52, 14);
            this.rTrackBar.Maximum = 255;
            this.rTrackBar.Name = "rTrackBar";
            this.rTrackBar.Size = new System.Drawing.Size(128, 45);
            this.rTrackBar.TabIndex = 0;
            this.rTrackBar.ValueChanged += new System.EventHandler(this.AllTrackBar_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripStatusLabel,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(595, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataToolStripStatusLabel
            // 
            this.dataToolStripStatusLabel.Name = "dataToolStripStatusLabel";
            this.dataToolStripStatusLabel.Size = new System.Drawing.Size(30, 17);
            this.dataToolStripStatusLabel.Text = "data";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.dayOfWeekToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Цвет фона";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.BackColorToolStripMenuItem_Click);
            // 
            // dayOfWeekToolStripMenuItem
            // 
            this.dayOfWeekToolStripMenuItem.Name = "dayOfWeekToolStripMenuItem";
            this.dayOfWeekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dayOfWeekToolStripMenuItem.Text = "День недели";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GasolineStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(595, 459);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.toPayTutorial);
            this.Controls.Add(this.miniCafe);
            this.Controls.Add(this.gasStation);
            this.Name = "GasolineStation";
            this.Text = "Gasoline Station";
            this.gasStation.ResumeLayout(false);
            this.gasStation.PerformLayout();
            this.toPayGasStation.ResumeLayout(false);
            this.toPayGasStation.PerformLayout();
            this.calculationOption.ResumeLayout(false);
            this.calculationOption.PerformLayout();
            this.miniCafe.ResumeLayout(false);
            this.miniCafe.PerformLayout();
            this.productCheckBoxPanel.ResumeLayout(false);
            this.productCheckBoxPanel.PerformLayout();
            this.productPricePanel.ResumeLayout(false);
            this.productPricePanel.PerformLayout();
            this.productCountPanel.ResumeLayout(false);
            this.productCountPanel.PerformLayout();
            this.toPayMiniCafe.ResumeLayout(false);
            this.toPayMiniCafe.PerformLayout();
            this.toPayTutorial.ResumeLayout(false);
            this.toPayTutorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dollarImage)).EndInit();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gasStation;
        private System.Windows.Forms.Label gazoline;
        private System.Windows.Forms.GroupBox miniCafe;
        private System.Windows.Forms.ComboBox typesOfFuel;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label tg;
        private System.Windows.Forms.Label priceValue;
        private System.Windows.Forms.Label tgLabel;
        private System.Windows.Forms.Label liter;
        private System.Windows.Forms.TextBox moneyValue;
        private System.Windows.Forms.TextBox amountOfFuelValue;
        private System.Windows.Forms.Panel calculationOption;
        private System.Windows.Forms.RadioButton money;
        private System.Windows.Forms.RadioButton amountOfFuel;
        private System.Windows.Forms.GroupBox toPayGasStation;
        private System.Windows.Forms.Label tgOrLiterLabel;
        private System.Windows.Forms.Label fuelToPayValue;
        private System.Windows.Forms.Label productCount;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.GroupBox toPayMiniCafe;
        private System.Windows.Forms.Label literOrTgLabel;
        private System.Windows.Forms.Label miniCafeToPayValue;
        private System.Windows.Forms.TextBox hotDogCount;
        private System.Windows.Forms.TextBox hamburgerCount;
        private System.Windows.Forms.TextBox frenchFriesCount;
        private System.Windows.Forms.TextBox cocaColaCount;
        private System.Windows.Forms.GroupBox toPayTutorial;
        private System.Windows.Forms.Label tengeLabel;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.CheckBox CocaColaCheckBox;
        private System.Windows.Forms.CheckBox FrenchFriesCheckBox;
        private System.Windows.Forms.CheckBox hamburgerСheckBox;
        private System.Windows.Forms.CheckBox hotDogCheckBox;
        private System.Windows.Forms.Panel productPricePanel;
        private System.Windows.Forms.Panel productCountPanel;
        private System.Windows.Forms.Panel productCheckBoxPanel;
        private System.Windows.Forms.PictureBox dollarImage;
        private System.Windows.Forms.Label frenchFriesPrice;
        private System.Windows.Forms.Label hamburgerPrice;
        private System.Windows.Forms.Label hotDogPrice;
        private System.Windows.Forms.Label cocaColaPrice;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TrackBar bTrackBar;
        private System.Windows.Forms.TrackBar gTrackBar;
        private System.Windows.Forms.TrackBar rTrackBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dataToolStripStatusLabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayOfWeekToolStripMenuItem;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Timer timer;
    }
}

