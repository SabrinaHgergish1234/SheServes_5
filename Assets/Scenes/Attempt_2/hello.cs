using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DelayedText : MonoBehaviour
{
    public TextMeshPro textObject;  // Assign this in the Inspector

    void Start()
    {
        // Ensure the text is hidden at the start
        if (textObject != null)
            textObject.gameObject.SetActive(false);

        // Start coroutine on an active object
        StartCoroutine(ShowTextAfterDelay());
    }

    IEnumerator ShowTextAfterDelay()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Ensure textObject is assigned before activating
        if (textObject != null)
            textObject.gameObject.SetActive(true);
    }
}
