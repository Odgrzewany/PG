using UnityEngine;
using System.Collections;
using UnityEngine.AI;


public class PlayerMovement : MonoBehaviour {

    NavMeshAgent nma;

    Vector3 correctOffset;

    public GameObject markedObject;

    float distanceToTarget;

    public float basicDmg;
    public bool marked;

    public HeroCaller hc;

    private void Start()
    {
        nma = GetComponent<NavMeshAgent>();
        correctOffset = new Vector3(0, 25, -7);
        hc = FindObjectOfType<HeroCaller>();
        basicDmg = hc.physicDamage;
    }
    void GoToTarget(Vector3 target)
    {
        nma.SetDestination(target);
    }

    private void Update()
    {
        

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(marked == true)
        {
            DistanceToTarget(markedObject.transform.position);
            if(distanceToTarget < 20)
            {
                hc.Shooting();
                if (nma.isStopped != true)
                {
                    nma.ResetPath();
                }
            }
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (marked == false)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    GoToTarget(hit.point);
                    Debug.Log("Wybrane miejsce");
                }
            }
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("MainBase"))
                {
                    markedObject = hit.collider.gameObject;
                    marked = true;
                    Debug.Log("Cel!");
                }
                else
                {
                    markedObject = null;
                    marked = false;
                    Debug.Log("Pusto!");
                }
            }
        }
    }
    void DistanceToTarget(Vector3 targetPosistion)
    {
        distanceToTarget = Vector3.Distance(transform.position, targetPosistion);
    }
    private void LateUpdate()
    {
        Camera.main.transform.position = transform.position + correctOffset;
    }
}