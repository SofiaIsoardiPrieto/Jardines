using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2Jardines.Servicios.Servicios;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades.Dtos.Categoria;
using Ejercicio2Jardines.Entidades.Dtos.Compra;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Proveedor;

namespace Ejercicio2Jardines.Windows.Helper
{
    public static class CombosHelper
    {
        public static void CargarComboPaises(ref ComboBox combo)
        {
            IServiciosPaises serviciosPaises = new ServiciosPaises();
            var lista = serviciosPaises.GetPaises(null);
            var defaultPais = new Pais()
            {
                PaisId = 0,
                NombrePais = "Seleccione País"
            };
            lista.Insert(0, defaultPais);
            combo.DataSource = lista;
            combo.DisplayMember = "NombrePais";
            combo.ValueMember = "PaisId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboCiudades(ref ComboBox combo, int paisId)
        {
            IServiciosCiudades serviciosPaises = new ServiciosCiudades();
            var lista = serviciosPaises.GetCiudades(paisId);
            var defaultCiudad = new CiudadDto()
            {
                CiudadId = 0,
                NombreCiudad = "Seleccione Ciudad"
            };
            lista.Insert(0, defaultCiudad);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCiudad";
            combo.ValueMember = "CiudadId";
            combo.SelectedIndex = 0;
        }
        public static void CargarComboCliente(ref ComboBox combo)
        {
            IServiciosClientes serviciosClientes = new ServiciosClientes();
            var lista = serviciosClientes.GetClienteComboDto();
            var defaultCliente = new ClienteComboDto()
            {
                ClienteId = 0,
                NombreCompleto = "Seleccione Cliente"
                
            };
            lista.Insert(0, defaultCliente);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCompleto";
            combo.ValueMember = "ClienteId";
            combo.SelectedIndex = 0;
        }
        public static void CargarComboCategoria(ref ComboBox combo)
        {
            IServiciosCategorias serviciosCategorias = new ServiciosCategorias();
            var lista = serviciosCategorias.GetCategoriaComboDto();
            var defaultCategoria = new CategoriaComboDto()
            {
                CategoriaId = 0,
                NombreCategoria = "Seleccione Categoria"

            };
            lista.Insert(0, defaultCategoria);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCategoria";
            combo.ValueMember = "CategoriaId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboProveedores(ref ComboBox combo)
        {
            IServiciosProveedores serviciosProveedores = new ServiciosProveedores();
            var lista = serviciosProveedores.GetProveedoresComboDto();
            var defaultProveedor = new ProveedorComboDto()
            {
                ProveedorId = 0,
                NombreProveedor = "Seleccione Proveedor"

            };
            lista.Insert(0, defaultProveedor);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProveedor";
            combo.ValueMember = "ProveedorId";
            combo.SelectedIndex = 0;
        }
    }
}
