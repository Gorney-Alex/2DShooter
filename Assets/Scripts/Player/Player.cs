using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Transform _shootPoint;

    private Weapon _currentWeapon;
    private int _currentWeaponNumber = 0;
    private int _currentHealth;

    private int _money;

    public int Money
    {
        get { return _money; }
        private set { _money = value; }
    }
    
    public event UnityAction<int, int> HealthChanged;
    public event UnityAction<int> MoneyChanged;
    
    private void Awake()
    {
        _currentHealth = _health;
        ChangeWeapon(_weapons[_currentWeaponNumber]);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            _currentWeapon.Fire(_shootPoint);
        }
    }

    public void NextWeapon()
    {
        if (_currentWeaponNumber == _weapons.Count - 1)
        {
            _currentWeaponNumber = 0;
        }
        else
        {
            _currentWeaponNumber++;
        }
        
        ChangeWeapon(_weapons[_currentWeaponNumber]);
    }
    
    public void PreviousWeapon()
    {
        if (_currentWeaponNumber == 0)
        {
            _currentWeaponNumber = _weapons.Count - 1;
        }
        else
        {
            _currentWeaponNumber--;
        }
        
        ChangeWeapon(_weapons[_currentWeaponNumber]);
    }
    
    public void OnEnemyDied(int reward)
    {
        Money += reward;
    }

    public void BuyWeapon(Weapon weapon)
    {
        Money -= weapon.Price;
        _weapons.Add(weapon);
        MoneyChanged?.Invoke(Money);
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;
        HealthChanged?.Invoke(_currentHealth, _health);
        
        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddMoney(int amount)
    {
        Money += amount;
        MoneyChanged?.Invoke(Money);
    }

    private void ChangeWeapon(Weapon weapon) => _currentWeapon = weapon;
}
