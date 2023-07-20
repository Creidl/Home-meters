namespace Home_Meters
{
    public class Statistics
    {
        public double MaxConsumption { 
            get 
            {   
                if(Consumption.Count > 0)
                {
                    return Consumption.Max();
                }
                else { return 0; }
            }
        }

        public double MinConsumption { 
            get
            {
                if (Consumption.Count > 0)
                {
                    return Consumption.Min();
                }
                else { return 0; }               
            }
        }

        public double AverageConsumption
        {
            get
            {
                if (Consumption.Count > 0)
                {
                    return Consumption.Sum() / Consumption.Count;
                }
                else { return 0; }
                
            }
        }

        public string CurrentConsumption
        {
            get
            {
                if (Consumption.Count > 0)
                {
                    switch (Value - LastValue)
                    {
                        case var x when x == AverageConsumption:
                            return "Average";
                        case var x when x == MaxConsumption:
                            return "Maximum";
                        case var x when x < MaxConsumption && x > AverageConsumption:
                            return "More than average";                        
                        case var x when x > MinConsumption && x < AverageConsumption:
                            return "Less than average";
                        case var x when x == MinConsumption:
                            return "Minimum";
                        default:
                            return "Error";
                    }
                }
                else { return "Meter with no values"; }
            }
        }

        public double Value { get; private set; }

        public double LastValue { get; private set; }

        private List<double> Consumption;
        

        public Statistics(List<double> values)
        {
            
            Consumption = new List<double>();

            if(values.Count != 0) 
            {
                Value = values[0];
                if(values.Count > 1) 
                {
                    for (int i = 1; i < values.Count; i++)
                    {
                        LastValue = Value;
                        Value = values[i];
                        Consumption.Add(Value - LastValue);
                    }
                }   
                else
                {
                    LastValue = Value;
                }
            }            
        }
    }
}
