using FluentValidation;
using FluentValidation.Results;


namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidationTool<T>
    {
        public static void Validate(IValidator<T> validator, T obj)
        {
            ValidationResult result = validator.Validate(obj);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
        }


        //private IValidator _iv;
        //private T _obj;
        //public ValidationTool(IValidator<T> validator, T obj)
        //{
        //    _iv = validator;
        //    _obj = obj;


        //        //ValidationResult result = _iv.Validate(_obj);

        //}



    }
}
