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
        readonly Point GRAPH_POS;

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
            GRAPH_POS = new Point(20, 20);

            MyModelCalculAlcoolemie = m;
        }

        private void GraphView_Load(object sender, EventArgs e) {
            timRefresh.Enabled = true;


        }

        private void GraphView_Paint(object sender, PaintEventArgs e) {
            Point[] tblGraph = MyModelCalculAlcoolemie.CalculateGraph(e.ClipRectangle.Height - 40, e.ClipRectangle.Width, 20, 20);
            double graphPosHour = 0;
            graphPosHour = ((60 - (double)DateTime.Now.Second) / 60) * ((double)e.ClipRectangle.Width / 24);

            e.Graphics.DrawLine(Pens.Black, new Point(GRAPH_POS.X, 0), new Point(GRAPH_POS.X, e.ClipRectangle.Height));
            for (int i = -1; i < 24; i++) {
                e.Graphics.DrawLine(Pens.LightGray, new Point((int)graphPosHour + GRAPH_POS.X + (e.ClipRectangle.Width * i) / 24, 0), new Point((int)graphPosHour + GRAPH_POS.X + (e.ClipRectangle.Width * i) / 24, e.ClipRectangle.Height));
            }
            e.Graphics.DrawLines(Pens.Red, tblGraph);

        }

        private void timRefresh_Tick(object sender, EventArgs e) {
            Invalidate();
            lblBloodAlcohol.Text = String.Format("Votre taux d'alcoolémie : {0:0.00000}%", MyModelCalculAlcoolemie.BloodAlcohol);
        }

        private void GraphView_FormClosing(object sender, FormClosingEventArgs e) {

        }
    }
}
