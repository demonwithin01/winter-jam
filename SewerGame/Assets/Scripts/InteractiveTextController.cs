using UnityEngine;
using System.Collections;

public class InteractiveTextController : MonoBehaviour
{
    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find( "MainCharacter" );
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt( Camera.main.transform );
        transform.Rotate( new Vector3( 0f, 180f, 0f ) );

        //var rotation = Vector3.RotateTowards( transform.position, Camera.main.transform.position, 0f, 0f ).normalized;
        //transform.rotation = Quaternion.Euler( rotation );
    }
}
