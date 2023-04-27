double[][] data = new double[][] {
    new double[] {1, 2},
    new double[] {2, 4},
    new double[] {3, 6},
    new double[] {4, 8},
    new double[] {5, 10},
};

double x_avg = 0, y_avg = 0, xy_cov = 0, x_var = 0;
foreach (double[] point in data) {
    x_avg += point[0];
    y_avg += point[1];
}
x_avg /= data.Length;
y_avg /= data.Length;
foreach (double[] point in data) {
    xy_cov += (point[0] - x_avg) * (point[1] - y_avg);
    x_var += Math.Pow(point[0] - x_avg, 2);
}
double b = xy_cov / x_var;
double a = y_avg - b * x_avg;

double[] x_values = new double[] {6, 7, 8, 9, 10};

Console.WriteLine("x\ty");
foreach (double x in x_values) {
    double y = a + b * x;
    Console.WriteLine(x + "\t" + y);
} 


// Muj ukol je stejny jako Filipuv, protoze jsme na tom delali spolu
