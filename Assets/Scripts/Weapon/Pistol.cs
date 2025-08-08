using UnityEngine;

public class Pistol : Weapon
{
    public override void Fire(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(0, 0, 90));
    }
}
