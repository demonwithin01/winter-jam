using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour
{
    protected bool _canInteract = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void UserInteraction( GameObject userGameObject )
    {
        Debug.Log( "User Interacting Base - DO NOT USE" );
    }

    public bool CanInteract { get { return _canInteract; } }
}
