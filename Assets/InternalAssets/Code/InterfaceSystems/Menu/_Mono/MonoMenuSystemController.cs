using AYellowpaper;
using System.Collections.Generic;
using UnityEngine;
using WildTech.Systems.Menu;

public class MonoMenuSystemController : MonoBehaviour
{
    public bool InizializeAtStart;

    [RequireInterface(typeof(IMenuTab))]
    [SerializeField] private MonoBehaviour[] menuTabs;


    private IMenuSystemController menuSystemController;
    private IMenuSystemModel menuSystemModel;
    private IMenuSystemView menuSystemView;

    private void Start()
    {
        if (InizializeAtStart) Inizialize();
    }

    public virtual void Inizialize()
    {
        IMenuTab[] tabs = ConvertTabs();

        menuSystemModel = new MenuSystemModel(tabs);
        menuSystemView = new ForceMenuSystemView();

        menuSystemController = new MenuSystemController(modelSystem: menuSystemModel, viewSystem: menuSystemView);

        foreach (var tab in tabs)
        {
            tab.InizializeButtons(menuSystemController);
        }
    }

    private IMenuTab[] ConvertTabs()
    {
        List<IMenuTab> tabs = new List<IMenuTab>();
        foreach (var tab in menuTabs)
        {
            tabs.Add(tab.GetComponent<IMenuTab>());
        }

        return tabs.ToArray();
    }
}
