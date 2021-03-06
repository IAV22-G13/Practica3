**RESUMEN ENUNCIADO**

En esta práctica vamos a ver la toma de decisiones de agentes inteligentes mediante máquinas
de estados como de árboles de comportamientos, centrándonos en el comportamiento del fantasma
de al ópera.

    -Patio de butacas(P): Estancia inicial del público, dividida en dos. Una lámpara a cada lado.
    -Vestíbulo(V): Zona a la que huye el público cuando cae la lámpara
    -Escenario(E): Estancia inicial de la cantante y el fantasma no puede acceder mientras haya público 
     observando.
    -Bambalinas(B): Estancia donde descansa la cantante.
    -Palco Oeste(Po): Estancia inicial del vizconde. Con una palanca para dejar caer la lámpara.
    -Palco este(Pe): Estancia opuesta al otro palco. Cuenta con la palanca de la otra lámpara.
    -Sótano oeste(So): Puerto para la barca y palanca para llamarla.
    -Sótano este(Se): Palancas para las dos barcas que llegan a esta sala.
    -Celda(C): Estancia donde el fantasma pretende llevar a la cantante. Cuenta con rejas activables
     por fantasma y vizconde.
    -Sótano norte(Sn).
    -Sala de música(M): Estancia inicial del fantasma

Contenidos requeridos para la práctica:

    -Mostrar el entorno virtual, con esquema de división de navegación de Unity, ubicando todos los
     elementos descritos.
    -Cámaras que sigan a los personajes y otra con vista general.
    -El público huye cuando cae la lámpara de su lado, y vuelve a sentarse cuando se repara.
    -Cantante como agente inteligente mediante máquina de estados:
        *Sale al escenario para tocar y vuelve a las bambalinas cuando termina.
        *Puede ser llevada por los otros personajes.
        *Se desorienta en las estancias subterráneas, moviéndose aleatoriamente.
        *Se deja llevar por el vizconde si este está cerca.
        *Percepción, navegación y movimiento sencillos, decisión mediante máquina de estados.
    -Fantasma como agente inteligente con árbol de comportamiento:
        *Busca a la cantante, primero en escenario y bambalinas. Si no está, busca por el resto.
        *Tira lámparas.
        *Capture a la cantante.
        *La deje en la celda.
        *Puede soltar a la cantante cuando quiera o si es atacado pore el vizconde.
        *Active las rejas.
        *Sistema de gestión sensorial para que reaccione realmente a lo que ve y oye, sin usar información.
         privilegiada, solo lo que recuerda haber visto.
        *No entra al palco si hay gente mirando.
        *Con la cantante atrapada, utiliza el camino más corto hasta la celda.
        *Cuando captura a la cantante se vuelve a la sala de música hasta que la vuelva a escuchar cantar.
        *Si lleva a la cantante pero escucha su piano, la soltará y volverá a la sala de música a arreglar 
         el piano.
    -Vizconde:
        *Movimiento libre controlado con cursores.
        *Tecla para interactuar con palancas, muebles, arreglar lámparas caidas y agarrar/soltar a la cantante.
        *Usar barcas.        

Restricciones

    -Utilizar plugins Bolt y Behavior Designer.
    -Documentar los algoritmos, eurística o ¨trucos¨ utilizados.
    -Programar de forma limpia y elegante.
    -Evitar el uso de recursos audiovisuales ajenos o pesados.

Extras:

    -Escenario con geometría compleja, portales que unen zonas y saltos en la malla de navegación.
    -Escenario más complejo(puestas con botones, puertas giratorias, ascensores, rampas con temporizador, etc.).
    -Mejorar razonamiento del fantasma sobre el estado y la posición de barcas, cantante y vizconde.
    -Mejorar la gestión sensorial, haciendo que oiga sin estar en la misma sala, con realimentación visual para
     que quede claro.
    -Plantear incluir varios fantasmas y cantantes.
    .Plantear un cargador de niveles desde fichero.

**PUNTO DE PARTIDA**

Como comienzo contamos con una escena de Unity con un escenario divido 
en las salas planteadas por el enunciado. Y distribuidos por este se encuentran: 

