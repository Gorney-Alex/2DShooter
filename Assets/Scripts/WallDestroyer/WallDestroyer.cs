using UnityEngine;

public class WallDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Bullet>(out Bullet bullet))
        {
            Destroy(bullet.gameObject);
        }
    }
}
