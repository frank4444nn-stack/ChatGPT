using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SistemaCarreteras.Entidades;
using SistemaCarreteras.Controladores;
using SistemaCarreteras.Formularios;

class Pruebas
{
    static int total;
    static void Verificar(bool valor, string nombre)
    {
        if (!valor) throw new Exception("FALLO: " + nombre);
        total++;
        Console.WriteLine("OK " + total + ": " + nombre);
    }
    static T Control<T>(Form frm, string nombre) where T : class
    {
        return (T)frm.GetType().GetField(nombre, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(frm);
    }
    static void Limpiar()
    {
        TListaExtremoCarretera.listaExtremos.Clear();
        TListaComunaRecorrida.listaRecorridos.Clear();
        TListaTramo.listaTramos.Clear();
        TListaCarretera.listaCarreteras.Clear();
        TListaComuna.listaComunas.Clear();
        TListaCategoria.listaCategorias.Clear();
    }
    [STAThread]
    static int Main()
    {
        try
        {
            Application.EnableVisualStyles();
            Limpiar();
            TListaDatos.CargarDatos();
            Verificar(TListaCategoria.GetLista().Count == 5, "Carga inicial de categorías");
            Verificar(TListaCarretera.GetLista().Count == 5, "Carga inicial de carreteras");
            Verificar(TListaTramo.GetLista().Count == 10, "Carga inicial de tramos");
            Verificar(TListaComunaRecorrida.GetLista().Count == 15, "Carga inicial de recorridos");
            Verificar(TListaExtremoCarretera.GetLista().Count == 6, "Carga inicial de extremos");
            Verificar(TListaExtremoCarretera.GetLista().All(TListaExtremoCarretera.Validar), "Extremos de ejemplo válidos");
            TListaDatos.CargarDatos();
            Verificar(TListaTramo.GetLista().Count == 10, "Carga repetida no duplica datos");

            Form[] forms = { new frmPrincipal(), new frmadminCategoria(), new frmAdminCarretera(), new frmAdminComuna(),
                new frmAdminTramo(), new frmAdminComunaRecorrida(), new frmAdminExtremo(), new frmCategoria(),
                new frmCarretera(), new frmComuna(), new frmTramo(), new frmComunaRecorrida(), new frmExtremo(), new frmConsultas() };
            foreach (Form f in forms)
            {
                f.Show(); Application.DoEvents();
                Verificar(f.Visible && f.IsHandleCreated, "Abre " + f.GetType().Name);
                f.Close(); f.Dispose();
            }
            using (frmPrincipal f = new frmPrincipal())
            {
                f.Show(); Application.DoEvents();
                ToolStripMenuItem menu = Control<ToolStripMenuItem>(f, "carreterasToolStripMenuItem");
                Verificar(menu != null && menu.Enabled, "Menú de carreteras disponible");
                f.Close();
            }
            using (frmAdminCarretera f = new frmAdminCarretera())
            {
                f.Show(); Application.DoEvents();
                Verificar(Control<DataGridView>(f,"dgvCarreteras").Rows.Count == 5, "Listado carreteras");
                Control<ComboBox>(f,"cboCategoria").SelectedItem = "Categoría";
                Control<TextBox>(f,"txtBuscar").Text = "regional";
                Verificar(Control<DataGridView>(f,"dgvCarreteras").Rows.Count == 1, "Filtro categoría carretera");
                f.Close();
            }
            using (frmAdminTramo f = new frmAdminTramo())
            {
                f.Show(); Application.DoEvents();
                Control<ComboBox>(f,"cboBuscarPor").SelectedItem = "Carretera";
                Control<TextBox>(f,"txtBuscar").Text = "101";
                DataGridView g = Control<DataGridView>(f,"dgvTramos");
                Verificar(g.Rows.Count == 2 && ((Tramo)g.Rows[0].Tag).Numero == 1, "Tramos por carretera ordenados");
                Control<ComboBox>(f,"cboBuscarPor").SelectedItem = "Rango de kilómetros";
                Control<TextBox>(f,"txtBuscar").Text = "2;4";
                Verificar(g.Rows.Count == 5, "Rango busca intersecciones");
                Control<TextBox>(f,"txtBuscar").Text = "abc";
                Verificar(g.Rows.Count == 0, "Rango inválido no muestra datos anteriores");
                f.Close();
            }
            using (frmAdminComuna f = new frmAdminComuna())
            {
                f.Show(); Application.DoEvents();
                Control<ComboBox>(f,"cboBuscarPor").SelectedItem = "Cantón";
                Control<TextBox>(f,"txtBuscar").Text = "Arenillas";
                DataGridView g = Control<DataGridView>(f,"dgvComunas");
                Verificar(g.Rows.Count == 1 && ((Comuna)g.Rows[0].Tag).Codigo == 6, "Fila filtrada mantiene el objeto correcto");
                f.Close();
            }
            using (frmComunaRecorrida f = new frmComunaRecorrida())
            {
                ComunaRecorrida r = TListaComunaRecorrida.Buscar(101, 1, 2);
                f.setDatos(r);
                Verificar(f.ValidarDatos(), "setDatos de recorrido conserva selección");
                Control<TextBox>(f,"txtOrden").Text = "3";
                f.Guardar();
                Verificar(f.DialogResult == DialogResult.OK && f.CrearObjeto().Orden == 3, "Guardar recorrido devuelve OK y objeto nuevo");
                Verificar(TListaComunaRecorrida.Buscar(101,1,2) == r, "Formulario no cambia lista antes de aceptar en administrador");
            }
            using (frmExtremo f = new frmExtremo())
            {
                f.setDatos(TListaExtremoCarretera.Buscar(101,"Final"));
                Verificar(f.ValidarDatos(), "setDatos extremo carga cascadas y destino");
                Control<ComboBox>(f,"cboTipoFinalizacion").SelectedItem = "Finalización física";
                Verificar(!Control<ComboBox>(f,"cboCarreteraDestino").Enabled && Control<TextBox>(f,"txtKmDestino").Text == "", "Final físico desactiva y limpia destino");
                f.Guardar();
                Verificar(f.DialogResult == DialogResult.OK && f.CrearObjeto().CarreteraDestino == null, "Final físico crea objeto sin destino");
            }
            using (frmTramo f = new frmTramo())
            {
                f.setDatos(TListaTramo.Buscar(101,1));
                Verificar(!Control<ComboBox>(f,"cboCarretera").Enabled && Control<TextBox>(f,"txtLongitud").Text == "10", "Tramo no se transfiere y calcula longitud");
            }
            using (frmConsultas f = new frmConsultas())
            {
                f.Show(); Application.DoEvents();
                int[] esperados = { 1, 2, 2, 2, 1 };
                ComboBox q = Control<ComboBox>(f,"cboConsulta");
                Control<ComboBox>(f,"cboCategoria").SelectedItem = TListaCategoria.Buscar(3);
                for (int i=0; i<5; i++)
                {
                    q.SelectedIndex = i;
                    f.Consultar(); Application.DoEvents();
                    DataGridView g = Control<DataGridView>(f,"dgvConsulta");
                    Verificar(g.Rows.Count == esperados[i], "Consulta LINQ " + (i+1));
                    if (i==0) Verificar(Convert.ToDouble(g.Rows[0].Cells["LongitudTotal"].Value) == 20, "Longitud total de carretera suma tramos");
                }
                f.Close();
            }

            Limpiar();
            Categoria ca = new Categoria(1,"Regional");
            Comuna co = new Comuna(1,"Comuna A","Cantón A","Provincia A");
            Comuna co2 = new Comuna(2,"Comuna B","Cantón B","Provincia B");
            Carretera a = new Carretera(101,"Carretera A", ca), b = new Carretera(102,"Carretera B", ca);
            Verificar(!TListaCategoria.Agregar(new Categoria(0,"X")), "Categoría rechaza código cero");
            Verificar(TListaCategoria.Agregar(ca) && !TListaCategoria.Agregar(new Categoria(1,"Otra")), "Categoría única");
            Verificar(TListaCarretera.Agregar(a) && TListaCarretera.Agregar(b), "Carreteras con categoría válida");
            Verificar(!TListaCarretera.Agregar(new Carretera(103,"X",new Categoria(99,"Inexistente"))), "Rechaza categoría inexistente");
            Verificar(TListaComuna.Agregar(co) && TListaComuna.Agregar(co2), "Comunas válidas");
            Tramo t = new Tramo(a,1,0,10), u = new Tramo(b,1,0,10);
            Verificar(TListaTramo.Agregar(t) && TListaTramo.Agregar(u), "Mismo número en distintas carreteras");
            Verificar(!TListaTramo.Agregar(new Tramo(a,1,0,20)), "Rechaza número duplicado dentro de carretera");
            Verificar(!TListaTramo.Agregar(new Tramo(a,2,10,10)), "Rechaza longitud cero");
            Verificar(!TListaTramo.Agregar(new Tramo(a,2,-1,10)), "Rechaza kilómetro negativo");
            Verificar(!TListaTramo.Agregar(new Tramo(a,2,0,double.NaN)), "Rechaza NaN");
            Verificar(!TListaTramo.Agregar(new Tramo(a,2,0,double.PositiveInfinity)), "Rechaza infinito");
            ComunaRecorrida r1=new ComunaRecorrida(t,co,1,0,10), r2=new ComunaRecorrida(u,co,1,0,10);
            Verificar(TListaComunaRecorrida.Agregar(r1) && TListaComunaRecorrida.Agregar(r2), "Comuna en varios tramos");
            Verificar(!TListaComunaRecorrida.Agregar(new ComunaRecorrida(t,co2,1,0,5)), "Rechaza orden duplicado");
            Verificar(!TListaComunaRecorrida.Agregar(new ComunaRecorrida(t,co2,2,8,2)), "Rechaza entrada mayor a salida");
            Verificar(!TListaComunaRecorrida.Agregar(new ComunaRecorrida(t,co2,2,0,11)), "Rechaza salida fuera de tramo");
            Verificar(TListaComunaRecorrida.Agregar(new ComunaRecorrida(t,co2,2,5,5)), "Acepta entrada igual a salida");
            Verificar(!TListaComunaRecorrida.Modificar(r1,new ComunaRecorrida(t,co,2,0,10)), "Edición no pisa otro orden");
            Verificar(TListaComunaRecorrida.Modificar(r1,new ComunaRecorrida(t,co,3,0,10)) && TListaComunaRecorrida.Buscar(101,1,1)==null, "Edición cambia orden sin perder el registro");
            r1=TListaComunaRecorrida.Buscar(101,1,3);
            ExtremoCarretera e = new ExtremoCarretera(a,"Inicio",t,co,0,"Finalización física",null,null,null,0,"");
            Verificar(TListaExtremoCarretera.Agregar(e), "Inicio físico sin destino");
            Verificar(!TListaExtremoCarretera.Agregar(e), "Un inicio por carretera");
            Verificar(!TListaExtremoCarretera.Validar(new ExtremoCarretera(a,"Final",t,co,5,"Finalización física",null,null,null,0,"")), "Final debe coincidir con límite");
            Verificar(!TListaExtremoCarretera.Validar(new ExtremoCarretera(a,"Final",u,co,10,"Finalización física",null,null,null,0,"")), "Tramo pertenece a carretera indicada");
            Verificar(!TListaExtremoCarretera.Validar(new ExtremoCarretera(a,"Final",t,co,10,"Confluencia con otra carretera",a,t,co,5,"Unión")), "No confluye consigo misma");
            Verificar(!TListaExtremoCarretera.Validar(new ExtremoCarretera(a,"Final",t,co,10,"Confluencia con otra carretera",b,u,co,5,"")), "Confluencia requiere observación");
            Verificar(!TListaExtremoCarretera.Validar(new ExtremoCarretera(a,"Final",t,co,10,"Confluencia con otra carretera",b,u,co,11,"Unión")), "Confluencia valida kilómetro destino");
            Verificar(!TListaExtremoCarretera.Validar(new ExtremoCarretera(a,"Final",t,co,10,"Confluencia con otra carretera",b,u,co2,5,"Unión")), "Comuna destino debe ser recorrida");
            ExtremoCarretera fin=new ExtremoCarretera(a,"Final",t,co,10,"Confluencia con otra carretera",b,u,co,5,"Unión");
            Verificar(TListaExtremoCarretera.Agregar(fin), "Confluencia válida");
            Verificar(!TListaCategoria.Eliminar(1), "No elimina categoría usada");
            Verificar(!TListaCarretera.Eliminar(101), "No elimina carretera con tramos");
            Verificar(!TListaTramo.Eliminar(101,1), "No elimina tramo con relaciones");
            Verificar(!TListaComuna.Eliminar(1), "No elimina comuna recorrida");
            Verificar(!TListaComunaRecorrida.Eliminar(101,1,3), "No elimina recorrido que sostiene extremo");
            Verificar(!TListaComunaRecorrida.Modificar(r1,new ComunaRecorrida(t,co,3,1,9)), "No deja extremo sin cobertura al editar recorrido");
            Verificar(!TListaTramo.Modificar(new Tramo(a,1,1,9)) && t.KmInicial==0, "Edición rechazada conserva tramo original");
            Verificar(!TListaTramo.Agregar(new Tramo(a,2,10,20)), "Agregar tramo no invalida final registrado");
            Verificar(TListaCategoria.Modificar(new Categoria(1,"Nueva categoría")) && a.NombreCategoria=="Nueva categoría", "Modificar categoría conserva referencias");
            Verificar(TListaCarretera.Modificar(new Carretera(101,"Nuevo nombre",ca)) && t.NombreCarretera=="Nuevo nombre", "Modificar carretera conserva referencias");
            Verificar(TListaComuna.Modificar(new Comuna(1,"Nuevo nombre","Cantón A","Provincia A")) && r1.NombreComuna=="Nuevo nombre", "Modificar comuna conserva referencias");
            Verificar(TListaExtremoCarretera.Eliminar(101,"Inicio") && TListaExtremoCarretera.Eliminar(101,"Final"), "Eliminar extremos");
            Verificar(TListaComunaRecorrida.Eliminar(101,1,3), "Eliminar recorrido al quitar extremos");
            Verificar(TListaComunaRecorrida.Eliminar(101,1,2) && TListaTramo.Eliminar(101,1), "Eliminar tramo al liberar relaciones");
            Verificar(TListaCarretera.Eliminar(101), "Eliminar carretera al liberar tramos");
            Verificar(TListaComunaRecorrida.Eliminar(102,1,1) && TListaComuna.Eliminar(1), "Eliminar comuna al liberar relaciones");
            TListaDatos.CargarDatos();
            Verificar(TListaCarretera.GetLista().Count==1, "Abrir pantallas no repone datos eliminados");
            Console.WriteLine("TOTAL: " + total + " pruebas aprobadas.");
            return 0;
        }
        catch(Exception ex) { Console.WriteLine(ex); return 1; }
    }
}
