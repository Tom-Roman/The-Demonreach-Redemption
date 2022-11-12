using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 motion = new Vector2(player.transform.position.x - this.transform.position.x, player.transform.position.y - this.transform.position.y);
        if (motion.magnitude > 0.02)
        {
            motion = motion.normalized;
            motion /= 100;
            Vector3 motion3d = new Vector3(motion.x, motion.y, 0);
            this.transform.position += motion3d;
        }
    }
}