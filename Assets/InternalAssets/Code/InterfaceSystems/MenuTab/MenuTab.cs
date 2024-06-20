using System;
using UnityEngine;

namespace WildTech.Systems.Menu
{
    public class MenuTab : MonoBehaviour, IMenuTab
    {
        public event Action OnMenuButtonClicked;

        [SerializeField, HideInInspector] private MenuButton[] _tabButtons;

        [field: SerializeField] private int _tabIndex;
        private void Awake()
        {
            _tabButtons = GetComponentsInChildren<MenuButton>();
        }

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
            foreach (var item in _tabButtons)
            {
                item.OnNewTabOpenCall += controller.OpenNewTab;
            }
        }
    }
}
