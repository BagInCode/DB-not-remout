using System;
using System.Collections.Generic;
using System.Text;

namespace DBMS.src
{
    public static class TypesValidator
    {
        private static readonly string pngExtension = ".png";
        public static bool IsValidValue(string customTypeName, string value)
        {
            switch (customTypeName)
            {
                case "Integer":
                    return ValidateInteger(value);

                case "Real":
                    return ValidateReal(value);
                
                case "Char":
                    return ValidateChar(value);

                case "String":
                    return ValidateString(value);

                case "StringInvl":
                    return ValidateStringInvl(value);

                case "CharInvl":
                    return ValidateCharInvl(value);

                default:
                    return false;
            }
        }

        private static bool ValidateChar(string value)
        {
            char buf;
            if (char.TryParse(value, out buf))
            {
                return true;
            }
            return false;
        }

        private static bool ValidateInteger(string value)
        {
            int buf;
            if (int.TryParse(value, out buf))
            {
                return true;
            }
            return false;
        }

        private static bool ValidateReal(string value)
        {
            double buf;
            if (double.TryParse(value, out buf))
            {
                return true;
            }
            return false;
        }


        private static bool ValidateString(string value)
        {
            return true;
        }

        private static bool ValidateCharInvl(string value)
        {
            var sidesOfInterval = value.Split(':');
            if (sidesOfInterval.Length != 2)
            {
                return false;
            }
            char leftSide;
            char rightSide;
            if (!char.TryParse(sidesOfInterval[0], out leftSide))
            {
                return false;
            }
            if (!char.TryParse(sidesOfInterval[1], out rightSide))
            {
                return false;
            }
            if (rightSide.CompareTo(leftSide) < 0)
            {
                return false;
            }
            return true;
        }

        private static bool ValidateStringInvl(string value)
        {
            var sidesOfInterval = value.Split(';');

            if (sidesOfInterval.Length == 0)
            {
                return false; 
            }

            foreach (string _value in sidesOfInterval)
            {
                if(!ValidateCharInvl(_value))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
