using UnityEngine;
using System.Collections;

public class SpriteScript : MonoBehaviour
{

    SpriteRenderer renderer;
    public Sprite[] image;
    int temp = 0;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        renderer.sprite = image[temp];
    }

     public void NextSprit()
    {
        //idx++;
        //if (idx >= image.Length) idx = 0;
         temp = Random.Range(0, image.Length);
        renderer.sprite = image[temp];
        Debug.Log("change "+temp);
    }
}