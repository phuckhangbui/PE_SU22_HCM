using System.Text.RegularExpressions;

namespace PE_SU22_HCM
{
    public class Utils
    {
        public static List<string> errorMes = new List<string>();

        public static void resetErrorMes()
        {
            errorMes = new List<string>();
        }
        public static bool isEmpty(String str)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(str) && errorMes == null)
                    errorMes.Add("All field must not be empty");
                return string.IsNullOrWhiteSpace(str);
            }
            catch (Exception e)
            {
                errorMes = new List<string>();
                errorMes.Add("All field must not be empty");
                return false;
            }
        }


        public static bool CheckBranch(String txtName)
        {
            if (Regex.IsMatch(txtName, @"^(?:\b[A-Z][\w]+\b\s*){2,}$"))
            {
                return true;
            }

            else
            {
                errorMes.Add("Incorrect format");
                return false;
            }
        }
        public static bool CheckDate(DateTime dtpDate)
        {
            return dtpDate.Year >= 2000 && dtpDate.Year <= 2022;
        }



    }
}
