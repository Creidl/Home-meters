namespace Home_Meters.Meters
{
    public class MeterInMemory : MeterBase
    {
        private List<double> values; 

        public MeterInMemory() 
        {
            values = new List<double>();
        }

        public override void AddValue (double value) 
        {
            if(values.Count == 0)
            {
                if (value >= 0)
                {
                    values.Add(value);
                }
                else
                {
                    throw new Exception(" Value is lower than 0! ");
                }
            }
            else
            {
                if(values.Max() <= value)
                {
                    values.Add(value);
                }
                else
                {
                    throw new Exception(" Value is lower than before! ");
                }
            }
                
        }

        public override Statistics GetStatistics()
        {
            Statistics statistics = new Statistics(values);
            return statistics;
        }
    }
}
