using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Player.PlayerStats player;

    Text lives_txt;

	void Start () {
        //GameObject player = GameObject.Find("Player");
        player.lives = 3;
        int lifeCount = player.lives;
        lives_txt = GetComponent<UnityEngine.UI.Text>();
        lives_txt.text = "Lives: " + lifeCount;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
