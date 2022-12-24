using System.Collections.Generic;
using System.Linq;

namespace DirectoryOfDoctors.Classes
{
    class Snils
    {
        private string StrNumber { get; set; }
        private List<int> Number { get; set; } = new List<int>();
        private string ControlNumber { get; set; }

        public bool IsValid { get; set; } = true;

        public Snils(string snils)
        {
            if (IsCorrect(snils))
            {
                string[] tempData = snils.Split();
                StrNumber = tempData[0];
                CreateNumber(StrNumber);
                ControlNumber = tempData[1];
                ValidationSnils();
            }
        }

        private bool IsCorrect(string snils)
        {
            if (string.IsNullOrEmpty(snils))
            {
                return false;
            }
            int countDigit = snils.Count(c => c >= '0' && c <= '9');
            int countDefis = snils.Count(c => c == '-');
            return countDigit == 11 && countDefis == 2;
        }

        private void CreateNumber(string number)
        {
            string[] tempNumbers = number.Split('-');
            for (int i = 0; i < 3; i++)
            {
                string temp = tempNumbers[i];
                for (int j = 0; j < 3; j++)
                {
                    Number.Add(temp[j] - '0');
                }
            }
        }

        private void ValidationSnils()
        {
            if (!RangeValidation())
            {
                int sum = 0, controlNumber = int.Parse(ControlNumber);
                for (int i = 0; i < Number.Count; i++)
                {
                    sum += Number[i] * (9 - i);
                }
                sum += 101;
                do
                {
                    sum -= 101;
                    if (sum >= 1 && sum <= 99)
                    {
                        IsValid = controlNumber == sum;
                    }
                    if (sum == 100 || sum == 101)
                    {
                        IsValid = controlNumber == 0;
                    }
                } while (sum > 101);
                if (IsValid)
                {
                    IsValid = AdditionalValidation();
                }
            }
        }

        private bool RangeValidation()
        {
            int first = Number[0] * 100 + Number[1] * 10 + Number[2],
                second = Number[3] * 100 + Number[4] * 10 + Number[5],
                third = Number[6] * 100 + Number[7] * 10 + Number[8];
            return first <= 1 && second <= 1 && third <= 998;
        }

        private bool AdditionalValidation()
        {
            int checkNumber = Number[0], count = 1;
            for (int i = 1; i < Number.Count; i++)
            {
                if (count > 2)
                {
                    return false;
                }
                int temp = Number[i];
                if (temp == checkNumber)
                {
                    count++;
                }
                else
                {
                    checkNumber = temp;
                    count = 1;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return StrNumber + ' ' + ControlNumber;
        }
    }
}
