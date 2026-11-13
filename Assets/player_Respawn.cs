using UnityEngine;

public class player_Respawn : MonoBehaviour
{
    private Transform respawnPoint;

    void Start()
    {
        GetComponent<player_health>().Death += PlayerRespawn_Death;
    }

    private void PlayerRespawn_Death()
    {
        transform.SetPositionAndRotation(respawnPoint.position, Quaternion.identity);
    }

    public void SetCheckPoint(Transform NewCheckpoint)
    {
       respawnPoint = NewCheckpoint;
    }
}
