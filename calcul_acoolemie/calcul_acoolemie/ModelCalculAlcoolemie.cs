using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcul_acoolemie {
    public class ModelCalculAlcoolemie {
        //MainView _myMainView;
        //public MainView MyMainView {
        //    get {
        //        return _myMainView;
        //    }

        //    set {
        //        _myMainView = value;
        //    }
        //}

        // en %
        double _bloodAlcohol;
        public double BloodAlcohol {
            get {
                return _bloodAlcohol;
            }

            set {
                if (value < 0) {
                    value = 0;
                }
                _bloodAlcohol = value;
            }
        }

        // en grammes
        double _alcoholConsumed;
        public double AlcoholConsumed {
            get {
                return _alcoholConsumed;
            }

            set {
                if (value < 0) {
                    value = 0;
                }
                _alcoholConsumed = value;
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

        public ModelCalculAlcoolemie() {
            BloodAlcohol = 0.0;
            AlcoholConsumed = 0;
            //MyMainView = myMainView;
            Drinks = new List<Drink>();
            Drinks.Add(new Drink("Bière", 250, 8));
            Drinks.Add(new Drink("Bière légère", 250, 4));
            Drinks.Add(new Drink("Bière", 500, 8));
            Drinks.Add(new Drink("Bière légère", 500, 4));
            Drinks.Add(new Drink("Verre de vin", 140, 11));
            Drinks.Add(new Drink("Shot", 45, 40));
        }

        public Drink DrinkADrink(Drink drinkDrinked, int weight, int gender) {
            AlcoholConsumed += drinkDrinked.AlcoholContent;

            if (gender == 0) {
                BloodAlcohol = AlcoholConsumed / (weight * 0.7) / 10;
            }
            else {
                BloodAlcohol = AlcoholConsumed / (weight * 0.6) / 10;
            }

            return drinkDrinked;
        }

        public Point[] CalculateGraph(int graphHeight, int graphWidth, int startX, int startY) {
            double tmpBloodAlcohol = BloodAlcohol;
            double tmpX = 0;
            double tmpY = 0;
            Point[] tblGraph = new Point[24];

            for (double i = 0; i < tblGraph.Length; i++) {
                if (BloodAlcohol == 0) {
                    tmpY = 0;
                }
                else {                        //A CHANGER SELON LE PLUS PRATIQUE
                    tmpY = (tmpBloodAlcohol / 0.3) * graphHeight;
                }
                tmpX = (i / tblGraph.Length) * graphWidth;


                tmpY = graphHeight - tmpY;
                tblGraph[(int)i] = new Point((int)tmpX + startX, (int)tmpY + startY);
                tmpBloodAlcohol -= 0.015;
                if (tmpBloodAlcohol < 0) {
                    tmpBloodAlcohol = 0;
                }
            }

            return tblGraph;
        }

        public void ShowGraphView() {
            GraphView myGraphView = new GraphView(this);
            myGraphView.Show();
        }
    }
}
