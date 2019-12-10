@ModelType MaterialUI2.MaterialUI2.Visitas
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Visitas</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.motivo_visita)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.motivo_visita)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre_completo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre_completo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.h_entrada)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.h_entrada)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.h_salida)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.h_salida)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.m_recibio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.m_recibio)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Miembros.m_nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Miembros.m_nombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.idVisita }) |
    @Html.ActionLink("Back to List", "Index")
</p>
