using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Button
using UnityEngine.SceneManagement; //SceneManager

public class Cir : MonoBehaviour
{


    void Start()
    {


        Button button = GameObject.Find("Button").GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("lob");
        });
    }
}

