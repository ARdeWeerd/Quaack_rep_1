using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quaack_domein.model
{
    public class Result
    {
        private ResultCode code;         
                
        public Result(ResultCode code)
        {
           this.code = code;
        }

        public string getMessage()
        {
            string message = "";
            switch (this.code)
            {
                case ResultCode.SUCCES:
                    message = "Succes";
                    break;
                case ResultCode.USERID_NOT_UNIQUE:
                    message = "Gebruikersnaam bestaat reeds";
                    break;
                default:
                    message = "Onbekende fout opgetreden";
                    break;
            }
            return message;
        }

        public static Result newResultSucces()
        {
            Result result = new Result(ResultCode.SUCCES);
            return result;

        }

    }
}
