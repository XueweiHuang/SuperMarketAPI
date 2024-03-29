using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Supermarket.API.Extensions
{
    public static class ModelStateExtensions
    {
        public static List<string> GetErrorMessage( this ModelStateDictionary dictionary)
        {
            return dictionary.SelectMany(d => d.Value.Errors).Select(d =>d.ErrorMessage).ToList();
        }
    }
}