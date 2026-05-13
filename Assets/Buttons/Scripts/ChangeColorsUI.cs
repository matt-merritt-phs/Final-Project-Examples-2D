using UnityEngine;

// This script can be placed on any GameObject,
//  it does not need to go on the button only.

public class ChangeColorsUI : MonoBehaviour
{
    public SpriteRenderer spr;

    // NEEDS TO BE PUBLIC TO BE USED IN EVENTS
    public void TurnGreen()
    {
        spr.color = new Color(0, 255, 0);
    }

    // NEEDS TO BE PUBLIC TO BE USED IN EVENTS
    public void TurnRed()
    {
        spr.color = new Color(255, 0, 0);
    }
}
