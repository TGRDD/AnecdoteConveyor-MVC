using UnityEngine;

namespace WildTech.Systems.Menu
{
    public class MenuTab : MonoBehaviour, IMenuTab
    {

        [SerializeField, HideInInspector] private MenuButton[] _tabButtons;


        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void SetInteractable(bool state)
        {
            foreach (var button in _tabButtons)
            {
                button.interactable = state;
            }
        }

        public void InizializeButtons(IMenuSystemController controller)
        {

            _tabButtons = GetComponentsInChildren<MenuButton>();

            foreach (var item in _tabButtons)
            {
                item.OnNewTabOpenCall += controller.OpenNewTab;
            }
        }

        public void InizializeButton(IMenuSystemController controller, IMenuButton button)
        {
            button.OnNewTabOpenCall += controller.OpenNewTab; 
        }
    }
}
