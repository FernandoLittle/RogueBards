using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tradutor : MonoBehaviour
{
    public int id;
    public Text textinho;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Tradutorar();
    }
    public void Tradutorar()
    {
        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {

        }
        if (language == 1)
        {
            if (id == 0)
            {
                textinho.text = "Esta é a versão alfa do Joker of Chaos.\n Junte-se ao nosso canal Discord para ser notificado quando novas versões forem lançadas. \n Você também pode colaborar com o jogo dando sugestões, feedback e reportando bugs. \nVocê é muito bem-vindo.";
            }
            if (id == 1)
            {
                textinho.text = "Esta é a versão alfa do Joker of Chaos.\n Junte-se ao nosso canal Discord para ser notificado quando novas versões forem lançadas. \n Você também pode colaborar com o jogo dando sugestões, feedback e reportando bugs. \nVocê é muito bem-vindo. ";
            }
            if (id == 2)
            {
                textinho.text = "Eu desejo te contar";
            }
            if (id == 3)
            {
                textinho.text = "uma história";
            }
            if (id == 4)
            {
                textinho.text = "Uma história muito engraçada";
            }
            if (id == 5)
            {
                textinho.text = "Você quer";
            }
            if (id == 6)
            {
                textinho.text = "me ouvir?";
            }
            if (id == 7)
            {
                textinho.text = "Sim";
            }
            if (id == 8)
            {
                textinho.text = "Não";
            }
            if (id == 9)
            {
                textinho.text = "Pular Introdução";
            }
            if (id == 10)
            {
                textinho.text = "Tanto faz, eu vou contar essa história de qualquer maneira.";
            }
            if (id == 11)
            {
                textinho.text = "Era uma vez um espantalho...";
            }
            if (id == 0)
            {
                textinho.text = "";
            }
        }
       

    }




}

