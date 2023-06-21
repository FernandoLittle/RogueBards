using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IlusControler : MonoBehaviour
{
    public List<Sprite> IlustrationList;
    public List<Card> CardList;
    public Image Cenario;
    public TalesVariables TalesVariables;
    public bool IlustrationChange;
    public Animator IlustrationAnime;
    public Image Face;
    public Text Name;
    public GameObject Gambiarra;

    public void SetCenario(int idCenario)
    {
        if (IlustrationChange == false)
        {

            Cenario.sprite = IlustrationList[idCenario];
            
        }
        else
        {

            Gambiarra.SetActive(false);
            Gambiarra.SetActive(true);
            IlustrationAnime.Play("IlustrationChange");
            IlustrationChange = false;
        }
    }
    public void SetCenario2()
    {
        Cenario.sprite = IlustrationList[TalesVariables.Tales[TalesVariables.TaleSelect].Cenario];
    }
    public void SetFaceName(int idchara)
    {
        Face.sprite = CardList[idchara].sprite;
        Name.text = CardList[idchara].Name;
    }
}
