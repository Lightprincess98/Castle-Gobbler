using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody rb;
    public int jumpForce;
    public long speed;
    RaycastHit hit;
    float jumpDistance = 1.5f;
    public bool inputDisabled;
    public AudioSource femaleScream;
    public AudioSource maleScream;
    private win winscript;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        winscript = GetComponent<win>();
    }

    public void enableInput()
    {
        inputDisabled = true;
    }
	
	// Update is called once per frame
	void Update () {

        if(transform.localScale.x >= 4)
        {
            speed = 10;
        }

        if (inputDisabled)
        {
            var y = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
            transform.Rotate(0, y, 0);
            transform.Translate(0, 0, z * speed);
        }
        Vector3 down = transform.TransformDirection(Vector3.down);
        bool canJump = true;
        //Debug.DrawRay(transform.position, down * jumpDistance, Color.black);


        if (Physics.Raycast(transform.position, down, out hit, jumpDistance))
        {
            //print("hit distance " + hit.distance);
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 down = transform.TransformDirection(Vector3.down);
        Random rnd;

        if(other.GetComponent<AudioSource>() != null)
        {
            other.GetComponent<AudioSource>().Play();
        }

        if (other.tag == "Tiny")
        {
            transform.localScale += new Vector3(0.15f, 0.15f, 0.15f);
            other.gameObject.SetActive(false);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
        }

        if (other.tag == "Small")
        {
            transform.localScale += new Vector3(0.25f, 0.25f, 0.25f);
            other.gameObject.SetActive(false);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
        }

        if (other.tag == "Normal")
        {
            transform.localScale += new Vector3(0.35f, 0.35f, 0.35f);
            other.gameObject.SetActive(false);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
        }

        if (other.tag == "Villager")
        {
            transform.localScale += new Vector3(0.35f, 0.35f, 0.35f);
            other.gameObject.SetActive(false);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
            if (Random.Range(0, 2) == 1)
            {
                femaleScream.Play();
            }
            else
            {
                maleScream.Play();
            }
        }

        if (other.tag == "Big")
        {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            other.gameObject.SetActive(false);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
        }
        if (other.tag == "House")
        {
            transform.localScale += new Vector3(0.75f, 0.75f, 0.75f);
            other.gameObject.SetActive(false);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
            if (Random.Range(0, 2) == 1)
            {
                femaleScream.Play();
            }
            else
            {
                maleScream.Play();
            }
        }

        if (other.tag == "Giant")
        {
            transform.localScale += new Vector3(1, 1, 1);
            other.gameObject.SetActive(false);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
            if (Random.Range(0, 2) == 1)
            {
                femaleScream.Play();
            }
            else
            {
                maleScream.Play();
            }
        }
        if (other.tag == "Castle")
        {
            transform.localScale += new Vector3(1.5f, 1.5f, 1.5f);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            //print("hit distance " + hit.distance);
            gameObject.GetComponent<AudioSource>().Play();
            if (Random.Range(0, 2) == 1)
            {
                femaleScream.Play();
            }
            else
            {
                maleScream.Play();
            }
        }
    }
}
