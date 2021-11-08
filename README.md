<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134291419/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830591)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# BootstrapGridView for ASP.NET Core - How to display a hyperlink in a templated column
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/134291419/)**
<!-- run online end -->
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
