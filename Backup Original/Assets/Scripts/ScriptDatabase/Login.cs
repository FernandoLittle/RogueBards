using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public WWW www;
    public InputField name;
    public InputField password;
    public Generic Generic;
    public int score1;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Login0()
    {
        StartCoroutine(Login1());

    }
    IEnumerator Login1()
    {
        WWWForm form = new WWWForm();
        form.AddField("nameplayer", name.text);
        form.AddField("password", password.text);
        Debug.Log(www);
        www = new WWW("http://localhost/sqlconnect/fatelogin.php", form);
        Debug.Log(www);
        yield return www;
        Debug.Log(www.text);
        if (www.text.Contains("0"))
        {

            score1 = int.Parse(Generic.CodeLyoko(www.text, 1));
            id = int.Parse(Generic.CodeLyoko(www.text, 2));
            PlayerPrefs.SetInt("id", id);
            PlayerPrefs.SetInt("score", score1);
            //SceneManager.LoadScene("Deckbuilding");
        }
    }

}
