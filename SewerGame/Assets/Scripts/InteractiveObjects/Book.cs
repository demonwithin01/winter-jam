using UnityEngine;
using System.Collections;

public class Book : InteractiveObject
{
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private Vector3 _startRotation;
    private Vector3 _endRotation;
    private float _lerpValue = 0f;

    private bool _movePosition = false;
    private bool _isInPosition = false;

    // Use this for initialization
    void Start()
    {
        _endPosition = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if ( _movePosition )
        {
            if ( _lerpValue < 1f )
            {
                transform.position = Vector3.Lerp( _startPosition, _endPosition, _lerpValue );
                transform.rotation = Quaternion.Euler( Vector3.Lerp( _startRotation, _endRotation, _lerpValue ) );

                _lerpValue += ( Time.deltaTime * 2f );
            }
            else
            {
                transform.position = _endPosition;
                transform.rotation = Quaternion.Euler( _endRotation );
                _movePosition = false;
                _isInPosition = true;
            }
        }
        else if ( _isInPosition && Input.GetKeyDown( KeyCode.E ) )
        {
            Globals.FPSController.CanMove = true;
            gameObject.SetActive( false );
        }
    }

    public override void UserInteraction( GameObject userGameObject )
    {
        _canInteract = false;

        PickupBook();
    }

    private void PickupBook()
    {
        _startPosition = transform.position;
        _startRotation = transform.rotation.eulerAngles;

        transform.gameObject.layer = Layer.UI;

        var position = Globals.PlayerController.transform.position;

        _endPosition = Camera.main.ScreenToWorldPoint( new Vector3( Screen.width / 2f, Screen.height / 2f ) ) + Camera.main.transform.forward;
        _endRotation = Camera.main.transform.rotation.eulerAngles;

        _endRotation.y += 180f;
        _endRotation.z = 0f;

        if ( _endRotation.y > 360f )
        {
            _endRotation.y -= 360f;
        }

        _movePosition = true;

        Globals.FPSController.CanMove = false;
    }
}
