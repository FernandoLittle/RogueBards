using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuyCard : MonoBehaviour
{
    public WWW www;
    public WWW www1;
    public int id;
    public int score;
    public Text idT;
    public Text scoreT;
    public List <bool> CardsOw;
    public int idcard;
    // Start is called before the first frame update
    void Start()
    {
        id = PlayerPrefs.GetInt("id");
        idT.text = id.ToString();
        score = PlayerPrefs.GetInt("score");
        scoreT.text = score.ToString();
        StartCoroutine(MyCards());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Buy()
    {
        StartCoroutine(Buy1());

    }
    IEnumerator Buy1()
    {
        WWWForm form = new WWWForm();
        form.AddField("idcarto", idcard.ToString());
        form.AddField("idplayor", id.ToString());
        form.AddField("scora", score.ToString());
        Debug.Log(www);
        www = new WWW("http://localhost/sqlconnect/fatebuycard.php", form);
        Debug.Log(www);
        yield return www;
        Debug.Log(www.text);
    }
    IEnumerator MyCards()
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("idplayor", id.ToString());
        //Debug.Log(www);
        www1 = new WWW("http://localhost/sqlconnect/mycards.php", form1);
        //Debug.Log(www);
        yield return www1;
        Debug.Log(www1.text);
        for (int x = 1; x < www1.text.Split('\t').Length; x += 1)
        {
            try
            {
                CardsOw[int.Parse(www1.text.Split('\t')[x])] = true;
            }
            catch
            {
 
            }

        }


    }
    public void Idle()
    {
        score += 1;
        scoreT.text = score.ToString();
    }
}
