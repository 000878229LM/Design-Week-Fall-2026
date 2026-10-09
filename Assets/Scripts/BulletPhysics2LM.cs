using UnityEngine;

public class BulletPhysics2LM : MonoBehaviour
{

    public Transform player; //Players location
    public Vector3 locatToGo; //The location the bullet should go
    public Vector3 curPos; //Current bullet position
    public float rise, run, speed = 1f;
    public float getPlayerPosTimer;
    bool isPlayerLoc = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
        curPos = transform.position; //Location of bullet
         rise = player.position.y - curPos.y;
         run = player.position.x - curPos.x;
        getPlayerPosTimer = 20000;
       
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("RISE position: " + rise);
        if (getPlayerPosTimer <= 0)
        {if (isPlayerLoc == false)
            {
                rise = player.position.y - curPos.y;
                run = player.position.x - curPos.x;
                locatToGo = player.position;
                isPlayerLoc = false;
            }

            float slope = rise / run;

            curPos.x += Mathf.Sign(run) * speed * Time.deltaTime;
            curPos.y += Mathf.Sign(run) * slope * speed * Time.deltaTime;

            transform.position = curPos;
        }
        else { getPlayerPosTimer--; }
    }
}
