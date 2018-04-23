# How to implement hierarchical data binding via Child Nodes Selector


<p>A hierarchical data structure is any set of nested business objects that have a structure where the children of a node are in a <i>childre</i><i>n</i> field. Parents and children can be different object types. When working with hierarchical data structures, the control's <strong>ItemsSource</strong> property contains only data items that correspond to root nodes. The TreeListView provides two approaches (tree derivation modes) allowing you to specify where a data object's child items come from. This can be done using Hierarchical Data Templates or in code-behind via a Child Nodes Selector.</p><p>This example shows how to build a tree in code-behind. The CustomChildrenSelector class implements DevExpress.Xpf.Grid.IChildNodeSelector and returns the list/collection of child nodes for the specified node. This selector is assigned to the TreeListView's <strong>ChildNodesSelector</strong> property. The TreeListView's <strong>TreeDerivationMode</strong> property should be set to <i>ChildNodesSelector</i>.</p>

<br/>


