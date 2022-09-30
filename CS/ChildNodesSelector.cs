using DevExpress.Xpf.Grid;
using System.Collections;

namespace ChildNodesSelector {
    public class CustomChildrenSelector : IChildNodesSelector {
        public IEnumerable SelectChildren(object item) {
            if(item is ProjectStage)
                return (item as ProjectStage).Tasks;
            else if(item is ProjectObject)
                return (item as ProjectObject).Stages;
            return null;
        }
    }
}
