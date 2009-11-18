﻿<%@ Control Language="C#" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewUserControl<EstanciaAcademicaExternaForm>" %>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Extensions"%>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers.Models"%>
<p>
    <label>Tipo de estancia</label>
    <%=Html.DropDownList("TipoEstancia", Model.TiposEstancias.CreateSelectList<TipoEstanciaForm>("Id", "Nombre"),
		"Seleccione ...", new { @class = "requerido" })%>
    <%=Html.ValidationMessage("TipoEstancia") %>
</p>
<p>
	<label>Instituci&oacute;n de procedencia</label>
	<%=Html.TextBox("InstitucionNombre", Model.InstitucionNombre,
        new { @class = "autocomplete buscar-requerido", rel = Url.Action("Search", "Institucion"), maxlength = 100 })%>
    <%=Html.Hidden("InstitucionId", Model.InstitucionId, new { rel = "#InstitucionNombre" })%>
    <%=Html.ValidationMessage("InstitucionNombre")%>
</p>
<p>
	<label>L&iacute;neas de investigaci&oacute;n</label>
	<%=Html.TextBox("LineasInvestigacion", Model.LineasInvestigacion, new { @class = "input420-requerido", maxlength = 100 })%>
	<%=Html.ValidationMessage("LineasInvestigacion")%>
</p>
<p>
	<label>Fecha de inicio</label>
	<%=Html.TextBox("FechaInicial", Model.FechaInicial, new { @class="datetime input100", maxlength = 10 })%>
	<span>(Formato dd/mm/yyyy)</span>
	<%=Html.ValidationMessage("FechaInicial")%>
</p>
<p>
	<label>Fecha de conclusi&oacute;n</label>
	<%=Html.TextBox("FechaFinal", Model.FechaFinal, new { @class="datetime input100", maxlength = 10 })%>
	<span>(Formato dd/mm/yyyy)</span>
	<%=Html.ValidationMessage("FechaFinal")%>
</p>
<p>
	<label>Actividades acad&eacute;micas previstas</label>
	<%=Html.TextBox("Actividades", Model.Actividades, new { @class = "input420-requerido", maxlength = 100 })%>
	<%=Html.ValidationMessage("Actividades")%>
</p>
<p>
	<label>Principales logros</label>
	<%=Html.TextArea("Logros", Model.Logros, new { @class = "input420-requerido", maxlength = 100 })%>
	<%=Html.ValidationMessage("Logros")%>
</p>