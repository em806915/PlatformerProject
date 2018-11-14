using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button b1;
    int level = 1;
    // Use this for initialization
    void Start()
    {
            b1.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick()
    {
        SceneManager.LoadScene(level+1,LoadSceneMode.Single);
    }
    public void GetPlayerStats(Player p1)
    {
        level = p1.playerStats.level;
    }
}