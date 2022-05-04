using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamenTest : MonoBehaviour
{
    private BoardController m_boardController;
    // Start is called before the first frame update
    void Awake()
    {
        m_boardController = new GameObject("BoardController").AddComponent<BoardController>();
        m_boardController.StartGame2(Resources.Load<GameSettings>(Constants.GAME_SETTINGS_PATH));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
