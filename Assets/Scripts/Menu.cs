using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void MudarCena(int cena)
    {
        SceneManager.LoadScene(cena);
    }
}
