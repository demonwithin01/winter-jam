using UnityEngine;
using System.Collections;
using System;

public class TextObject
{
    public TextObject( string text, float delay, Action callback )
    {
        Text = text;
        Delay = delay;
        Callback = callback;
    }

    public string Text { get; private set; }

    public float Delay { get; private set; }

    public Action Callback { get; private set; }
}
