<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657830/11.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3298)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ChildNodesSelector.cs](./CS/ChildNodesSelector.cs) (VB: [ChildNodesSelector.vb](./VB/ChildNodesSelector.vb))
* [Data.cs](./CS/Data/Data.cs) (VB: [Data.vb](./VB/Data/Data.vb))
* **[MainPage.xaml](./CS/MainPage.xaml) (VB: [MainPage.xaml](./VB/MainPage.xaml))**
* [MainPage.xaml.cs](./CS/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/MainPage.xaml.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel.vb))
<!-- default file list end -->
# How to implement hierarchical data binding via Child Nodes Selector


<p>A hierarchical data structure is any set of nested business objects that have a structure where the children of a node are in a <i>childre</i><i>n</i> field. Parents and children can be different object types. When working with hierarchical data structures, the control's <strong>ItemsSource</strong> property contains only data items that correspond to root nodes. The TreeListView provides two approaches (tree derivation modes) allowing you to specify where a data object's child items come from. This can be done using Hierarchical Data Templates or in code-behind via a Child Nodes Selector.</p><p>This example shows how to build a tree in code-behind. The CustomChildrenSelector class implements DevExpress.Xpf.Grid.IChildNodeSelector and returns the list/collection of child nodes for the specified node. This selector is assigned to the TreeListView's <strong>ChildNodesSelector</strong> property. The TreeListView's <strong>TreeDerivationMode</strong> property should be set to <i>ChildNodesSelector</i>.</p>

<br/>


