using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public bool isOpen = false;

    

    public Recepteur[] Recepteur; //chaque porte est associé à un ou plusieur récepteur
    public int nbRecepteur = 0; //nombre de récepteur associé à la porte
    public int nbRecepteurCompleted = 0; //nombre de récepteur qui ont été complété, de base 0

    void Start()
    {
        nbRecepteur = Recepteur.Length;
        nbRecepteurCompleted = 0;
    }

    public void addArecepteurCompleted()
    {
        nbRecepteurCompleted = Mathf.Min(nbRecepteur, nbRecepteurCompleted + 1);
        checkIfDoorIsOpen();
    }

    public void removeArecepteurCompleted()
    {
        nbRecepteurCompleted = Mathf.Max(0, nbRecepteurCompleted - 1);
        checkIfDoorIsOpen();
    }

    public void checkIfDoorIsOpen()
    {
        if (nbRecepteurCompleted == nbRecepteur)
        {
            anim.SetTrigger("open");
            isOpen = true;
        }
        else
        {
            if (isOpen == true && nbRecepteurCompleted < nbRecepteur)
            {
                anim.SetTrigger("close");
                isOpen = false;

            }
        }
    }
}
