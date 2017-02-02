using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcul_acoolemie
{
    class ModelCalculAlcoolemie
    {
        MainView _myMainView;
        public MainView MyMainView {
            get {
                return _myMainView;
            }

            set {
                _myMainView = value;
            }
        }

        List<Drink> _drinks;
        public List<Drink> Drinks {
            get {
                return _drinks;
            }

            set {
                _drinks = value;
            }
        }

        List<Drink> _drinksDrunk;
        public List<Drink> DrinksDrunk {
            get {
                return _drinksDrunk;
            }

            set {
                _drinksDrunk = value;
            }
        }

        int _weight;
        public int Weight {
            get {
                return _weight;
            }

            set {
                _weight = value;
            }
        }

        int _gender;
        public int Gender {
            get {
                return _gender;
            }

            set {
                _gender = value;
            }
        }

        public ModelCalculAlcoolemie(int weight, int gender, MainView myMainView)
        {
            Weight = weight;
            Gender = gender;
            MyMainView = myMainView;
            Drinks = new List<Drink>();



        }
    }
}
