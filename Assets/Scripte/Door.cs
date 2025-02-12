using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public bool isOpen = false;

    

    public Recepteur[] Recepteur; //chaque porte est associ� � un ou plusieur r�cepteur
    public int nbRecepteur = 0; //nombre de r�cepteur associ� � la porte
    public int nbRecepteurCompleted = 0; //nombre de r�cepteur qui ont �t� compl�t�, de base 0

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
