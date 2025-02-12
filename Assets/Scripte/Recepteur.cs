using UnityEngine;



public class Recepteur : MonoBehaviour
{
    public Door Door; 
    public TypeObject typeObjectAccepted;

    public bool isCompleted = false;


    private void OnTriggerEnter(Collider other)
    {
        print("triggerENTER");
        objetSpecial obj = other.GetComponent<objetSpecial>();
        if (obj != null && obj.getTypeObject() == typeObjectAccepted)
        {
            Door.addArecepteurCompleted();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("triggerEXIT");
        objetSpecial obj = other.GetComponent<objetSpecial>();
        if (obj != null && obj.getTypeObject() == typeObjectAccepted)
        {
            Door.removeArecepteurCompleted();
        }
    }
}
