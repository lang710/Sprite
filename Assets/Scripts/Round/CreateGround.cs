using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float sizeX = 2.2f;
        float sizeY = 0;
        float sizeZ = 0;
        for(int i = 0; i < 5; i++)
        {
            CreateTheGround(i, sizeX, sizeY, sizeZ);
        }
    }

    void CreateTheGround(int count, float sizeX, float sizeY, float sizeZ)
    {
        GameObject ground = (GameObject)Resources.Load("Prefabs/Ground");
        ground = Instantiate(ground);
        GameObject op = GameObject.Find("OriginPoint");
        float offsetX = 0;
        float offsetY = -1.3f;
        float offsetZ = 0;
        float localX = op.transform.localPosition.x + offsetX + count*sizeX;
        float localY = op.transform.localPosition.y + offsetY + count*sizeY;
        float localZ = op.transform.localPosition.z + offsetZ + count*sizeZ;
        //block.transform.position = new Vector3(0, 0, 0);
        //Debug.Log(localX);
        //Debug.Log("localY:" + localY);
        //Debug.Log(localZ);
        ground.transform.position = new Vector3(localX, localY, localZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
