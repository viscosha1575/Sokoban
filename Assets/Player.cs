using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne; // клавишы
    [SerializeField] KeyCode keyTwo; // клавишы
    [SerializeField] Vector3 moveDirection; //траектория
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection; //вперед
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection; //назад
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } //повтор
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } //новая сцена
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player")&& other.CompareTag("Finish")){

            //SceneManager.LoadScene("Lvl1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        } //препятствие для выхода


    }

}

