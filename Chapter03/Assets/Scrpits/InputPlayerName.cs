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
            Debug.Log("�α��� ����!");
            PlayerNameTxt.text = fieldTxt.text;

            inputNamePanel.SetActive(false);
        }
        else
        {
            Debug.Log("�α��� ����");
            Debug.Log("2���ڿ��� 10���� ���̷� �Է��� �ּ���.");
        }

     }
}
