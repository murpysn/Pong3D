using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHeal : MonoBehaviour
{
    public GUISkin ScoreSkin;
    int PlayerScore = 0;
    int Heal = 3;

    public int Heals()
    {
        return Heal;
    }
    public void DecreaseHeal()
    {
        Heal-= 1;
        print(Heal.ToString());
    }
    public void IncreaseScore()
    {
        PlayerScore += 10;
    }

    private void OnGUI()
    {
        if (GUI.skin != ScoreSkin)
        {
            GUI.skin = ScoreSkin;
        }
        GUI.Label(new Rect(200, 20, 300, 30), PlayerScore.ToString());
        GUI.Label(new Rect(100, 10, 300, 30), "Heals : " +Heal.ToString());
    }
}
