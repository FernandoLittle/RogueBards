using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BookAlma : MonoBehaviour
{
    public Image BookI;
    public Text QuestionT;
    public Text Answer1;
    public Text Answer2;
    public Text Answer3;
    public Text Answer4;
    public List<Book> Books;
    public int BookIndex;
    public Text NameBook;
    public GameObject WrongAnswerGO;
    public GameObject CorrectAnswerGO;
    public GameObject UltraCorrectAnswerGO;
    public int Idle;
    public GodCube GodCube;//x
    
    // Start is called before the first frame update
    void Start()
    {
        BookIndex = Random.Range(0, Books.Count);
        Answer1.text = Books[BookIndex].Answer1;
        Answer2.text = Books[BookIndex].Answer2;
        Answer3.text = Books[BookIndex].Answer3;
        Answer4.text = Books[BookIndex].Answer4;
        QuestionT.text = Books[BookIndex].Question;
        NameBook.text= Books[BookIndex].NameBook;
        BookI.sprite= Books[BookIndex].BookSprite;
    }
    public void Answer(int choose)
    {
      
            if (choose == Books[BookIndex].CorrectAnswer)
            {
                CorrectAnswer();
            }
            else if (choose == Books[BookIndex].UltraCorrectAnswer)
            {
                UltraCorrectAnswer();
            }
            else
            {
                WrongAnswer();
            }
        
     
    }
    public void CorrectAnswer()
    {
        CorrectAnswerGO.SetActive(true);
    }
    public void UltraCorrectAnswer()
    {
        UltraCorrectAnswerGO.SetActive(true);
    }
    public void WrongAnswer()
    {
        WrongAnswerGO.SetActive(true);
    }
    public void CorrectAnswer1()
    {
        int buda;

        PlayerPrefs.SetInt("Batalha", 1);
        PlayerPrefs.SetInt("IdList", 3);

            PlayerPrefs.SetInt("Tale", 1);

        Idle = PlayerPrefs.GetInt("Idle");
        if (Idle == 1)
        {

            buda = PlayerPrefs.GetInt("Buda");
            if (buda == 1)
            {
                GodCube.TakeScreenshot("Adventure");
                //SceneManager.LoadScene("Adventure");
            }
            else
            {
                GodCube.TakeScreenshot("Money");
                //SceneManager.LoadScene("Money");
            }

        }
        else
        {
            GodCube.TakeScreenshot("Tales");
            //SceneManager.LoadScene("Tales");
        }

 

    }
    public void UltraCorrectAnswer1()
    {
        int buda;

        PlayerPrefs.SetInt("Batalha", 1);
        PlayerPrefs.SetInt("IdList", 3);

        PlayerPrefs.SetInt("Tale", 2);

        Idle = PlayerPrefs.GetInt("Idle");
        if (Idle == 1)
        {

            buda = PlayerPrefs.GetInt("Buda");
            if (buda == 1)
            {
                GodCube.TakeScreenshot("Adventure");
                //SceneManager.LoadScene("Adventure");
            }
            else
            {
                GodCube.TakeScreenshot("Money");
                //SceneManager.LoadScene("Money");
            }

        }
        else
        {
            GodCube.TakeScreenshot("Tales");
            //SceneManager.LoadScene("Tales");
        }
    }
    public void WrongAnswer1()
    {
        int buda;
        PlayerPrefs.SetInt("Batalha", 1);
        PlayerPrefs.SetInt("IdList", 3);

        PlayerPrefs.SetInt("Tale", 0);

        Idle = PlayerPrefs.GetInt("Idle");
        if (Idle == 1)
        {

            buda = PlayerPrefs.GetInt("Buda");
            if (buda == 1)
            {
                GodCube.TakeScreenshot("Adventure");
                //SceneManager.LoadScene("Adventure");
            }
            GodCube.TakeScreenshot("Money");
            //SceneManager.LoadScene("Money");
        }
        else
        {
            GodCube.TakeScreenshot("Tales");
            //SceneManager.LoadScene("Tales");
        }
    }

}
