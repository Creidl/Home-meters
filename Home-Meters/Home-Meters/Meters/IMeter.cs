namespace Home_Meters.Meters
{
    public interface IMeter
    {
        void AddValue(double value);

        void AddValue(string value);

        Statistics GetStatistics();
    }
}
