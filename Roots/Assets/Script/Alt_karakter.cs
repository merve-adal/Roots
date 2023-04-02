using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alt_karakter : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent _navMesh;
    void Start()
    {
        _navMesh = GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().VarisNoktasi;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        _navMesh.SetDestination(Target.transform.position);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("igneliKutu"))
        {
            Vector3 yeniPoz = new Vector3(transform.position.x, .23f, transform.position.z);

            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().YokolmaEfektiOlustur(yeniPoz);
            gameObject.SetActive(false);
            
        }

        if (other.CompareTag("Testere"))
        {
            Vector3 yeniPoz = new Vector3(transform.position.x, .23f, transform.position.z);

            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().YokolmaEfektiOlustur(yeniPoz);
            gameObject.SetActive(false);

        }

        if (other.CompareTag("Pervane_Igneler"))
        {
            Vector3 yeniPoz = new Vector3(transform.position.x, .23f, transform.position.z);

            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().YokolmaEfektiOlustur(yeniPoz);
            gameObject.SetActive(false);

        }

        if (other.CompareTag("Balyoz"))
        {
            Vector3 yeniPoz = new Vector3(transform.position.x, .23f, transform.position.z);
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().YokolmaEfektiOlustur(yeniPoz, true);
            gameObject.SetActive(false);

        }

    }
}
