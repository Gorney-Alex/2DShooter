using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed;

    [SerializeField] protected Bullet Bullet;

    private void Awake()
    {
        _isBuyed = false;
    }

    public abstract void Fire(Transform shootPoint);
}
