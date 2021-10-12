using Entity.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Yazar adı en az 3 karakter olmalıdır");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Yazar adı en fazla 20 karakter olmalıdır");

            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı en az 2 karakter olmalıdır");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Yazar soyadı en fazla 20 karakter olmalıdır");

            RuleFor(x => x.WriterPassword).MinimumLength(10).WithMessage("Yazar şifresi en az 10 karakter olmalıdır");
            RuleFor(x => x.WriterPassword).MaximumLength(30).WithMessage("Yazar şifresi en fazla 30 karakter olmalıdır");


            //RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Yazar resmi boş bırakılamaz");



        }
    }
}
