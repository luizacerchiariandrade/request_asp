using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class WRespSalárioMin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request["txbSalario"] == null)
            {
                Response.Redirect("~/wFormSalario.aspx");
            }
            Response.Write("<h3> Salário:" + Request.Form["txbSalario"]+ "</h3>");
            Response.Write("<h3> Desconto:" + Request["txbDesconto"] + "</h3>");
            Response.Write("<h3> Produto:" + Request.QueryString["Nome"] + "</h3>");
            Response.Write("<h3> Status:" + Request["Status"] + "</h3>");

            Double salario = Convert.ToDouble(Request.Form["txbSalario"]);
            //Double desconto = Convert.ToDouble(Request.Form["txbDesconto"]);
            Double desconto = 0;
            RadioButtonList radioBtList = (RadioButtonList) Page.PreviousPage.FindControl("radioDesconto");
            
            if (radioBtList.SelectedIndex != 3)
            {
                switch (radioBtList.SelectedIndex)
                {
                    case 0:
                        desconto = 10;
                        break;
                    case 1:
                        desconto = 20;
                        break;
                    case 2:
                        desconto = 30;
                        break;

                }

            } else
            {
                desconto = Convert.ToDouble(Request.Form["txbOutro"]);
            }
           
            Double resultado = (salario - desconto);
            lbResultado.Text = resultado.ToString();

            Table tabela = new Table();

            TableRow linha = new TableRow();
            TableCell coluna = new TableCell();
            coluna.Text = "Salário Brutoo";
            linha.Cells.Add(coluna);
            coluna = new TableCell();
            coluna.Text = salario.ToString();
            linha.Cells.Add(coluna);
            tabela.Rows.Add(linha);

            linha = new TableRow();
            coluna = new TableCell();
            coluna.Text = "Descontoo";
            linha.Cells.Add(coluna);
            coluna = new TableCell();
            coluna.Text = desconto.ToString();
            linha.Cells.Add(coluna);
            tabela.Rows.Add(linha);

            PlaceHolder1.Controls.Add(tabela);

        }
    }
}