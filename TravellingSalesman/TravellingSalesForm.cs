using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravellingSalesLibrary;

namespace TravellingSalesman
{
    public partial class TravellingSalesForm : Form
    {
        private readonly TravellingSalesMan TravellingSalesMan;

        private const int CITIES = 20;
        private const int SIZE = 10;

        public TravellingSalesForm()
        {
            InitializeComponent();

            TravellingSalesMan = new TravellingSalesMan()
            {
                TotalCities = CITIES,
                Width = Width - panelSidebar.Width,
                Height = Height
            };
            TravellingSalesMan.InitCity();

            trackBarCities.Value = CITIES;
            trackBarCircleSize.Value = SIZE;

        }

        private void TravellingSalesForm_Paint(object sender, PaintEventArgs e)
        {
            Brush brushColor = new SolidBrush(Color.FromArgb(46, 209, 66));
            Pen pen = new Pen(brushColor, 2);

            foreach (Node node in TravellingSalesMan.Cities)
            {
                brushColor = new SolidBrush(Color.FromArgb(209, 57, 46));
                if (node.Visited) { brushColor = new SolidBrush(Color.FromArgb(68, 207, 74)); }

                e.Graphics.FillEllipse(brushColor, new RectangleF(
                    node.XLocation, 
                    node.YLocation, 
                    TravellingSalesMan.EllipseSize, 
                    TravellingSalesMan.EllipseSize));
            }

            //  Draw lines to connect the nodes
            for (int i = 0; i < TravellingSalesMan.BestRoute.Count - 1; i++)
            {
                Point point1 = GetPoint(TravellingSalesMan.BestRoute[i]);
                Point point2 = GetPoint(TravellingSalesMan.BestRoute[i + 1]);
                e.Graphics.DrawLine(pen, point1, point2);
            }

        }

        private Point GetPoint(Node city)
        {
            int point1X = city.XLocation + TravellingSalesMan.EllipseSize / 2;
            int point1Y = city.YLocation + TravellingSalesMan.EllipseSize / 2;
            return new Point(point1X, point1Y);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            TravellingSalesMan.ReportProgress += ReportHandler;

            Task.Run(() => TravellingSalesMan.CalculateNearestNeighbour());
        }

        private void ReportHandler()
        {
            Invalidate();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            TravellingSalesMan.InitCity();
            Invalidate();

        }

        private void TravellingSalesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TrackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
 
        }

        private void TrackBarCities_ValueChanged(object sender, EventArgs e)
        {
            TravellingSalesMan.TotalCities = Convert.ToInt32(trackBarCities.Value);
            TravellingSalesMan.InitCity();
            Invalidate();
        }

        private void TrackBarCircleSize_ValueChanged(object sender, EventArgs e)
        {
            TravellingSalesMan.EllipseSize = Convert.ToInt32(trackBarCircleSize.Value);
            //TravellingSalesMan.InitCity();
            Invalidate();
        }
    }
}
