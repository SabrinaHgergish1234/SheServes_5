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
                DontDestroyOnLoad(arSession.gameObject);

            if (xrOrigin != null)
                DontDestroyOnLoad(xrOrigin);

            isSessionPersisted = true;
        }

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
