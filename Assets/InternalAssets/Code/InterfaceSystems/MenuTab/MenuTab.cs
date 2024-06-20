using UnityEngine;
using UnityEngine.UI;

namespace WildTech.Systems.Menu
{
    public class MenuTab : MonoBehaviour, IMenuTab
    {
        [SerializeField, HideInInspector] private Button[] _tabButtons;

        private void Awake()
        {
            _tabButtons = GetComponentsInChildren<Button>();
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
    }
}
