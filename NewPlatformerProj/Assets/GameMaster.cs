using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;

    void Start()
    {
        if (gm == null) {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    public Transform playerPrefab;
    public Transform SpawnPoint;
    public Transform collectable;

    public void RespawnPlayer(){
        Instantiate(playerPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }

    public static void KillPlayer(Player player) {
        Destroy(player.gameObject);
        gm.RespawnPlayer();
    }

    public static void Collect(Transform collectable)
    {
        Destroy(collectable);
    }


}
