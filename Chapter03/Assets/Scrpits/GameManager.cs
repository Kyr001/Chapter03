using UnityEngine;

public class GameManager
{
    public ChooseCharacter chooseCharacter;
    public InputPlayerName inputPlayerName;


    // 싱글톤
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
        //캐릭터 선택창 띄우기
        //chooseCharacter.Start();

        //이름 선택창 띄우기
        //inputPlayerName.Start();

        //InputSystem 호출

        //CameraManager 호출
    }

}
