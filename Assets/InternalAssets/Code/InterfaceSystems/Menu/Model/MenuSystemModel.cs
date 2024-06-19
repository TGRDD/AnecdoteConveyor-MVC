using System;

public class MenuSystemModel
{
    public event Action<MenuSystemViewModel> OnModelChanged;
    private IMenuTab[] MenuTabs;
    private int currentTabSelectedID;

    public IMenuTab PreviousTabObject = null;
    public IMenuTab CurrentTabObject => MenuTabs[currentTabSelectedID];

    public MenuSystemModel(IMenuTab[] MenuTabsArray)
    {
        MenuTabs = MenuTabsArray;
    }

    public void OpenNewTab(int TabID)
    {
        PreviousTabObject = CurrentTabObject;
        currentTabSelectedID = TabID;

        OnModelChanged?.Invoke(new MenuSystemViewModel(this));
    }
}
