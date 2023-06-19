using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace labo4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Forme> ListeForme = new();
        private readonly SettingsForm.MainWindow SettingForm = new();

        public MainWindow()
        {
            InitializeComponent();
            ListViewForm.ItemsSource = ListeForme;
            SettingForm.SettingCompleted += SettingForm_SettingCompleted;
        }

        private void SettingForm_SettingCompleted(object sender, OptionEventArgs e)
        {
            if (sender is SettingsForm.MainWindow)
            {
                Background = new SolidColorBrush(e.Couleur);
                FontSize = e.Taille;
            }
        }

        private void ComboBoxForm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsInitialized) return;

            ComboBoxItem item = (ComboBoxItem)ComboBoxForm.SelectedItem;
            if (item is not null)
            {
                if (item.Content.Equals("Rectangle"))
                {
                    LabelLongueur.Content = "Longueur";
                    LabelLargeur.Visibility = Visibility.Visible;
                    TextBoxLargeur.Visibility = Visibility.Visible;
                }
                else
                {
                    if (item.Content.Equals("Carre"))
                    {
                        LabelLongueur.Content = "Côté";
                    }
                    else
                    {
                        LabelLongueur.Content = "Rayon";
                    }
                    LabelLargeur.Visibility = Visibility.Hidden;
                    TextBoxLargeur.Visibility = Visibility.Hidden;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Forme f;
            if (ComboBoxForm.Text.Equals("Rectangle"))
            {
                f = new Rectangle(Convert.ToInt32(TextBoxX.Text), Convert.ToInt32(TextBoxY.Text),
                                  Convert.ToInt32(TextBoxLongueur.Text), Convert.ToInt32(TextBoxLargeur.Text));
            }
            else if (ComboBoxForm.Text.Equals("Carre"))
            {
                f = new Carre(Convert.ToInt32(TextBoxX.Text), Convert.ToInt32(TextBoxY.Text), Convert.ToInt32(TextBoxLongueur.Text));
            }
            else
            {
                f = new Cercle(Convert.ToInt32(TextBoxX.Text), Convert.ToInt32(TextBoxY.Text), Convert.ToInt32(TextBoxLongueur.Text));
            }
            ListeForme.Add(f);
        }

        private void ListViewForm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewForm.SelectedItem is null)
            {
                LabelFormInfos.Content = "AUCUNE FORME SELECTIONNEE !";
            }
            else
            {
                LabelFormInfos.Content = ListViewForm.SelectedItem.GetType().Name + " : " + ListViewForm.SelectedItem.ToString();
            }
        }

        private void BtnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnParametres_Click(object sender, RoutedEventArgs e)
        {
            SettingForm.Show();
            SettingForm.Focus();
            SettingForm.Activate();
        }

        private void Dispose()
        {
            SettingForm.SettingCompleted -= SettingForm_SettingCompleted;
        }

        protected override void OnClosed(EventArgs e)
        {
            SettingForm.CloseWindow();
            Dispose();
            base.OnClosed(e);
        }
    }
}