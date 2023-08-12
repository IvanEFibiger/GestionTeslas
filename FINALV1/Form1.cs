using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FINALV1
{
    public partial class Form1 : Form
    {
        private SistemaGestion sistemaGestion;

        public Form1()
        {
            InitializeComponent();
            sistemaGestion = new SistemaGestion(); // Inicializar la instancia de SistemaGestion
            ActualizarDataGridView();
            ActualizarDataGridViewCarga();
            ActualizarDataGridViewEscaneo();

        }
        #region Pestaña ALTA


        // Eventos para cargar y guardar vehículos Teslas

        /// <summary>
        /// Evento que se ejecuta cuando el TextBox de año de Tesla recibe el enfoque.
        /// Borra el texto predeterminado y cambia el color de fuente a negro.
        /// </summary>
        private void textBoxAñoTesla_Enter(object sender, EventArgs e)
        {
            if (textBoxAñoTesla.Text == "Año")
            {
                textBoxAñoTesla.Text = ""; // Borra el texto predeterminado
                textBoxAñoTesla.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Evento que se ejecuta cuando el TextBox de año de Tesla pierde el enfoque.
        /// Restablece el texto predeterminado si no se ha escrito nada y cambia el color de fuente a gris.
        /// </summary>
        private void textBoxAñoTesla_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAñoTesla.Text))
            {
                textBoxAñoTesla.Text = "Año"; // Restablece el texto predeterminado si no se ha escrito nada
                textBoxAñoTesla.ForeColor = Color.Gray;
            }
        }

        private void textBoxKMtesla_Enter(object sender, EventArgs e)
        {
            if (textBoxKMtesla.Text == "Km Actual")
            {
                textBoxKMtesla.Text = "";
                textBoxKMtesla.ForeColor = Color.Black;
            }
        }

        private void textBoxKMtesla_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxKMtesla.Text))
            {
                textBoxKMtesla.Text = "Km Actual";
                textBoxKMtesla.ForeColor = Color.Gray;
            }
        }

        private void textBoxColorTesla_Enter(object sender, EventArgs e)
        {
            if (textBoxColorTesla.Text == "Color")
            {
                textBoxColorTesla.Text = "";
                textBoxColorTesla.ForeColor = Color.Black;
            }
        }

        private void textBoxColorTesla_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxColorTesla.Text))
            {
                textBoxColorTesla.Text = "Color";
                textBoxColorTesla.ForeColor = Color.Gray;
            }
        }

        private void textBoxDueñoTesla_Enter(object sender, EventArgs e)
        {
            if (textBoxDueñoTesla.Text == "Dueño")
            {
                textBoxDueñoTesla.Text = "";
                textBoxDueñoTesla.ForeColor = Color.Black;
            }
        }

        private void textBoxDueñoTesla_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDueñoTesla.Text))
            {
                textBoxDueñoTesla.Text = "Dueño";
                textBoxDueñoTesla.ForeColor = Color.Gray;
            }
        }

        // Eventos para cargar y guardar vehículos SpaceX

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Guardar" de los vehículos Tesla.
        /// Valida y guarda los datos ingresados en la lista de Teslas.
        /// </summary>
        private void buttonGuardarTeslas_Click(object sender, EventArgs e)
        {
            if (comboBoxModelosTesla.SelectedItem != null)
            {
                // Validación de datos de entrada

                // Validar el año. Se tuvo en cuenta la fecha de salida al mercado del primer tesla.
                if (!int.TryParse(textBoxAñoTesla.Text, out int año) || año < 2006 || año > 2023)
                {
                    MessageBox.Show("Ingrese un año válido (entre 2006 y 2023).");
                    return;
                }

                // Validar la cantidad de kilómetros. Se tuvo en cuenta que el kilometraje no pueda ser negativo.
                if (!double.TryParse(textBoxKMtesla.Text, out double cantKms) || cantKms <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad de kilómetros válida (mayor o igual a 0).");
                    return;
                }

                // Validar el color. Se optó por limitar los colores disponibles para poder realizar correctamente la validación.
                string color = textBoxColorTesla.Text.Trim().ToLower();
                if (color != "verde" && color != "azul" && color != "rojo" && color != "negro")
                {
                    MessageBox.Show("Ingrese un color válido (verde, azul, rojo o negro).");
                    return;
                }

                // Validar el dueño. En este caso lo que se espera es que el campo no quede vacío.
                string dueño = textBoxDueñoTesla.Text.Trim();
                if (string.IsNullOrWhiteSpace(textBoxDueñoTesla.Text) || textBoxDueñoTesla.Text == "Dueño")
                {
                    MessageBox.Show("Ingrese el propietario del vehículo.");
                    return;
                }

                // Crear objeto Tesla con los datos ingresados
                string modelo = comboBoxModelosTesla.SelectedItem.ToString();
                Tesla tesla;

                if (modelo == "X")
                    tesla = new ModeloX(modelo, año, cantKms, color, dueño, 0.0, 0.0, 0.0);
                else if (modelo == "S")
                    tesla = new ModeloS(modelo, año, cantKms, color, dueño, 0.0, 0.0, 0.0);
                else if (modelo == "CYBERTRUCK")
                    tesla = new Cybertruck(modelo, año, cantKms, color, dueño, 0.0, 0.0, 0.0);
                else
                {
                    MessageBox.Show("Seleccione un modelo válido.");
                    return;
                }

                // Agregar el objeto Tesla a la lista del sistema de gestión
                sistemaGestion.AgregarTesla(tesla);
                double cargaBateria = sistemaGestion.ObtenerCargaBaterias(tesla);
                tesla.CombustibleActual = cargaBateria;

                // Limpiar los campos de entrada después de guardar los datos
                comboBoxModelosTesla.SelectedIndex = -1;
                comboBoxModelosTesla.Text = "Modelo";
                textBoxAñoTesla.Text = "Año";
                textBoxKMtesla.Text = "Km Actual";
                textBoxColorTesla.Text = "Color";
                textBoxDueñoTesla.Text = "Dueño";

                MessageBox.Show("Datos de Tesla guardados correctamente.");

                ActualizarDataGridView();
                ActualizarDataGridViewCarga();
                ActualizarDataGridViewEscaneo();
            }
            else
            {
                MessageBox.Show("Seleccione un modelo de Tesla.");
            }
        }

        // Eventos para cargar y guardar vehículos Space X. Tienen el mismo comportamiento que los de Teslas.

        private void textBoxAñoSpaceX_Enter(object sender, EventArgs e)
        {
            if (textBoxAñoSpaceX.Text == "Año")
            {
                textBoxAñoSpaceX.Text = "";
                textBoxAñoSpaceX.ForeColor = Color.Black;
            }
        }

        private void textBoxAñoSpaceX_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAñoSpaceX.Text))
            {
                textBoxAñoSpaceX.Text = "Año";
                textBoxAñoSpaceX.ForeColor = Color.Gray;
            }
        }

        private void textBoxHsVueloSpaceX_Enter(object sender, EventArgs e)
        {
            if (textBoxHsVueloSpaceX.Text == "Hs Vuelo")
            {
                textBoxHsVueloSpaceX.Text = "";
                textBoxHsVueloSpaceX.ForeColor = Color.Black;
            }
        }

        private void textBoxHsVueloSpaceX_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHsVueloSpaceX.Text))
            {
                textBoxHsVueloSpaceX.Text = "Hs Vuelo";
                textBoxHsVueloSpaceX.ForeColor = Color.Gray;
            }
        }

        private void textBoxColorSpaceX_Enter(object sender, EventArgs e)
        {
            if (textBoxColorSpaceX.Text == "Color")
            {
                textBoxColorSpaceX.Text = "";
                textBoxColorSpaceX.ForeColor = Color.Black;
            }
        }

        private void textBoxColorSpaceX_Leave(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(textBoxColorSpaceX.Text))
            {
                textBoxColorSpaceX.Text = "Color";
                textBoxColorSpaceX.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmpresaSpaceX_Enter(object sender, EventArgs e)
        {
            if (textBoxEmpresaSpaceX.Text == "Empresa")
            {
                textBoxEmpresaSpaceX.Text = "";
                textBoxEmpresaSpaceX.ForeColor = Color.Black;
            }
        }

        private void textBoxEmpresaSpaceX_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmpresaSpaceX.Text))
            {
                textBoxEmpresaSpaceX.Text = "Empresa";
                textBoxEmpresaSpaceX.ForeColor = Color.Gray;
            }
        }


        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Guardar" de los vehículos SpaceX.
        /// Valida y guarda los datos ingresados en la lista de SpaceX.
        /// Tiene el mismo comportamiento que el evento de vehículos Teslas.
        /// </summary>
        private void buttonGuardarSpaceX_Click(object sender, EventArgs e)
        {
            if (comboBoxModelosSpaceX.SelectedItem != null)
            {
                // Validar el año. Se tuvo en cuenta la fecha de fundación de la empresa SpaceX.
                if (!int.TryParse(textBoxAñoSpaceX.Text, out int año) || año < 2008 || año > 2023)
                {
                    MessageBox.Show("Ingrese un año válido (entre 2008 y 2023).");
                    return;
                }

                //Validar la cantidad de Hs de vuelo. Se contempla que la cantidad de horas no pueda ser negativa.
                if (!double.TryParse(textBoxHsVueloSpaceX.Text, out double hsVuelo) || hsVuelo < 0)
                {
                    MessageBox.Show("Ingrese una cantidad de horas de vuelo válida (mayor o igual a 0).");
                    return;
                }
                //Al igual que en la versión Tesla, se limitó la cantidad de colores disponibles para poder validar.
                string color = textBoxColorSpaceX.Text.Trim().ToLower();
                if (color != "verde" && color != "azul" && color != "rojo" && color != "negro")
                {
                    MessageBox.Show("Ingrese un color válido (verde, azul, rojo o negro).");
                    return;
                }
                //Mismo comportamiento que en la versión Tesla. No puede ser un campo en blanco.
                string dueño = textBoxEmpresaSpaceX.Text.Trim();
                if (string.IsNullOrWhiteSpace(textBoxEmpresaSpaceX.Text) || textBoxEmpresaSpaceX.Text == "Empresa")
                {
                    MessageBox.Show("Ingrese el propietario del vehículo.");
                    return;
                }

                string modelo = comboBoxModelosSpaceX.SelectedItem.ToString();
                SpaceX spacex;

                if (modelo == "STARSHIP")
                    spacex = new Starship(modelo, año, hsVuelo, color, dueño, 0.0, 0.0, 0.0);
                else if (modelo == "FALCON 9")
                    spacex = new Falcon9(modelo, año, hsVuelo, color, dueño, 0.0, 0.0, 0.0);
                else
                {
                    MessageBox.Show("Seleccione un modelo válido.");
                    return;
                }

                sistemaGestion.AgregarSpaceX(spacex);
                double cargaCombustible = sistemaGestion.ObtenerCargaCombustible(spacex);
                spacex.CombustibleActual = cargaCombustible;

                comboBoxModelosSpaceX.SelectedIndex = -1;
                comboBoxModelosSpaceX.Text = "Modelo";
                textBoxAñoSpaceX.Text = "Año";
                textBoxHsVueloSpaceX.Text = "Hs Vuelo";
                textBoxColorSpaceX.Text = "Color";
                textBoxEmpresaSpaceX.Text = "Empresa";

                MessageBox.Show("Datos de SpaceX guardados correctamente.");

                ActualizarDataGridView();
                ActualizarDataGridViewCarga();
                ActualizarDataGridViewEscaneo();
            }
            else
            {
                MessageBox.Show("Seleccione un modelo de SpaceX.");
            }
        }
        #endregion
        #region Pestaña ELIMINAR


        /// <summary>
        /// Método para actualizar el DataGridView en la pestaña eliminar.
        /// </summary>
        private void ActualizarDataGridView()
        {
            // Limpiar las filas existentes en el DataGridView
            dataGridViewEliminar.Rows.Clear();

            // Obtener la lista de Teslas desde la instancia de SistemaGestion
            List<Tesla> teslas = sistemaGestion.ObtenerTeslas();

            // Obtener la lista de SpaceX desde la instancia de SistemaGestion
            List<SpaceX> spacexs = sistemaGestion.ObtenerSpaceXs();

            // Recorrer la lista de Teslas y agregar las filas correspondientes en el DataGridView
            foreach (Tesla tesla in teslas)
            {
                dataGridViewEliminar.Rows.Add("Tesla", tesla.Modelo, tesla.Año, tesla.Propietario);
            }

            // Recorrer la lista de SpaceX y agregar las filas correspondientes en el DataGridView
            foreach (SpaceX spacex in spacexs)
            {
                dataGridViewEliminar.Rows.Add("SpaceX", spacex.Modelo, spacex.Año, spacex.Propietario);
            }
        }

        // Botón para eliminar el vehículo seleccionado. Para que este funcione correctamente, debe seleccionarse TODA la fila que se
        //desea eliminar.
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada en el DataGridView
            if (dataGridViewEliminar.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridViewEliminar.SelectedRows[0];

                // Verificar si la fila tiene datos válidos
                if (row.Cells["ColumnEliminarVehiculo"].Value != null &&
                    row.Cells["ColumnEliminarModelo"].Value != null &&
                    row.Cells["ColumnEliminarAño"].Value != null)
                {
                    // Obtener el valor de la columna "vehículo" para determinar si es un objeto Tesla o SpaceX
                    string vehiculo = row.Cells["ColumnEliminarVehiculo"].Value.ToString();

                    // Obtener los valores de las otras columnas
                    string modelo = row.Cells["ColumnEliminarModelo"].Value.ToString();
                    int año = Convert.ToInt32(row.Cells["ColumnEliminarAño"].Value);

                    if (vehiculo == "Tesla")
                    {
                        // Obtener el valor de la columna "dueño"
                        string dueño = row.Cells["ColumnEliminarPropietario"].Value.ToString();

                        // Buscar el objeto Tesla en la lista y eliminarlo
                        Tesla tesla = sistemaGestion.ObtenerTeslas().FirstOrDefault(t => t.Modelo == modelo && t.Año == año && t.Propietario == dueño);
                        if (tesla != null)
                        {
                            sistemaGestion.EliminarTesla(tesla);
                            ActualizarDataGridView();
                            MessageBox.Show("Tesla eliminado correctamente.");
                        }
                    }
                    else if (vehiculo == "SpaceX")
                    {
                        // Buscar el objeto SpaceX en la lista y eliminarlo
                        SpaceX spacex = sistemaGestion.ObtenerSpaceXs().FirstOrDefault(s => s.Modelo == modelo && s.Año == año);
                        if (spacex != null)
                        {
                            sistemaGestion.EliminarSpaceX(spacex);
                            ActualizarDataGridView();
                            MessageBox.Show("SpaceX eliminado correctamente.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila válida.");
                }
            }
        }
        #endregion
        #region Pestaña MOSTRAR


        /// <summary>
        /// Método para mostrar el Tesla con mayor cantidad de kilómetros en el DataGridView.
        /// Si hubiese 2 o más Teslas con la misma cantidad de kilómetros se mostrarán todos en el DataGrid.
        /// </summary>
        private void buttonMostrarKm_Click(object sender, EventArgs e)
        {
            List<Tesla> teslas = sistemaGestion.ObtenerTeslas();

            // Verificar si hay Teslas registrados en el sistema
            if (teslas.Count > 0)
            {
                // Obtener la máxima cantidad de kilómetros entre todos los Teslas
                double maxKilometraje = teslas.Max(t => t.KilometrajeActual);

                // Filtrar los Teslas que tienen el máximo kilometraje
                var teslasConMaxKilometraje = teslas.Where(t => t.KilometrajeActual == maxKilometraje).ToList();

                // Limpiar el DataGridView antes de agregar los datos
                dataGridViewMostrarKm.Rows.Clear();

                // Agregar filas al DataGridView con los datos de los Teslas con máximo kilometraje
                foreach (var tesla in teslasConMaxKilometraje)
                {
                    dataGridViewMostrarKm.Rows.Add("TESLA", tesla.KilometrajeActual, tesla.Modelo, tesla.Propietario);
                }
            }
            else
            {
                MessageBox.Show("No hay Teslas registrados en el sistema.");
            }
        }

        //Método para mostrar el datagrid vacío
        private void LimpiarDataGridViewMostrarKm()
        {
            dataGridViewMostrarKm.Rows.Clear();
        }
        //La funcionalidad de este botón es limpiar el datagrid si algún tesla es eliminado, luego debe volver a pulsarse el botón 
        //"Mostrar" para que se vuelva a cargar el tesla con mas km.
        //En este caso al tener un botón específico para actualizar un único vehículo mostrado, no se vió la necesidad de refrescar el datagrid
        private void buttonActualizarMostrar_Click(object sender, EventArgs e)
        {
            LimpiarDataGridViewMostrarKm();
        }

        #endregion
        #region Pestaña BATERÍA


        /// <summary>
        /// Método para actualizar el DataGridView en la pestaña de carga de batería.
        /// </summary>
        private void ActualizarDataGridViewCarga()
        {
            // Limpiar filas existentes en el DataGridView
            dataGridViewCarga.Rows.Clear();

            // Obtener los vehículos de Tesla y agregarlos al DataGridView
            List<Tesla> teslas = sistemaGestion.ObtenerTeslas();
            foreach (Tesla tesla in teslas)
            {
                double cargaBateria = sistemaGestion.ObtenerCargaBaterias(tesla);

                // Verificar si el Tesla todavía existe en el sistema antes de agregarlo al DataGridView
                if (!sistemaGestion.TeslaEliminado(tesla))
                {
                    dataGridViewCarga.Rows.Add("Tesla", tesla.Modelo, tesla.Propietario, tesla.KilometrajeActual, cargaBateria);
                }
            }

            // Obtener los vehículos de SpaceX y agregarlos al DataGridView
            List<SpaceX> spacexs = sistemaGestion.ObtenerSpaceXs();
            foreach (SpaceX spacex in spacexs)
            {
                // Verificar si el SpaceX todavía existe en el sistema antes de agregarlo al DataGridView
                if (!sistemaGestion.SpaceXEliminado(spacex))
                {
                    dataGridViewCarga.Rows.Add("SpaceX", spacex.Modelo, spacex.Propietario, spacex.HsVuelo, spacex.CombustibleActual);
                }
            }
        }

        //Método para vaciar el datagrid 
        private void LimpiarDataGridViewCarga()
        {
            dataGridViewCarga.Rows.Clear();
        }
        //La funcionalidad de este botón es poder actualizar el datagrid.
        //Por ejemplo, se van mostrando los diferentes vehículos cargados, y al eliminar alguno este se seguirá mostrando, 
        //entonces al hacer click en este botón la lista se actualiza con los vehículos existentes.
        private void buttonActualizarBateria_Click(object sender, EventArgs e)
        {
            LimpiarDataGridViewCarga();
            ActualizarDataGridViewCarga();
        }

        #endregion
        #region Pestaña ESCANEO


        /// <summary>
        /// Método para actualizar el DataGridView en la pestaña de escaneo.
        /// </summary>
        private void ActualizarDataGridViewEscaneo()
        {
            dataGridViewEscaneo.Rows.Clear();

            foreach (Tesla tesla in sistemaGestion.ObtenerTeslas())
            {
                dataGridViewEscaneo.Rows.Add("Tesla", tesla.Modelo, tesla.Año, tesla.Propietario, tesla.KilometrajeActual);
            }

            foreach (SpaceX spacex in sistemaGestion.ObtenerSpaceXs())
            {
                dataGridViewEscaneo.Rows.Add("SpaceX", spacex.Modelo, spacex.Año, spacex.Propietario, spacex.HsVuelo);
            }
        }
        /// <summary>
        /// Método para realizar el escaneo de un vehículo seleccionado en el DataGridView.
        /// </summary>
        private void buttonEscanear_Click(object sender, EventArgs e)
        {
            if (dataGridViewEscaneo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEscaneo.SelectedRows[0];

                // Verificar si la fila seleccionada no está vacía
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                    string tipoVehiculo = selectedRow.Cells[0].Value.ToString();
                    string modelo = selectedRow.Cells[1].Value.ToString();

                    if (tipoVehiculo == "Tesla")
                    {
                        // Obtener el objeto Tesla correspondiente al modelo seleccionado
                        Tesla tesla = sistemaGestion.ObtenerTeslas().FirstOrDefault(t => t.Modelo == modelo && t.Propietario == selectedRow.Cells[3].Value.ToString());
                        if (tesla != null)
                        {
                            // Escanear el vehículo Tesla
                            sistemaGestion.EscanearVehiculo(tesla);
                            ActualizarDataGridViewEscaneo();
                        }
                    }
                    else if (tipoVehiculo == "SpaceX")
                    {
                        // Obtener el objeto SpaceX correspondiente al modelo seleccionado
                        SpaceX spacex = sistemaGestion.ObtenerSpaceXs().FirstOrDefault(s => s.Modelo == modelo && s.Propietario == selectedRow.Cells[3].Value.ToString());
                        if (spacex != null)
                        {
                            // Escanear el vehículo SpaceX
                            sistemaGestion.EscanearVehiculo(spacex);
                            ActualizarDataGridViewEscaneo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede escanear el vehículo. Tipo de vehículo no válido.");
                    }
                }
                else
                {
                    MessageBox.Show("La fila seleccionada no contiene valores válidos.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vehículo para realizar el escaneo.");
            }
        }

        private void LimpiarDataGridViewEscaneo()
        {
            dataGridViewCarga.Rows.Clear();
        }
        //Este botón tiene el mismo comportamiento que el de la pestaña batería.
        private void buttonActualizarEscaneo_Click(object sender, EventArgs e)
        {
            LimpiarDataGridViewEscaneo();
            ActualizarDataGridViewEscaneo();
        }
    }
}
#endregion






