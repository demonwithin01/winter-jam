using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class DialogController : MonoBehaviour
{
    private Text _textRenderer;

    private float _timer = 0f;

    private float _delayTimer = 0f;

    private Queue<TextObject> _textQueue = new Queue<TextObject>();

    private TextObject _currentTextObject = null;

    [SerializeField]
    private float _textDisplayTime = 5f;

    // Use this for initialization
    void Start()
    {
        _timer = _textDisplayTime;
    }

    void Awake()
    {
        _textRenderer = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( _timer > _textDisplayTime && _delayTimer <= 0f )
        {
            if ( _currentTextObject != null )
            {
                EndCurrentText();
            }
            else if ( _textQueue.Count > 0 )
            {
                _currentTextObject = _textQueue.Dequeue();

                _textRenderer.text = _currentTextObject.Text;

                _timer = 0f;
            }
        }
        
        _timer += Time.deltaTime;
        _delayTimer -= Time.deltaTime;
    }

    private void EndCurrentText()
    {
        if ( _currentTextObject.Callback != null )
        {
            _currentTextObject.Callback();
        }

        _delayTimer = _currentTextObject.Delay;

        _currentTextObject = null;
        _textRenderer.text = "";
    }

    public void AddText( string text )
    {
        AddText( text, 0f, null );
    }

    public void AddText( string text, float delay )
    {
        AddText( text, delay, null );
    }

    public void AddText( string text, Action callback )
    {
        AddText( text, 0f, callback );
    }
    
    public void AddText( string text, float delay, Action callback )
    {
        _textQueue.Enqueue( new TextObject( text, delay, callback ) );
    }
}
