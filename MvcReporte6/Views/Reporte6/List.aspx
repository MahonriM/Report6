<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcReporte6.Models.Reporte6>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>List</title>
</head>
<body>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">IdMunicipio</div>
        <div class="display-field"><%: Model.IdMunicipio %></div>
        
        <div class="display-label">CantidadCamion</div>
        <div class="display-field"><%: Model.CantidadCamion %></div>
        
        <div class="display-label">CantidadEmpleado</div>
        <div class="display-field"><%: Model.CantidadEmpleado %></div>
        
        <div class="display-label">Matutino</div>
        <div class="display-field"><%: Model.Matutino %></div>
        
        <div class="display-label">Vespertino</div>
        <div class="display-field"><%: Model.Vespertino %></div>
        
        <div class="display-label">Nocturno</div>
        <div class="display-field"><%: Model.Nocturno %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</body>
</html>

