using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Briks : MonoBehaviour
{
    public  enum Type
    {
        wall, window, box, floor,
    }

    public Type typebrick;
   
    void Test()
    {
          switch (typebrick)
        {
            case Type.wall:
                break;
        }
    }
}
