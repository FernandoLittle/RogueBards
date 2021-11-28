using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public WWW www;
    public InputField name;
    public InputField password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Register0()
    {
        StartCoroutine(Register1());

    }
    IEnumerator Register1()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name.text);
        form.AddField("password", password.text);
        Debug.Log(www);
        www = new WWW("http://localhost/sqlconnect/fateregister.php", form);
        Debug.Log(www);
        yield return www;
        Debug.Log(www.text);
    }
}
