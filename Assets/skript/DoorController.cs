using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour

{
    public float distance = 2f;
    List<Key> keyList;

    // Start is called before the first frame update
    void Start()
    {
        keyList = new List<Key>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height /2));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, distance))
            {
                if (hit.collider.tag == "Door")
                { 
                    Door door = hit.collider.GetComponent<Door>();
                    if (door.isLocked)
                    {
                        for (int i = 0; i < keyList.Count; i++)
                        {
                            if (keyList[i].id == door.id)
                            {
                                door.isLocked = false;
                                door.isOpen = !door.isOpen;
                            }
                            else 
                                Debug.Log("У тебя нет нужного ключа!");
                        }
                    }
                    else
                    {
                        door.isOpen = !door.isOpen;
                    }
                }

                if (hit.collider.GetComponent<Key>())
                {
                    Key key = hit.collider.GetComponent<Key>();
                    keyList.Add(key);
                    Debug.Log(keyList.Count);
                    Destroy(key.gameObject); 
                }
            }
        }
    }
}
