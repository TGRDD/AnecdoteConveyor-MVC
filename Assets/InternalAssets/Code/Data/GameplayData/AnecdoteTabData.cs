using System;
using UnityEngine;

[Serializable]
public struct AnecdoteTabData
{
    public AnecdoteTabType Type
    {
        get
        {
            if (AnecdoteText.Length == 0 || AnecdoteText == null) return AnecdoteTabType.NoText;
            else if (Sprite == null) return AnecdoteTabType.NoSprite;
            else return AnecdoteTabType.Full;
        }
        private set { return; }
    }
    public string AnecdoteText;
    public Sprite Sprite;
}

public enum AnecdoteTabType
{
    Full,
    NoText,
    NoSprite
}
