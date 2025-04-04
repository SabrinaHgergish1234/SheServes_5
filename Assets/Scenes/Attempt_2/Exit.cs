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
        // Check for ARSession and XR Origin
        ARSession arSession = FindObjectOfType<ARSession>();
        GameObject xrOrigin = GameObject.Find("XR Origin (Mobile AR)");

        if (arSession != null)
        {
            DontDestroyOnLoad(arSession.gameObject);
        }
        else
        {
            Debug.LogWarning("ARSession not found. Ensure it exists in the scene.");
        }

        if (xrOrigin != null)
        {
            DontDestroyOnLoad(xrOrigin);
        }
        else
        {
            Debug.LogWarning("XR Origin not found. Ensure it exists in the scene.");
        }

        if (switchButton != null)
        {
            switchButton.onClick.AddListener(SwitchScene);
        }
        else
        {
            Debug.LogWarning("Switch button is not assigned in the Inspector.");
        }
    }

    void SwitchScene()
    {
        if (SceneManager.GetActiveScene().name != "ThirdScene_2")
        {
            SceneManager.LoadScene("FirstScene_2");
        }
        else
        {
            Debug.LogWarning("Scene is already loaded or switching is unnecessary.");
        }
    }
}
