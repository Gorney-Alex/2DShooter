using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected readonly Quaternion Rotation90 = Quaternion.Euler(0, 0, 90);
    
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed;

    [SerializeField] protected Bullet Bullet;
    
    public string Label => _label;
    public int Price => _price;
    public Sprite Icon => _icon;
    public bool IsBuyed => _isBuyed;

    public abstract void Fire(Transform shootPoint);

    public void Buy() => _isBuyed = true;
}
