<!-- default file list -->
*Files to look at*:

* [CustomLayoutConrol.cs](./CS/dxSample/Custom Layout Control/CustomLayoutConrol.cs) (VB: [CustomLayoutConrol.vb](./VB/dxSample/Custom Layout Control/CustomLayoutConrol.vb))
* [CustomLayoutControlImplementor.cs](./CS/dxSample/Custom Layout Control/CustomLayoutControlImplementor.cs) (VB: [CustomLayoutControlImplementor.vb](./VB/dxSample/Custom Layout Control/CustomLayoutControlImplementor.vb))
* [CustomLayoutControlItem.cs](./CS/dxSample/Custom Layout Control/CustomLayoutControlItem.cs) (VB: [CustomLayoutControlItem.vb](./VB/dxSample/Custom Layout Control/CustomLayoutControlItem.vb))
* **[CustomLayoutControlItemSkinPainter.cs](./CS/dxSample/Custom Layout Control/CustomLayoutControlItemSkinPainter.cs) (VB: [CustomLayoutControlItemSkinPainter.vb](./VB/dxSample/Custom Layout Control/CustomLayoutControlItemSkinPainter.vb))**
* [CustomLayoutSkinPaintStyle.cs](./CS/dxSample/Custom Layout Control/CustomLayoutSkinPaintStyle.cs) (VB: [CustomLayoutSkinPaintStyle.vb](./VB/dxSample/Custom Layout Control/CustomLayoutSkinPaintStyle.vb))
* [Form1.cs](./CS/dxSample/Form1.cs) (VB: [Form1.vb](./VB/dxSample/Form1.vb))
* [Program.cs](./CS/dxSample/Program.cs) (VB: [Program.vb](./VB/dxSample/Program.vb))
<!-- default file list end -->
# OBSOLETE: LayoutControlItem - How to implement the HighlightFocusedItem property at the item level
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t195123)**
<!-- run online end -->


<strong>Starting with version 16.2, LayoutControl supports highlighting the currently focused item out-of-the-box.</strong> <strong>Use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraLayoutLayoutControlItem_HighlightFocusedItemtopic">LayoutControlItem.HighlightFocusedItem</a> property for this.</strong><br><br>The example demonstrates how to implement the HighlightFocusedItem property for a layout control item. <br>In this example, a LayoutControl descendant is created to implement the required logic. Here are the main implementation points:<br>1. The HighlightFocusedItemEx property is introduced to the LayoutControlItem class.<br>2. In a custom item skin painter (CustomLayoutControlItemSkinPainter), the PatchImageIndexCore method is overridden to provide the required image index based on the controlItem.HighlightFocusedItemEx property.<br><br><em>Please note that the highlight focused item feature is actual in the skinned painting scheme only; i.e., when the LayoutControl.LookAndFeel.Style property is set to Skin.</em>

<br/>


