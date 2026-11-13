using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out player_health health))
        {
            health.AddHealth(-damage);
        }
        Debug.Log(collision);
    }
}
