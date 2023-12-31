# Ajedrez Simple
Una aplicación de Ajedrez sencilla para practicar herencia y polimorfismo en C#.

![Demostración de Juego](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Muestras/muestra1.gif)

![Mate del Pastor](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Muestras/muestra2.gif)

![Apertura](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Muestras/muestra3.gif)

![Tablas](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Muestras/muestra4.gif)

![Promoción](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Muestras/muestra5.gif)

## Tecnologías
* .NET Framework 4.7.2
* WhiteStarUML 5.9.1.0

##  Notaciones
### Posición de Tablero
Se puede inicializar un tablero bajo cualquier distribución que se desee utilizando la [Notación Estándar Forsyth–Edwards](https://en.wikipedia.org/wiki/Forsyth%E2%80%93Edwards_Notation).
```cs
//Estado inicial estándar de un tablero de Ajedrez
Ajedrez juego = new Ajedrez("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
```
Las barras diagonales separan filas.
Los números indican una cantidad de espacios en blanco del 1 al 8.
Las letras indican piezas de Ajedrez individuales, siendo blancas si son mayúsculas o negras si son minúsculas. La pieza en particular es determinada por la letra.
* Torre/**R**ook "`Rr`"
* Caballero/K**n**ight "`Nn`"
* Alfil/**B**ishop "`Bb`"
* Reina/**Q**ueen "`Qq`"
* Rey/**K**ing "`Kk`"
* Peón/**P**awn "`Pp`"

### Movimientos
Los métodos `Notación()` y `ToString()` de la clase `Registro` utilizan la versión con íconos de la [Notación Algebraica Estándar](https://en.wikipedia.org/wiki/Algebraic_notation_(chess)) para describir movimientos.
Esto significa que en lugar de usar las letras significativas de cada pieza, se las representa con su Emoji.

## Planificación
**Primera versión correcta del diagrama UML**
![UML 1](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Planificación/v1.jpg)

**Primera revisión, con clase Registro y movimientos especiales**
![UML 2](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Planificación/v2.jpg)

**Segunda revisión, con simulaciones de Movimientos y Finalizaciones de Partida**
![UML 3](https://github.com/PapitaConPure/ajedrez-simple/blob/main/Planificación/v3.jpg)

## Tareas
* [X] Implementar detección básica de movimientos válidos
* [X] Implementar colisiones
* [X] Implementar turnos
* [X] Implementar Captura _En-Passant_ (Peón al Paso) para la clase Peón
* [X] [Implementar Enroque Corto y Enroque Largo para la clase Rey](https://github.com/PapitaConPure/ajedrez-simple/issues/1)
* [X] [Implementar Promoción para la clase Peón](https://github.com/PapitaConPure/ajedrez-simple/issues/2)
* [X] [Implementar Jaque y Jaque Mate](https://github.com/PapitaConPure/ajedrez-simple/issues/3)
* [X] [Implementar Empate por Rey Ahogado](https://github.com/PapitaConPure/ajedrez-simple/issues/4)
* [X] Implementar Empate por Insuficiencia Material
* [ ] Implementar Empate por Acuerdo
* [ ] Implementar Reproductor de Partidas

## Desarrolladores
* [@PapitaConPuré](https://github.com/PapitaConPure)
