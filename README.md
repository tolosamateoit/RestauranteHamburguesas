# **__RestauranteHamburguesas (EN CONSTRUCCIÓN)__**

**Resumen**



Se trata de un proyecto donde el usuario puede pedir una hamburguesa a domicilio, especificando sus datos personales, los ingredientes,
y la dirección de entrega. Se busca desarrollar el proyecto de forma que la aplicación pueda ser utilizada por un negocio real, aplicando
técnicas de código limpio, y con la posibilidad de agregar funciones según las necesidades del restaurante.

**Funcionalidades:**


Se valida la distancia y se visualiza la ubicación utilizando la API de Google MAPS.
Si los datos son todos válidos se le informa al cliente su tiempo de espera aproximado y el costo.
Se guarda el pedido mediante Entity Framework en una base de datos.


Se realiza una validacion en los campos. La ubicación marcada es la ubicación del restaurante ficticio.
Hasta que no estén todos los campos completados correctamente, no se puede confirmar el pedido.

![image](https://user-images.githubusercontent.com/68035536/231653950-ee40ef89-07fb-404e-bdb5-6cb4b5ff6314.png)


Cuando la dirección es válida, se marca en el mapa, y se bloquea la escritura, que se puede habilitar nuevamente con el 
botón Modificar.

![image](https://user-images.githubusercontent.com/68035536/231652468-998b5c32-6427-47f8-b470-706d573f6c74.png)


**Casos de error:**

Caso 1: Dirección inválida o no encontrada:

![image](https://user-images.githubusercontent.com/68035536/231652765-6f9fe032-4954-4c7e-bdd4-8ddad5b60eb3.png)
 
Respuesta: se debe volver a escribir la dirección.

Caso 2: Dirección fuera de rango de delivery (10km de radio desde el restaurante)

![image](https://user-images.githubusercontent.com/68035536/231653773-043f98f0-71c4-4c8d-bb01-76e2d4c5364e.png)

Respuesta: se debe volver a escribir la dirección.

**Caso de éxito:**
Todos los campos fueron validados correctamente
La distancia de delivery es menor a 10km y la ubicación existe.
Se calcula el precio distancia como un precio fijo de 100 + 0.01 por metro.

![image](https://user-images.githubusercontent.com/68035536/231654113-78c13393-86fc-4e06-a371-f5441a52eb49.png)

Respuesta: se puede confirmar el pedido


![image](https://user-images.githubusercontent.com/68035536/231655324-9d4244be-0c83-464f-a3d6-dd8bfe33ffec.png)




Finalmente se guarda en la base de datos.

![image](https://user-images.githubusercontent.com/68035536/231655562-a1f9c531-2f70-4610-a387-43ee85151142.png)
















TRABAJANDO EN:

Calcular el precio del pedido según ingredientes y delivery.
Calcular el tiempo de demora según ingredientes y delivery.
Ordenar la lista de pedidos según se requiera.

FUNCIONALIDADES A FUTURO:
Implementar un "pago online".
