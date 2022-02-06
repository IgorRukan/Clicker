using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneyText;
    
    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
    }

    public void ButtonClick()
    {
        money++;
        PlayerPrefs.SetInt("money", money);
    }
    
    public void ToPauseMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Reset() => money = 0;
    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();
    }
}
