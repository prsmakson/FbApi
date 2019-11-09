using System;
using System.Collections.Generic;
using System.Text;

namespace Fb.Api.Models.Intf
{
	public interface IFacebook<T>
	{
		public void SetObjectToFacebook();
		public T GetObjectFromFacebook(string id);
	}
}
