using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ARSceneSwitcher : MonoBehaviour
{
    public Button switchButton; // Assign in Inspector
    private static bool isSessionPersisted = false;

    void Start()
    {
        if (!isSessionPersisted)
        {
            // Find AR components
            ARSession arSession = FindObjectOfType<ARSession>();
            GameObject xrOrigin = GameObject.Find("XR Origin (Mobile AR)");

            // Keep AR session and XR Origin between scenes
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

            isSessionPersisted = true;
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
        // Check if the current scene is FirstScene_2
        if (SceneManager.GetActiveScene().name == "FirstScene_2")
        {
            // Load the SecondScene_2
            SceneManager.LoadScene("SecondScene_2");
            Debug.Log("Switching to SecondScene_2...");
        }
        else
        {
            // If the scene is already loaded or switching is unnecessary
            Debug.LogWarning("Scene is already loaded or switching is unnecessary.");
        }
    }
}




