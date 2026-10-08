using UnityEngine;
using System;
using TMPro;


public class StarSystem : MonoBehaviour
{
    public static int starCount = 1;
    public TMP_Text starCountText;

    void Start()
    {
        
    }

    void Update()
    {
        if (BulletPhysics.end)
        {
            Star();
        }
    }

    void Star()
    {
        if (!PeopleMechanics.isDead)
        {
            starCount++;
        }
        if (Enemy.isDead)
        {
            starCount++;
        }
        starCountText.text = starCount.ToString();
    }
}
