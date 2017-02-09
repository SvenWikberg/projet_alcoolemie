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
    public partial class GraphView : Form {
        ModelCalculAlcoolemie _myModelCalculAlcoolemie;
        public ModelCalculAlcoolemie MyModelCalculAlcoolemie {
            get {
                return _myModelCalculAlcoolemie;
            }

            set {
                _myModelCalculAlcoolemie = value;
            }
        }

        public GraphView(ModelCalculAlcoolemie m) {
            InitializeComponent();
            MyModelCalculAlcoolemie = m;
        }

        private void GraphView_Load(object sender, EventArgs e) {
            timRefresh.Enabled = true;
        }

        private void GraphView_Paint(object sender, PaintEventArgs e) {
            Point[] tblGraph = MyModelCalculAlcoolemie.CalculateGraph(e.ClipRectangle.Height - 40, e.ClipRectangle.Width, 20, 20);

            foreach (Point pt in tblGraph) {
                e.Graphics.DrawLine(Pens.LightGray, new Point(pt.X, 0), new Point(pt.X, e.ClipRectangle.Height));
            }
            e.Graphics.DrawLines(Pens.Red, tblGraph);
        }

        private void timRefresh_Tick(object sender, EventArgs e) {
            Invalidate();
            lblBloodAlcohol.Text = String.Format("Votre taux d'alcoolémie : {0:0.0000}%", MyModelCalculAlcoolemie.BloodAlcohol);
        }
    }
}
