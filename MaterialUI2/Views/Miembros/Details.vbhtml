@ModelType MaterialUI2.MaterialUI2.Miembros
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Miembros</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.m_nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.m_nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.m_apellido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.m_apellido)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.idMiembro }) |
    @Html.ActionLink("Back to List", "Index")
</p>
