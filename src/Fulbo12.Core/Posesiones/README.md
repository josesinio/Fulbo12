Ya teniendo nuestros futbolistas, podemos crear a nuestros usuarios (físicos).

#### Posesion

Define la posesión de un Futbolista por parte de un Usuario; es la parte fundamental donde se van a guardar las estadísticas de partidos y goles convertidos. **Los goles en contra no suman ni restan goles para el historial del jugador.**

- [ ] Referencias al Usuario dueño y Futbolista en cuestión.
- [ ] Cantidad de dueños que tuvo (máximo 199), partidos jugados y goles convertidos (máximo 9.999).
- [ ] `void ReiniciarContadores()`: vuelve a cero los partidos jugados al igual que sus goles.
- [ ] `void IncrementarPartido()`: suma 1 a los partidos jugados.
- [ ] `void IncrementarGoles(byte)`: incrementa la cantidad de goles.
- [ ] `void IncrementarDueno()`: suma 1 a los dueños.

#### Usuario

- [ ] Poseen: nombre, apellido, email, fecha de nacimiento y monedas (valor máximo 9.999.999).
- [ ] Colección de posesiones nuevas.
- [ ] Colección de futbolistas en posesión.
- [ ] `bool PoseeFutbolista(Futbolista)`: verifica si el Usuario posee al futbolista en su lista de Posesiones.
- [ ] `void AgregarPosesion(Posesion)`: agrega un futbolista a la lista de posesiones; solamente puede si no lo tiene entre su lista de posesiones; en ese caso se tiene que devolver una excepción del tipo `InvalidOperationException` con la leyenda "Futbolista ya se encuentra en posesión".
- [ ] `void AgregarTransferible(Posesion)`: agrega la posesión a la colección de transferibles
- [ ] Colección de transferencias.
- [ ] Cuando un jugador recibe un futbolista nuevo y ya lo tiene entre su lista de posesiones, puede agregarlo a una lista de posesiones transferibles, la cual tiene un limite de 100 entre la suma de cantidades de posesiones transferibles y posesiones ofertadas.
- [ ] `void Publicar (Transferencia)`: un jugador puede publicar una de sus posesiones solo si esta se encuentra en su colección de _Posesiones transferibles_. Este método saca a dicha posesión de su lista de transferibles y la coloca en su lista de transferencias.
- [ ] `bool TieneAlMenos (uint)`: método que recibe una cantidad de monedas e indica si el Usuario posee esa cantidad mínima.
- [ ] `void Ofertar (Transferencia, uint)`: permite al usuario en cuestión ofertar por una transferencia publicada siempre y cuando:
  - El usuario a ofertante tenga al menos la cantidad de monedas que oferta; caso contrario se arroja `InvalidOperationException` con la leyenda "No hay monedas suficientes".
  - El usuario oferte por una transferencia de la cual él no sea el vendedor;  caso contrario se arroja `InvalidOperationException` con la leyenda "No se puede ofertar por publicaciones propias".
  En caso de que la oferta cumpla las reglas, se debe _Debitar_ la cantidad de monedas ofertadas en el ofertante y registrar la suma de la oferta y Usuario ofertante en la transferencia.

#### Publicacion

Son las publicaciones que hacen los usuarios de sus futbolistas transferibles.

- [ ] Poseen: Posesion en cuestión, fecha y hora de la publicación y cantidad de días en publicación (valor máximo, 5 días, igual para todas las transferencias), precio mínimo de subasta y precio de compra inmediata (la compra inmediata siempre debe ser mayor al precio minimo); ademas cuando un usuario hace una oferta, se registran las monedas ofertadas y el usuario ofertante.
- [ ] `bool CantidadEsMayor(uint)`: devuelve `true` solo si la cantidad recibida por parámetro es mayor a 
- [ ] `void RecibirOferta (Usuario, uint)`: registra el usuario ofertante y las monedas, siempre y cuando la cantidad ofertada sea superior a una cantidad ofertada previa o al precio mínimo de subasta si no existe oferta previa; además si previamente ya había un ofertante
se le deben devolver a este la cantidad de monedas ofertadas.
- [ ] `void Aplicar()`: Si hay un ofertante se debe:
  - Reiniciar los contadores de la Posesion.
  - Sacar a la transferencia de la colección de transferencias del vendedor
  - _Acreditar_ en el Vendedor las monedas de la transacción.
  - Agregar la posesión a la colección de posesiones nuevas del comprador.
  En caso de que no haya un ofertante, se tiene que sacar a la posesión de las publicaciones y devolverla a las transferencias del vendedor.
