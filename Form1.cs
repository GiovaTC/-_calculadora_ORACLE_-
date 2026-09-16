using CalculadoraOracle_19C.Models;
using CalculadoraOracle_19C.Repositories;
using System.Globalization;

namespace CalculadoraOracle_19C
{
    public partial class Form1 : Form
    {
        private readonly OperacionRepository repository;

        public Form1()
        {
            InitializeComponent();

            repository = new OperacionRepository();

            CargarHistorial();
        }

        // =====================================================
        // CALCULAR
        // =====================================================

        private void btnCalcular_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                // ---------------------------------------------
                // Validar número 1
                // ---------------------------------------------

                if (!decimal.TryParse(
                    txtNumero1.Text,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal numero1))
                {
                    MessageBox.Show(
                        "Ingrese correctamente el número 1.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtNumero1.Focus();

                    return;
                }

                // ---------------------------------------------
                // Validar número 2
                // ---------------------------------------------

                if (!decimal.TryParse(
                    txtNumero2.Text,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal numero2))
                {
                    MessageBox.Show(
                        "Ingrese correctamente el número 2.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtNumero2.Focus();

                    return;
                }

                // ---------------------------------------------
                // Obtener operador
                // ---------------------------------------------

                string operador =
                    cmbOperador.SelectedItem?.ToString()
                    ?? string.Empty;

                if (string.IsNullOrEmpty(operador))
                {
                    MessageBox.Show(
                        "Seleccione un operador.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbOperador.Focus();

                    return;
                }

                // ---------------------------------------------
                // Realizar operación
                // ---------------------------------------------

                decimal resultado;

                switch (operador)
                {
                    case "+":

                        resultado = numero1 + numero2;

                        break;

                    case "-":

                        resultado = numero1 - numero2;

                        break;

                    case "*":

                        resultado = numero1 * numero2;

                        break;

                    case "/":

                        if (numero2 == 0)
                        {
                            MessageBox.Show(
                                "No es posible dividir por cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            txtNumero2.Focus();

                            return;
                        }

                        resultado = numero1 / numero2;

                        break;

                    default:

                        MessageBox.Show(
                            "Operador no válido.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                }

                // ---------------------------------------------
                // Mostrar resultado
                // ---------------------------------------------

                txtResultado.Text =
                    resultado.ToString(
                        "0.##########",
                        CultureInfo.InvariantCulture
                    );

                // ---------------------------------------------
                // Crear objeto
                // ---------------------------------------------

                Operacion operacion = new Operacion
                {
                    Numero1 = numero1,
                    Operador = operador,
                    Numero2 = numero2,
                    Resultado = resultado
                };

                // ---------------------------------------------
                // Guardar en Oracle
                // ---------------------------------------------

                repository.Insertar(operacion);

                // ---------------------------------------------
                // Actualizar historial
                // ---------------------------------------------

                CargarHistorial();

                MessageBox.Show(
                    "Operación calculada y almacenada correctamente en Oracle 19c.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al realizar la operación:\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // LIMPIAR
        // =====================================================

        private void btnLimpiar_Click(
            object? sender,
            EventArgs e)
        {
            txtNumero1.Clear();

            txtNumero2.Clear();

            txtResultado.Clear();

            cmbOperador.SelectedIndex = 0;

            txtNumero1.Focus();
        }

        // =====================================================
        // ACTUALIZAR HISTORIAL
        // =====================================================

        private void btnActualizar_Click(
            object? sender,
            EventArgs e)
        {
            CargarHistorial();
        }

        // =====================================================
        // ELIMINAR HISTORIAL
        // =====================================================

        private void btnEliminarHistorial_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Está seguro de eliminar todo el historial?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                repository.EliminarTodas();

                CargarHistorial();

                txtResultado.Clear();

                MessageBox.Show(
                    "El historial fue eliminado correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible eliminar el historial:\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // CARGAR HISTORIAL
        // =====================================================

        private void CargarHistorial()
        {
            try
            {
                List<Operacion> operaciones =
                    repository.ObtenerTodas();

                dgvHistorial.DataSource = null;

                dgvHistorial.DataSource = operaciones;

                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible consultar Oracle 19c.\n\n"
                    + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // CONFIGURAR COLUMNAS DEL GRID
        // =====================================================

        private void ConfigurarColumnas()
        {
            if (dgvHistorial.Columns.Count == 0)
            {
                return;
            }

            dgvHistorial.Columns["Id"].HeaderText =
                "ID";

            dgvHistorial.Columns["Numero1"].HeaderText =
                "Número 1";

            dgvHistorial.Columns["Operador"].HeaderText =
                "Operador";

            dgvHistorial.Columns["Numero2"].HeaderText =
                "Número 2";

            dgvHistorial.Columns["Resultado"].HeaderText =
                "Resultado";

            dgvHistorial.Columns["FechaOperacion"].HeaderText =
                "Fecha";

            // ---------------------------------------------
            // Formato de números
            // ---------------------------------------------

            dgvHistorial.Columns["Numero1"]
                .DefaultCellStyle.Format =
                "0.##########";

            dgvHistorial.Columns["Numero2"]
                .DefaultCellStyle.Format =
                "0.##########";

            dgvHistorial.Columns["Resultado"]
                .DefaultCellStyle.Format =
                "0.##########";

            // ---------------------------------------------
            // Formato de fecha
            // ---------------------------------------------

            dgvHistorial.Columns["FechaOperacion"]
                .DefaultCellStyle.Format =
                "dd/MM/yyyy HH:mm:ss";
        }
    }
}   