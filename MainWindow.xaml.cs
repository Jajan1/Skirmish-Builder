using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
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
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;

namespace Skirmish_Builder
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyList FactionList = new MyList();
        MyList HeroList = new MyList();
        MyList UnitList = new MyList();
        ObservableCollection<ObservableCollection<PartialContent>> ListofLists = new ObservableCollection<ObservableCollection<PartialContent>>();
        public int WarbandCost = 0;
        DataBase MyDataBase;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = ListofLists;

            ListofLists.Add(FactionList);
            ListofLists.Add(HeroList);
            ListofLists.Add(UnitList);

            FactionList.contentSelected += closeFactionList;
            FactionList.contentSelected += printHeroes;
            FactionList.contentSelected += printUnits;

            HeroList.contentSelected += closeHeroList;
            HeroList.contentSelected += countCost;
            UnitList.contentSelected += closeUnitList;
            UnitList.contentSelected += countCost;

            MyDataBase = new DataBase();
            ChaosButton.IsChecked = true;
            ChaosButton_Checked(ChaosButton,null);
        }

        private void ChaosButton_Checked(object sender, RoutedEventArgs e)
        {
            ChaosButton.IsChecked = true;
            OrderButton.IsChecked = false;
            DestructionButton.IsChecked = false;
            DeathButton.IsChecked = false;

            FactionList?.Clear();
            FactionList?.AddRange(MyDataBase?.FactionDataBase["Chaos"]);
            resetChooseButton();
            HeroList?.Clear();
            UnitList?.Clear();

            HeroStackPanel.Children.Clear();
            UnitStackPanel.Children.Clear();
            WarbandCost = 0;
            resetCostCounter();
        }

        private void OrderButton_Checked(object sender, RoutedEventArgs e)
        {
            OrderButton.IsChecked = true;
            ChaosButton.IsChecked = false;
            DestructionButton.IsChecked = false;
            DeathButton.IsChecked = false;

            FactionList?.Clear();
            FactionList?.AddRange(MyDataBase?.FactionDataBase["Order"]);
            resetChooseButton();
            HeroList?.Clear();
            UnitList?.Clear();

            HeroStackPanel.Children.Clear();
            UnitStackPanel.Children.Clear();
            WarbandCost = 0;
            resetCostCounter();
        }

        private void DestructionButton_Checked(object sender, RoutedEventArgs e)
        {
            DestructionButton.IsChecked = true;
            OrderButton.IsChecked = false;
            ChaosButton.IsChecked = false;
            DeathButton.IsChecked = false;

            FactionList?.Clear();
            FactionList?.AddRange(MyDataBase?.FactionDataBase["Destruction"]);
            resetChooseButton();
            HeroList?.Clear();
            UnitList?.Clear();

            HeroStackPanel.Children.Clear();
            UnitStackPanel.Children.Clear();
            WarbandCost = 0;
            resetCostCounter();
        }

        private void DeathButton_Checked(object sender, RoutedEventArgs e)
        {
            DeathButton.IsChecked = true;
            OrderButton.IsChecked = false;
            DestructionButton.IsChecked = false;
            ChaosButton.IsChecked = false;

            FactionList?.Clear();
            FactionList?.AddRange(MyDataBase?.FactionDataBase["Death"]);
            resetChooseButton();
            HeroList?.Clear();
            UnitList?.Clear();

            HeroStackPanel.Children.Clear();
            UnitStackPanel.Children.Clear();
            WarbandCost = 0;
            resetCostCounter();
        }

        private void closeFactionList(object factionObject)
        {
            FPopup.IsOpen = false;
            Choose.Content = (factionObject as PartialContent).name;
        }

        private void resetChooseButton()
        {
            Choose.Content = "Select a Faction";
        }

        private void closeHeroList(object heroObject)
        {
            HPopup.IsOpen = false;
            if (heroObject != null)
            {
                WarbandParts chosenHero = new WarbandParts((heroObject as PartialContent).RPCost);
                chosenHero.plusButton.Visibility = Visibility.Collapsed;
                chosenHero.minusButton.Visibility = Visibility.Collapsed;
                HeroStackPanel.Children.Add(chosenHero);
                chosenHero.DataContext = (heroObject as PartialContent).name;
                chosenHero.totalCostChangedBy += updateCostCounter;
            }
        }

        private void closeUnitList(object unitObject)
        {
            UPopup.IsOpen = false;
            if (unitObject != null)
            {
                WarbandParts chosenUnit = new WarbandParts((unitObject as PartialContent).RPCost);
                UnitStackPanel.Children.Add(chosenUnit);
                chosenUnit.DataContext = (unitObject as PartialContent).name;
                chosenUnit.totalCostChangedBy += updateCostCounter;
            }
        }

        private void countCost(object selectedObject)
        {
            WarbandCost += (selectedObject as PartialContent).RPCost;
            resetCostCounter();
        }

        private void resetCostCounter()
        {
            CostBlock.Text = WarbandCost + " ";
        }

        private void updateCostCounter(int costDifference)
        {
            WarbandCost += costDifference;
            CostBlock.Text = WarbandCost + " ";
        }

        private void printHeroes(object factionObject)
        {
            HeroList?.Clear();
            HeroList?.AddRange(MyDataBase?.HeroDataBase[(factionObject as PartialContent).name]);
        }
        private void printUnits(object factionObject)
        {
            UnitList?.Clear();
            UnitList?.AddRange(MyDataBase?.UnitDataBase[(factionObject as PartialContent).name]);
        }

        private void AddHeroButton_Click(object sender, RoutedEventArgs e)
        {
            ListOfHeroes.SelectedItem = null;
            AddHero.IsChecked = true;
            AddUnit.IsChecked = false;
        }

        private void AddUnitButton_Click(object sender, RoutedEventArgs e)
        {
            ListOfUnits.SelectedItem = null;
            AddUnit.IsChecked = true;
            AddHero.IsChecked = false;
        }

        private void PDFButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to save your Warband to PDF?", "Saving to PDF", System.Windows.MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //savedialog
                string fileName = "";
                System.Windows.Forms.SaveFileDialog saveDialog = new System.Windows.Forms.SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.FilterIndex = 0;
                saveDialog.FileName = WarbandNameTextBox.Text;
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = saveDialog.FileName;
                    
                    //fonts
                    Font boldFont = new Font(Font.FontFamily.TIMES_ROMAN, 15f, Font.BOLD, BaseColor.BLACK);
                    Font boldUnderlinedGreyFont = new Font(Font.FontFamily.TIMES_ROMAN, 15f, Font.BOLD | Font.UNDERLINE, BaseColor.GRAY);

                    Document doc = new Document(iTextSharp.text.PageSize.A4, 20, 20, 42, 35);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                    doc.Open();

                    //CONTENT
                    //header
                    iTextSharp.text.Paragraph header = new iTextSharp.text.Paragraph("Created using Skirmish Builder");
                    header.Alignment = Element.ALIGN_CENTER;
                    doc.Add(header);

                    PdfPTable warbandName = new PdfPTable(2);
                    warbandName.TotalWidth = 560f;
                    warbandName.LockedWidth = true;
                    warbandName.SetWidths(new float[] { 2f, 1f });
                    PdfPCell nameOfWarband = new PdfPCell(new Phrase(WarbandNameTextBox.Text, boldFont));
                    nameOfWarband.BorderWidth = 0;
                    warbandName.AddCell(nameOfWarband);
                    PdfPCell costOfWarband = new PdfPCell(new Phrase(string.Format("Total warband cost: {0}", WarbandCost), boldFont));
                    costOfWarband.BorderWidth = 0;
                    warbandName.AddCell(costOfWarband);
                    warbandName.SpacingBefore = 20;
                    doc.Add(warbandName);

                    string allegianceString = "";
                    if (ChaosButton.IsChecked == true)
                        allegianceString = "Chaos";
                    else if (OrderButton.IsChecked == true)
                        allegianceString = "Order";
                    else if (DestructionButton.IsChecked == true)
                        allegianceString = "Destruction";
                    else if (DeathButton.IsChecked == true)
                        allegianceString = "Death";
                    iTextSharp.text.Paragraph allegiance = new iTextSharp.text.Paragraph(string.Format("Allegiance: {0}", allegianceString), boldFont);
                    doc.Add(allegiance);

                    //Heroes
                    iTextSharp.text.Paragraph heroesHeader = new iTextSharp.text.Paragraph();
                    heroesHeader.Add(new Chunk("Heroes                                                                                                                                      ", boldUnderlinedGreyFont));
                    heroesHeader.Font = boldUnderlinedGreyFont;
                    heroesHeader.SpacingBefore = 20;
                    doc.Add(heroesHeader);

                    for (int i = 0; i < HeroStackPanel.Children.Count; i++)
                    {
                        if (HeroStackPanel.Children[i].Visibility == Visibility.Visible)
                        {
                            string heroLine = "";
                            string heroNameString = ((HeroStackPanel.Children[i] as WarbandParts)?.DataContext as string);
                            heroLine += heroNameString;
                            int heroCounterInt = (HeroStackPanel.Children[i] as WarbandParts).multiplier;
                            heroLine += "  x" + heroCounterInt;

                            PdfPTable heroName = new PdfPTable(2);
                            heroName.TotalWidth = 560f;
                            heroName.LockedWidth = true;
                            heroName.SetWidths(new float[] { 2f, 1f });
                            PdfPCell name = new PdfPCell(new Phrase(heroLine, boldFont));
                            name.BorderWidth = 0;
                            heroName.AddCell(name);
                            int heroTotalCostInt = (HeroStackPanel.Children[i] as WarbandParts).totalCost;
                            heroLine = "Cost: " + heroTotalCostInt;
                            PdfPCell cost = new PdfPCell(new Phrase(heroLine, boldFont));
                            cost.BorderWidth = 0;
                            cost.HorizontalAlignment = Element.ALIGN_CENTER;
                            heroName.AddCell(cost);
                            heroName.SpacingBefore = 20;
                            doc.Add(heroName);
                        }
                    }

                    //Units
                    iTextSharp.text.Paragraph unitsHeader = new iTextSharp.text.Paragraph();
                    unitsHeader.Add(new Chunk("Units                                                                                                                                         ", boldUnderlinedGreyFont));
                    unitsHeader.Font = boldUnderlinedGreyFont;
                    unitsHeader.SpacingBefore = 20;
                    doc.Add(unitsHeader);

                    for (int i = 0; i < UnitStackPanel.Children.Count; i++)
                    {
                        if (UnitStackPanel.Children[i].Visibility == Visibility.Visible)
                        {
                            string unitLine = "";
                            string unitNameString = ((UnitStackPanel.Children[i] as WarbandParts)?.DataContext as string);
                            unitLine += unitNameString;
                            int unitCounterInt = (UnitStackPanel.Children[i] as WarbandParts).multiplier;
                            unitLine += "  x" + unitCounterInt;

                            PdfPTable unitName = new PdfPTable(2);
                            unitName.TotalWidth = 560f;
                            unitName.LockedWidth = true;
                            unitName.SetWidths(new float[] { 2f, 1f });
                            PdfPCell name = new PdfPCell(new Phrase(unitLine, boldFont));
                            name.BorderWidth = 0;
                            unitName.AddCell(name);
                            int unitTotalCostInt = (UnitStackPanel.Children[i] as WarbandParts).totalCost;
                            unitLine = "Cost: " + unitTotalCostInt;
                            PdfPCell cost = new PdfPCell(new Phrase(unitLine, boldFont));
                            cost.BorderWidth = 0;
                            cost.HorizontalAlignment = Element.ALIGN_CENTER;
                            unitName.AddCell(cost);
                            unitName.SpacingBefore = 20;
                            doc.Add(unitName);
                        }
                    }

                    doc.Close();

                    System.Windows.MessageBox.Show("The PDF file has been created.", "Success");
                }
            }
        }
    }

    public class PartialContent
    {
        public String name { get; private set; }
        public int RPCost;

        public PartialContent(String name, int cost = 0)
        {
            this.name = name;
            this.RPCost = cost;
        }
    }

    //lista
    public class MyList : ObservableCollection<PartialContent>
    {
        public MyList() { }

        private PartialContent _selectedContent;
        public PartialContent SelectedContent
        {
            get
            {
                return _selectedContent;
            }
            set
            {
                _selectedContent = value;
                if (_selectedContent != null)
                {
                    contentSelected?.Invoke(_selectedContent);
                }
            }
        }
        public delegate void OnEventThatContentSelected(object selectedContent);
        public OnEventThatContentSelected contentSelected;

        public void AddRange(IEnumerable<PartialContent> collection)
        {
            if (collection == null) throw new ArgumentNullException("collection");

            foreach (var i in collection) Items.Add(i);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}