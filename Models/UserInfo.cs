using System.ComponentModel.DataAnnotations;

namespace HomeWorkMVC1.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage = "Введите ваше ФИО")]
        [MaxLength(60, ErrorMessage = "Длинна не должна превышать 60 символов")]
        public string Name { get; set; }


        [Range(1, 100, ErrorMessage = "Недопустимый возраст ")]
        public int Age { get; set; }

        [Required(ErrorMessage = "ВВедите ваш пол ")]
        public string Sex { get; set; }



        public override string ToString()
        {
            return $"UserName: {Name}, Age: {Age},Sex: {Sex}";
           
        }





    }
}
