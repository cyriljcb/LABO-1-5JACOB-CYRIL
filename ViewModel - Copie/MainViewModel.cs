﻿using Infrastructure;
using Labo3;


namespace ViewModel
{
    public class MainViewModel : BindableBase
    {
        private FormeWrapper _selectedForme;
        public ObservableCollection<FormeWrapper> Items { get; set; }

        public FormeWrapper SelectedForme
        {
            get => _selectedForme;
            set
            {
                if (_selectedForme == value) return;
                _selectedForme = value;
                OnPropertyChanged(nameof(SelectedForme));
            }
        }

        private string myTitle;

        public string MyTitle
        {
            get { return myTitle; }
            set
            {
                if (myTitle == value) return;
                myTitle = value;
                OnPropertyChanged();
            }
        }


        public ICommand AddCarreCommand { get; set; }
        public ICommand AddCercleCommand { get; set; }
        public ICommand AddRectangleCommand { get; set; }

        public MainViewModel()
        {
            MyTitle = DateTime.Now.ToShortTimeString();
            Items = new ObservableCollection<FormeWrapper>();
            AddCarreCommand = new DelegateCommand(AddCarre);
            AddCercleCommand = new DelegateCommand(AddCercle);
            AddRectangleCommand = new DelegateCommand(AddRectangle);
            Add(new CarreWrapper(new Carre(0, 0, 10)));
        }

        private void Add(FormeWrapper v)
        {
            Items.Add(v);
            SelectedForme = v;
        }

        public void AddCarre(object args)
        {
            Add(new CarreWrapper(new Carre()));
        }

        public void AddRectangle(object args)
        {
            Add(new RectangleWrapper(new Rectangle()));
        }

        public void AddCercle(object args)
        {
            Add(new CercleWrapper(new Cercle()));
        }
    }
}
