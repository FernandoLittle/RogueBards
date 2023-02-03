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
            if (id == 12)
            {
                textinho.text = "Caminho da Felicidade";
            }
            if (id == 13)
            {
                textinho.text = "Você será levado imediatamente para o jogo verdadeiro, O Caminho da Felicidade.\n No entanto, o jogo falso, O Caminho do Dinheiro, será destruído para sempre, você nunca mais poderá jogá-lo.\n O verdadeiro desapego é um dos caminhos para a iluminação.";
            }
            if (id == 14)
            {
                textinho.text = "Caminho do Dinheiro";
            }
            if (id == 15)
            {
                textinho.text = "O jogo falso não será destruído e você ainda poderá jogar O Caminho da Felicidade.\n No entanto, você precisará ganhar muito dinheiro para ter acesso ao jogo verdadeiro.\n O dinheiro pode lhe trazer o prazer que o mundo material traz, mas ganhar dinheiro nem sempre é divertido.";
            }





            if (id == 0)
            {
                textinho.text = "";
            }
        }
       

    }




}

