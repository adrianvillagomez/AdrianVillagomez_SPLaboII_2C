# La Cartuchera
 Proyecto creado para la segunda evaluación de Laboratorio de Programación II.
 Se nos pide generar una aplicación de escritorio de una cartuchera donde se calificaran los temas vistas en la segunda parte de la materia.

 ## Autor
  * [Adrian Villagomez](https://github.com/adrianvillagomez)

 ## Lecciones Aprendidas

+ Clases y métodos estáticos
+ OOP
+ Sobrecarga
+ WindowsForms
+ Colecciones
+ Enumerados
+ Encapsulamiento
+ Herencia
+ Polimorfismo
+ Unit Test
+ Excepciones
+ Tipos Genéricos
+ Interfaces
+ Conexión a bases de datos (SQLServer)
+ Programación MultiHilo y concurrencia
+ Eventos


# Menu Principal

![Imagen](/ImagenesReadme/main.png)

* Los Botones agregar Lápiz,agregar sacapuntas y agregar goma agregaran el producto a mi lista de útiles y a la base de datos.
Estos Actuaran como Alta para mi base de datos con 3 tablas, una por cada util.
* Si el precio total de la cartuchera excede los $500 se lanzara el un evento que escribirá un archivo en Mis documentos llamado tickets.log, que mostrara información de la cartuchera

* El botón ver útiles nos llevara a un nuevo formulario donde veremos todos nuestros útiles cargados

* El botón ver tickets nos mostrara  todos los elementos de mi cartuchera y información de la cartuchera.

* El botón listaBuckup nos abrirá un nuevo formulario donde se guardara la lista como buckup cada 10 seg.
En este apartado y junto con el reloj aplicamos Programación multihilos
# Ver útiles

![Imagen](/ImagenesReadme/verutiles.png)

![Imagen](/ImagenesReadme/VerUtilesDiagrama.png)

* Los botones Deserializar Lápiz Json y Deserializar XML nos nos permitirá deserializar datos guardados en nuestra carpeta Mis Documentos.

* Nuestro DataGridView Lapices nos permitirá que al hacer doble click en la fila que seleccionemos nos abrira un form con esa características :

![Imagen](/ImagenesReadme/serializar.png)

* El botón SerializarJson y SerializarXml nos guardara un archivo de texto ubicado en Mis Documentos con el nombre escrito en el textbox.

* El botón Eliminar Lápiz nos Borrar el lápiz tanto de mi lista como de mi base de datos.

* Tanto los DataGridView de Sacapuntas y Goma tendrán el evento doble click donde se podrá modificar o eliminar el elemento seleccionado.

![Imagen](/ImagenesReadme/Opciones.png)