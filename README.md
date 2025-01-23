Tres en Raya

Este es un sencillo juego de Tres en Raya (Tic-Tac-Toe) desarrollado en C# para jugar en la consola. Permite que dos jugadores se turnen para colocar sus fichas (X y O) en un tablero de 3x3 hasta que haya un ganador o se produzca un empate.

Cómo jugar

Al ejecutar el programa, se mostrará el tablero vacío con las posiciones numeradas del 1 al 9.

El jugador 1 (X) comienza eligiendo una casilla introduciendo un número del 1 al 9.

Luego, el jugador 2 (O) elige su casilla de la misma manera.

El juego continuará alternando turnos hasta que un jugador logre alinear tres fichas seguidas (horizontal, vertical o diagonal) o se llene el tablero sin un ganador, resultando en empate.

Cuando termine la partida, se ofrecerá la opción de jugar nuevamente o salir del juego.

Instalación

Para ejecutar este proyecto en tu máquina local:

Asegúrate de tener instalado Visual Studio con soporte para C#.

Descarga o clona este repositorio:

https://github.com/jimgza97/Actividad-1-Progra-Videojuegos-2939586

Abre el proyecto en Visual Studio.

Compila y ejecuta el proyecto presionando Ctrl + F5.

Funcionamiento del código

Inicialización:

Se crea un tablero representado por un array de caracteres.

Se asigna el turno al jugador 1.

Flujo del juego:

Se muestra el tablero.

Se solicita la casilla al jugador actual.

Se verifica si hay un ganador o empate.

Se cambia de turno.

Condiciones de victoria:

Se verifica si hay tres fichas consecutivas en filas, columnas o diagonales.

Requisitos del sistema

.NET Core o .NET Framework compatible.

Consola de comandos para ejecutar el programa.
