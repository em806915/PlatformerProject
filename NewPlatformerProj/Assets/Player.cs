using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public class PlayerStats {
        public int coins = 0;
        public int lives = 3;
    }

    public PlayerStats playerStats = new PlayerStats();
    public Text livesLeft;

    public void Update()
    {
       
        if (transform.position.y <= -20) {
            playerStats.lives -= 1;
            GameMaster.KillPlayer(this);
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        print("Lives: ");

        if (col.gameObject.name == "Coin") {
            playerStats.coins += 1;
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "Spike") {
            playerStats.lives -= 1;
            GameMaster.KillPlayer(this);
        }

        if (col.gameObject.name == "Mace")
        {
            playerStats.lives -= 1;
            GameMaster.KillPlayer(this);


        }

        if (col.gameObject.name == "End")
        {
            SceneManager.LoadScene("SceneSelect", LoadSceneMode.Single);
        }
    } //End OnCollisionEnter
}
