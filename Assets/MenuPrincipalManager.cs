using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;


    // Start is called before the first frame update
    public void Jogar() 
    {
        SceneManager.LoadScene("a");
    }

    public void AbrirOpcoes() 
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
}
