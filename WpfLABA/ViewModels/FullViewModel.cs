using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows;

namespace WpfLABA.ViewModels
{
    class FullViewModel : ObservableObject
    {

        List<Threats> li = (List<Threats>)Application.Current.Properties["List"];
        private int _nameOfThreat;
        private string _description;
        private string _source;
        private string _vector;
        public int NameOfThreat
        {
            get
            {
                return _nameOfThreat;
            }
            set
            {
                if (value<li.Count)
                {
                    _nameOfThreat = value;
                    foreach (Threats t in li)
                    {
                        if (Convert.ToInt32(t[0]) == _nameOfThreat)
                        {
                            _description = Convert.ToString(t[1]);
                            _source = Convert.ToString(t[2]);
                            _vector = Convert.ToString(t[3]);
                        }
                    }

                    OnPropertyChanged("NameOfThreat");
                    OnPropertyChanged("Description");
                    OnPropertyChanged("Source");
                    OnPropertyChanged("Vector");
                }
                else
                {
                    _nameOfThreat = 0;
                }
            }
        }

        public string Description
        {
            get
            {
                return Convert.ToString(li[_nameOfThreat][1]);
            }
            set
            {
                OnPropertyChanged("NameOfThreat");
            }

        }
        public string Source
        {
            get
            {
                return Convert.ToString(li[_nameOfThreat][2]);
            }
            set
            {
                OnPropertyChanged("NameOfThreat");
            }

        }
        public string Vector
        {
            get
            {
                return Convert.ToString(li[_nameOfThreat][3]);
            }
            set
            {
                OnPropertyChanged("NameOfThreat");
            }

        }

    }

}

