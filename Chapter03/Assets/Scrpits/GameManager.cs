using UnityEngine;

public class GameManager
{
    public ChooseCharacter chooseCharacter;
    public InputPlayerName inputPlayerName;


    // �̱���
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(null == instance)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //ĳ���� ����â ����
        //chooseCharacter.Start();

        //�̸� ����â ����
        //inputPlayerName.Start();

        //InputSystem ȣ��

        //CameraManager ȣ��
    }

}
