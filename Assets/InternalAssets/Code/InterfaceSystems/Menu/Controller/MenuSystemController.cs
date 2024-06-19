using UnityEngine;

public class MenuSystemController : MonoBehaviour
{
    [Header("Config data")]
    [SerializeField] private MenuTab[] _tabsArray;

    private IMenuSystemView _view;
    private MenuSystemModel _model;

    //TODO: Change to bootstrap
    private void Start()
    {
        Inizialize();
    }

    private void Inizialize()
    {
        _model = new MenuSystemModel(_tabsArray);
        _view = new ForceMenuSystemView();

        _model.OnModelChanged += _view.UpdateView;
    }


    public void OpenNewTab(int TabID)
    {
        _model.OpenNewTab(TabID);
    }
}
