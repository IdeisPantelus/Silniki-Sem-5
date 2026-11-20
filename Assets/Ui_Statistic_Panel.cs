using TMPro;
using UnityEngine;

public class Ui_Statistic_Panel : MonoBehaviour
{               
    public player_health player_health;         // tworzenie zmiennych dla UI
    public TextMeshProUGUI Health_Text;
    public Player_Purse player_purse;
    public TextMeshProUGUI Coin_Text;


    private void Awake()        //Tworzenie metod
    {
        player_health.OnAddHealth += Player_health_OnAddHealth;
        player_health.OnHealthInnit += Player_health_OnHealthInnit;

        player_purse.OnAddcoin += Player_Purse_OnAddcoin;
        player_purse.OnCoinInnit += Player_Purse_OnCoinInnit;
    }

            private void Player_Purse_OnCoinInnit(int Coin) //Stabilizacja na starcie Coin
    {
                Coin_Text.text = Coin.ToString();
            }

            private void Player_Purse_OnAddcoin(int Coin)
            {
                Coin_Text.text = Coin.ToString();
            }

    private void Player_health_OnHealthInnit(int health)    //Stabilizacja na starcie Hp
    {
        Health_Text.text = health.ToString();
    }
    private void Player_health_OnAddHealth(int health)
    {
     Health_Text.text = health.ToString();
    }
}
