﻿using System;

namespace AjedrezSimple {
	public abstract class Pieza {
		protected int x;
		protected int y;
		protected Ajedrez juego;

		public enum ColorPieza {
			Ninguna = -1,
			Blanco = 0,
			Negro = 1,
		}

		public Pieza(int x, int y, ColorPieza color, Ajedrez juego) {
			this.x = x;
			this.y = y;
			this.Color = color;
			this.juego = juego;
		}

		public Pieza(Pieza origen) {
			this.x = origen.x;
			this.y = origen.y;
			this.Color = origen.Color;
			this.juego = origen.juego;
			this.Nombre = origen.Nombre;
			this.Ícono = origen.Ícono;
		}

		public int X {
			get { return this.x; }
		}

		public int Y {
			get { return this.y; }
		}

		public ColorPieza Color { get; private set; }

		public ColorPieza ColorContrario {
			get {
				if(this.Color == ColorPieza.Blanco)
					return ColorPieza.Negro;

				if(this.Color == ColorPieza.Negro)
					return ColorPieza.Blanco;

				return ColorPieza.Ninguna;
			}
		}

		public string Ícono { get; protected set; }

		public string Nombre { get; protected set; }

		public bool Mover(int destinoX, int destinoY) {
			Movimiento movimiento = new Movimiento(this.x, this.y, destinoX, destinoY);

			if(!this.PuedeMover(movimiento))
				return false;

			this.Registrar(movimiento);
			this.x = destinoX;
			this.y = destinoY;
			return true;
		}

		public Registro Registrar(Movimiento movimiento) {
			Registro registro = new Registro(this, movimiento, this.juego);

			this.juego.Registrar(registro);

			return registro;
		}

		public static string ANotación(int x, int y) {
			return $"{(char)('a' + x)}{1 + y}";
		}

		public static int[] APosición(string notación) {
			return new int[2] {
				Convert.ToInt32((notación.ToLower()[0] - 'a').ToString()),
				Convert.ToInt32(notación[1].ToString()) - 1,
			};
		}

		protected bool AnalizarCamino(Movimiento movimiento) {
			if(this.juego.Colisiones(this.x, this.y, movimiento).Length > 0)
				return false;

			return this.AnalizarDestino(movimiento);
		}

		protected bool AnalizarDestino(Movimiento movimiento) {
			Pieza piezaDestino = this.juego[movimiento.DestinoX, movimiento.DestinoY];

			if(piezaDestino.Color == this.Color)
				return false;

			if(piezaDestino.Color == this.ColorContrario)
				movimiento.Captura = piezaDestino;

			return true;
		}

		public abstract bool PuedeMover(Movimiento movimiento);

		public override string ToString() {
			return $"{this.Ícono} ({ANotación(this.x, this.y)})";
		}
	}
}
