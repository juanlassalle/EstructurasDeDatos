# EstructurasDeDatos

# LISTAS ENLAZADAS

¿Qué es una Lista Enlazada?

A diferencia de un arreglo (array) tradicional donde los elementos se guardan en espacios de memoria contiguos, una lista enlazada es una secuencia de elementos donde cada elemento está guardado de forma independiente en la memoria.

Operaciones Básicas

A estos elementos los llamamos Nodos. Cada nodo tiene dos partes principales:

1-El valor (Data): La información que quieres guardar (un número, un texto, un objeto, etc.).

2-El puntero (Next): Una referencia o enlace que "apunta" a la dirección de memoria del siguiente nodo en la lista.

El primer nodo de la lista se conoce como la Cabeza (Head). Si la lista está vacía, la Cabeza es nula. El último nodo de la lista apunta a null, indicando que es el final.

Ventajas y Desventajas
1-Ventajas: Su tamaño es dinámico. Puedes agregar o quitar elementos fácilmente sin tener que reorganizar toda la estructura en la memoria (como pasa con los arrays cuando se llenan).

2-Desventajas: No puedes acceder a un elemento directamente por su índice (como array[5]). Si quieres el sexto elemento, tienes que empezar desde la Cabeza y viajar nodo por nodo hasta llegar a él.

# Creación desde cero

1. Crear la clase Nodo
Primero, necesitamos definir cómo se ve un "eslabón" de nuestra cadena.

2. Crear la clase de la Lista Enlazada
Ahora creamos la estructura que va a gestionar estos nodos.

3. Usando nuestra Lista
Así es como usarías este código en el método Main

# PILAS

¿Qué es una Pila (Stack)?

Una pila es una estructura de datos lineal que sigue el principio LIFO (Last In, First Out), es decir: el último en entrar es el primero en salir.

Piensa en una pila de platos para lavar: el último plato que pones arriba de todo es el primero que vas a agarrar para lavar. No intentas sacar el de abajo de todo porque se rompería toda la torre (y probablemente tu paciencia).

En software, el ejemplo más claro es el botón Deshacer (Ctrl + Z): el programa va guardando tus acciones en una pila, y cuando deshaces, borra la última acción que realizaste.

Operaciones Básicas

Para manejar una pila en C#, usamos la clase genérica Stack<T> (que vive en el espacio de nombres System.Collections.Generic). Sus métodos principales son:

1-Push: Añade un elemento a la cima de la pila.

2-Pop: Remueve y te devuelve el elemento que está en la cima.

3-Peek: Te deja "espiar" el elemento de la cima sin removerlo.

4-Count: Te dice cuántos elementos hay actualmente.

# COLAS

¿Qué es una cola (Queue)?

Cuando se realiza una fila para comprar café o esperar tu turno en el banco, se entiende perfectamente cómo funciona esta estructura. La regla de oro aquí es la filosofía FIFO (First In, First Out), lo que significa: el primero en entrar es el primero en salir. El que llega último, espera al final de la línea.

Operaciones básicas de una Cola

En C#, la clase estándar para manejar esto es Queue<T>, que vive dentro del espacio de nombres System.Collections.Generic. Las tres operaciones sagradas que tenés que conocer son:

1-Enqueue() (Encolar): Agrega un elemento al final de la cola.

2-Dequeue() (Desencolar): Elimina y te devuelve el elemento que está al principio de la cola.

3-Peek() (Ojeada): Te deja ver quién está al principio de la cola, pero sin sacarlo.

¿Cuándo vas a usar una cola en la vida real?
No las vas a usar para todo, pero son las reinas indiscutibles cuando necesitás orden de llegada:

Impresoras: Cuando varias personas mandan documentos a imprimir, se encolan y se procesan en orden.

Sistemas de mensajería o tareas: Procesar pedidos en una tienda online en el orden en que se pagaron.

Algoritmos de videojuegos: Por ejemplo, para la Inteligencia Artificial cuando busca caminos (algoritmo BFS o búsqueda en anchura).

# Creación desde cero

1. El bloque de construcción: El Nodo
Primero, se necesita una clase pequeña que represente a cada "persona" en la fila. Guarda su valor y una referencia al que sigue.

2-Clase Cola

Se arma la estructura lógica. Se verá que las operaciones Enqueue y Dequeue siguen siendo súper rápidas (O(1), es decir, tiempo constante) porque siempre se sabe exactamente dónde toca