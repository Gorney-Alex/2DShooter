using UnityEngine;

public class MoveState : State
{
    [SerializeField] private float _speed;

    private void LateUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position,Target.transform.position, _speed * Time.deltaTime);
    }
}
