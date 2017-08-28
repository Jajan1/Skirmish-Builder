using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Skirmish_Builder
{
    /// <summary>
    /// Logika interakcji dla klasy WarbandParts.xaml
    /// </summary>
    public partial class WarbandParts : UserControl
    {
        private int singleCost;
        public int multiplier = 1;
        public int totalCost = 0;

        public WarbandParts(int RPcost)
        {
            InitializeComponent();
            this.singleCost = RPcost;
            this.totalCost = singleCost;
            CostTextBlock.Text = "Cost: " + singleCost;
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (multiplier > 1)
            {
                multiplier--;
                MultiplierTextBlock.Text = "x " + multiplier;
                int previousTotalCost = totalCost;
                totalCost = singleCost * multiplier;
                CostTextBlock.Text = "Cost: " + (totalCost);
                totalCostChangedBy?.Invoke(totalCost - previousTotalCost);
            }
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            multiplier++;
            MultiplierTextBlock.Text = "x " + multiplier;

            int previousTotalCost = totalCost;
            totalCost = singleCost * multiplier;
            CostTextBlock.Text = "Cost: " + (totalCost);
            totalCostChangedBy?.Invoke(totalCost - previousTotalCost);
        }

        public delegate void OnEventThatTotalCostChanged(int costDifference);
        public OnEventThatTotalCostChanged totalCostChangedBy;

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            totalCostChangedBy?.Invoke(-totalCost);
        }
    }
}
