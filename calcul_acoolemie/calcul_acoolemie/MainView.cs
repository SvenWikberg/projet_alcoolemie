using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcul_acoolemie {
    public partial class MainView : Form {
        private ModelCalculAlcoolemie _myModelCalculAlcoolemie;
        public ModelCalculAlcoolemie MyModelCalculAlcoolemie {
            get {
                return _myModelCalculAlcoolemie;
            }

            set {
                _myModelCalculAlcoolemie = value;
            }
        }

        public MainView() {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e) {
            nudPoid.Value = 50;
            cbxSexe.SelectedIndex = 0;
            lstbxBoissons.Enabled = false;
            lstbxBu.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            lstbxBoissons.Enabled = true;
            lstbxBu.Enabled = true;
            cbxSexe.Enabled = false;
            nudPoid.Enabled = false;
            btnStart.Enabled = false;

            MyModelCalculAlcoolemie = new ModelCalculAlcoolemie();
            lstbxBoissons.DataSource = MyModelCalculAlcoolemie.Drinks;
            lstbxBoissons.DisplayMember = "Display";

            MyModelCalculAlcoolemie.ShowGraphView();
        }

        private void lstbxBoissons_MouseDoubleClick(object sender, MouseEventArgs e) {
            lstbxBu.Items.Add(MyModelCalculAlcoolemie.DrinkADrink((Drink)lstbxBoissons.SelectedItem, (int)nudPoid.Value, cbxSexe.SelectedIndex).Display);
        }

        private void timBloodAlcohol_Tick(object sender, EventArgs e) {
            MyModelCalculAlcoolemie.BloodAlcohol -= ModelCalculAlcoolemie.BLOOD_ALCOHOL_LOOSING_HOUR;
        }
    }
}
