using System;
using UnityEngine;

public class Player_Purse : MonoBehaviour
{
    private int Player_coins;
    public int Start_Coins = 0;

    public event Action<int> OnAddcoin;
    public event Action<int> OnCoinInnit;

    void Start()                                            // Normalizing starting coins
    {
        Player_coins = Start_Coins;
        OnCoinInnit?.Invoke(Player_coins);
       
        GetComponent<player_health>().Death += Player_Purse_Death;  
    }

    private void Player_Purse_Death()                                // Player Death Effect
    {
        Player_coins = 0;
      
    }

    public void AddCoin(int CoinToAdd)          // coin calculator, No debt (0)
    {
        Player_coins += CoinToAdd;
        OnCoinInnit?.Invoke(Player_coins);

        if (Player_coins <= 0)
        {
            Player_coins = 0;
        }
    }
    
   
}
