using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button b1;
    public string level;
    // Use this for initialization
    void Start()
    {
            b1.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick()
    {
        SceneManager.LoadScene(level,LoadSceneMode.Single);
    }

}