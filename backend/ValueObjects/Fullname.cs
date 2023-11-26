namespace Honey.backend.ValueObjects
{
    public sealed class Fullname : ValueObject<Fullname>
    {
        public Fullname(string value)
        {
            Value = value;
        }
        public string Value { get; }
        public string DisplayShortName
        {
            get
            {
                string[] splitName = Value.Split(" ");
                if (splitName.Length == 2)
                {
                    return Convert.ToString(splitName[0]) + Convert.ToString(splitName[1]);
                }
                return Convert.ToString(splitName[0]);
            }

        }
        public override bool EqualsCore(Fullname other)
        {
            return Value == other.Value;
        }
    }
}