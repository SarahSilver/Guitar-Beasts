using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField]
    private GameObject _gameOverTela;

    [SerializeField]
    private TextMeshProUGUI _scoretext;


    private int pontos;

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }else if(instance!=this)
        {
            Destroy(this.gameObject);
        }
    }

    public void AtualizarPontos(int n)
    {
        pontos += n;
        _scoretext.text = pontos.ToString();
    }

    public void GameOver()
    {
        _gameOverTela.SetActive(true);
    }
    

    public void Restart(int fase)
    {
        SceneManager.LoadScene(fase);
        Time.timeScale = 1;
    }

   
}
