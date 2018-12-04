using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doExitGame : MonoBehaviour {

    public Button b1;

    // Use this for initialization
    void Start () {
        b1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
    }
}
