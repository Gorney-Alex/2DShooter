using UnityEngine;

public class ShotGun : Weapon
{
    public override void Fire(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 90));
        Instantiate(Bullet, shootPoint.position - new Vector3(0, -1, 0), Quaternion.Euler(0, 0, 90));
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(0, 0, 90));
    }
}
