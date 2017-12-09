using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;
public class SceneControl : MonoBehaviour
{
    public NetworkManagerHUD hud;

    void Start()
    {
      //  hud= gameObject.GetComponent(hud);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == " TITLE")
        {
            hud.offsetX = Screen.width / 2 - 100; ;
            hud.offsetY = Screen.height - 200;
        }
        else
        {
            hud.offsetX = Screen.width - 215; ;
            hud.offsetY = -50;
        }
    }
}