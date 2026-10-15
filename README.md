# FDV-Fisicas-2627

## Ejercicio 1

El ejercicio consiste en experimentar con diferentes configuraciones de los components Rigidbody y Collider y explicar los resultados obtenidos en base a lo explicado en clase. Para ello vamos a configurar una escena con 3 objetos: Plano, Cubo y Esfera.

### Situación 1

***El plano no es un objeto físico. El cubo es un objeto físico y la esfera no. En este caso, el plano y la esfera sólo tendrán collider, mientras que el cubo debe tener Rigidbody.***

El cubo se posa sobre el plano, que se queda inmóvil, mientras que la esfera se encuentra inmóvil flotando en el aire.

### Situación 2

***El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody.***

El cubo se posa sobre el plano, que se queda inmóvil, mientras que la esfera cae sobre el cubo y rebota, rodando por el plano hasta caer al vacío.

### Situación 3

***El plano no es un objeto físico. El cubo es un objeto físico y la esfera es cinemática. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody esta última cinemático.***

El cubo se posa sobre el plano, que se queda inmóvil, mientras que la esfera se mantiene inmóvil flotando en el aire, es un objeto físico, pero al ser cinemática no reacciona a la gravedad ni a las colisiones.

### Situación 4

***El plano es un objeto físico. El cubo es un objeto físico y la esfera es física. En este caso, todos los objetos deben tener Rigidbody.***

Todos los objetos caen al vacío, incluyendo el plano, que al ser un objeto físico también reacciona a la gravedad y cae.

### Situación 5

***El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 10 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.***

Igual que el caso anterior, todos los objetos caen al vacío con la misma aceleración, debido a que caen en el vacío y no hay fricción, la masa de la esfera resulta irrelevante. Pero si el plano fuese estático, la esfera caería sobre el cubo y lo golpearía con más fuerza que en la situación 4.

### Situación 6

***El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 100 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.***

Ocurre lo mismo que en la situación 5, todos los objetos caen al vacío con la misma aceleración, debido a que caen en el vacío y no hay fricción, la masa de la esfera resulta irrelevante. Pero si el plano fuese estático, la esfera caería sobre el cubo y lo golpearía con mucha más fuerza.

### Situación 7

***El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con fricción. En este caso, todos los objetos deben tener Rigidbody.***

Todos los objetos caen al vacío con la misma aceleración, debido a que caen en el vacío y no hay fricción, la fricción de la esfera resulta irrelevante. Si la esfera rodase por el plano, rodaría a menor velocidad y tardaría más en caer al vacío, incluso puede que no llegase al borde del plano.

### Situación 8

***El plano es un objeto físico. El cubo es un objeto físico y la esfera no es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.***

La esfera no interactúa con el resto de los objetos, ya que es un Trigger. Cualquier objeto que colisionase con la esfera la atravesaría, ya que carece de colisión física, pero se podría activar un evento como `OnTriggerEnter`.

### Situación 9

***El plano es un objeto físico. El cubo es un objeto físico y la esfera es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.***

Siendo un objeto Trigger y teniendo físicas, respondería a las reglas físicas como la gravedad, pero en el caso de colisionar con algún objeto, simplemente lo atravesaría, ya que no tiene colisión física.

## Ejercicio 2

Crea un controlador con las flechas arriba-abajo, derecha-izquierda que controle al cilindro con físicas.

