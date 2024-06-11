using newcursach;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace newcursach
{


    //public partial class MainForm : Form
    //{
    //    private List<Car> cars;
    //    private List<Buyer> buyers;
    //    private List<Car> matchingCars;
    //    private const string CarsFilePath = @"C:\CarDatabaseData\cars.json";
    //    private const string BuyersFilePath = @"C:\CarDatabaseData\buyers.json";

    //    private Button btnUpdateSearch;  // Объявление кнопки

    //    public MainForm()
    //    {
    //        InitializeComponent();
    //        LoadData();
    //        UpdateBuyersComboBox();
    //        lstMatchingCars.DoubleClick += lstMatchingCars_DoubleClick;
    //        InitializeUpdateSearchButton();
    //        InitializePlaceholderText();
    //        InitializeFormLayout();
    //    }

    //    private void LoadData()
    //    {
    //        cars = DataHandler.LoadCars(CarsFilePath);
    //        buyers = DataHandler.LoadBuyers(BuyersFilePath);
    //    }

    //    private void SaveData()
    //    {
    //        Directory.CreateDirectory(Path.GetDirectoryName(CarsFilePath));
    //        Directory.CreateDirectory(Path.GetDirectoryName(BuyersFilePath));

    //        DataHandler.SaveCars(cars, CarsFilePath);
    //        DataHandler.SaveBuyers(buyers, BuyersFilePath);
    //        MessageBox.Show($"Data saved to:\nCars: {CarsFilePath}\nBuyers: {BuyersFilePath}", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //    }

    //    private void lstMatchingCars_DoubleClick(object sender, EventArgs e)
    //    {
    //        if (lstMatchingCars.SelectedIndex >= 0)
    //        {
    //            if (matchingCars != null && lstMatchingCars.SelectedIndex < matchingCars.Count)
    //            {
    //                var selectedCar = matchingCars[lstMatchingCars.SelectedIndex];
    //                MessageBox.Show($"Brand: {selectedCar.Brand}\n" +
    //                                $"Year: {selectedCar.Year}\n" +
    //                                $"Specifications: {selectedCar.Specifications}\n" +
    //                                $"Features: {selectedCar.Features}\n" +
    //                                $"Condition: {selectedCar.Condition}\n" +
    //                                $"Price: ${selectedCar.Price / 1:F2}", "Car Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //            }
    //        }
    //    }

    //    private void UpdateBuyersComboBox()
    //    {
    //        cmbBuyers.Items.Clear();
    //        foreach (var buyer in buyers)
    //        {
    //            cmbBuyers.Items.Add(buyer.Name);
    //        }

    //        if (buyers.Count > 0)
    //            cmbBuyers.SelectedIndex = 0;
    //    }

    //    private void btnAddCar_Click(object sender, EventArgs e)
    //    {
    //        if (string.IsNullOrWhiteSpace(txtCarBrand.Text) ||
    //            string.IsNullOrWhiteSpace(txtCarYear.Text) ||
    //            string.IsNullOrWhiteSpace(txtCarSpecifications.Text) ||
    //            string.IsNullOrWhiteSpace(txtCarFeatures.Text) ||
    //            string.IsNullOrWhiteSpace(txtCarCondition.Text) ||
    //            string.IsNullOrWhiteSpace(txtCarPrice.Text))
    //        {
    //            MessageBox.Show("Please fill in all fields for the car.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        if (!int.TryParse(txtCarYear.Text, out int year))
    //        {
    //            MessageBox.Show("Invalid year format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        if (!decimal.TryParse(txtCarPrice.Text, out decimal price))
    //        {
    //            MessageBox.Show("Invalid price format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        var car = new Car
    //        {
    //            Brand = txtCarBrand.Text,
    //            Year = year,
    //            Specifications = txtCarSpecifications.Text,
    //            Features = txtCarFeatures.Text,
    //            Condition = txtCarCondition.Text,
    //            Price = price
    //        };
    //        cars.Add(car);
    //        SaveData();
    //    }

    //    private void btnAddBuyer_Click(object sender, EventArgs e)
    //    {
    //        if (string.IsNullOrWhiteSpace(txtBuyerName.Text) ||
    //            string.IsNullOrWhiteSpace(txtBuyerContactDetails.Text) ||
    //            string.IsNullOrWhiteSpace(txtBuyerBudget.Text))
    //        {
    //            MessageBox.Show("Please fill in all required fields for the buyer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        if (!decimal.TryParse(txtBuyerBudget.Text, out decimal budget))
    //        {
    //            MessageBox.Show("Invalid budget format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        var confirmationResult = MessageBox.Show("Are you sure you want to add this buyer?", "Confirm Add Buyer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    //        if (confirmationResult == DialogResult.Yes)
    //        {
    //            var buyer = new Buyer
    //            {
    //                Name = txtBuyerName.Text,
    //                ContactDetails = txtBuyerContactDetails.Text,
    //                PreferredBrands = string.IsNullOrWhiteSpace(txtBuyerPreferredBrand.Text) || txtBuyerPreferredBrand.Text == "Preferred Brand" ? null : txtBuyerPreferredBrand.Text,
    //                PreferredSpecifications = string.IsNullOrWhiteSpace(txtBuyerPreferredSpecifications.Text) || txtBuyerPreferredSpecifications.Text == "Preferred Specifications" ? null : txtBuyerPreferredSpecifications.Text,
    //                PreferredCondition = string.IsNullOrWhiteSpace(txtBuyerPreferredCondition.Text) || txtBuyerPreferredCondition.Text == "Preferred Condition" ? null : txtBuyerPreferredCondition.Text,
    //                Budget = budget
    //            };
    //            buyers.Add(buyer);
    //            SaveData();
    //            UpdateBuyersComboBox();
    //        }
    //    }

    //    private void btnFindCars_Click(object sender, EventArgs e)
    //    {
    //        if (cmbBuyers.SelectedIndex < 0) return;

    //        var selectedBuyer = buyers[cmbBuyers.SelectedIndex];
    //        var preferredBrands = string.IsNullOrWhiteSpace(selectedBuyer.PreferredBrands)
    //            ? null
    //            : selectedBuyer.PreferredBrands.Split(',').Select(b => b.Trim()).ToList();
    //        var preferredConditions = string.IsNullOrWhiteSpace(selectedBuyer.PreferredCondition)
    //            ? null
    //            : selectedBuyer.PreferredCondition.Split(',').Select(c => c.Trim()).ToList();
    //        var preferredSpecifications = string.IsNullOrWhiteSpace(selectedBuyer.PreferredSpecifications)
    //            ? null
    //            : selectedBuyer.PreferredSpecifications.Split(',').Select(spec => spec.Trim()).ToList();

    //        matchingCars = cars.Where(car =>
    //            (preferredBrands == null || preferredBrands.Any(pb => car.Brand.Equals(pb, StringComparison.OrdinalIgnoreCase))) &&
    //            (preferredSpecifications == null || preferredSpecifications.Any(spec => car.Specifications.IndexOf(spec, StringComparison.OrdinalIgnoreCase) >= 0)) &&
    //            (preferredConditions == null || preferredConditions.Any(pc => car.Condition.Equals(pc, StringComparison.OrdinalIgnoreCase))) &&
    //            car.Price <= selectedBuyer.Budget).ToList();

    //        lstMatchingCars.Items.Clear();
    //        foreach (var car in matchingCars)
    //        {
    //            lstMatchingCars.Items.Add($"{car.Brand} ({car.Year}) - ${car.Price / 1:F2}");
    //        }

    //        if (matchingCars.Count == 0)
    //        {
    //            MessageBox.Show("No matching cars found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        }
    //    }

    //    private void btnUpdateSearch_Click(object sender, EventArgs e)
    //    {
    //        btnFindCars_Click(sender, e);
    //    }

    //    private void InitializeUpdateSearchButton()
    //    {
    //        this.btnUpdateSearch = new System.Windows.Forms.Button();
    //        this.btnUpdateSearch.Location = new System.Drawing.Point(270, 460);
    //        this.btnUpdateSearch.Size = new System.Drawing.Size(100, 30);
    //        this.btnUpdateSearch.Text = "Update Search";
    //        this.btnUpdateSearch.Click += new System.EventHandler(this.btnUpdateSearch_Click);
    //        this.Controls.Add(this.btnUpdateSearch);
    //    }

    //    private void InitializePlaceholderText()
    //    {
    //        SetPlaceholderText(txtBuyerPreferredBrand, "Preferred Brand");
    //        SetPlaceholderText(txtBuyerPreferredSpecifications, "Preferred Specifications");
    //        SetPlaceholderText(txtBuyerPreferredCondition, "Preferred Condition");
    //    }

    //    private void SetPlaceholderText(TextBox textBox, string placeholder)
    //    {
    //        textBox.Text = placeholder;
    //        textBox.ForeColor = System.Drawing.Color.Gray;

    //        textBox.Enter += (sender, e) =>
    //        {
    //            if (textBox.Text == placeholder)
    //            {
    //                textBox.Text = "";
    //                textBox.ForeColor = System.Drawing.Color.Black;
    //            }
    //        };

    //        textBox.Leave += (sender, e) =>
    //        {
    //            if (string.IsNullOrWhiteSpace(textBox.Text))
    //            {
    //                textBox.Text = placeholder;
    //                textBox.ForeColor = System.Drawing.Color.Gray;
    //            }
    //        };
    //    }

    //    private void InitializeFormLayout()
    //    {
    //        // Настройка элементов управления для изменения размера с формой
    //        txtCarBrand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtCarYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtCarSpecifications.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtCarFeatures.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtCarCondition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtCarPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtBuyerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtBuyerContactDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtBuyerBudget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtBuyerPreferredBrand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtBuyerPreferredSpecifications.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        txtBuyerPreferredCondition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        cmbBuyers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //        lstMatchingCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    //        btnAddCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    //        btnAddBuyer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    //        btnFindCars.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    //        btnUpdateSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    //    }
    //}

    //#############################################################################################################################################################################

    public partial class DBCAR : Form
    {
        private List<Car> cars;
        private List<Buyer> buyers;
        private List<Car> matchingCars;
        private const string CarsFilePath = @"C:\CarDatabaseData\cars.json";
        private const string BuyersFilePath = @"C:\CarDatabaseData\buyers.json";
        private Button btnRemoveBuyer;


        public DBCAR()
        {
            InitializeComponent();
            LoadData();
            UpdateBuyersComboBox();
            lstMatchingCars.DoubleClick += lstMatchingCars_DoubleClick;
            InitializeRemoveBuyerButton();

            InitializePlaceholderText();
            InitializeFormLayout();
            this.MinimumSize = new Size(500, 700);
        }

        private void InitializeRemoveBuyerButton()
        {
            // Создаем кнопку
            btnRemoveBuyer = new Button();
            btnRemoveBuyer.Text = "Remove Buyer";
            btnRemoveBuyer.AutoSize = true;
            btnRemoveBuyer.Click += btnRemoveBuyer_Click;

            btnRemoveBuyer.Location = new Point(10, 10);

            Controls.Add(btnRemoveBuyer);
        }



        private void LoadData()
        {
            cars = DataHandler.LoadCars(CarsFilePath);
            buyers = DataHandler.LoadBuyers(BuyersFilePath);
        }

        private void SaveData()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(CarsFilePath));
            Directory.CreateDirectory(Path.GetDirectoryName(BuyersFilePath));

            DataHandler.SaveCars(cars, CarsFilePath);
            DataHandler.SaveBuyers(buyers, BuyersFilePath);
            MessageBox.Show($"Data saved to:\nCars: {CarsFilePath}\nBuyers: {BuyersFilePath}", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmbBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuyers.SelectedIndex >= 0)
            {
                var selectedBuyer = buyers[cmbBuyers.SelectedIndex];
                // Обновляем текст полей формы
                txtBuyerName.Text = selectedBuyer.Name;
                txtBuyerContactDetails.Text = selectedBuyer.ContactDetails;
                txtBuyerPreferredBrand.Text = selectedBuyer.PreferredBrands;
                txtBuyerPreferredSpecifications.Text = selectedBuyer.PreferredSpecifications;
                txtBuyerPreferredCondition.Text = selectedBuyer.PreferredCondition;
                txtBuyerBudget.Text = selectedBuyer.Budget.ToString();


            }
        }
        private void InitializeBuyersComboBox()
        {
            buyers = DataHandler.LoadBuyers(BuyersFilePath); // Загрузите список покупателей из файла
            cmbBuyers.Items.Clear(); // Очистите элементы ComboBox перед добавлением новых
            foreach (var buyer in buyers)
            {
                cmbBuyers.Items.Add(buyer.Name); // Добавьте имена покупателей в ComboBox
            }
        }








        private void lstMatchingCars_DoubleClick(object sender, EventArgs e)
        {
            if (lstMatchingCars.SelectedIndex >= 0)
            {
                if (matchingCars != null && lstMatchingCars.SelectedIndex < matchingCars.Count)
                {
                    var selectedCar = matchingCars[lstMatchingCars.SelectedIndex];
                    MessageBox.Show($"Brand: {selectedCar.Brand}\n" +
                                    $"Year: {selectedCar.Year}\n" +
                                    $"Specifications: {selectedCar.Specifications}\n" +
                                    $"Features: {selectedCar.Features}\n" +
                                    $"Condition: {selectedCar.Condition}\n" +
                                    $"Price: ${selectedCar.Price / 1:F2}", "Car Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateBuyersComboBox()
        {
            cmbBuyers.Items.Clear();
            foreach (var buyer in buyers)
            {
                cmbBuyers.Items.Add(buyer.Name);
            }

            if (buyers.Count > 0)
                cmbBuyers.SelectedIndex = 0;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarBrand.Text) ||
                string.IsNullOrWhiteSpace(txtCarYear.Text) ||
                string.IsNullOrWhiteSpace(txtCarSpecifications.Text) ||
                string.IsNullOrWhiteSpace(txtCarFeatures.Text) ||
                string.IsNullOrWhiteSpace(txtCarCondition.Text) ||
                string.IsNullOrWhiteSpace(txtCarPrice.Text))
            {
                MessageBox.Show("Please fill in all fields for the car.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCarYear.Text, out int year))
            {
                MessageBox.Show("Invalid year format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtCarPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var car = new Car
            {
                Brand = txtCarBrand.Text,
                Year = year,
                Specifications = txtCarSpecifications.Text,
                Features = txtCarFeatures.Text,
                Condition = txtCarCondition.Text,
                Price = price
            };
            cars.Add(car);
            SaveData();
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuyerName.Text) ||
                string.IsNullOrWhiteSpace(txtBuyerContactDetails.Text) ||
                string.IsNullOrWhiteSpace(txtBuyerBudget.Text))
            {
                MessageBox.Show("Please fill in all required fields for the buyer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtBuyerBudget.Text, out decimal budget))
            {
                MessageBox.Show("Invalid budget format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmationResult = MessageBox.Show("Are you sure you want to add this buyer?", "Confirm Add Buyer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmationResult == DialogResult.Yes)
            {
                var buyer = new Buyer
                {
                    Name = txtBuyerName.Text,
                    ContactDetails = txtBuyerContactDetails.Text,
                    PreferredBrands = string.IsNullOrWhiteSpace(txtBuyerPreferredBrand.Text) || txtBuyerPreferredBrand.Text == "Preferred Brand" ? null : txtBuyerPreferredBrand.Text,
                    PreferredSpecifications = string.IsNullOrWhiteSpace(txtBuyerPreferredSpecifications.Text) || txtBuyerPreferredSpecifications.Text == "Preferred Specifications" ? null : txtBuyerPreferredSpecifications.Text,
                    PreferredCondition = string.IsNullOrWhiteSpace(txtBuyerPreferredCondition.Text) || txtBuyerPreferredCondition.Text == "Preferred Condition" ? null : txtBuyerPreferredCondition.Text,
                    Budget = budget
                };
                buyers.Add(buyer);
                SaveData();
                UpdateBuyersComboBox();
            }
        }

        private void btnFindCars_Click(object sender, EventArgs e)
        {
            if (cmbBuyers.SelectedIndex < 0) return;

            var selectedBuyer = buyers[cmbBuyers.SelectedIndex];
            var preferredBrands = string.IsNullOrWhiteSpace(selectedBuyer.PreferredBrands)
                ? null
                : selectedBuyer.PreferredBrands.Split(',').Select(b => b.Trim()).ToList();
            var preferredConditions = string.IsNullOrWhiteSpace(selectedBuyer.PreferredCondition)
                ? null
                : selectedBuyer.PreferredCondition.Split(',').Select(c => c.Trim()).ToList();
            var preferredSpecifications = string.IsNullOrWhiteSpace(selectedBuyer.PreferredSpecifications)
                ? null
                : selectedBuyer.PreferredSpecifications.Split(',').Select(spec => spec.Trim()).ToList();

            matchingCars = cars.Where(car =>
                (preferredBrands == null || preferredBrands.Any(pb => car.Brand.Equals(pb, StringComparison.OrdinalIgnoreCase))) &&
                (preferredSpecifications == null || preferredSpecifications.Any(spec => car.Specifications.IndexOf(spec, StringComparison.OrdinalIgnoreCase) >= 0)) &&
                (preferredConditions == null || preferredConditions.Any(pc => car.Condition.Equals(pc, StringComparison.OrdinalIgnoreCase))) &&
                car.Price <= selectedBuyer.Budget).ToList();

            lstMatchingCars.Items.Clear();
            foreach (var car in matchingCars)
            {
                lstMatchingCars.Items.Add($"{car.Brand} ({car.Year}) - ${car.Price / 1:F2}");
            }

            if (matchingCars.Count == 0)
            {
                MessageBox.Show("No matching cars found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnRemoveBuyer_Click(object sender, EventArgs e)
        {
            if (cmbBuyers.SelectedIndex >= 0)
            {
                var confirmationResult = MessageBox.Show("Are you sure you want to remove this buyer?", "Confirm Remove Buyer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationResult == DialogResult.Yes)
                {
                    buyers.RemoveAt(cmbBuyers.SelectedIndex);
                    SaveData(); // Сохраняем обновленные данные без удаленного клиента
                    UpdateBuyersComboBox(); // Обновляем выпадающий список покупателей
                    ClearBuyerFields(); // Очищаем текстовые поля 
                }
            }
        }

        private void ClearBuyerFields()
        {
            txtBuyerName.Text = "Name";
            txtBuyerContactDetails.Text = "Contact Details";
            txtBuyerPreferredBrand.Text = "Preferred Brand";
            txtBuyerPreferredSpecifications.Text = "Preferred Specifications";
            txtBuyerPreferredCondition.Text = "Preferred Condition";
            txtBuyerBudget.Text = "Budget";
        }



        private void InitializePlaceholderText()
        {
            SetPlaceholderText(txtBuyerPreferredBrand, "Preferred Brand");
            SetPlaceholderText(txtBuyerPreferredSpecifications, "Preferred Specifications");
            SetPlaceholderText(txtBuyerPreferredCondition, "Preferred Condition");
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void InitializeFormLayout()
        {



            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 10,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            tableLayoutPanel.Controls.Add(btnRemoveBuyer, 1, 17);


            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            for (int i = 0; i < 10; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // Добавляем контролы в TableLayoutPanel
            tableLayoutPanel.Controls.Add(new Label { Text = "Brand:" }, 0, 0);
            tableLayoutPanel.Controls.Add(txtCarBrand, 1, 0);
            tableLayoutPanel.Controls.Add(new Label { Text = "Year:" }, 0, 1);
            tableLayoutPanel.Controls.Add(txtCarYear, 1, 1);
            tableLayoutPanel.Controls.Add(new Label { Text = "Specifications:" }, 0, 2);
            tableLayoutPanel.Controls.Add(txtCarSpecifications, 1, 2);
            tableLayoutPanel.Controls.Add(new Label { Text = "Features:" }, 0, 3);
            tableLayoutPanel.Controls.Add(txtCarFeatures, 1, 3);
            tableLayoutPanel.Controls.Add(new Label { Text = "Condition:" }, 0, 4);
            tableLayoutPanel.Controls.Add(txtCarCondition, 1, 4);
            tableLayoutPanel.Controls.Add(new Label { Text = "Price:" }, 0, 5);
            tableLayoutPanel.Controls.Add(txtCarPrice, 1, 5);
            tableLayoutPanel.Controls.Add(btnAddCar, 0, 6);
            tableLayoutPanel.Controls.Add(new Label { Text = "Name:" }, 0, 7);
            tableLayoutPanel.Controls.Add(txtBuyerName, 1, 7);
            tableLayoutPanel.Controls.Add(new Label { Text = "Contact Details:" }, 0, 8);
            tableLayoutPanel.Controls.Add(txtBuyerContactDetails, 1, 8);
            tableLayoutPanel.Controls.Add(new Label { Text = "Budget:" }, 0, 9);
            tableLayoutPanel.Controls.Add(txtBuyerBudget, 1, 9);
            tableLayoutPanel.Controls.Add(btnAddBuyer, 0, 10);
            tableLayoutPanel.Controls.Add(new Label { Text = "Preferred Brand:" }, 0, 11);
            tableLayoutPanel.Controls.Add(txtBuyerPreferredBrand, 1, 11);
            tableLayoutPanel.Controls.Add(new Label { Text = "Preferred Specifications:" }, 0, 12);
            tableLayoutPanel.Controls.Add(txtBuyerPreferredSpecifications, 1, 12);
            tableLayoutPanel.Controls.Add(new Label { Text = "Preferred Condition:" }, 0, 13);
            tableLayoutPanel.Controls.Add(txtBuyerPreferredCondition, 1, 13);
            tableLayoutPanel.Controls.Add(new Label { Text = "Select Buyer:" }, 0, 14);
            tableLayoutPanel.Controls.Add(cmbBuyers, 1, 14);
            tableLayoutPanel.Controls.Add(btnFindCars, 0, 15);
            tableLayoutPanel.Controls.Add(lstMatchingCars, 0, 16);
            tableLayoutPanel.SetColumnSpan(lstMatchingCars, 2);



            tableLayoutPanel.RowStyles[9].Height = 200;




            this.Controls.Add(tableLayoutPanel);


            txtCarBrand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCarYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCarSpecifications.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCarFeatures.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCarCondition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCarPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuyerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuyerContactDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuyerBudget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuyerPreferredBrand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuyerPreferredSpecifications.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuyerPreferredCondition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBuyers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstMatchingCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddBuyer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFindCars.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

        }

        
    }
}



