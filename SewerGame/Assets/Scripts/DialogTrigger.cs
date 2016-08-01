using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogTrigger : MonoBehaviour
{
    [SerializeField]
    private List<string> _text;
    
    private bool _hasTriggered = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter( Collider collider )
    {
        if ( _hasTriggered == false && collider.gameObject.tag == "Player" )
        {
            _hasTriggered = true;

            foreach ( var text in _text )
            {
                Globals.Dialog.AddText( text );
            }
        }
    }
}
