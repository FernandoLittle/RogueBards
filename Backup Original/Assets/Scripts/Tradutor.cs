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
        if (id == 1)//Loading
        {
            if (language == 0)
            {
                textinho.text = "This is the alpha version of Joker of Chaos.\n Join our Discord channel to be notified when new versions are released. \n You can also collaborate with the game by giving suggestions, feedback and reporting bugs. \nYou are very welcome.";
            }
            if (language == 1)
            {
                textinho.text = "Esta é a versão alfa do Joker of Chaos.\n Junte-se ao nosso canal Discord para ser notificado quando novas versões forem lançadas. \n Você também pode colaborar com o jogo dando sugestões, feedback e reportando bugs. \nVocê é muito bem-vindo. ";
            }
        }

    }




}

