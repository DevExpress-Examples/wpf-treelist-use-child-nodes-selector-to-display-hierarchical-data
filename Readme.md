<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657830/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3298)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Tree List - Use the Child Nodes Selector to Display Hierarchical Data

This example displays the hierarchical data structure that contains different object types. If all objects have the same field that contains child nodes, use the [Child Nodes Path](https://github.com/DevExpress-Examples/wpf-treelist-implement-childnodespath) technique.

1. Create a selector class that implements the `DevExpress.Xpf.Grid.IChildNodesSelector` interface, and override the `SelectChildren` method that returns node children.
2. Assign the selector class to the [TreeListView.ChildNodesSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ChildNodesSelector) property.
3. Set the [TreeListView.TreeDerivationMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.TreeDerivationMode) property to `ChildNodesSelector`.

![image](https://user-images.githubusercontent.com/65009440/193272998-7ef230be-d8e0-4b9e-aa94-dc95243e293c.png)

## Files to Review

* [ChildNodesSelector.cs](./CS/ChildNodesSelector.cs) (VB: [ChildNodesSelector.vb](./VB/ChildNodesSelector.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [ViewModel.cs](./CS/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel.vb))
* [Data.cs](./CS/DataModel.cs) (VB: [Data.vb](./VB/DataModel.vb))

## Documentation

* [Child Nodes Selector](https://docs.devexpress.com/WPF/10366/controls-and-libraries/data-grid/display-hierarchical-data/bind-to-hierarchical-data-structure#child-nodes-selector)
* [Display Hierarchical Data](https://docs.devexpress.com/WPF/9700/controls-and-libraries/data-grid/display-hierarchical-data)
* [TreeListView.ChildNodesSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ChildNodesSelector)

## More Examples

* [WPF Tree List - Bind to Self-Referential Data Structure](https://github.com/DevExpress-Examples/wpf-treelist-bind-to-self-referential-data)
* [WPF Tree List - Implement the Child Nodes Path](https://github.com/DevExpress-Examples/wpf-treelist-implement-childnodespath)
* [WPF Tree List - Use the Hierarchical Data Template to Build a Tree](https://github.com/DevExpress-Examples/how-to-build-a-tree-via-hierarchicaldatatemplate-e3410)
* [WPF Tree List - Manually Create a Tree](https://github.com/DevExpress-Examples/how-to-manually-create-a-tree-unbound-mode-e3128)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-treelist-use-child-nodes-selector-to-display-hierarchical-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-treelist-use-child-nodes-selector-to-display-hierarchical-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
