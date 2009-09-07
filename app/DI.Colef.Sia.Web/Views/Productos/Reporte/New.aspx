<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" 
    Inherits="System.Web.Mvc.ViewPage<GenericViewData<ReporteForm>>" %>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers.Productos"%>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers.ViewData"%>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Controllers.Models"%>
<%@ Import Namespace="DecisionesInteligentes.Colef.Sia.Web.Extensions"%>
<%@ Import Namespace="DI.Colef.Sia.Web.Controllers" %>

<asp:Content ID="titleContent" ContentPlaceHolderID="TituloPlaceHolder" runat="server">
    <h2><%=Html.Encode(Model.Title) %></h2>
</asp:Content>

<asp:Content ID="introductionContent" ContentPlaceHolderID="IntroduccionPlaceHolder" runat="server">
	<div id="introduccion">
		<p>Favor de llenar los siguientes campos para dar de alta un nuevo reporte dentro del sistema.</p>
	</div><!--end introduccion-->	
</asp:Content>

<asp:Content ID="sidebarContent" ContentPlaceHolderID="SidebarContentPlaceHolder" runat="server">
    <div id="barra">
        <div id="asistente">
            <h3>Asistente de secci&oacute;n</h3>
            <% Html.RenderPartial("_NewSidebar"); %>
        </div><!--end asistente-->
    </div><!--end barra-->
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div id="textos">
    
	    <% Html.RenderPartial("_Message"); %>    
	    <div id="forma">

            <% using (Html.BeginForm("Create", "Reporte")) { %>
		        <%=Html.AntiForgeryToken() %>
                <%=Html.Hidden("Id", Model.Form.Id) %>
                
                <% Html.RenderPartial("_DatosReporte", Model.Form); %>
                
                <h4>Coautores</h4>
				<% Html.RenderPartial("_EditCoautorInterno", Model.Form); %>
				<% Html.RenderPartial("_EditCoautorExterno", Model.Form); %>
                
                <h4>Referencia bibliogr&aacute;fica</h4>
				<% Html.RenderPartial("_ReferenciaBibliografica", Model.Form); %>
                
                <h4>Opcionales</h4>
                <% Html.RenderPartial("_DatosOpcionales", Model.Form); %>
        		
                <p class="submit">
                    <%=Html.SubmitButton("Guardar", "Guardar cambios") %> &oacute; <%=Html.ActionLink<ReporteController>(x => x.Index(), "Regresar")%>
                </p>
            <% } %>
	    </div><!--end forma-->	
    		
    </div><!--end textos-->
    
<script type="text/javascript">
    $(document).ready(function() {
        setupDocument();
        $('#TipoReporte').dynamicui(
            [
                ['Cuaderno de trabajo', ['.CuadernoTrabajo']],
                ['Reporte t�cnico', ['.ReporteTecnico']]
            ]
        );

        $('#TipoReporte')[0].dynamic.setup();
    });
</script>
</asp:Content>
