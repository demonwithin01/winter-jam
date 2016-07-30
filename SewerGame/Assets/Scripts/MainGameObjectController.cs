using UnityEngine;

public class MainGameObjectController : MonoBehaviour
{

    private void Awake()
    {
        Globals.MainPlayer = GameObject.FindGameObjectWithTag( "Player" );
        Globals.Dialog = GameObject.Find( "DialogCanvas" ).GetComponent<DialogController>();
    }
    
}