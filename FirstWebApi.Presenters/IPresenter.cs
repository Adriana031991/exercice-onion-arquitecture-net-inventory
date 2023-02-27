using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.Presenters
{
	public interface IPresenter<FormatDataType>
	{
		//proporcia informacion o expone el resultado en el formato que le pidan🤴🏻
		public FormatDataType Content { get; }
	}
}
