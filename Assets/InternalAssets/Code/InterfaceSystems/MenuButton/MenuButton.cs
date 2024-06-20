using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MenuButton : MonoBehaviour, IMenuButton
{
    public event Action<int> OnNewTabOpenCall;

    [SerializeField] private Button _buttonComponent;
    [field: SerializeField] public int _tabToOpenIndex { get; private set; }

    public bool interactable
    {
        get { return _buttonComponent.interactable; }
        set { _buttonComponent.interactable = value; }
    }

    private void OnValidate()
    {
        _buttonComponent ??= GetComponent<Button>();
    }

    private void OnEnable()
    {
        _buttonComponent.onClick.AddListener(OpenCall);
    }

    private void OnDisable()
    {
        _buttonComponent.onClick.RemoveListener(OpenCall);
    }

    public void OpenCall()
    {
        OnNewTabOpenCall?.Invoke(_tabToOpenIndex);
    }
}
