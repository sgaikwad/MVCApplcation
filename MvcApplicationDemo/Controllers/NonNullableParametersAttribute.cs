using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationDemo.Controllers
{
    public class NonNullableParametersAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo)
        {
            var methodParams = methodInfo.GetParameters();

            foreach (var parameterInfo in methodParams)
            {
                if (parameterInfo.HasDefaultValue)
                {
                    continue;
                }

                var paramType = parameterInfo.ParameterType;
                if (!IsSimpleType(paramType))
                {
                    continue;
                }

                var value = controllerContext.Controller.ValueProvider.GetValue(parameterInfo.Name);
                if (value == null || value.AttemptedValue == null || !CanParse(value.AttemptedValue, paramType, value.Culture))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsSimpleType(Type t)
        {
            return t.IsPrimitive || t.IsEnum || t == typeof(Decimal) || t == typeof(DateTime) || t == typeof(Guid);
        }

        private static bool CanParse(object rawValue, Type destinationType, IFormatProvider formatProvider)
        {
            try
            {
                var test = Convert.ChangeType(rawValue, destinationType, formatProvider);
                return test != null;
            }
            catch
            {
                return false;
            }
        }
    }
}