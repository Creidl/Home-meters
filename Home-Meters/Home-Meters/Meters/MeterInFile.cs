namespace Home_Meters.Meters
{
    public class MeterInFile : MeterBase
    {
        private readonly string fileName;

        public MeterInFile(string fileName)
        {
            this.fileName = fileName;   
        }       

        public override void AddValue(double value)
        {
            List<double> values = GetValuesFromFile();

            if (values.Count == 0)
            {
                if (value >= 0)
                {
                    AddValueToFile(value);
                }
                else
                {
                    throw new Exception(" Value is lower than 0! ");
                }
            }
            else
            {
                if (values.Max() <= value)
                {
                    AddValueToFile(value);
                }
                else
                {
                    throw new Exception(" Value is lower than before! ");
                }
            }
        }
        
        public override Statistics GetStatistics()
        {
            List<double> values = GetValuesFromFile();
            Statistics statistics = new Statistics(values);
            return statistics;
        }

        private List<double> GetValuesFromFile()
        {
            List<double> values = new List<double>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        values.Add(double.Parse(line));
                        line = reader.ReadLine();
                    }
                }
            }
            return values;
        }

        private void AddValueToFile(double value)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(value);
            }
        }
    }
}