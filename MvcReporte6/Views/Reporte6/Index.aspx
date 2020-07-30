<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcReporte6.Models.Municipio>" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
   <%using (Html.BeginForm())
     { %>
   <legend>Seleccionar municipio</legend>
   <fieldset>
   <div class="display.label">Municipio</div>
   <div class="editor-field">
    <%: Html.DropDownListFor(model => model.IdMunicipio, (SelectList)ViewData["municipios"], "Seleccionar")%>
    <%:Html.ValidationMessageFor(Model=>Model.IdMunicipio) %>
   </div>

   <p> 
       <input type="submit"  value="Mostrar" />
       
   <%:Html.ActionLink("Reporte6", "Detail", new { IdMunicipio = 10 })%>
   <a href="/Reporte6/Detail?IdMunicipio=">Click</a>
   </p>
   </fieldset>

   <%} %>

</body>
</html>
