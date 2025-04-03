using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ARSceneSwitcherBackToSecond : MonoBehaviour
{
    public Button switchButton; // Assign in Inspector
    private static bool isSessionPersisted = true; // Session persists from previous scenes

    void Start()
    {
        if (switchButton != null)
        {
            switchButton.onClick.AddListener(SwitchScene);
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("SecondScene_2");
    }
}