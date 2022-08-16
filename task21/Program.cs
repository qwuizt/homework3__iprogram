double Distance(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double dist = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2));
    return dist;
}
double Adist = Distance(3,6,8,4,1,-7);
Console.WriteLine(Adist);

