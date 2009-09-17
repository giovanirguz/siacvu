﻿<%@ Control Language="C#" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewUserControl<TesisDirigidaForm>" %>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Extensions"%>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers.Models"%>
<p>
    <label>Sector</label>
    <%=Html.DropDownList("Sector", Model.Sectores.CreateSelectList<SectorForm>("Id", "Nombre"),
		    "Seleccione ...")%>
    <span class="cvu"></span>
</p>
<p>
    <label>Dependencia</label>
    <%=Html.DropDownList("Dependencia", Model.Dependencias.CreateSelectList<DependenciaForm>("Id", "Nombre"),
		    "Seleccione ...")%>
    <span class="cvu"></span>
</p>
<p>
    <label>Departamento</label>
    <%=Html.DropDownList("Departamento", Model.Departamentos.CreateSelectList<DepartamentoForm>("Id", "Nombre"),
	        "Seleccione ...")%>
    <span class="cvu"></span>
</p>
<p>
    <label>&Aacute;rea</label>
    <%=Html.DropDownList("Area", Model.Areas.CreateSelectList<AreaForm>("Id", "Nombre"),
        "Seleccione ...", new { @class = "cascade", rel = Url.Action("ChangeArea") })%>
    <span class="cvu"></span>
</p>
<p>
    <label>Disciplina</label>
    <%=Html.DropDownList("Disciplina", Model.Disciplinas.CreateSelectList<DisciplinaForm>("Id", "Nombre"),
        "Seleccione ...", new { @class = "cascade", rel = Url.Action("ChangeDisciplina") })%>
    <span class="cvu"></span>
</p>
<p>
    <label>Subdisciplina</label>
    <%=Html.DropDownList("Subdisciplina", Model.Subdisciplinas.CreateSelectList<SubdisciplinaForm>("Id", "Nombre"),
		    "Seleccione ...")%>    
    <span class="cvu"></span>
</p>