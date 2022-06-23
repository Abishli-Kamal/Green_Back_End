using System.ComponentModel.DataAnnotations;

namespace Green_Back_End.View_models
{
    public class RegisterVM
    {
        [Required, StringLength(maximumLength: 20)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string SurName { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string UserName { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required ,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType (DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
