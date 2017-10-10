using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_WF
{
    public partial class GasolineStation : Form
    {
        private List<string> typeOfGasoline;

        public GasolineStation()
        {
            InitializeComponent();
            typeOfGasoline = new List<string> { "АИ-92", "А-80", "АИ-91", "АИ-93", "АИ-95", "АИ-98", "ДТ" };
            foreach(string ai in typeOfGasoline)
            {
                typesOfFuel.Items.Add(ai);
            }
            typesOfFuel.SelectedItem = typeOfGasoline[0];

            dayOfWeekToolStripMenuItem.Text = DateTime.Now.DayOfWeek.ToString();
            dataToolStripStatusLabel.Text = DateTime.Now.ToShortDateString();

        }

        private void AmountOfFuel_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                amountOfFuelValue.ReadOnly = false;
                moneyValue.ReadOnly = true;
                moneyValue.Text = "";
            }
            else
            {
                amountOfFuelValue.ReadOnly = true;
                amountOfFuelValue.Text = "";
                moneyValue.ReadOnly = false;
            }
        }

        private void TypesOfFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((sender as ComboBox).SelectedItem as String).CompareTo(typeOfGasoline[0]) == 0)
            {
                priceValue.Text = "147";
            }
            else if (((sender as ComboBox).SelectedItem as String).CompareTo( typeOfGasoline[1])==0)
            {
                priceValue.Text = "89";
            }
            else if (((sender as ComboBox).SelectedItem as String).CompareTo(typeOfGasoline[2]) == 0)
            {
                priceValue.Text = "150";
            }
            else if (((sender as ComboBox).SelectedItem as String).CompareTo(typeOfGasoline[3]) == 0)
            {
                priceValue.Text = "153";
            }
            else if (((sender as ComboBox).SelectedItem as String).CompareTo(typeOfGasoline[4]) == 0)
            {
                priceValue.Text = "161";
            }
            else if (((sender as ComboBox).SelectedItem as String).CompareTo(typeOfGasoline[5]) == 0)
            {
                priceValue.Text = "171";
            }
            else if (((sender as ComboBox).SelectedItem as String).CompareTo(typeOfGasoline[6]) == 0)
            {
                priceValue.Text = "148";
            }
            if (amountOfFuelValue.Text.Length > 0)
            {
                AmountOfFuelValue_TextChanged(amountOfFuelValue, null);
            }
            if(moneyValue.Text.Length > 0)
            {
                MoneyValue_TextChanged(moneyValue, null);
            }
        }

        private void AmountOfFuelValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void MoneyValue_TextChanged(object sender, EventArgs e)
        {
            tgOrLiterLabel.Text = "л.";
            int price, count;
            if (Int32.TryParse((sender as TextBox).Text, out count))
            {
                if (Int32.TryParse(priceValue.Text, out price))
                {
                    fuelToPayValue.Text = (count / price).ToString();
                }
                else
                {
                    fuelToPayValue.Text = "0";
                }
            }
            else
            {
                fuelToPayValue.Text = "0";
            }
        }

        private void AmountOfFuelValue_TextChanged(object sender, EventArgs e)
        {
            tgOrLiterLabel.Text = "тг.";
            if (Int32.TryParse((sender as TextBox).Text, out int count))
            {
                if (Int32.TryParse(priceValue.Text, out int price))
                {
                    fuelToPayValue.Text = (count * price).ToString();
                }
                else
                {
                    fuelToPayValue.Text = "0";
                }
            }
            else
            {
                fuelToPayValue.Text = "0";
            }
        }

        private void HotDogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotDogCount.Enabled)
            {
                hotDogCount.Enabled = false;
                hotDogCount.Text = "";
            }
            else
            {
                hotDogCount.Enabled = true;
            }
        }

        private void HamburgerСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburgerCount.Enabled)
            {
                hamburgerCount.Enabled = false;
                hamburgerCount.Text = "";
            }
            else
            {
                hamburgerCount.Enabled = true;
            }
        }

        private void FrenchFriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (frenchFriesCount.Enabled)
            {
                frenchFriesCount.Enabled = false;
                frenchFriesCount.Text = "";
            }
            else
            {
                frenchFriesCount.Enabled = true;
            }
        }

        private void CocaColaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cocaColaCount.Enabled)
            {
                cocaColaCount.Enabled = false;
                cocaColaCount.Text = "";
            }
            else
            {
                cocaColaCount.Enabled = true;
            }
        }

        private void ProductCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void ProductCount_TextChanged(object sender, EventArgs e)
        {
            int sum = 0, count = 0;
            if (Int32.TryParse(hotDogCount.Text, out count))
            {
                sum += count * Int32.Parse(hotDogPrice.Text);
            }
            if (Int32.TryParse(hamburgerCount.Text, out count))
            {
                sum += count * Int32.Parse(hamburgerPrice.Text);
            }
            if (Int32.TryParse(frenchFriesCount.Text, out count))
            {
                sum += count * Int32.Parse(frenchFriesPrice.Text);
            }
            if (Int32.TryParse(cocaColaCount.Text, out count))
            {
                sum += count * Int32.Parse(cocaColaPrice.Text);
            }
            miniCafeToPayValue.Text = sum.ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if ( !(String.IsNullOrEmpty(moneyValue.Text)) || !(String.IsNullOrEmpty(amountOfFuelValue.Text)) ) {
                if (money.Checked)
                {
                    total.Text = (Int32.Parse(moneyValue.Text) + Int32.Parse(miniCafeToPayValue.Text)).ToString();
                }
                else
                {
                    total.Text = (Int32.Parse(fuelToPayValue.Text) + Int32.Parse(miniCafeToPayValue.Text)).ToString();
                }
            }
        }

        private void ClearWindow()
        {
            typesOfFuel.SelectedItem = typeOfGasoline[0];
            money.Checked = true;
            hotDogCheckBox.Checked = false;
            hamburgerСheckBox.Checked = false;
            FrenchFriesCheckBox.Checked = false;
            CocaColaCheckBox.Checked = false;
            fuelToPayValue.Text = "0";
            moneyValue.Text = "0";
            total.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearWindow();
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorPanel.Visible = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            colorPanel.Visible = false;
        }

        //Все три трака ссылаются на одно это событие
        private void AllTrackBar_ValueChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }

        bool changeStatus = true;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (changeStatus)
            {
                dataToolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
                changeStatus = false;
            }
            else
            {
                dataToolStripStatusLabel.Text = DateTime.Now.ToShortDateString();
                changeStatus = true;
            }
        }
    }
}
