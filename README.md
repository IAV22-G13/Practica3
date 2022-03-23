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