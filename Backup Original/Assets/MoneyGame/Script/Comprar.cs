using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comprar : MonoBehaviour
{
    public int id;
    public Button BuyButton;
    public Dio Dio;
    public int price;
    public Text BuyText;
    public int language;
    public Text PriceText;
    public void OnEnable()
    {
        language = PlayerPrefs.GetInt("Language");
        Rules();
    }
    public void Rules()
    {
        if(id == 9 || id == 10 | id == 11 | id == 12)
        {
            Price1();
        }
        else
        {
            Price();
        }
        

    }

    public void Buy()
    {
        if (id == 1 || id == 2 | id == 3 | id == 4)//BackGrounds
        {
            Dio.Background(id);
            PlayerPrefs.SetInt("Background", id);
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
                Tradução();
            }
            Dio.Dialogue(3,4,0);
        }
        if (id == 5)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Dio.Dialogue(22, 0, 0);
                Pagamento();
                Tradução();
            }
            else
            {
                Dio.MusicGame();
            }
               
        }
        if (id == 6)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Dio.Dialogue(18, 0, 0);
                Pagamento();
                Tradução();
            }
            else
            {
                Dio.PrayGame();
            }

        }
        if (id == 7)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Dio.Dialogue(15, 16, 17);
                Pagamento();
                Tradução();
            }
            else
            {
                Dio.BookGame();
            }

        }
        if (id == 8)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Dio.Dialogue(22, 23, 24);
                Pagamento();
                Tradução();
            }
            else
            {
                Dio.PathOfHappiness();
            }

        }
        if (id == 9)
        {
            Dio.Dialogue(9, 0, 0);
            PagamentoUpgrade(1);
        }
        if (id == 10)
        {
            Dio.Dialogue(11, 12, 0);
            PagamentoUpgrade(2);
        }
        if (id == 11)
        {
            Dio.Dialogue(9, 0, 0);
            PagamentoUpgrade(3);
        }
        if (id == 12)
        {
            Dio.Dialogue(11, 12, 0);
            PagamentoUpgrade(4);
        }
        if (id == 13)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
            }
            Tradução();
            Dio.Intro();
        }
        if (id == 14)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
            }
            Tradução();
            Dio.Discord();
        }
        if (id == 15)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
            }
            Tradução();
            Dio.ExitB();
        }
        if (id == 16)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
            }
            Tradução();
            Dio.AudioControler();
        }
        if (id == 17)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
            }
            Tradução();
            Dio.RoyDialogo();
        }
        if (id == 18)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
            }
            Tradução();
            Dio.WillDialogo();
        }
        if (id == 19)
        {
            if (Dio.Upgrades[id] == 0)
            {
                Pagamento();
            }
            Tradução();
            Dio.Volume();
        }
    }
    public void PagamentoUpgrade(int idUpgrade)
    {
        Dio.Upgrades[id] += 1;
        Dio.SaveUpgrade(id, Dio.Upgrades[id]);
        Dio.money -= price;
        Dio.Money.Dio.Money.Dio.Money.MoneyText.text = Dio.money.ToString();
        if (idUpgrade == 1)
        {
            price = Dio.PricesUpgrade1[Dio.Upgrades[9]];
        }
        if (idUpgrade == 2)
        {
            price = Dio.PricesUpgrade1[Dio.Upgrades[10]];
        }
        if (idUpgrade == 3)
        {
            price = Dio.PricesUpgrade1[Dio.Upgrades[11]];
        }
        if (idUpgrade == 4)
        {
            price = Dio.PricesUpgrade1[Dio.Upgrades[12]];
        }
        Rules();
    }
    public void Pagamento()
    {

        PriceText.text = "";
        Dio.Upgrades[id] += 1;

        Dio.SaveUpgrade(id, Dio.Upgrades[id]);
        Dio.money -= price;
        Dio.Money.Dio.Money.Dio.Money.MoneyText.text = Dio.money.ToString();
    }
    public void Tradução()
    {
        if (id == 1 || id == 2 || id == 3 || id == 4)
        {
            if (language == 0)
            {
                BuyText.text = "Select";
            }
            if (language == 1)
            {
                BuyText.text = "Selecionar";
            }
        }
        if (id == 5 || id == 6 || id == 7 || id == 8 || id == 13)
        {
            if (language == 0)
            {
                BuyText.text = "Play";
            }
            if (language == 1)
            {
                BuyText.text = "Jogar";
            }
        }
        if (id == 14)
        {
            if (language == 0)
            {
                BuyText.text = "Fix your posture";
            }
            if (language == 1)
            {
                BuyText.text = "Ajeita sua postura";
            }
        }
        if (id == 16)
        {
            if (language == 0)
            {
                BuyText.text = "Play";
            }
            if (language == 1)
            {
                BuyText.text = "Tocar";
            }
        }
        if (id == 17)
        {
            if (language == 0)
            {
                BuyText.text = "Play";
            }
            if (language == 1)
            {
                BuyText.text = "Tocar";
            }
        }
        if (id == 18)
        {
            if (language == 0)
            {
                BuyText.text = "Play";
            }
            if (language == 1)
            {
                BuyText.text = "Tocar";
            }
        }
        if (id == 19)
        {
            if (language == 0)
            {
                BuyText.text = "Piadinha";
            }
            if (language == 1)
            {
                BuyText.text = "Piadinha";
            }
        }
    }
    public void Price()
    {
        if (Dio.Upgrades[id] == 0)
        {
            if (language == 0)
            {
                PriceText.text = "Price $" + price.ToString();
            }
            if (language == 1)
            {
                PriceText.text = "Preço $" + price.ToString();
            }

            if (price > Dio.money)
            {
                BuyButton.interactable = false;
            }
            else
            {
                BuyButton.interactable = true;
            }

        }
        else
        {
            PriceText.text = "";
            BuyButton.interactable = true;
            Tradução();
        }

    }
    public void Price1()
    {

        
            if (language == 0)
            {
                PriceText.text = "Price $" + price.ToString();
            }
            if (language == 1)
            {
                PriceText.text = "Preço $" + price.ToString();
            }

            if (price > Dio.money)
            {
                BuyButton.interactable = false;
            }
            else
            {
                BuyButton.interactable = true;
            }

        
       

    }
}
