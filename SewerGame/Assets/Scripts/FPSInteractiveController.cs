﻿using UnityEngine;
using System.Collections;

public class FPSInteractiveController : MonoBehaviour
{
    [SerializeField]
    private float _interactionDistance = 0.5f;

    private Vector3 _screenCenter;

    private InteractiveObject _currentInteractive = null;

    // Use this for initialization
    void Start()
    {
        _screenCenter = new Vector3( Screen.width / 2f, Screen.height / 2f );
    }

    // Update is called once per frame
    void Update()
    {
        if ( Camera.main == null )
        {
            return;
        }

        FindInteractiveObject();

        if  ( _currentInteractive != null && Input.GetKeyDown( KeyCode.E ) && _currentInteractive.CanInteract )
        {
            _currentInteractive.UserInteraction( gameObject );
        }
    }

    private void FindInteractiveObject()
    {
        Ray ray = Camera.main.ScreenPointToRay( _screenCenter );
        
        RaycastHit hitInfo;
        if ( Physics.Raycast( ray, out hitInfo, _interactionDistance ) && hitInfo.transform.gameObject.layer == Layer.Interactive )
        {
            GameObject obj = hitInfo.transform.gameObject;
            InteractiveObject interactiveObj = obj.GetComponent<InteractiveObject>();
            
            if ( _currentInteractive != null && _currentInteractive != interactiveObj )
            {
                HideInteraction();
            }

            if ( _currentInteractive == null || _currentInteractive != interactiveObj )
            {
                _currentInteractive = interactiveObj;

                ShowInteraction();
            }
        }
        else if ( _currentInteractive != null )
        {
            HideInteraction();
        }
    }

    private void ShowInteraction()
    {

    }

    private void HideInteraction()
    {

        _currentInteractive = null;
    }
}
