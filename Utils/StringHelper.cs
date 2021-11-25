using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace lioncs.Utils
{
    public class  StringHelper
    {
        public static bool hasText(string str){
            return str != null && str.Trim().Length > 0;
        }

        public static bool isEmpty(string str)
        {
            return !hasText(str);
        }

        public static string removeSpaces(string str)
        {
            string result  = str;
            if (hasText(str))
            {
                result =  str.Trim().Replace(" ", "");
            }
            return str;
        }

        public static string removeNonNumbers(string str)
        {
            string result = str;
            if (hasText(str))
            {
                result = Regex.Replace(str, "[^0-9]", "");
            }
            return result;
        }

        public static bool isDate(string date)
        {
            try
            {
                DateTime.Parse(date);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool isAllNumbers(String text)
        {
            //make sure no blanks
            if (isEmpty(text) || text.Contains(' '))
            {
                return false;
            }
            int x = 0;
            return Int32.TryParse(text,out x);
        }

          public static bool isValidEmailAddress(string emailAddress)
        {
              if(isEmpty(emailAddress)){
                  return false;
              }
            var foo = new EmailAddressAttribute();
            return foo.IsValid(emailAddress);
        }

          public static string formatPhoneNumber(string number)
          {
              string result = number;
              if (number != null && StringHelper.hasText(number))
              {
                  string temp = number;
                  //eliminate all other characters
                  temp = StringHelper.removeSpaces(temp);
                  temp = StringHelper.removeNonNumbers(temp);
                  //check that there is 10 digits
                  if (temp.Length == 10)
                  {
                      temp = temp.Insert(0, "(");
                      temp = temp.Insert(4, ")");
                      temp = temp.Insert(5, " ");
                      temp = temp.Insert(9, "-");
                      result = temp;
                  }

              }
              return result;
          }
          public static string prependIfNeeded(string currentText, string valueToPrepend)
          {
              if (hasText(currentText))
              {
                  currentText += valueToPrepend;
              }
               
            return currentText;
        }
          public static string prependIfNeededAndAdd(string currentText, string valueToPrepend, string additionalText)
          {
              return prependIfNeeded(currentText, valueToPrepend) + additionalText;
          }

          public static string textToShowIfNull(string currentText, string showIfNull)
          {
              return hasText(currentText) ? currentText : showIfNull;
          }
    }
}
