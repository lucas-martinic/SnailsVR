using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeScript : MonoBehaviour
{
    public GameObject laserPrefab;
    public bool rightEye;
    private bool shooting;
    private AudioSource aSource;
    public AudioClip clip;
    public float cooldown;
    private float counter;

    // Update is called once per frame

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if((OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) > 0.8) && rightEye && !shooting)
        {
            shooting = true;
            GameObject obj = Instantiate(laserPrefab, transform.position, Quaternion.identity);
            obj.transform.forward = -transform.right;
            Destroy(obj, 3);
            aSource.PlayOneShot(clip);

        }
        else if ((OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch) > 0.8) && !rightEye && !shooting){
            shooting = true;
            GameObject obj = Instantiate(laserPrefab, transform.position, Quaternion.identity);
            obj.transform.forward = -transform.right;
            Destroy(obj, 3);
            aSource.PlayOneShot(clip);
        }

        counter += Time.deltaTime;
        if(counter >= cooldown)
        {
            counter = 0;
            shooting = false;
        }
    }
}
