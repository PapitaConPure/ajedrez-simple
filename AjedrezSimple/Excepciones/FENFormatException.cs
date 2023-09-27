using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjedrezSimple {
	class FENFormatException: FormatException {
		public FENFormatException(): base("No se pudo decodificar la notación FEN ingresada porque tenía un formato inválido") {}
	}
}
