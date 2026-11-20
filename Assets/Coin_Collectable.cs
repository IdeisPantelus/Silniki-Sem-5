using UnityEngine;

public class Coin_Collectable : MonoBehaviour
{
    public int Coin = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player_Purse Player_coins))
        {
            Player_coins.AddCoin(+Coin);
            Destroy(gameObject);
        }
        Debug.Log("Coin");
    }
}
