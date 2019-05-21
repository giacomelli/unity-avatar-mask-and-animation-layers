using UnityEngine;

public class QuitController : MonoBehaviour
{   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q))
            Application.Quit();
    }
}
