namespace SDT621_FA1_SectionB_Q2
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAgeFromID(idNumber);
        }

        private int CalculateAgeFromID(string idNumber)
        {
            int year = int.Parse(idNumber.Substring(0, 2));
            if (year > DateTime.Now.Year % 100)
            {
                year += 1900;
            }
            else
            {
                year += 2000;
            }
            return DateTime.Now.Year - year;
        }

        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid ID. Must be exactly 13 digits.";

            if (!IDNumber.All(char.IsDigit))
                return "Invalid ID. Must contain only numbers.";

            if (Age <= 0)
                return "Invalid ID. Age could not be determined.";

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}