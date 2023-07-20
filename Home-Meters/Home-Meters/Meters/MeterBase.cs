namespace Home_Meters.Meters
{
    public abstract class MeterBase : IMeter
    {
        public MeterBase() 
        { 
        }

        public abstract Statistics GetStatistics();

        public abstract void AddValue(double value);

        public void AddValue(string value)
        {
            if (float.TryParse(value, out float result))
            {
                AddValue(result);
            }
            else
            {
                throw new Exception("  Wrong value !!!");
            }
        }
    }
}
