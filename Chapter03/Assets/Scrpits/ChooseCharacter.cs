

using UnityEngine;
using UnityEngine.UI;

public class ChooseCharacter: MonoBehaviour
{
    public GameObject ChooseCharacterPanel;

    public GameObject MainScript1;
    public GameObject MainScript2;

    public GameObject CharacterImg1;
    public GameObject CharacterImg2;

    private void Start()
    {
        ChooseCharacterPanel.SetActive(true);
    }

    public void SelectCharacter1()
    {
        MainScript2.SetActive(false);
        MainScript1.SetActive(true);

        ChooseCharacterPanel.SetActive(false);

        CharacterImg2.SetActive(false);
        CharacterImg1.SetActive(true);
    }

    public void SelectCharacter2()
    {
        MainScript1.SetActive(false);
        MainScript2.SetActive(true);

        ChooseCharacterPanel.SetActive(false);

        CharacterImg1.SetActive(false);
        CharacterImg2.SetActive(true);
    }
}