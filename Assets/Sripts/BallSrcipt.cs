using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSrcipt : MonoBehaviour
{
    
    public GameObject sp;
    private SpriteRenderer spriteR;
    private Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = Resources.Load<Sprite>("football");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
