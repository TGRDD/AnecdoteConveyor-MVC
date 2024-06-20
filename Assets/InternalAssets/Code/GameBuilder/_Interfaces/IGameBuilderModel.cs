using System;
public interface IGameBuilderModel
{
    public event Action OnModelChanged;
    public float BuildProgress { get; set; }
    //TODO: ADD GAME DATA HERE
}
