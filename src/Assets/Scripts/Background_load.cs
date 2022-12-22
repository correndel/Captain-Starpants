using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_load : MonoBehaviour
{
    public GameObject desert;
    public GameObject jungle;
    public GameObject ice;
    public GameObject moon;
    public int level = 2;

    // Start is called before the first frame update
    void Start()
    {
        //get menu level
        switch (level)
        {
            case 1:
                Instantiate(desert);
                break;
            case 2:
                Instantiate(jungle);
                break;
            case 3:
                Instantiate(ice);
                break;
            case 4:
                Instantiate(moon);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
