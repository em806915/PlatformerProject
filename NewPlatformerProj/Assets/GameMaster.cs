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
    public GameObject player;

    public static void KillPlayer(Player player) {
        player.transform.position = new Vector3(2, 0.5f, 0);
    }

    public static void Collect(Transform collectable)
    {
        Destroy(collectable);
    }


}
