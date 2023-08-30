using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i;
    int randomValue;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randomValue = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name+":"+i); 
        if (i == 100 && gameObject.tag.Equals("Red"))
        {
            gameObject.SetActive(false);
        } else if (i == randomValue && gameObject.tag.Equals("Blue"))
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
