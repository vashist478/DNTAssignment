using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation_Assignment1.Attributes
{
    public class ValidateCheckBoxAttribute : ValidationAttribute,IClientModelValidator
    {

        /// <summary>
        /// SK: client side validation for boolean type Eg. Checkobx
        /// </summary>
        /// <param name="context"></param>
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-validatecheckbox",ErrorMessage);
        }
        /// <summary>
        /// SK: server side validation for boolean type Eg. Checkobx
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            //return (bool)value;
            //or
            if((bool)value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
