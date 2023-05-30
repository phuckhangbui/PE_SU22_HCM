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
            if (txtName.Length > 5)
            {
                string[] words = txtName.Split(' ');
                foreach (string word in words)
                {
                    if (string.IsNullOrEmpty(word)) continue;
                    if (char.IsLower(word[0]))
                    {
                        errorMes.Add("Incorrect format");
                        return false;
                    }
                }

                return true;

            }



            errorMes.Add("Incorrect format");
            return false;
        }
        public static bool CheckDate(DateTime dtpDate)
        {
            return dtpDate.Year >= 2000 && dtpDate.Year <= 2022;
        }



    }
}
