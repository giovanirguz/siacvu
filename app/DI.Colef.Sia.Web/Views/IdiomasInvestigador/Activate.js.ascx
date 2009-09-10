<%@ Control Language="C#" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewUserControl<IdiomasInvestigadorForm>" %>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers.Models"%>

var html = '
<% if (Model.Activo) { %>
    <%=Html.ActionLink("Desactivar", "Deactivate", new { id = Model.Id }, new { @class = "remote put" })%>
<% } else { %>
    <%=Html.ActionLink("Activar", "Activate", new { id = Model.Id }, new { @class = "remote put" })%>
<% } %>
';

$('#accion_<%=Html.Encode(Model.Id)%> .elementobotones span:last').html(html);
$('#accion_<%=Html.Encode(Model.Id)%> .elementobotones span:last a').removeLoading();
showMessage('Idioma del investigador <%=Html.Encode(Model.IdiomaNombre) %> ha sido <%if(Model.Activo) { %> activado. <% } else { %> desactivado. <% } %>');
