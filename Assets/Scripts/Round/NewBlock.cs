using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlock : MonoBehaviour
{
    const int RATE = 100;
    private int rate = RATE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // NewBlock is called to new block
    private void PruduceBlock()
    {
        GameObject block = (GameObject)Resources.Load("Prefabs/block");
        block = Instantiate(block);
        GameObject op = GameObject.Find("OriginPoint");
        int offset_int = Random.Range(-2, 10);
        float offset_dec = Random.Range(0, 10) / 10;
        float offsetX = offset_int + offset_dec;
        //block.transform.position = new Vector3(0, 0, 0);
        block.transform.position = new Vector3(op.transform.localPosition.x + offsetX, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(rate == 0)
        {
            rate = RATE;
            PruduceBlock();
        }else
        {
            rate--;
        }
    }
}
