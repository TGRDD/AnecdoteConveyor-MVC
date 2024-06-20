using System;

public interface IMenuButton
{
    public event Action<int> OnNewTabOpenCall;
    public void OpenCall();
}
