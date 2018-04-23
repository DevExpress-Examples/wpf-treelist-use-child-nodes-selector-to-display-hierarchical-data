using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Grid;
using System.Collections;

namespace HierarchicalDataBinding {
    public class CustomChildrenSelector : IChildNodesSelector {
        public IEnumerable SelectChildren(object item) {
            if(item is Task)
                return null;
            else if(item is ProjectStage)
                return (item as ProjectStage).Tasks;
            else if(item is ProjectObject)
                return (item as ProjectObject).Stages;
            return null;
        }
    }
}
