using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcul_acoolemie {
    public class Drink {

        // Nom de la boisson
        string _name;
        public string Name {
            get {
                return _name;
            }

            set {
                _name = value;
            }
        }

        // Quantité en ml de la boisson
        double _quantity;
        public double Quantity {
            get {
                return _quantity;
            }

            set {
                _quantity = value;
            }
        }

        // Degré d'alcool dans la boisson
        private double _degree;
        /// <summary>
        /// Retourne une valeur en 0 et 100
        /// </summary>
        public double Degree {
            get {
                return _degree;
            }

            set {
                if (value > 100) {
                    value = 100;
                } else {
                    if (value < 0) {
                        value = 0;
                    }
                }
                _degree = value;
            }
        }
        
        // Quantité d'alcool dans la boisson
        double _alcoholContent;
        public double AlcoholContent {
            get {
                //0.8 est car 1L d'alcool pur pèse 0.8kg
                return ((Degree * Quantity) / 100) * 0.8;
            }
            set {
                _alcoholContent = value;
            }
        }

        public string Display {
            get {
                return Name + " " + Quantity + "ml " + Degree + "%";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Nom de la boisson</param>
        /// <param name="quantity">Quantité en ml de la boisson</param>
        /// <param name="degree">Degré d'alcool dans la boisson</param>
        public Drink(string name, double quantity, double degree) {
            Name = name;
            Quantity = quantity;
            Degree = degree;
        }
    }
}