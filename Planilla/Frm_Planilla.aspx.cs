using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculo_Planilla
{ // ========================== Inicio del Namespace ========================== //

	public partial class Frm_Planilla : System.Web.UI.Page
	{ // ----------------- Inicio de la Clase ----------------- //

		double var_Valor; // Este es una variable global
		protected void Page_Load(object sender, EventArgs e)
		{ // ============= Inicio del Load ================ //

		} // =============  Fin  del Load  ================ // 

		protected void Obj_Calcular_Click(object sender, EventArgs e)
		{ // ************* Inicio del Botón Calcular ************* //

			double var_Horas_Trabajadas = Convert.ToDouble(Obj_Horas_Trabajadas.Text);
			double var_Costo_Hora = Convert.ToDouble(Obj_Costo_Hora.Text);
			double var_Horas_Extras = Convert.ToDouble(Obj_Horas_extras.Text);
			double var_Salario_Bruto = Salario_Bruto(var_Horas_Trabajadas, var_Costo_Hora, var_Horas_Extras);
			double var_Deducciones = Deducciones(var_Salario_Bruto);
			double var_Salario_Neto = Salario_Neto(var_Salario_Bruto, var_Deducciones);

			Obj_Salario_Bruto.Text = var_Salario_Bruto.ToString();
			Obj_Deducciones.Text = var_Deducciones.ToString();
			Obj_Salario_Neto.Text = var_Salario_Neto.ToString();

		} // *************  Fin  del Botón Calcular ************* //

		// ************* Inicio de los UDF. ************* //
		double Salario_Bruto(double p_Horas_Trabajadas, double p_Valor_Hora, double p_Horas_Extras)  /* la "p" significa que es un parametro que resive */
		{ // ************* Inicio Funsión Salario Bruto ************* //
			return ((p_Horas_Trabajadas * p_Valor_Hora) + (p_Horas_Extras * p_Valor_Hora * 1.5)); //funsion para calcular el salario bruto
		} // *************  Fin  Funsión Salario Bruto ************* //
		double Deducciones(double p_Salario_Bruto)  /* la "p" significa que es un parametro que resive */
		{ // ************* Inicio Funsión Deducciones ************* //
			return (p_Salario_Bruto * 0.09);
		} // *************  Fin  Funsión Deducciones  ************* //
		double Salario_Neto(double p_Salario_bruto, double p_Deducciones)  /* la "p" significa que es un parametro que resive */
		{ // ************* Inicio Funsión Salario Neto ************* //
			double var_Salario_Neto;
			var_Salario_Neto = p_Salario_bruto - p_Deducciones;
			return (var_Salario_Neto);  // Return significa que devuelva al medio de donde fue llamado (Whatever)
		} // *************  Fin  Funsión  Salario Neto ************* //

		// En estas funciones lo parametros entran por valor, ojo, esto significa que el valor de esos parametros no cambia.
		// Existen otros parametros que se denominan parametros por referencia. Estos parametros si cambian su valor.



		// ************* Fin  de  los  UDF. ************* //

	}  // -----------------  Fin  de la  Clase ----------------- // 

} // ==========================  Fin  del  Namespace ========================== //
