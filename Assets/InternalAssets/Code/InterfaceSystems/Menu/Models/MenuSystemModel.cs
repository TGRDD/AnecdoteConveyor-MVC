using System;

namespace WildTech.Systems.Menu
{
    public class MenuSystemModel : IMenuSystemModel
    {
        public event Action<MenuSystemViewModel> OnModelChanged;
        private IMenuTab[] MenuTabs;
        private int currentTabSelectedID;

        public int CurrentTabSelectedID { get { return currentTabSelectedID; } set { return; } }

        public IMenuTab PreviousTabObject = null;
        public IMenuTab CurrentTabObject => MenuTabs[currentTabSelectedID];

        public MenuSystemModel(IMenuTab[] MenuTabsArray)
        {
            MenuTabs = MenuTabsArray;
        }

        public void SetCurrentTabID(int TabID)
        {
            PreviousTabObject = CurrentTabObject;
            currentTabSelectedID = TabID;

            OnModelChanged?.Invoke(new MenuSystemViewModel(this));
        }
    }
}
