using UnityEngine;
using WildTech.Systems.Menu;

public class MonoMenuSystemController : MonoBehaviour
{
    public bool InizializeAtStart;

    [SerializeField] private MenuTab menuTab;

    private IMenuSystemController menuSystemController;
    private IMenuSystemModel menuSystemModel;
    private IMenuSystemView menuSystemView;

    private void Start()
    {
        if (InizializeAtStart) Inizialize();
    }

    //public virtual void Inizialize()
    //{
    //    menuSystemController = new 
    //}
}
