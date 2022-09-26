using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı ve soyadı kısmı boş geçilemez.");
            RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("E-posta kısmı boş geçilemez.");
            RuleFor(p => p.WriterEmail).Matches(@"[@,.]+").WithMessage("E-posta adresi @ ve . içermelidir");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola kısmı boş geçilemez.");
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Parola en az 1 büyük harf içermelidir.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Parola en az 1 küçük harf içermelidir.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Parola en az 1 rakam içermelidir.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı ve soyadı en az 2 karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı ve soyadı en fazla 50 karakter olmalıdır.");

        }
    }
}
