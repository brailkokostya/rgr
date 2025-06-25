// Form1.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int N = (int)nudN.Value;
            var rand = new Random();
            var numbers = new List<int>(2 * N);
            for (int i = 0; i < 2 * N; i++)
                numbers.Add(rand.Next(0, 100));

            var points = new List<CustomVector>(N);
            for (int i = 0; i < N; i++)
            {
                var pt = new CustomVector(2) { [0] = numbers[2 * i], [1] = numbers[2 * i + 1] };
                points.Add(pt);
            }

            double maxAngle = 0;
            var best = Tuple.Create(0, 1, 2);

            for (int i = 0; i < N - 2; i++)
                for (int j = i + 1; j < N - 1; j++)
                    for (int k = j + 1; k < N; k++)
                    {
                        double a = Angle(points[i], points[j], points[k]);
                        double b = Angle(points[j], points[i], points[k]);
                        double c = Angle(points[k], points[i], points[j]);
                        double local = Math.Max(a, Math.Max(b, c));
                        if (local > maxAngle)
                        {
                            maxAngle = local;
                            best = Tuple.Create(i, j, k);
                        }
                    }

            lbResults.Items.Clear();
            lbResults.Items.Add("Точки:");
            for (int i = 0; i < N; i++)
                lbResults.Items.Add($"{i + 1}: {points[i]}");
            lbResults.Items.Add("");
            lbResults.Items.Add($"Макс. кут: {maxAngle * 180 / Math.PI:F2}°");
            lbResults.Items.Add($"Вершини: {best.Item1 + 1}, {best.Item2 + 1}, {best.Item3 + 1}");
        }

        private double Angle(CustomVector P, CustomVector Q, CustomVector R)
        {
            var v1 = Q.Subtract(P);
            var v2 = R.Subtract(P);
            double d = v1.Dot(v2);
            double denom = v1.Length() * v2.Length();
            if (denom == 0) return 0;
            double cos = Math.Max(-1, Math.Min(1, d / denom));
            return Math.Acos(cos);
        }

        private CustomVector ReadA() => new CustomVector(new List<double> { (double)nudAx.Value, (double)nudAy.Value });
        private CustomVector ReadB() => new CustomVector(new List<double> { (double)nudBx.Value, (double)nudBy.Value });

        private void btnAdd_Click(object sender, EventArgs e) => lblOpResult.Text = $"A + B = {ReadA().Add(ReadB())}";
        private void btnSubtract_Click(object sender, EventArgs e) => lblOpResult.Text = $"A - B = {ReadA().Subtract(ReadB())}";
        private void btnDot_Click(object sender, EventArgs e) => lblOpResult.Text = $"A·B = {ReadA().Dot(ReadB())}";
        private void btnScale_Click(object sender, EventArgs e) => lblOpResult.Text = $"A * {(double)nudScalar.Value} = {ReadA().Scale((double)nudScalar.Value)}";
        private void btnLength_Click(object sender, EventArgs e) => lblOpResult.Text = $"|A| = {ReadA().Length():F2}";
    }
}
