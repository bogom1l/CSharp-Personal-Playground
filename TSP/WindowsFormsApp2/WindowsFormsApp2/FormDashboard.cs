namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using Database;
    using Entities;

    public partial class FormDashboard : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public FormDashboard()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            GetCarMakeStatistics();
            GetCarPriceStatistics();
            GetCarYearStatistics();
        }

        // Car Price Statistics
        private void GetCarPriceStatistics()
        {
            chart1.Series.Clear();

            List<string> priceCategories = new List<string>
                { "0-2000", "2000-5000", "5000-10000", "10000-20000", "20000+" };

            Dictionary<string, double> carCounts = new Dictionary<string, double>();
            foreach (string category in priceCategories)
            {
                carCounts.Add(category, 0);
            }

            List<double> carPrices = dataAccess.GetCarPrices();

            foreach (int price in carPrices)
            {
                if (price <= 2000)
                    carCounts["0-2000"]++;
                else if (price <= 5000)
                    carCounts["2000-5000"]++;
                else if (price <= 10000)
                    carCounts["5000-10000"]++;
                else if (price <= 20000)
                    carCounts["10000-20000"]++;
                else
                    carCounts["20000+"]++;
            }

            Series series = new Series("Car Prices");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(102, 178, 178); // Set bar color

            foreach (KeyValuePair<string, double> entry in carCounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart1.Series.Add(series);

            // Set background and border colors
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.ChartAreas[0].BorderColor = Color.FromArgb(0, 128, 128); // Border color

            // Set grid lines to specific color
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(178, 216, 216); // Horizontal major grid lines
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(178, 216, 216); // Vertical major grid lines

            chartArea.AxisX.LineColor = Color.FromArgb(178, 216, 216); // X-axis line color
            chartArea.AxisY.LineColor = Color.FromArgb(178, 216, 216); // Y-axis line color

            chartArea.AxisY.MajorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MajorY tick marks
            chartArea.AxisY.MinorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MinorY tick marks

            chartArea.AxisX.MajorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MajorX tick marks
            chartArea.AxisX.MinorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MinorX tick marks

            chart1.BorderColor = Color.FromArgb(178, 216, 216); // Change the outer border color
            chart1.BorderlineWidth = 2; // Optionally, adjust the width of the border
            chart1.BorderlineDashStyle = ChartDashStyle.Solid; // You can choose the dash style

            // Set series label font and color
            series.Font = new Font("Arial", 10f, FontStyle.Bold);
            series.LabelForeColor = Color.FromArgb(0, 76, 76);

            // Set axis label colors
            chartArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(178, 216, 216); // X-axis label color
            chartArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(178, 216, 216); // Y-axis label color

            // Configure legends
            foreach (var legend in chart1.Legends)
            {
                legend.BackColor = Color.FromArgb(178, 216, 216); // Legend background color
                legend.ForeColor = Color.FromArgb(0, 76, 76);     // Legend text color
            }

            chart1.Invalidate();
        }

        // Car Make Statistics
        private void GetCarMakeStatistics()
        {
            chart2.Series.Clear();

            List<Car> allCars = dataAccess.GetAllCars();

            Dictionary<string, int> carMakeCounts = new Dictionary<string, int>();
            foreach (Car car in allCars)
            {
                if (carMakeCounts.ContainsKey(car.Make))
                {
                    carMakeCounts[car.Make]++;
                }
                else
                {
                    carMakeCounts.Add(car.Make, 1);
                }
            }

            Series series = new Series("Car Make");
            series.ChartType = SeriesChartType.Pie;

            foreach (KeyValuePair<string, int> entry in carMakeCounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
                /*
                if we want to print "BMW - 15.5%", "Audi - 12.7%", instead of just "BMW", "Audi", ...:
                    double percentage = ((double)entry.Value / allCars.Count) * 100;
                    series.Points.AddXY(entry.Key + " - " + percentage.ToString("0.##") + "%", percentage);
                */
            }

            chart2.Series.Add(series);

            // Change the chart background color to RGB(0, 76, 76)
            chart2.ChartAreas[0].BackColor = Color.FromArgb(0, 76, 76);

            // Change the legend background and foreground colors
            if (chart2.Legends.Count > 0)
            {
                foreach (var legend in chart2.Legends)
                {
                    legend.BackColor = Color.FromArgb(178, 216, 216); // Set legend background color
                    legend.ForeColor = Color.FromArgb(0, 76, 76);     // Set legend foreground color
                }
            }

            chart2.BorderColor = Color.FromArgb(178, 216, 216); // Change the outer border color
            chart2.BorderlineWidth = 2; // Optionally, adjust the width of the border
            chart2.BorderlineDashStyle = ChartDashStyle.Solid; // You can choose the dash style

            chart2.Invalidate();
        }

        // Car Year Statistics
        private void GetCarYearStatistics()
        {
            chart3.Series.Clear();

            List<Car> allCars = dataAccess.GetAllCars();

            Dictionary<string, int> carYearCounts = new Dictionary<string, int>
            {
                { "Before 2000", 0 },
                { "2000-2010", 0 },
                { "2011-2020", 0 },
                { "After 2020", 0 }
            };

            foreach (Car car in allCars)
            {
                if (car.Year < 2000)
                {
                    carYearCounts["Before 2000"]++;
                }
                else if (car.Year >= 2000 && car.Year <= 2010)
                {
                    carYearCounts["2000-2010"]++;
                }
                else if (car.Year >= 2011 && car.Year <= 2020)
                {
                    carYearCounts["2011-2020"]++;
                }
                else
                {
                    carYearCounts["After 2020"]++;
                }
            }

            Series series = new Series("Car Year");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(102, 178, 178);


            foreach (KeyValuePair<string, int> entry in carYearCounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart3.Series.Add(series);

            chart3.ChartAreas[0].BackColor = Color.Transparent;
            chart3.ChartAreas[0].BorderColor = Color.FromArgb(0, 128, 128);

            var chartArea = chart3.ChartAreas[0];
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(178, 216, 216); // Horizontal major grid lines
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(178, 216, 216); // Vertical major grid lines

            chartArea.AxisX.MinorGrid.LineColor = Color.FromArgb(178, 216, 216); // Horizontal minor grid lines
            chartArea.AxisY.MinorGrid.LineColor = Color.FromArgb(178, 216, 216); // Vertical minor grid lines

            chartArea.AxisX.LineColor = Color.FromArgb(178, 216, 216); // X-axis line color
            chartArea.AxisY.LineColor = Color.FromArgb(178, 216, 216); // Y-axis line color

            chartArea.AxisY.MajorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MajorY tick marks
            chartArea.AxisY.MinorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MinorY tick marks

            chartArea.AxisX.MajorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MajorX tick marks
            chartArea.AxisX.MinorTickMark.LineColor = Color.FromArgb(178, 216, 216); // MinorX tick marks


            chart3.BorderColor = Color.FromArgb(178, 216, 216); // Change the outer border color
            chart3.BorderlineWidth = 2; // Optionally, adjust the width of the border
            chart3.BorderlineDashStyle = ChartDashStyle.Solid; // You can choose the dash style

            series.Font = new Font("Arial", 10f, FontStyle.Bold);
            series.Font = new Font("Arial", 10f, FontStyle.Bold); // Adjust font as needed

            chartArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(178, 216, 216); // Axis X label color
            chartArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(178, 216, 216); // Axis Y label color

            if (chart3.Legends.Count > 0)
            {
                foreach (var legend in chart3.Legends)
                {
                    legend.BackColor = Color.FromArgb(178, 216, 216); // Set legend background color
                    legend.ForeColor = Color.FromArgb(0, 76, 76);     // Set legend text color
                }
            }

            if (chart3.Legends.Count > 0)
            {
                foreach (var legend in chart3.Legends)
                {
                    legend.ForeColor = Color.FromArgb(0, 76, 76); // Legend text color
                }
            }

            chart3.Invalidate();
        }
    }
}



