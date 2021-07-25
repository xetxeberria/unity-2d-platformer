using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
