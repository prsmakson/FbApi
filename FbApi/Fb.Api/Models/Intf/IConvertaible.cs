using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models.Intf
{
	interface IConvertaible<T>
	{
		public T Convert();
	}
}
