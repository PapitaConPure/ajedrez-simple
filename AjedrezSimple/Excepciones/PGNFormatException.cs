using System;

namespace AjedrezSimple {
	class PGNFormatException: FormatException {
		public PGNFormatException(): base("No se pudo decodificar la notación PGN ingresada porque tenía un formato inválido") {}
	}
}
