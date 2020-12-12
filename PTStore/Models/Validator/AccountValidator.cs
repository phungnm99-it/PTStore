using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTStore.Models.Validator
{
	public class AccountValidator : AbstractValidator<Account>
	{
		public AccountValidator()
		{
			//RuleFor(x => x.TenDangNhap).NotNull();
			RuleFor(x => x.TenDangNhap).NotEmpty().WithMessage("Tên đăng nhập không được để trống!");
			RuleFor(x => x.MatKhau).Length(8, 255).WithMessage("Mật khẩu phải lớn hơn 8 kí tự!");
		}
	}
}
