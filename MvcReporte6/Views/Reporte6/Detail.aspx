<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcReporte6.Models.Reporte6>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link href="../../Content/Estilolink.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detail</title>
</head>
<body>
    <fieldset>
        <legend>Fields</legend>
        
        
        
        
        <div class="display-label">CantidadCamion</div>
        <div class="display-field"><%:Model.CantidadCamion%></div>

        <div class="display-label">CantidadEmpleado</div>
        <div class="display-field"><%: Model.CantidadEmpleado %></div>

        <div class="display-label">Matutino</div>
        <div class="display-field"><%: Model.Matutino %></div>
        <div class="display-label">Vespertino</div>
         <div class="display-field"> <%:Model.Vespertino %></div>
        <div class="display-label"> Nocturno</div>
        <div class="displat-field"> <%:Model.Nocturno %></div>
        
    </fieldset>
    <p>
    <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</body>
</html>

