using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedAppear : MonoBehaviour
{
    [SerializeField] private Image customImage;
    [SerializeField] private Image customImage2;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("appearImage", 2.7f);
        Invoke("appearImage2", 3f);
    }

    public void appearImage()
    {
        customImage.enabled = true;
    }

    public void appearImage2()
    {
        customImage2.enabled = true;
    }

}
