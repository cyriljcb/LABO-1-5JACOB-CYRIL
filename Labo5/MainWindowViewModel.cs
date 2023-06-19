using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairieForme;


namespace Labo3
{
    public class MainWindowViewModel : Bindablebase
    {
        public MainWindowViewModel() 
        {
            Items = new ObservableCollection<Carre>();
            Items.Add(new Carre(2,2,2));
            
        }
        public ObservableCollection<Carre> Items { get; set; }
    }
}
