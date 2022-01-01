using UnityEngine;

public class LearnMember : MonoBehaviour
{
    public GameObject objA;
    public GameObject objB;
    public Transform objC;

    private void Start()
    {
        objA.name = "測試物件A";
        print(objB.name);
    }

    private void Update()
    {
        objC.Rotate(60, 0, 0);
    }
}
