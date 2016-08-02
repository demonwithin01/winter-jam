using UnityEngine;
using System.Collections;

public class Gate : InteractiveObject
{
    private Animator _animator;
    private AudioSource _AudioSource;

    [SerializeField]
    private bool _requiresKey = false;

    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        _animator = GetComponent<Animator>();

        _AudioSource = GetComponent<AudioSource>();
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

    public void FinishAnimation()
    {
        _animator.Stop();
    }

    private void OpenGate()
    {
        _animator.SetBool( "Open", true );

        _AudioSource.Play();
    }
}
