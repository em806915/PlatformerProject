using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (player.playerStats.lives <= 0)
        {
            player.playerStats.lives = 3;
            player.playerStats.coins = 0;
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
        else
        {
            player.transform.position = new Vector3(2, 0.5f, 0);
        }
    }

    public static void Collect(Transform collectable)
    {
        Destroy(collectable);
    }


}
