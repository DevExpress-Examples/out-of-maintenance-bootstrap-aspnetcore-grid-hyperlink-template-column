# BootstrapGridView for ASP.NET Core - How to display a hyperlink in a templated column
The example demonstrates how to show a hyperlink in BootstrapGridView's column. The hyperlink parameters (text, navigate url) are calculated based on the template's container.
See also: [Cell Template](https://demos.devexpress.com/aspnetcore-bootstrap/GridView-Templates#CellTemplate) demo

## Here is the most important part of the code that is responsible for hyperlink creation:
```csharp
columns.Add(m => m.ProductName)
.DataItemTemplate(t => @<text>
	@(Html.DevExpress()
		.BootstrapHyperLink("MyHyperLink" + t.VisibleIndex)
		.Text(t.DataItem.ProductName)
		.NavigateUrl(Url.Action("Details", "Sample", new { id = t.KeyValue })))
</text>);
```