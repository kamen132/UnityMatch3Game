using UnityEngine;
using System.Collections;

public class PLayerInfo : MonoBehaviour
{

    public static PLayerInfo Info;      // infomations of player

    public static Player MapPlayer;     // player object

    public static byte MODE;            // mode : Arcade or Classic 

    public static int BACKGROUND;       // background of mode

    public int Score;

    public const string KEY_CLASSIC_HISCORE = "classichightscore";

    public TextMesh textlv;

    void Awake()
    {
        PLayerInfo.MapPlayer = new Player();
        Info = this;
       // BACKGROUND = MapPlayer.Background;
        MapPlayer.Level = 86;
    }

    void Start()
    {
        Score = 0;
        EffectSpawner.effect.SetLevel(MapPlayer.Level);
        Debug.LogError("Level=="+MapPlayer.Level);
        EffectSpawner.effect.SetBest(MapPlayer.HightScore);
        EffectSpawner.effect.SetScore(Score);
        textlv.text = MapPlayer.Level.ToString();
    }
}
