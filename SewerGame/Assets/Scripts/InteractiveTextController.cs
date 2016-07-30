using UnityEngine;
using System.Collections;

public class InteractiveTextController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( Camera.main != null && Camera.main.transform != null )
        {
            transform.LookAt( Camera.main.transform );
            transform.Rotate( new Vector3( 0f, 180f, 0f ) );
        }
    }
}
