using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcherBackToSecond : MonoBehaviour
{
    public Button switchButton; // Reference to the UI button

    void Start()
    {
        if (switchButton != null)
        {
            switchButton.onClick.AddListener(SwitchScene);
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("Second Scene");
    }
}