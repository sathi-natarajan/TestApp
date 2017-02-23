@ModelType TestAppEF_MVC.Table
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Table</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Firstname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Firstname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Lastname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Lastname)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
