# Práctica 13/11/2018

Se realizó la importación del atlas de sprites, del cual se utilizo el método automático para la división de sprites. Se corrigieron algunas imperfecciones resultantes y se ajusto el **Pixel per Unit** a 65.

Se procedió a continuación, a crear las diferentes animaciones del personaje *stand*, *sit* y *walking* en los distinto colores.

Una vez creado todos las animaciones se procedió a crear composición de animaciones. Que siguen la lógica propuesta de cambio de color.

![](./animation_screen.png)

Se creo un *grid* cuadrado para el escenario. y la paleta se creo a partir de diversos sprites del atlas

![](./tile_pallete.png)

Se cambiaron el input del personaje para ajustarse a lo requerido con i,j,k,l

![](./input_settings.png)

Se ajustaron las propiedades del perro y se enlazaron los scripts adecuados a él.

![](./dog_properties.png)


El juego en acción.
![](./game.gif)

El *DogController.cs* maneja toda la lógica del perro, cambia las animaciones, le falta evento de OnEat con su delegate apropiado para el script *JumperDog.cs* que iría asociado al perro rosa.

*LifeRemover.cs* y *BoneAction.* se han asociado a la caquita y a los huesos. Son los componentes a buscar dentro del trigger, para cambiar entre animaciones.

*ReachingHome.cs* Se le ha asociado a la casa y terminaría el juego, si no se corriese dentro del editor.

*BeeFlying.cs* Fue un intento de generar movimientos aleatorios dentro de una zona, cada cierta cantidad de segundos.