using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager _GameManager;
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 1.5f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - .08f, transform.position.y,
                    transform.position.z), .3f);
            }
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + .08f, transform.position.y,
                    transform.position.z), .3f);
            }

        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Toplama") || other.CompareTag("Carpma") || other.CompareTag("Cikartma") || other.CompareTag("Bolme"))
        {
            int sayi = int.Parse(other.name);
            _GameManager.AdamYonetimi(other.tag, sayi, other.transform);

        }

        if (other.tag == "ATA")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("kök"))
        {
            // Oyunu bitir
            Time.timeScale = 0;
            Destroy(gameObject);
        }

    }


}
