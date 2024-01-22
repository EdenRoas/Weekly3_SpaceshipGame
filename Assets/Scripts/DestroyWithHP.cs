using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyWithHP : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string triggeringTag;
    [SerializeField] int Health;
    [SerializeField] string GameOverSceneName;

   
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if(Health > 0 )
            {
                Health --;
            }
            else
            {
                //We Are Death
                SceneManager.LoadScene(GameOverSceneName);    // Input can either be a serial number or a name; here we use name.


            }
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