Ya esta implementado en la maquina de estados de la cantante algunos de sus comportamientos. Esta cantando en el escenario,
y después, se mueve hasta las bambalinas para descansar, para que mas tarde vuelva al escenario 
y comience el ciclo de nuevo. Además la cantante tiene algunos comportamientos implementados, aunque todavía no introducidos en la máquina de estados,
como comprobar si reconoce la sala en la que se encuentra, comprobar si está encerrada en la celda, 
y merodear cogiendo posiciones aleatorias en el mapa.

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

**COMPORTAMIENTOS A AÑADIR**

Máquina de estados de la cantante:

![Máquina de estados de la cantante](./P3/CantanteStateMachine.png)

Arbol de comportamiento del fantasma:

![Árbol de comportamiento del fantasma](./P3/GhostBehaviourTree.png)

**IMPLEMENTACIÓN FINAL**

Se han añadido diversos comportamientos neceserarios.

Captura de la cantante por parte del jugador:

- Se ha creado el script capture y modificado el player para que haga lo siguiente:
    
    OnTriggerEnter() //trigger de captura activado al pulsar la tecla q
    {
        if (otro objeto es la cantante)
            capturarCantante();
    }

    en script Player:

    capturarCantante(){  //hace hija del jugador y la captura, o si ya esta capturada, la suelta.
        if (!cantante.capturada){
            cantante.setParent() = jugador;
            cantante.capturada = true,
        }
        else {
            cantante.setParent() = null;
            cantante.capturada = false,
        }
        
    }

- Se ha creado el script attack y modificado el player para que haga lo siguiente:
    
    OnTriggerEnter() //trigger de ataque activado al pulsar la tecla espacio
    {
        if (otro objeto es el fantasma)
            attackGhost();
    }

    en script Player:

    attackGhost(){  //hace hija del jugador y la captura, o si ya esta capturada, la suelta.
        ghostHitted = true; //desde el arbol se comprueba si ha sido pegado.    
    }

- Se han modificado ligeramente los scripts control palanca y público:
    
    En control palanca ahora al tirar y subir las lamparas se especifica cual de las dos esta siendo modificada

    En público, a través del editor se informa que lampara es la que se encuentra encima suya, y cuando cae esa lampara, y no la otra, se
    va solo la mitad del público correspondiente.

    Además el fantasma en el componente GhostPalancaAction, va primero a por la palanca más cercana, y después a por la más lejana, y hasta que ambas lamparas esten caidas no da la tarea por terminada.

- Se han añadido algunos comportamientos al fantasma: 

    + PianoHittedCondition comprube si el piano está roto

    + GhostRepairAction que permite arreglar el piano, tiene el siguiente pseudoCódigo:

        agent.SetDestination(piano) //se mueve hasta el piano
            if (ha llegado hasta el piano)
            {
                roto = false
                Tarea resuelta
            }       
            continuar tarea

    + GhostIsHittedCondition comprueba si le han golpeado

    + RecoverHit para recuperarse cuando le ha golpeado el vizconde

    + GhostListenSingerCondition que comprueba si puede escuchar a la cantante

    + GhostLetSingerAction libera a la cantante, el codigo es:

        cantante.setParent = null;
        cantante.capturada = false;
        Tarea resuelta

    + VisionSingerInBackStageCondition comprueba que la cantante este en las bambalinas.

    + GhostComponingAction, hasta que el fantasma vuelva a escuchar a la cantante, se queda componiendo en el piano (toca una tecla cada poco tiempo), esta programado asi:

        if(cantante.cantando)
                Tarea resuelta;

        agent.SetDestination(piano);
        timer -= tiempo que ha pasado;
        if (estas en el piano, y ha pasado un timepo, toca el piano)
        {
            timer = tiempoParaSiguiente;
            piano.tocarTecla
        }
        continuar tarea

    + GhostAndSingerSameRoomCondition comprueba que el fantasma y la cantante esten en la misma habitacion al mismo tiempo.

    + GhostInActuationCondition comprueba que la cantante este en el escenario o en las bambalinas (cuando las ve).

    Además se han implementando la máquina de estados y el arbol de comportamiento con algunas modificaciones:

    Máquina de estados de la cantante:

    ![Máquina de estados de la cantante](./P3/CantanteStateMachineNew.png)

    Arbol de comportamiento del fantasma:

    ![Árbol de comportamiento del fantasma](./P3/GhostBehaviourTreeNew.png)

    Reset de la escena: 'r'

    Video YouTube: https://youtu.be/k6cyt9LfHuw
    