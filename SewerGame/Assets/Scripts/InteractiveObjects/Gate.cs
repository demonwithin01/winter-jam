using UnityEngine;
using System.Collections;

public class Gate : InteractiveObject
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void UserInteraction( GameObject userGameObject )
    {
        _canInteract = false;

        OpenGate();
    }

    private void OpenGate()
    {

    }
}
