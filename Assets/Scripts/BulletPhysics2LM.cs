using UnityEngine;

public class BulletPhysics2LM : MonoBehaviour
{

    public Transform player; //Players location
    public Vector3 locatToGo; //The location the bullet should go
    public Vector3 curPos; //Current bullet position
    public float rise, run, speed = 1f;
    public float getPlayerPosTimer;
    bool isPlayerLoc;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
        curPos = transform.position; //Location of bullet
         rise = player.position.y - curPos.y;
         run = player.position.x - curPos.x;
        getPlayerPosTimer = 40000;
       
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("RISE position: " + rise);

        if (isPlayerLoc == false && getPlayerPosTimer == 0)
        {
            rise = player.position.y - curPos.y;
            run = player.position.x - curPos.x;
            isPlayerLoc = true;
        }
        else { getPlayerPosTimer--; }

            float slope = rise / run;

        curPos.x += Mathf.Sign(run) * speed * Time.deltaTime;
        curPos.y += Mathf.Sign(run) * slope * speed * Time.deltaTime;

        transform.position = curPos;
    }
}
