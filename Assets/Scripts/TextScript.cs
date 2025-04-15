using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{

    // This script allows for the health of the wall to be displayed on the sign UI element

    public CastleWall castleWall;

    public TMP_Text damage;

    void Update()
    {
        damage.SetText("Castle Health: " + castleWall.wallHealth + "/5");
    }
}
