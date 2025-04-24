using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlesScreenManager : MonoBehaviour
{
    public GameObject TitleScreenUI;
    public string desiredScene = "Kapil put the main game scene here";

    public void ChangeToGame()
    {
        SceneManager.LoadScene(desiredScene);
        Debug.Log("Scene Transition is Working");
    }
}
