using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi kısmı boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola kısmı boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapın.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter olacak şekilde giriş yapınız.");
            RuleFor(x => x.WriterPassword).Matches(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*").WithMessage("test");
            RuleFor(x=> x.WriterPassword).Equal(x=> x.ConfirmPassword).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
