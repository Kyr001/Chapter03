using UnityEngine;
using UnityEngine.UI;

public class InputPlayerName : MonoBehaviour
{
    public GameObject inputNamePanel;

    public InputField fieldTxt;
    public Button JoinBtn;
    public Text PlayerNameTxt;

    private void Start()
    {
        inputNamePanel.SetActive(true);
    }

    public void Login()
    {
        if(fieldTxt.text.Length >= 2 && fieldTxt.text.Length <= 10)
        {
            JoinBtn.interactable = true;
            Debug.Log("로그인 성공!");
            PlayerNameTxt.text = fieldTxt.text;

            inputNamePanel.SetActive(false);
        }
        else
        {
            Debug.Log("로그인 실패");
            Debug.Log("2글자에서 10글자 사이로 입력해 주세요.");
        }

     }
}
