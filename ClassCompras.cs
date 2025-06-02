using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 namespace ProyectoFinal
    {
        public class ClassCompras
        {
            public ClassNodoCompras? Pila { get; set; }
            public int TotalNodos { get; set; }

            public ClassCompras()
            {
                Pila = null;
            }

            public void Push(string zona, int tickets, string cliente)
            {
                ClassNodoCompras nuevo = new ClassNodoCompras(zona, tickets, cliente);
                if (Pila == null)
                {
                    Pila = nuevo;
                }
                else
                {
                    nuevo.Siguiente = Pila; //aqui se usa .Siguiente ya que dice "enlace de nuevo"
                    Pila = nuevo;
                }
                TotalNodos++;
            }

            public void Pop()
            {
                if (Pila == null)
                {
                    MessageBox.Show("No existen datos para tomar", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Pila = Pila.Siguiente;
                    TotalNodos--;
                }
            }

            public string Mostrar()
            {
                string? lista = null;
                if (Pila != null)
                {
                    ClassNodoCompras auxiliar = new ClassNodoCompras(null, 0, null);
                    auxiliar = Pila;
                    while (auxiliar != null)
                    {
                        lista = lista + auxiliar.Zona + ", " + auxiliar.TicketsDevueltos + ", " + auxiliar.Cliente + " || ";
                        auxiliar = auxiliar.Siguiente;
                    }
                }
                else
                {
                    lista = "No existen datos";
                }
                return lista;
            }

                public void ReasignarDesdePila(ClassOrden orden, ClassEstadio estadio)
                {
                    while (!orden.EstaVacia() && Pila != null)
                    {
                        ClassNodoOrden? cliente = orden.Desencolar();
                        ClassNodoCompras? devolucion = Pila;

                        // Solo reasignar si la zona que pide el cliente es igual a la zona de la devolución
                        if (cliente != null && devolucion != null && cliente.ZonaDeseada == devolucion.Zona)
                        {
                            // Buscar la zona en el estadio
                            ClassNodoEstadio? zona = estadio.Inicio;
                            while (zona != null)
                            {
                                if (zona.Zona == devolucion.Zona)
                                {
                                    // Aumentar tickets disponibles y simular asignación
                                    zona.Tickets += devolucion.TicketsDevueltos;
                                    MessageBox.Show($"Cliente {cliente.Nombre} recibió {devolucion.TicketsDevueltos} tickets de la zona {zona.Zona} que fueron cancelados por {devolucion.Cliente}");
                            
                                    Pop(); // Eliminar el nodo de la pila
                                    break;
                                }
                                zona = zona.Siguiente;
                            }
                        }
                    }
                }

            public int MostrarNodos()
            {
                return TotalNodos;
            }
        }
 }
