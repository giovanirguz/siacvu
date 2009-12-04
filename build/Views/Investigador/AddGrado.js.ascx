﻿<%@ Control Language="C#" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewUserControl<GradoAcademicoInvestigadorForm>" %>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers"%>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Extensions"%>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers.Models"%>

var html = '
    <div id="grado_<%=Html.Encode(Model.Id) %>" class="sublista">
        <h6><%=Html.Encode(Model.GradoAcademicoNombre)%> <span><%=Html.Encode(Model.Fecha)%>, Institución: <%=Html.Encode(Model.InstitucionNombre)%></span></h6>
        <span><%=Html.Encode(Model.Programa.Substring(0, Model.Programa.Length < 40 ? Model.Programa.Length : 40))%></span>
    </div><!--end estadolista-->
';

$('#message').html('');
$('#message').removeClass('errormessage');

$('#gradoForm').hide();
$('#gradoNew').show();
$('#gradoForm').html('');
$('#gradoList div:first').before(html);

$('#grado_' + <%=Html.Encode(Model.Id) %> + ':first').hide();
$('#grado_' + <%=Html.Encode(Model.Id) %> + ':first').fadeIn('slow');

setupSublistRows();
