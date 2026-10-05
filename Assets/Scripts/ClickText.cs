using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.SceneManagement;

using System.Collections;

//https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html
//https://discussions.unity.com/t/onclick-event-for-ui-text/182600/2
//https://gamedevbeginner.com/how-to-load-a-new-scene-in-unity-with-a-loading-screen/

public class ClickText : MonoBehaviour
{

    TextMeshProUGUI beginGame;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beginGame = GetComponent<TextMeshProUGUI>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Scene1");
        }
    }
}

