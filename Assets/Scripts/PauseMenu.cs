using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] int money;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
    }

    public void ToGame()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        
    }
}
