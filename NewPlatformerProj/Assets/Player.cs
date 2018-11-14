using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public class PlayerStats {
        public int coins = 0;
        public int lives = 3;
        public int level = 1;
    }

    public PlayerStats playerStats = new PlayerStats();

    public void Update()
    {
        if (transform.position.y <= -20) {
            GameMaster.KillPlayer(this);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Coin") {
            playerStats.coins += 1;
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "Spike") {
            playerStats.lives -= 1;
            GameMaster.KillPlayer(this);
        }
        if (col.gameObject.name == "End"){
            LoadScene.GetPlayerStats(this);
            SceneManager.LoadScene("StageComplete", LoadSceneMode.Single);
        }
    }
}
