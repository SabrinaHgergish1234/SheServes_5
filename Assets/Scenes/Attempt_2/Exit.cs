using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ARSceneSwitcherBack : MonoBehaviour
{
    public Button switchButton; // Assign in Inspector
    private static bool isSessionPersisted = true; // Session is already persisted from the first scene

    void Start()
    {
        if (switchButton != null)
        {
            switchButton.onClick.AddListener(SwitchScene);
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("FirstScene_2");
    }
}