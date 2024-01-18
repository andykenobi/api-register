using FluentValidation.Results;

namespace ApiRegister.DTOs
{
    public class Response<T>
    {
        public List<string> Errors { get; set; } = new List<String>();
        public T? Value { get; set; }

        public Response() { }

        public Response(T value)
        {
            Value = value;
        }

        public Response(List<string> errors)
        {
            Errors = errors;
        }

        public void AddErrors(List<ValidationFailure> errors)
        {
            foreach (var error in errors)
            {
                this.Errors.Add(error.ErrorMessage);
            }
        }
    }
}
