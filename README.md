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

# ÁRBOLES BINARIOS

Se imagina un árbol genealógico al revés: la raíz está arriba y las ramas se extienden hacia abajo. La regla de oro de un árbol binario es que cada nodo puede tener, como máximo, dos hijos (comúnmente llamados hijo izquierdo e hijo derecho).

Conceptos Clave
Antes de tocar código, manejemos el mismo idioma con estos términos:

1-Raíz (Root): El nodo supremo, el origen de todo el árbol. No tiene padre.

2-Nodo (Node): Cada uno de los elementos que contiene la información (un número, un texto, etc.) y los enlaces a sus hijos.

3-Hijo (Child): Un nodo que depende de otro superior.

4-Padre (Parent): Un nodo que tiene enlaces a otros nodos inferiores.

5-Hojas (Leaves): Los nodos del final del árbol, los que ya no tienen hijos.

# ALGORITMOS FUNDAMENTALES DE ORDENAMIENTO

1. Bubble Sort (Ordenamiento Burbuja)
El concepto es simple: los elementos más grandes "flotan" hacia el final del arreglo, como burbujas en el agua.

¿Cómo funciona paso a paso?
Compara cada elemento con el siguiente. Si el de la izquierda es mayor que el de la derecha, los intercambia. Este proceso se repite recorriendo la lista una y otra vez hasta que no se necesiten más intercambios.

```text
1-Primera pasada:
    ¿5 > 1? Sí Intercambio: [1, 5, 4, 2]
    ¿5 > 4? Sí Intercambio: [1, 4, 5, 2]
    ¿5 > 2? Sí Intercambio: [1, 4, 2, 5] (El 5, que es el más grande, ya llegó al final).
2-Segunda pasada:
    ¿1 > 4? No.
    ¿4 > 2? Sí Intercambio: [1, 2, 4, 5].
3-El algoritmo hace una pasada más para verificar que todo esté en orden y termina.
```

## Análisis de Complejidad

### Peor caso y caso promedio: `O(n²)`

Si la lista está invertida, tendrás que comparar e intercambiar prácticamente todos los elementos entre sí.

### Mejor caso: `O(n)`

Si la lista ya está ordenada y se utiliza una bandera (*flag*) para detectar que no hubo intercambios durante una pasada, el algoritmo finaliza inmediatamente.

### Espacio: `O(1)`

Es un algoritmo **in-place**, lo que significa que ordena los elementos utilizando una cantidad constante de memoria adicional.

2. Insertion Sort (Ordenamiento por Inserción)

Se piensa en como se ordena las cartas en una mano cuando se juega al póker o al truco. Se Toma una carta y la se mueve hacia atrás hasta insertarla en su lugar correcto entre las que ya se tiene ordenadas.

## ¿Cómo funciona paso a paso?

El algoritmo divide virtualmente el arreglo en una parte ordenada (al principio) y otra desordenada. Toma el primer elemento de la parte desordenada y lo arrastra hacia la izquierda comparándolo con los elementos anteriores hasta encontrar su posición correcta.

### Ejemplo práctico

Vamos a ordenar:

```text
[5, 2, 4, 1]
```

El `5` se considera ya ordenado. Pasamos al `2`.

- Tomamos el `2`: Como `2 < 5`, movemos el `5` a la derecha e insertamos el `2`.

```text
[2, 5, 4, 1]
```

- Tomamos el `4`: Es menor que `5`, pero mayor que `2`. Se inserta ahí.

```text
[2, 4, 5, 1]
```

- Tomamos el `1`: Es menor que `5`, menor que `4` y menor que `2`. Viaja hasta el principio.

```text
[1, 2, 4, 5]
```

## Análisis de Complejidad

### Peor caso y caso promedio: `O(n²)`

Ocurre si el arreglo está en orden descendente.

### Mejor caso: `O(n)`

Si el arreglo ya está ordenado, solo hace una comparación por elemento y no mueve nada. Por esto es extremadamente eficiente para listas que ya están casi ordenadas.

### Espacio: `O(1)`

Es un algoritmo **in-place**, es decir, no requiere memoria adicional significativa.

## 3. Selection Sort (Ordenamiento por Selección)

Este algoritmo es un poco más "egoísta" e intuitivo. En lugar de arrastrar elementos poco a poco, busca directamente al protagonista de cada posición.

## ¿Cómo funciona paso a paso?

Divide el arreglo en una zona **ordenada** y una zona **desordenada**. Recorre la zona desordenada para encontrar el elemento más pequeño de todos y lo intercambia con el primer elemento de esa zona.

### Ejemplo práctico

Vamos a ordenar:

```text
[5, 3, 4, 1]
```

### Paso 1

Buscar el mínimo en todo el arreglo.

El mínimo es `1`. Lo intercambiamos con el elemento de la posición `0` (donde está el `5`).

```text
[1, 3, 4, 5]
```

### Paso 2

Ahora la zona desordenada empieza en el índice `1`.

```text
[3, 4, 5]
```

Buscar el mínimo.

El mínimo es `3`. Ya está en su lugar, por lo que no hay intercambio.

### Paso 3

Siguiente zona desordenada:

```text
[4, 5]
```

Buscar el mínimo.

El mínimo es `4`. Ya está en su lugar.

### Resultado final

El arreglo queda ordenado:

```text
[1, 3, 4, 5]
```

## Análisis de Complejidad

### Peor caso, caso promedio y mejor caso: `O(n²)`

A diferencia de Bubble Sort e Insertion Sort, a Selection Sort no le importa si el arreglo ya está ordenado. En cada iteración debe recorrer toda la zona desordenada para asegurarse de encontrar el elemento mínimo.

### Espacio: `O(1)`

Es un algoritmo **in-place**, ya que utiliza una cantidad constante de memoria adicional.

### 📊 Resumen Comparativo de Algoritmos

Para consolidar lo aprendido, mira cómo se comparan en la cancha:

---

#### 🧼 Bubble Sort (Ordenamiento Burbuja)
* **Complejidad:**
  * **Mejor Caso:** $O(n)$
  * **Peor Caso:** $O(n^2)$
* **Ventaja Principal:** Muy fácil de entender y programar.
* **Desventaja Principal:** Muy ineficiente en la práctica.

---

#### 🃏 Insertion Sort (Ordenamiento por Inserción)
* **Complejidad:**
  * **Mejor Caso:** $O(n)$
  * **Peor Caso:** $O(n^2)$
* **Ventaja Principal:** Excelente para listas casi ordenadas o flujos de datos en tiempo real.
* **Desventaja Principal:** Sigue siendo lento para listas grandes desordenadas.

---

#### 🎯 Selection Sort (Ordenamiento por Selección)
* **Complejidad:**
  * **Mejor Caso:** $O(n^2)$
  * **Peor Caso:** $O(n^2)$
* **Ventaja Principal:** Minimiza la cantidad de intercambios de memoria.
* **Desventaja Principal:** Ineficiente, ya que siempre realiza el mismo número de comparaciones.

---