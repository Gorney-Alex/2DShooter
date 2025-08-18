using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CelebrationState : State
{
    private const string CELEBRATION_STATE = "Celebration";
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(CELEBRATION_STATE);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
