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
                textinho.text = "BUG A UM BUG ISSO TÀ BUGAOJSDLKJLSD.\n Junte-se ao nosso canal Discord para ser notificado quando novas versões forem lançadas. \n Você também pode colaborar com o jogo dando sugestões, feedback e reportando bugs. \nVocê é muito bem-vindo.";
            }
            if (id == 1)
            {
                textinho.text = "EstBUAGSGBUGGGGGGGGBBUBUBUBUBGBUGBUGBUGs.\n Junte-se ao nosso canal Discord para ser notificado quando novas versões forem lançadas. \n Você também pode colaborar com o jogo dando sugestões, feedback e reportando bugs. \nVocê é muito bem-vindo. ";
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
                textinho.text = "Era uma vez um espantalho";
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
            if (id == 16)
            {
                textinho.text = "Novo";
            }
            if (id == 17)
            {
                textinho.text = "Antigo";
            }
            if (id == 18)
            {
                textinho.text = "Você deseja substituir sua habilidade por uma nova?";
            }
            if (id == 19)
            {
                textinho.text = "Você ganhou uma nova relíquia.";
            }
            if (id == 20)
            {
                textinho.text = "Suas orações são patéticas.";
            }
            if (id == 21)
            {
                textinho.text = "Suas orações são aceitáveis.";
            }
            if (id == 22)
            {
                textinho.text = "Parabéns, suas orações são lindas.";
            }
            if (id == 23)
            {
                textinho.text = "Sua música é irritantemente alegre.";
            }
            if (id == 24)
            {
                textinho.text = "Sua música é satisfatoriamente tranquila.";
            }
            if (id == 25)
            {
                textinho.text = "Parabéns, sua música é maravilhosamente triste.";
            }
            if (id == 26)
            {
                textinho.text = "Resposta errada.";
            }
            if (id == 27)
            {
                textinho.text = "Resposta correta!";
            }
            if (id == 28)
            {
                textinho.text = "Resposta errada. Parabéns!";
            }
            if (id == 29)
            {
                textinho.text = " Parabéns, você concluiu um dos finais da versão beta do The Four Paths.\n Muito obrigado por jogar. Você também é bem-vindo no nosso canal do Discord para dar feedback, relatar bugs ou fazer sugestões.\n :)";
            }

            if (id == 30)
            {
                textinho.text = "Sua vida";
            }
            if (id == 31)
            {
                textinho.text = "Vida do oponente";
            }
            if (id == 32)
            {
                textinho.text = "Vitória";
            }
            if (id == 33)
            {
                textinho.text = "Derrota";
            }
            if (id == 34)
            {
                textinho.text = "Carregando...";
            }
            if (id == 35)
            {
                textinho.text = "Morte genérica";
            }
            if (id == 36)
            {
                textinho.text = "William se vinga";
            }
            if (id == 37)
            {
                textinho.text = "William se torna um mercenário";
            }
            if (id == 38)
            {
                textinho.text = "O Bardo mata William";
            }
            if (id == 39)
            {
                textinho.text = "Final feliz";
            }
            if (id == 40)
            {
                textinho.text = "Ebu mata William";
            }
            if (id == 41)
            {
                textinho.text = "William perde as pernas";
            }
            if (id == 42)
            {
                textinho.text = "William é demitido";
            }
            if (id == 43)
            {
                textinho.text = "Maduin e Ebu vivem felizes para sempre";
            }
            if (id == 44)
            {
                textinho.text = "William foge como um covarde";
            }
            if (id == 45)
            {
                textinho.text = "A misericórdia mata William";
            }
            if (id == 46)
            {
                textinho.text = "Fim do tutorial";
            }






            if (id == 0)
            {
                textinho.text = "";
            }
        }

        if (language == 2)
        {
            if (id == 0)
            {
                textinho.text = "AAAAAAAAAAAAAAAA BUG THIS IS A BUGs.\n Junte-se ao nosso canal Discord para ser notificado quando novas versões forem lançadas. \n Você também pode colaborar com o jogo dando sugestões, feedback e reportando bugs. \nVocê é muito bem-vindo.";
            }
            if (id == 1)
            {
                textinho.text = "BUG.\n Junte-se ao nosso canal Discord para ser notificado quando novas versões forem lançadas. \n Você também pode colaborar com o jogo dando sugestões, feedback e reportando bugs. \nVocê é muito bem-vindo. ";
            }
            if (id == 2)
            {
                textinho.text = "Quiero contarte";
            }
            if (id == 3)
            {
                textinho.text = "una historia";
            }
            if (id == 4)
            {
                textinho.text = "Una historia muy divertida";
            }
            if (id == 5)
            {
                textinho.text = "Quieres";
            }
            if (id == 6)
            {
                textinho.text = "Escucharme?";
            }
            if (id == 7)
            {
                textinho.text = "Sí";
            }
            if (id == 8)
            {
                textinho.text = "No";
            }
            if (id == 9)
            {
                textinho.text = "Omitir Introducción";
            }
            if (id == 10)
            {
                textinho.text = "Lo que sea, voy a contar esta historia de todos modos.";
            }
            if (id == 11)
            {
                textinho.text = "Había una vez un espantapájaros";
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
            if (id == 16)
            {
                textinho.text = "Nuevo";
            }
            if (id == 17)
            {
                textinho.text = "Antiguo";
            }
            if (id == 18)
            {
                textinho.text = "¿Quieres reemplazar tu habilidad por una nueva?";
            }
            if (id == 19)
            {
                textinho.text = "Has ganado una nueva reliquia.";
            }
            if (id == 20)
            {
                textinho.text = "Tus oraciones son patéticas.";
            }
            if (id == 21)
            {
                textinho.text = "Sus oraciones son aceptables.";
            }
            if (id == 22)
            {
                textinho.text = "Felicidades, tus oraciones son hermosas.";
            }
            if (id == 23)
            {
                textinho.text = "Su música es irritantemente optimista.";
            }
            if (id == 24)
            {
                textinho.text = "Su música es satisfactoriamente tranquila.";
            }
            if (id == 25)
            {
                textinho.text = "Felicidades, tu canción es maravillosamente triste.";
            }
            if (id == 26)
            {
                textinho.text = "Respuesta equivocada.";
            }
            if (id == 27)
            {
                textinho.text = "¡Respuesta correcta!";
            }
            if (id == 28)
            {
                textinho.text = "Respuesta equivocada. ¡Felicidades!";
            }
            if (id == 29)
            {
                textinho.text = " Enhorabuena, has completado una de las finales de la versión beta de The Four Paths.\n Muchas gracias por jugar. También eres bienvenido en nuestro canal de Discord para enviar comentarios, informar errores o hacer sugerencias.\n :)";
            }

            if (id == 30)
            {
                textinho.text = "Su vida";
            }
            if (id == 31)
            {
                textinho.text = "la vida del oponente";
            }
            if (id == 32)
            {
                textinho.text = "Victoria";
            }
            if (id == 33)
            {
                textinho.text = "Fracaso";
            }
            if (id == 34)
            {
                textinho.text = "Cargando...";
            }
            if (id == 35)
            {
                textinho.text = "Muerte Genérica";
            }
            if (id == 36)
            {
                textinho.text = "William se venga";
            }
            if (id == 37)
            {
                textinho.text = "William se convierte en mercenario";
            }
            if (id == 38)
            {
                textinho.text = "El Bardo mata a William";
            }
            if (id == 39)
            {
                textinho.text = "Final feliz";
            }
            if (id == 40)
            {
                textinho.text = "Ebu mata a William";
            }
            if (id == 41)
            {
                textinho.text = "William pierde las piernas";
            }
            if (id == 42)
            {
                textinho.text = "William es despedido";
            }
            if (id == 43)
            {
                textinho.text = "Maduin y Ebu viven felices para siempre";
            }
            if (id == 44)
            {
                textinho.text = "William huye como un cobarde";
            }
            if (id == 45)
            {
                textinho.text = "La misericordia mata a William";
            }
            if (id == 46)
            {
                textinho.text = "Fin del tutorial";
            }






            if (id == 0)
            {
                textinho.text = "";
            }
        }





    }

}