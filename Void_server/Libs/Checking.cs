using System;

namespace Void_server.Libs
{
    class Checking
    {
        public static bool CheckPort(int port)
        {
            return port < 1 || port > 65535;
        }

        public static bool CheckConvertInt(string text)
        {
            int temp;

            //try to convert the text given and return the success
            try
            {
                temp = int.Parse(text);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckNullOrEmpty(params string[] text)
        {
            //loop through the text things
            foreach (var textThingy in text)
            {
                //if the text is null or empty return true
                if (string.IsNullOrEmpty(textThingy))
                    return true;
            }

            return false; //if none of them raise a positive; return false
        }
    } 
}
