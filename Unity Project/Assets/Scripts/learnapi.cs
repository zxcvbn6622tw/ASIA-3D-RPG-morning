
using UnityEngine;

public class learnapi : MonoBehaviour
{
    public Transform test1;
    private void Start()
    {
        print(test1.position);
        transform.localScale = new Vector3(600,600,600);
    }

    private void Update()
    {
        test1.Rotate(0, 5, 0);
    }


}
