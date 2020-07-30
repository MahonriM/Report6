<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<MvcReporte6.Models.Municipio>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index1</title>
</head>
<body>
   <fieldset>
   <div class="display.label">Municipio</div>
   <div class="editor-field">
   <th> Descripcion</th>
   


   </fieldset>


    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
               
                <%:Html.ActionLink("Reporte6", "Detail", new { IdMunicipio = item.IdMunicipio})%>
       
            </td>


        </tr>
    
    <% } %>

    </table>
</body>
</html>
