using UnityEngine;

public class ShotGun : Weapon
{
    private readonly Vector3 _shotDirectionForSecondBullet = new Vector3(0, 1, 0);
    
    public override void Fire(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position + _shotDirectionForSecondBullet, Rotation90);
        Instantiate(Bullet, shootPoint.position, Rotation90);
    }
}
