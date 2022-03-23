*PUNTO DE PARTIDA*

Como comienzo contamos con una escena de Unity con un escenario divido 
en las salas planteadas por el enunciado. Y distribuidos por este se encuentran: 

Ya esta implementado en la maquina de estados de la cantante algunos de sus comportamientos. Esta cantando en el escenario,
y después, se mueve hasta las bambalinas para descansar, para que mas tarde vuelva al escenario 
y comience el ciclo de nuevo. Además la cantante tiene algunos comportamientos implementados, aunque todavía no introducidos en la máquina de estados,
como comprobar si reconoce la sala en la que se encuentra, comprobar si está encerrada en la celda, 
y merodear cogiendo posiciones aleatorias en el mapa.

El fantasma tiene un árbol de comportamientos, pero ninguno de sus comportamientos está todavía definido.

El jugador tiene un control jugador que le permite moverse con el cualquiera de los dos botones del ratón.
Además, al pulsar la tecla E o Q, realiza una animación de "uso", y al pulsar el espacio una de "ataque", la cual tiene 
tiempo de espera hasta usarla de nuevo. Cada uno de ellos activa un objeto vacio distinto, los cuales se llaman:
AreaUso, AreaCaptura y AreaAtaque. Uno de ellos, el AreaUso, le permite realizar acciones únicas como 
tocar el piano, tirar de la palanca que sube o baja las lámparas o tocar la puerta.

En el sótano, se necesita de unas barcas para moverse entre ellos, cuyo comportamiento ya está implementado,
y funciona a través de triggers. Al entrar en contacto con el trigguer, el jugador si montará en la barca y será llevado
al otro lado si esta se encuentra en el mismo lado del canal que ella, en caso contrario la barca se moverá hacia ese lado del canal.

Antes he mencionado que el jugador podrá interactuar con el piano, esto hará que este suene, y solo podrá ser desactivado 
por el fantasma.

La puerta de la celda también se abrirá a través de una palanca, esta hará que suba y baje la puerta.

Hay un público que esta escuchando a la cantante, estos huirán al vestíbulo cuando una de las lámparas caiga, 
y volverán una vez se hayan vuelto a subir.

Por último el fantasma, que aunque no tenga ningún comportamiento asociado actualmente al 
árbol de comportamientos, estos están ya implementados. Para empezar, tiene un comportamiento que 
consiste en moverse hasta la posición de la cantante, otra que consiste en llevar a la cantante hasta la prisión 
y cerrar la puerta, otra para apagar el piano. Tiene un comportamiento que le impide entrar en el escenario si hay 
público observando, e hilado con esto, puede tirar las lámparas para asustarles. Y por último, tiene un comportamiento 
de movimiento aleatorio, y otros de movimiento a salas especificas, como  a las bambalinas, o al escenario.

