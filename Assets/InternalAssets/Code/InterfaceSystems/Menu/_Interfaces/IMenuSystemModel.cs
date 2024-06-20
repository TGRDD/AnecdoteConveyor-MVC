using System;

namespace WildTech.Systems.Menu
{
    public interface IMenuSystemModel
    {
        event Action<MenuSystemViewModel> OnModelChanged;
        public int CurrentTabSelectedID { get; set; }

        public void SetCurrentTabID(int TabID);
    }
}
