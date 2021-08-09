using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaYRestaMatricezAlgebraLineal
{
	class Matriz
	{
		public static byte fila {get;private set;}
		public static byte columna {get;private set;}
		public int[,] matriz { get; private set; }
		private StringBuilder _string = new StringBuilder();
		public Matriz(byte orden)
		{
			fila = columna = orden;
			matriz = new int[orden, orden];
			llenado(orden, orden);
		}
		public Matriz(byte filas, byte columnas)
		{
			fila = filas;
			columna = columnas;
			matriz = new int[fila, columna];
			llenado(filas, columnas);
		}

		public Matriz(int[,] _matriz)
		{
			matriz = _matriz;
		}

		private void llenado(byte filas, byte columnas)
		{
			for (int columna = 0; columna < columnas; columna++)
			{
			for (int fila = 0; fila < filas; fila++)
				{
					Random aleatorio = new Random(int.Parse (new string(Guid.NewGuid().ToString().Where(x => char.IsDigit(x)).ToArray())[0..5]));
					matriz[fila, columna] = aleatorio.Next(0, 20);
				}
			}
		}
	


		public override string ToString()
		{
				for (int c = 0; c < columna; c++)
			{
				_string.Append("| ");
			for (int f = 0; f < fila; f++)
				{
					_string.Append(matriz[f, c]+((matriz[f, c] > 9) ? " | ": "  | "));
				}
				_string.Append("\n");
			}
			return _string.ToString();
		}

		public int[,] ToMatriz()
		{
			int[,] _valores = new int[fila, columna];
			for (int c = 0; c < columna; c++)
			{
				for (int f = 0; f < fila; f++)
				{
					_valores[f,c] =  matriz[f, c];
				}
			}
			return _valores;
		}
		public static Matriz operator +(Matriz a, Matriz b)
		{
			int[,] _newMatriz = new int[fila, columna];
			for (int c = 0; c < columna; c++)
			{
				for (int f = 0; f < fila; f++)
				{
					_newMatriz[f,c] = a.ToMatriz()[f,c] + b.ToMatriz()[f, c];
				}
			}
			return new Matriz(_newMatriz);
		}
	}
}
