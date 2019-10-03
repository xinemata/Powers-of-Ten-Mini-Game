using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyBallEmpty : MonoBehaviour
{
    public GameObject BallEmpty;
    public StickyBall script;

    // Start is called before the first frame update
    void Start()
    {
        script = BallEmpty.GetComponent<StickyBall>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is working!" + script.size);
    }
}
