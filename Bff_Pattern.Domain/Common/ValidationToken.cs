using Microsoft.AspNetCore.Authorization;

namespace Bff_Pattern.Domain.Common
{
    public class ValidationToken : Attribute
    {
        public bool isValid(string _token)
        {
            if(_token != null && _token == "Silvathiago2005") 
            {
                return true; 
            }

            return false;
        }

        
    }
}
