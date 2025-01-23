using System;

class TresEnRaya
{
    // Arreglo que representa el tablero de juego
    static char[] tablero = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    static int jugador = 1; // 1 - jugador 1 (X), 2 - jugador 2 (O)
    static int eleccion; // La casilla elegida por el jugador
    static bool juegoActivo = true;

    public static void Main(string[] args)
    {
        do
        {
            InicializarJuego();
            MostrarTablero();

            while (juegoActivo)
            {
                TurnoJugador();
                MostrarTablero();
                VerificarGanador();
                CambiarJugador();
            }

            if (juegoActivo)
            {
                Console.WriteLine("\u00a1Es un empate!");
            }

            Console.WriteLine("\u00bfQuieres jugar de nuevo? (s/n)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            {
                break;
            }
        } while (true);
    }

    // Inicializa el tablero para una nueva partida
    static void InicializarJuego()
    {
        tablero = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        juegoActivo = true;
    }

    // Muestra el estado actual del tablero en la consola
    static void MostrarTablero()
    {
        Console.Clear();
        Console.WriteLine("Jugador 1 (X) vs Jugador 2 (O)");
        Console.WriteLine("Tablero:");
        Console.WriteLine(" {0} | {1} | {2} ", tablero[1], tablero[2], tablero[3]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", tablero[4], tablero[5], tablero[6]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", tablero[7], tablero[8], tablero[9]);
    }

    // Maneja la lógica de entrada del turno del jugador
    static void TurnoJugador()
    {
        Console.WriteLine("Jugador " + jugador + ", elige un número de 1 a 9 para colocar tu ficha.");
        if (int.TryParse(Console.ReadLine(), out eleccion) && eleccion >= 1 && eleccion <= 9 && tablero[eleccion] == ' ')
        {
            tablero[eleccion] = (jugador == 1) ? 'X' : 'O';
        }
        else
        {
            Console.WriteLine("\u00a1Casilla no válida! Intenta de nuevo.");
            TurnoJugador();
        }
    }

    // Verifica si hay un ganador o empate
    static void VerificarGanador()
    {
        int[,] combinacionesGanadoras = new int[,]
        {
            { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, // Filas
            { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 }, // Columnas
            { 1, 5, 9 }, { 3, 5, 7 } // Diagonales
        };

        for (int i = 0; i < combinacionesGanadoras.GetLength(0); i++)
        {
            if (tablero[combinacionesGanadoras[i, 0]] != ' ' &&
                tablero[combinacionesGanadoras[i, 0]] == tablero[combinacionesGanadoras[i, 1]] &&
                tablero[combinacionesGanadoras[i, 1]] == tablero[combinacionesGanadoras[i, 2]])
            {
                MostrarTablero();
                Console.WriteLine("\u00a1Jugador " + jugador + " gana!");
                juegoActivo = false;
                return;
            }
        }

        if (!Array.Exists(tablero, element => element == ' '))
        {
            juegoActivo = false;
        }
    }

    // Cambia el turno de jugador
    static void CambiarJugador()
    {
        jugador = (jugador == 1) ? 2 : 1;
    }
}
