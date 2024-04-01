using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Button exitButton;

    void Start()
    {
        exitButton.onClick.AddListener(ExitGame);
        // Start is called before the first frame update       
    }

    // Update is called once per frame
    void Update()
    {
        // Quit Program
        if (Input.GetKey(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
