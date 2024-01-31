using Proyecto2.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {

        // Creamos una Lista de teslas que contendra todos los teslas añadidos y otra para los cohetes
         List<Tesla> teslas = new List<Tesla>();
         List<SpaceX> cohetes = new List<SpaceX>();

        // Funcion para limpiar todas las opciones seleccionadas en el groupbox agregar
        private void AgregarLimpiar()
        {
            comboBoxAgregar2.Text = "- Seleccione una opcion -";
            txtBoxDuenio.Clear();
            txtBoxColor.Clear();
            numAnio.Value = 2005;
            numKm.Value = 0;
            panelAgregarDatos.Enabled = false;
            lblAgregarAlerta.Hide();
            panelAgregarModelo.Enabled = false;
        }

        // Funcion para limpiar el groupbox de scan
        private void scanLimpiar()
        {
            GBoxScan.Enabled = false;
            lblModel.Text = "Modelo: ???";
            lblAutonomia.Text = "Autonomia: ???";
            lblService.Text = "Service: ???";
            lblAsientos.Text = "Asientos: ???";
            lblAsientos.Show();
            dataGridService.Rows.Clear();
            lblScanAlerta.Hide();
            LogoImage.Image = Properties.Resources.Signo_Pregunta;
        }

        // Creamos una funcion para actualizar, y cambiar la lista a ver en el DataGrid
        private void mostrarLista(bool teslaOspacex)
        {
            scanLimpiar();
            dataGridVehiculos.DataSource = null;
            dataGridVehiculos.ReadOnly = true;              // Hacemos que no se puedan modificar/agregar columnas a traves de la DataGrid
            dataGridVehiculos.Columns.Clear();              // borramos todas las columnas
            dataGridVehiculos.AllowUserToAddRows = false;   // Para que no se genere una fila vacia al inicio
            dataGridVehiculos.AutoGenerateColumns = false;  // para que no se generen columnas automaticamente
            dataGridVehiculos.RowHeadersWidth = 30;         // ancho de la columna Vacia
            dataGridVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   // Para que al seleccionar una celda se seleccione toda la fila

            // Si el booleano que recibe la funcion es true, realiza las operaciones en la lista tesla o spacex
            if (teslaOspacex == true)       // True = Tesla
            {
                // Empezamos a agregar las columnas, su medida y centrar el header
                dataGridVehiculos.Columns.Add("duenio", "Dueño");
                dataGridVehiculos.Columns[0].Width = 158;
                dataGridVehiculos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("model","Modelo");
                dataGridVehiculos.Columns[1].Width = 60;
                dataGridVehiculos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("kmActual", "Km");
                dataGridVehiculos.Columns[2].Width = 45;
                dataGridVehiculos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("anio", "Año");
                dataGridVehiculos.Columns[3].Width = 32;
                dataGridVehiculos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("color", "Color");
                dataGridVehiculos.Columns[4].Width = 45;
                dataGridVehiculos.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("cargasCompleta", "Cargas Total");
                dataGridVehiculos.Columns[5].Width = 40;
                dataGridVehiculos.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("cargaActual", "Carga Actual");
                dataGridVehiculos.Columns[6].Width = 40;
                // fila invisible para identificar a cada fila con su objeto
                dataGridVehiculos.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("ID", "ID");
                dataGridVehiculos.Columns[7].Visible = false;


                // Agregamos las filas 1 x 1, Recorremos la lista de teslas
                foreach (Tesla tesla in teslas)
                {
                    // Generamos una fila
                    DataGridViewRow fila = new DataGridViewRow();

                    // Agregamos las celdas en el orden correcto
                    DataGridViewCell duenioCell = new DataGridViewTextBoxCell();    // Creamos una celda
                    duenioCell.Value = tesla.Duenio;                                // le damos un valor a la celda
                    fila.Cells.Add(duenioCell);                                     // agregamos la celda a la fila

                    DataGridViewCell modeloCell = new DataGridViewTextBoxCell();
                    modeloCell.Value = tesla.Modelo;
                    fila.Cells.Add(modeloCell);

                    DataGridViewCell kmCell = new DataGridViewTextBoxCell();
                    kmCell.Value = tesla.KmActual;
                    fila.Cells.Add(kmCell);

                    DataGridViewCell anioCell = new DataGridViewTextBoxCell();
                    anioCell.Value = tesla.Anio;
                    fila.Cells.Add(anioCell);

                    DataGridViewCell colorCell = new DataGridViewTextBoxCell();
                    colorCell.Value = tesla.Color;
                    fila.Cells.Add(colorCell);

                    DataGridViewCell cargascompletasCell = new DataGridViewTextBoxCell();
                    cargascompletasCell.Value = tesla.CargasCompletas;
                    fila.Cells.Add(cargascompletasCell);

                    DataGridViewCell cargaactualCell = new DataGridViewTextBoxCell();
                    cargaactualCell.Value = tesla.CargaActual;
                    fila.Cells.Add(cargaactualCell);

                    // Fila que contiene la ID para identificar a cada uno de los objetos en la lista
                    DataGridViewCell idCell = new DataGridViewTextBoxCell();
                    idCell.Value = tesla.ID;
                    fila.Cells.Add(idCell);

                    dataGridVehiculos.Rows.Add(fila);           // agregamos la fila a el datagrid
                }
                dataGridVehiculos.ClearSelection();         // deseleccionamos lo que este seleccionado
            }
            if (teslaOspacex == false)      // False = SpaceX
            {
                // Empezamos a agregar las columnas, su medida y estilos 
                dataGridVehiculos.Columns.Add("empresa", "Empresa");
                dataGridVehiculos.Columns[0].Width = 158;
                dataGridVehiculos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("model", "Modelo");
                dataGridVehiculos.Columns[1].Width = 60;
                dataGridVehiculos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("hsActual", "Horas");
                dataGridVehiculos.Columns[2].Width = 45;
                dataGridVehiculos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("anio", "Año");
                dataGridVehiculos.Columns[3].Width = 32;
                dataGridVehiculos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("color", "Color");
                dataGridVehiculos.Columns[4].Width = 45;
                dataGridVehiculos.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("cargasCompleta", "Cargas Total");
                dataGridVehiculos.Columns[5].Width = 40;
                dataGridVehiculos.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridVehiculos.Columns.Add("cargaActual", "Carga Actual");
                dataGridVehiculos.Columns[6].Width = 40;
                dataGridVehiculos.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // fila invisible para identificar a cada fila con su objeto
                dataGridVehiculos.Columns.Add("ID", "ID");
                dataGridVehiculos.Columns[7].Visible = false;
                // fila invisible para identificar si es un elemento de tipo tesla o spacex
                dataGridVehiculos.Columns.Add("kmActual", "KM");
                dataGridVehiculos.Columns[8].Visible = false;

                // Agregamos las filas 1 x 1
                // Recorremos la lista de teslas
                foreach (SpaceX cohete in cohetes)
                {
                    // Generamos una fila
                    DataGridViewRow fila = new DataGridViewRow();

                    // Agregamos las celdas en el orden correcto
                    DataGridViewCell duenioCell = new DataGridViewTextBoxCell();        // Creamos una celda
                    duenioCell.Value = cohete.Empresa;                                  // le damos un valor a la celda
                    fila.Cells.Add(duenioCell);                                         // agregamos la celda a la fila

                    DataGridViewCell modeloCell = new DataGridViewTextBoxCell();
                    modeloCell.Value = cohete.Modelo;
                    fila.Cells.Add(modeloCell);

                    DataGridViewCell kmCell = new DataGridViewTextBoxCell();
                    kmCell.Value = cohete.HsActual;
                    fila.Cells.Add(kmCell);

                    DataGridViewCell anioCell = new DataGridViewTextBoxCell();
                    anioCell.Value = cohete.Anio;
                    fila.Cells.Add(anioCell);

                    DataGridViewCell colorCell = new DataGridViewTextBoxCell();
                    colorCell.Value = cohete.Color;
                    fila.Cells.Add(colorCell);

                    DataGridViewCell cargascompletasCell = new DataGridViewTextBoxCell();
                    cargascompletasCell.Value = cohete.CargasCompletas;
                    fila.Cells.Add(cargascompletasCell);

                    DataGridViewCell cargaactualCell = new DataGridViewTextBoxCell();
                    cargaactualCell.Value = cohete.CargaActual;
                    fila.Cells.Add(cargaactualCell);

                    // Fila que contiene la ID para identificar a cada uno de los objetos en la lista
                    DataGridViewCell idCell = new DataGridViewTextBoxCell();
                    idCell.Value = cohete.ID;
                    fila.Cells.Add(idCell);

                    // Fila para identificar si el elemento es un spacex o tesla a traves de el datagrid
                    DataGridViewCell kmVacioCell = new DataGridViewTextBoxCell();
                    kmVacioCell.Value = null;
                    fila.Cells.Add(kmVacioCell);
                        
                    dataGridVehiculos.Rows.Add(fila);   // agregamos la fila
                }
                dataGridVehiculos.ClearSelection();     // limpiamos la seleccion
            }
        }

        // Funcion para Crear objetos de clase tesla/spacex
        private void CrearObjeto(int indexTipoVehiculo, int indexModelo, int anio, int KmHs, string DuenioEmpresa, string Color)
        {
            if (indexTipoVehiculo == 0) // Si esta seleccionado TESLA
            {
                if (indexModelo == 0)   // si esta seleccionado Modelo X
                {
                    ModelX agregarTesla = new ModelX(anio, KmHs, Color, DuenioEmpresa);    // Creamos un objeto
                    teslas.Add(agregarTesla);                                              // lo agregamos a la lista
                    mostrarLista(true);                                                    // actualizamos la lista 
                }
                if (indexModelo == 1) // si esta seleccionado Modelo S
                {
                    ModelS agregarTesla = new ModelS(anio, KmHs, Color, DuenioEmpresa);
                    teslas.Add(agregarTesla);
                    mostrarLista(true);
                }
                if (indexModelo == 2) // si esta seleccionado Cybertruck
                {
                    Cybertruck agregarTesla = new Cybertruck(anio, KmHs, Color, DuenioEmpresa);
                    teslas.Add(agregarTesla);
                    mostrarLista(true);
                }
                TeslaConMasKm();
            }
            if (indexTipoVehiculo == 1)     // Si esta seleccionado SPACEX
            { 
                if (indexModelo == 0)       // Si esta seleccionado starship
                {
                    Starship agregarCohete = new Starship(anio,KmHs,Color, DuenioEmpresa);
                    cohetes.Add(agregarCohete);
                    mostrarLista(false);
                }
                if (indexModelo == 1) // Si esta seleccionado Falcon 9
                {
                    Falcon9 agregarCohete = new Falcon9(anio,KmHs,Color,DuenioEmpresa);
                    cohetes.Add(agregarCohete);
                    mostrarLista(false);
                }
            }
        }

        // Generador de constructores aleatorio
        private void GenerarTeslaSpacexAleatorio(bool teslaOspacex)
        {
            //Generamos algunos datos aleatorios
            Random random = new Random();       // Generamos una seed para seleccionar aleatoriamente distintos puntos
            int anio = random.Next(2005, 2024);
            int kmOhs = random.Next(0, 50000);

            List<string> colores = new List<string> { "Rojo", "Azul", "Verde", "Amarillo", "Naranja", "Violeta", "Rosa", "Blanco", "Negro", "Gris" };
            string color = colores[random.Next(colores.Count)];

            // True para Tesla y false para spacex
            if (teslaOspacex == true)       // Tesla = True
            {
                //Generamos mas datos aleatorios propios de un tesla 
                int modelo = random.Next(0,3);

                List<string> nombres = new List<string> { "Juan", "María", "Carlos", "Laura", "Luis", "Ana", "Pedro", "Isabel", "Javier", "Marta" };
                string duenio = nombres[random.Next(nombres.Count)];

                // finalmente creamos el objeto
                CrearObjeto(0, modelo,anio,kmOhs,duenio,color);
            }
            if (teslaOspacex == false)      // SpaceX = False
            {
                // Generamos mas datos aleatorios propios de un cohete SpaceX
                int modelo = random.Next(0,2);

                List<string> empresas = new List<string> { "NASA", "ESA", "Roscosmos", "Blue Origin", "Boeing", "Lockheed Martin", "Northrop Grumman", "Arianespace", "United Launch Alliance (ULA)", "Space Adventures" };
                string empresa = empresas[random.Next(empresas.Count)];

                // finalmente creamos el objeto
                CrearObjeto(1, modelo,anio,kmOhs,empresa,color);
            }
        }

        // Tesla con mas Km
        private void TeslaConMasKm()
        {
            //Calculo de cual es es tesla con mas KM
            Tesla maxKm = teslas[0];        // Le asignamos el primer objeto de la lista a maxKm
            for (int i = 0; i < teslas.Count; i++)          // recorre desde 0 hasta la cantidad de objetos en la lista Teslas
            {
                if (teslas[i].KmActual > maxKm.KmActual)        // si el objeto seleccionado actualmente tiene mas Km que el de maxKm
                {
                    maxKm = teslas[i];                          // el seleccionado se convierte en el nuevo maxKm
                }
            }
                
                // Configuraciones para el  datagridview
                dataGridTeslaKm.DataSource = null;
                dataGridTeslaKm.ReadOnly = true;              // Hacemos que no se puedan modificar/agregar columnas a traves de la DataGrid
                dataGridTeslaKm.Columns.Clear();              // borramos todas las columnas
                dataGridTeslaKm.AllowUserToAddRows = false;   // Para que no se genere una columna vacia al inicio
                dataGridTeslaKm.AutoGenerateColumns = false;  // para que no se generen columnas automaticamente
                dataGridTeslaKm.RowHeadersWidth = 30;

                // Empezamos a agregar las columnas, su medida y las ocultamos
                dataGridTeslaKm.Columns.Add("duenio", "Dueño");
                dataGridTeslaKm.Columns[0].Width = 158;
                dataGridTeslaKm.Columns.Add("model", "Modelo");
                dataGridTeslaKm.Columns[1].Width = 60;
                dataGridTeslaKm.Columns.Add("kmActual", "Km");
                dataGridTeslaKm.Columns[2].Width = 45;
                dataGridTeslaKm.Columns.Add("anio", "Año");
                dataGridTeslaKm.Columns[3].Width = 32;
                dataGridTeslaKm.Columns.Add("color", "Color");
                dataGridTeslaKm.Columns[4].Width = 45;
                dataGridTeslaKm.Columns.Add("cargasCompleta", "Cargas Total");
                dataGridTeslaKm.Columns[5].Width = 40;
                dataGridTeslaKm.Columns.Add("cargaActual", "Carga Actual");
                dataGridTeslaKm.Columns[6].Width = 40;
                dataGridTeslaKm.ColumnHeadersVisible = false;

                // Generamos una fila
                DataGridViewRow fila = new DataGridViewRow();

                // Agregamos las celdas en el orden correcto
                DataGridViewCell duenioCell = new DataGridViewTextBoxCell();
                duenioCell.Value = maxKm.Duenio;
                fila.Cells.Add(duenioCell);

                DataGridViewCell modeloCell = new DataGridViewTextBoxCell();
                modeloCell.Value = maxKm.Modelo;
                fila.Cells.Add(modeloCell);

                DataGridViewCell kmCell = new DataGridViewTextBoxCell();
                kmCell.Value = maxKm.KmActual;
                fila.Cells.Add(kmCell);

                DataGridViewCell anioCell = new DataGridViewTextBoxCell();
                anioCell.Value = maxKm.Anio;
                fila.Cells.Add(anioCell);

                DataGridViewCell colorCell = new DataGridViewTextBoxCell();
                colorCell.Value = maxKm.Color;
                fila.Cells.Add(colorCell);

                DataGridViewCell cargascompletasCell = new DataGridViewTextBoxCell();
                cargascompletasCell.Value = maxKm.CargasCompletas;
                fila.Cells.Add(cargascompletasCell);

                DataGridViewCell cargaactualCell = new DataGridViewTextBoxCell();
                cargaactualCell.Value = maxKm.CargaActual;
                fila.Cells.Add(cargaactualCell);

                dataGridTeslaKm.Rows.Add(fila);         // Agregamos la fila
                dataGridTeslaKm.ClearSelection();       // limpiamos la seleccion
        }


        public Form1()
        {
            InitializeComponent();
        }

        // Al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Escondemos los paneles de seleccionar modelo e ingresar datos y algunas alertas
            panelAgregarModelo.Enabled = false;
            panelAgregarDatos.Enabled = false;
            GBoxScan.Enabled = false;
            lblAgregarAlerta.Hide();
            lblEliminarAlerta.Hide();
            lblScanAlerta.Hide();

            // Inicializamos la dataGrid
            mostrarLista(true);
        }

        // Al seleccionar una opcion en el comboBox 1
        private void comboBoxAgregar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eliminamos todos los items para que no se dupliquen y borramos las selecciones
            AgregarLimpiar();
            comboBoxAgregar2.Items.Clear();

            // Habilitamos los paneles con sus opciones respectivas y cambiamos algunas labels
            if (comboBoxAgregar1.SelectedItem.ToString() == "Tesla")        // Si esta seleccionado Tesla
            {
                panelAgregarModelo.Enabled = true;
                comboBoxAgregar2.Items.Add("Modelo X");
                comboBoxAgregar2.Items.Add("Modelo S");
                comboBoxAgregar2.Items.Add("Cybertruck");
                lblAgregarDuenio.Text = "Dueño";
                lblAgregarKm.Text = "Km";
            }
            if (comboBoxAgregar1.SelectedItem.ToString() == "SpaceX")       // Si esta seleccionado SpaceX
            {
                panelAgregarModelo.Enabled = true;
                comboBoxAgregar2.Items.Add("Starship");
                comboBoxAgregar2.Items.Add("Falcon 9");
                lblAgregarDuenio.Text = "Empresa";
                lblAgregarKm.Text = "Hs";
            }
        }

        // Al seleccionar un modelo
        private void comboBoxAgregar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si se selecciona alguna opcion en modelo habilitamos el siguiente panel
            panelAgregarDatos.Enabled = true;
        }

        // Al darle al boton "Dar De Alta"
        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (txtBoxColor.Text != "" && txtBoxDuenio.Text != "")  // Si se pulsa el boton y no estan los campos vacios
            {
                // Creamos el objeto y limpiamos todo el menu
                CrearObjeto(comboBoxAgregar1.SelectedIndex, comboBoxAgregar2.SelectedIndex, Decimal.ToInt32(numAnio.Value), Decimal.ToInt32(numKm.Value), txtBoxDuenio.Text, txtBoxColor.Text);
                AgregarLimpiar();
                comboBoxAgregar1.Text = "- Seleccione una opcion -";
            }
            else       // si hay algun campo vacio
            {
                lblAgregarAlerta.Show();        // mostrar alerta
            }
        }

        // Al darle al boton "Generar Tesla"
        private void bttnGenerarTesla_Click(object sender, EventArgs e)
        {
            GenerarTeslaSpacexAleatorio(true);      // generamos un tesla aleatorio
            lblGridTitulo.Text = "Lista de Tesla";      // cambiamos el titulo
            bttnCambiarLista.Text = "Ver lista SpaceX";     // cambiamos el texto del boton
        }

        // Al darle al boton "Generar SpaceX"
        private void bttnGenerarSpacex_Click(object sender, EventArgs e)
        {
            GenerarTeslaSpacexAleatorio(false);  // generamos un cohete aleatorio
            lblGridTitulo.Text = "Lista de SpaceX";  // cambiamos el titulo
            bttnCambiarLista.Text = "Ver lista Tesla"; // cambiamos el texto del boton
        } 

        // Al darle al boton "Cambiar Lista" o "Ver lista Tesla/SpaceX"
        private void bttnCambiarLista_Click(object sender, EventArgs e)
        {
            if (bttnCambiarLista.Text == "Ver lista SpaceX")    // Si se esta mostrando la lista de teslas
            {
                mostrarLista(false);    // mostrar la lista de spacex
                lblGridTitulo.Text = "Lista de SpaceX";     //cambiar titulo
                bttnCambiarLista.Text = "Ver lista Tesla";  // cambiar texto del boton

            }
            else if (bttnCambiarLista.Text == "Ver lista Tesla")    // Si se esta mostrando la lista de teslas
            {
                mostrarLista(true);  // mostrar la lista de spacex
                lblGridTitulo.Text = "Lista de Tesla"; //cambiar titulo
                bttnCambiarLista.Text = "Ver lista SpaceX"; // cambiar texto del boton
            }
        }

        // Al  darle al boton de "Eliminar"
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridVehiculos.SelectedRows.Count > 0)   // si hay mas de un elemento seleccionado en el datagridview de vehiculos
            {
                foreach (DataGridViewRow fila in dataGridVehiculos.SelectedRows)    // recorremos la lista de elementos seleccionados
                {
                    int idEliminar = Convert.ToInt32(fila.Cells["ID"].Value);       // extraemos el id del objeto a eliminar
                    if (lblGridTitulo.Text == "Lista de Tesla")                 // si esta mostrandose la lista de teslas
                    {
                        teslas.RemoveAll(t=> t.ID == idEliminar);               // elimina de la lista de teslas los elementos que coincidan con el id 
                        dataGridVehiculos.Rows.Remove(fila);                // elimina la fila
                        if (teslas.Count > 0)                               // si en la lista queda mas de 0 elementos 
                        {
                            TeslaConMasKm();            // llama la funcion Tesla con mas km para actualizar el valor
                        }
                        else                    // si no hay nada en la lista 
                        {
                            dataGridTeslaKm.Rows.RemoveAt(0);           // borra la fila del datagridview del tesla con mas km
                        }
                    }
                    else    // si esta mostrandose la lista de cohetes
                    {
                        cohetes.RemoveAll(c => c.ID == idEliminar);  // elimina de la lista de cohetes los elementos que coincidan con el id
                        dataGridVehiculos.Rows.Remove(fila);    // elimina la fila
                    }
                }
                scanLimpiar();          // reiniciamos el apartado de escaneo
                lblEliminarAlerta.Hide();       // escondemos la alerta
            }
            else    // si no hay elementos seleccionados
            {
                lblEliminarAlerta.Show();       // mostrar la alerta
            }
        }

        // Al darle al boton "Escanear"
        private void bttnScan_Click(object sender, EventArgs e)
        {
            if (dataGridVehiculos.SelectedRows.Count == 1)  // si hay 1 unico elemento seleccionado en el datagridview de vehiculos
            {
                GBoxScan.Enabled = true;        // habilitar el panel de escaneo
                DataGridViewRow fila = dataGridVehiculos.SelectedRows[0];   // creamos una variable tipo row (Fila) y extraemos la fila seleccionada del arreglo en el que se encuetra

                // configuraciones de visualizacion del datagridview service
                dataGridService.DataSource = null;
                dataGridService.ReadOnly = true;              // Hacemos que no se puedan modificar/agregar columnas a traves de la DataGrid
                dataGridService.Columns.Clear();              // borramos todas las columnas
                dataGridService.AllowUserToAddRows = false;   // Para que no se genere una fila vacia al inicio
                dataGridService.AutoGenerateColumns = false;  // para que no se generen columnas automaticamente
                dataGridService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;    // que se seleccione toda la fila al darle click

                // agregamos las columnas, ancho y las centramos
                dataGridService.Columns.Add("numService", "Service");
                dataGridService.Columns["numService"].Width = 64;
                dataGridService.Columns["numService"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridService.Columns.Add("cinturones", "(1)");
                dataGridService.Columns["cinturones"].Width = 22;
                dataGridService.Columns["cinturones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridService.Columns.Add("baterias", "(2)");
                dataGridService.Columns["baterias"].Width = 22;
                dataGridService.Columns["baterias"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridService.Columns.Add("propulsion", "(3)");
                dataGridService.Columns["propulsion"].Width = 22;
                dataGridService.Columns["propulsion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridService.Columns.Add("navegacion", "(4)");
                dataGridService.Columns["navegacion"].Width = 22;
                dataGridService.Columns["navegacion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridService.Columns.Add("traccion", "(5)");
                dataGridService.Columns["traccion"].Width = 22;
                dataGridService.Columns["traccion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridService.Columns.Add("motor", "(6)");
                dataGridService.Columns["motor"].Width = 22;
                dataGridService.Columns["motor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // inicializamos variables que dependeran del modelo, o si es un tesla o spacex
                int kmActuales;
                int serviceKm;
                bool isTesla;

                if (fila.Cells["kmActual"].Value != null)   // si en la fila, en la columna "kmActual" no esta vacia, utilizado para identificar si es un tesla o un spacex, si tiene valor = tesla
                {
                    int id = Convert.ToInt32(fila.Cells["ID"].Value);   // extraemos el id del elemento
                    int index = teslas.FindIndex(t => t.ID == id);      // extraemos el index en la lista del elemento a partir del id
                    // mostramos informacion sobre el vehiculo
                    lblModel.Text = $"Modelo: {teslas[index].Modelo}";      
                    lblAutonomia.Text = $"Autonomia: {teslas[index].Autonomia}Km";  
                    lblService.Text = $"Service: {teslas[index].ServiceKm}Km";
                    lblAsientos.Text = $"Asientos: {teslas[index].Asientos}";
                    lblAsientos.Show();     // mostramos los asientos en caso de estar ocultos

                    // le pasamos datos sobre el modelo a las variables previamente inicializadas
                    isTesla = true;         
                    kmActuales = teslas[index].KmActual;
                    serviceKm = teslas[index].ServiceKm;
                    LogoImage.Image = Properties.Resources.Tesla_Logo;
                }
                else    // si la columna kmActual tiene un valor null 
                {
                    int id = Convert.ToInt32(fila.Cells["ID"].Value);  // extraemos el id del elemento
                    int index = cohetes.FindIndex(t => t.ID == id); // extraemos el index en la lista del elemento a partir del id
                    // mostramos informacion sobre el vehiculo
                    lblModel.Text = $"Modelo: {cohetes[index].Modelo}";
                    lblAutonomia.Text = $"Autonomia: {cohetes[index].Autonomia}Hs";
                    lblService.Text = $"Service: {cohetes[index].ServiceHs}Hs";
                    lblAsientos.Hide();     // escondemos el texto de asientos ya que no tiene

                    // le pasamos datos sobre el modelo a las variables previamente inicializadas
                    isTesla = false;
                    kmActuales = cohetes[index].HsActual;
                    serviceKm = cohetes[index].ServiceHs;
                    LogoImage.Image = Properties.Resources.SpaceX_Logo;
                }

                // inicializamos los contadores necesarios para establecer cuando se deben hacer los mantenimientos
                int cinturonesContador = 0;
                int bateriasContador = 0;
                int propulsionContador = 0;
                int navegacionContador = 0;
                int traccionContador = 0;
                int motorContador = 0;
                int service = 1;
                while (kmActuales >= serviceKm)     // mientras los km actuales sean mayor o igual a los km para ir a service
                {
                    // inicializamos una variable con valor null, en caso de hacer el mantenimiento el valor cambia
                    string cinturones = null;
                    string baterias = null;
                    string propulsion = null;
                    string navegacion = null;
                    string traccion = null;
                    string motor = null;

                    // sumamos Valores a los contadores, cada vez que se va al service tiene siempre mas kilometros dependiendo de cada cuanto se haga (depende del modelo)
                    cinturonesContador += serviceKm;
                    bateriasContador += serviceKm;
                    propulsionContador += serviceKm;
                    navegacionContador += serviceKm;
                    traccionContador += serviceKm;
                    motorContador += serviceKm;

                    // Verificamos si toca hacer mantenimiento de cada una de las cosas y en caso de que si se modifica el valor str inicializado arriba
                    if (isTesla && cinturonesContador >= 1000) { cinturones = "✔"; cinturonesContador = 0; }
                    if (isTesla && bateriasContador >= 2000) { baterias = "✔"; bateriasContador = 0; }
                    if (!isTesla && propulsionContador >= 1000) { propulsion = "✔"; propulsionContador = 0; }
                    if ((isTesla && navegacionContador >= 2500) || (!isTesla && navegacionContador >= 500)) { navegacion = "✔"; navegacionContador = 0; }
                    if (isTesla && traccionContador >= 3000) { traccion = "✔"; traccionContador = 0; }
                    if (isTesla && motorContador >= 3000) { motor = "✔"; motorContador = 0; }

                    // Generamos una fila
                    DataGridViewRow newFila = new DataGridViewRow();
                    newFila.Height = 18;    // le damos un alto a la fila (tamaño)

                    DataGridViewCell serviceNumCell = new DataGridViewTextBoxCell();            // Cremos una celda
                    serviceNumCell.Value = $"service{service}";         // le damos un valor
                    newFila.Cells.Add(serviceNumCell);                  // agregamos la celda a la fila
                    service++;  // aumentamos el numero de service, asi el proximo sera el serviceN+1
                    
                    DataGridViewCell cinturonesCell = new DataGridViewTextBoxCell();
                    cinturonesCell.Value = cinturones;
                    newFila.Cells.Add(cinturonesCell);

                    DataGridViewCell bateriasCell = new DataGridViewTextBoxCell();
                    bateriasCell.Value = baterias;
                    newFila.Cells.Add(bateriasCell);

                    DataGridViewCell propulsionCell = new DataGridViewTextBoxCell();
                    propulsionCell.Value = propulsion;
                    newFila.Cells.Add(propulsionCell);

                    DataGridViewCell navegacionCell = new DataGridViewTextBoxCell();
                    navegacionCell.Value = navegacion;
                    newFila.Cells.Add(navegacionCell);

                    DataGridViewCell traccionCell = new DataGridViewTextBoxCell();
                    traccionCell.Value = traccion;
                    newFila.Cells.Add(traccionCell);

                    DataGridViewCell motorCell = new DataGridViewTextBoxCell();
                    motorCell.Value = motor;
                    newFila.Cells.Add(motorCell);

                    // agregamos la fila al datagrid service
                    dataGridService.Rows.Add(newFila);
                    kmActuales -= serviceKm;        // restamos los km de cada cuanto se hace el service a los km actuales
                }

                lblScanAlerta.Hide();   // escondemos la alerta
            }
            else if (dataGridVehiculos.SelectedRows.Count > 1)      // si hay mas de una fila seleccionada
            {
                lblScanAlerta.Text = "Seleccione unicamente una fila!";     // cambiamos el texto de la alerta
                lblScanAlerta.Show();       // mostramos la alerta
            }
            else // si no hay ninguna fila seleccionada
            {
                lblScanAlerta.Text = "Seleccione una fila!";  // cambiamos el texto de la alerta
                lblScanAlerta.Show(); // mostramos la alerta
            }
        }
    }
}
