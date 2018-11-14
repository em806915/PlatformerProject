using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    AssetBundle myLoadedAssetBundle;
    string[] scenePaths;

    // Use this for initialization
    public void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }

    public void OnGUI()
    {
        Debug.Log("Scene2 loading: " + scenePaths[0]);
        SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
    }
}