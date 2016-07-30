using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MainGameObjectController : MonoBehaviour
{

    private void Awake()
    {
        Globals.MainPlayer = GameObject.FindGameObjectWithTag( "Player" );
        Globals.PlayerController = Globals.MainPlayer.GetComponent<FPSInteractiveController>();
        Globals.FPSController = Globals.MainPlayer.GetComponent<FirstPersonController>();
        Globals.Dialog = GameObject.Find( "DialogCanvas" ).GetComponent<DialogController>();
    }
    
}