/*
 

namespace WindowsFormsApp2
   {
   using System;
   using System.Collections.Generic;
   using System.Drawing;
   using System.Windows.Forms;
   using System.Windows.Forms.DataVisualization.Charting;
   using Database;
   using Entities;
   
   public partial class FormDashboard : Form
   {
   private readonly DataAccess dataAccess = new DataAccess();
   
   public FormDashboard()
   {
   InitializeComponent();
   chart1.Series.Clear();
   chart2.Series.Clear();
   chart3.Series.Clear();
   }
   
   // Car Price Statistics
   private void button1_Click(object sender, EventArgs e)
   {
   chart1.Series.Clear();
   
   List<string> priceCategories = new List<string>
   { "0-2000", "2000-5000", "5000-10000", "10000-20000", "20000+" };
   
   Dictionary<string, double> carCounts = new Dictionary<string, double>();
   foreach (string category in priceCategories)
   {
   carCounts.Add(category, 0);
   }
   
   List<double> carPrices = dataAccess.GetCarPrices();
   
   foreach (int price in carPrices)
   {
   if (price <= 2000)
   carCounts["0-2000"]++;
   else if (price <= 5000)
   carCounts["2000-5000"]++;
   else if (price <= 10000)
   carCounts["5000-10000"]++;
   else if (price <= 20000)
   carCounts["10000-20000"]++;
   else
   carCounts["20000+"]++;
   }
   
   Series series = new Series("Car Prices");
   series.ChartType = SeriesChartType.Column;
   
   foreach (KeyValuePair<string, double> entry in carCounts)
   {
   series.Points.AddXY(entry.Key, entry.Value);
   }
   
   chart1.Series.Add(series);
   
   chart1.Invalidate();
   }
   
   // Car Make Statistics
   private void button2_Click(object sender, EventArgs e)
   {
   chart2.Series.Clear();
   
   List<Car> allCars = dataAccess.GetAllCars();
   
   Dictionary<string, int> carMakeCounts = new Dictionary<string, int>();
   foreach (Car car in allCars)
   {
   if (carMakeCounts.ContainsKey(car.Make))
   {
   carMakeCounts[car.Make]++;
   }
   else
   {
   carMakeCounts.Add(car.Make, 1);
   }
   }
   
   Series series = new Series("Car Make");
   series.ChartType = SeriesChartType.Pie;
   
   foreach (KeyValuePair<string, int> entry in carMakeCounts)
   {
   series.Points.AddXY(entry.Key, entry.Value);
   /*
   if we want to print "BMW - 15.5%", "Audi - 12.7%", instead of just "BMW", "Audi", ...:
   double percentage = ((double)entry.Value / allCars.Count) * 100;
   series.Points.AddXY(entry.Key + " - " + percentage.ToString("0.##") + "%", percentage);
   * /
   }
   
   chart2.Series.Add(series);
   
   chart2.Invalidate();
   }
   
   // Car Year Statistics
   private void button3_Click(object sender, EventArgs e)
   {
   chart3.Series.Clear();
   
   List<Car> allCars = dataAccess.GetAllCars();
   
   Dictionary<string, int> carYearCounts = new Dictionary<string, int>
   {
   { "Before 2000", 0 },
   { "2000-2010", 0 },
   { "2011-2020", 0 },
   { "After 2020", 0 }
   };
   
   foreach (Car car in allCars)
   {
   if (car.Year < 2000)
   {
   carYearCounts["Before 2000"]++;
   }
   else if (car.Year >= 2000 && car.Year <= 2010)
   {
   carYearCounts["2000-2010"]++;
   }
   else if (car.Year >= 2011 && car.Year <= 2020)
   {
   carYearCounts["2011-2020"]++;
   }
   else
   {
   carYearCounts["After 2020"]++;
   }
   }
   
   Series series = new Series("Car Year");
   series.ChartType = SeriesChartType.Column;
   
   
   foreach (KeyValuePair<string, int> entry in carYearCounts)
   {
   series.Points.AddXY(entry.Key, entry.Value);
   }
   
   chart3.Series.Add(series);
   
   chart3.ChartAreas[0].BackColor = Color.Transparent;
   chart3.ChartAreas[0].BorderColor = Color.White;
   
   chart3.Series["Car Year"].LabelForeColor = Color.Black;
   chart3.Series["Car Year"].Font = new Font("Arial", 10f, FontStyle.Bold);
   
   chart3.Invalidate();
   }
   }
   }


*/