using UnityEngine;
using UnityEngine.UI;

public class StartExit : MonoBehaviour
{
    public GameObject button;
    public GameObject menu;
    public Image[] options;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        options[index].color = new Color32(0, 255, 0, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (button.GetComponent<Buttons>().isPressed[5])
        {
            menu.SetActive(true);
        }

        if (menu.activeSelf)
        {
              
            if (Input.GetKeyDown(KeyCode.R))
               
            {
                if (index + 1 == 3)
                {
                    options[index].color = new Color32(255, 255, 255, 255);
                    index = 0;
                    options[index].color = new Color32(0, 255, 0, 255);
                }
                else
                {
                    options[index].color = new Color32(255, 255, 255, 255);
                    index++;
                    options[index].color = new Color32(0, 255, 0, 255);
                }
            }

            if  (button.GetComponent<Buttons>().isPressed[0])
            switch (index)
            {
                case 0:
                        menu.SetActive(false);
                        index = 0;
                    break;
                case 1:
                        Application.Quit();
                    break;
                case 2:
                    break;
            }
        }

    }
}
