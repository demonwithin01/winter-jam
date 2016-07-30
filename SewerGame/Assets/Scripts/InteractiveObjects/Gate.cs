﻿using UnityEngine;
using System.Collections;

public class Gate : InteractiveObject
{
    private Animator _animator;

    [SerializeField]
    private bool _requiresKey = false;

    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void UserInteraction( GameObject userGameObject )
    {
        if ( _requiresKey == false || _animator  != null )
        {
            _canInteract = false;

            OpenGate();
        }
    }

    private void OpenGate()
    {
        _animator.SetBool( "Open", true );
    }
}
