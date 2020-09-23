# render-partialview-with-model

This article explains how you can render a partial view in the main view with model data.

You can render Partial View using **Html.RenderAction** and **Html.RenderPartial** helper methods.

## Files

1. **[Order Model](https://github.com/geeksarray/render-partialview-with-model/blob/master/RenderPartialViewWithModel/Models/Order.cs)** - Order Model with IEnumerable<OrderLineItem>
  
1. **[Order Line item Model](https://github.com/geeksarray/render-partialview-with-model/blob/master/RenderPartialViewWithModel/Models/OrderLineItem.cs)** -  Order line item entity with properties like OrderID, ProductID etOrder HTML View with Modelc.https://github.com/geeksarray/render-partialview-with-model/blob/master/RenderPartialViewWithModel/Views/Order/GetOrder.cshtml

1. **[Order HTML View with Model](https://github.com/geeksarray/render-partialview-with-model/blob/master/RenderPartialViewWithModel/Views/Order/GetOrder.cshtml)** - to show Order Model data on view.
  
  Order Partial View will be shown as below image
  
  ![Partial View Model](https://geeksarray.com/images/blog/partial-view-with-model-example.png)
  
  For more detailed description visit - [ASP.NET MVC Partial View with Model](https://geeksarray.com/blog/render-partialview-with-model)
  
  




