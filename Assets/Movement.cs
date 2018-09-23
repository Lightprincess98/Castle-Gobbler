using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody rb;
    public int jumpForce;
    public long speed;
    RaycastHit hit;
    float jumpDistance = 1.5f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        Vector3 down = transform.TransformDirection(Vector3.down);
        transform.Rotate(0, y, 0);
        transform.Translate(0, 0, z);

        bool canJump = true;

        Debug.DrawRay(transform.position, down * jumpDistance, Color.black);

        if (Physics.Raycast(transform.position, down, out hit, jumpDistance))
        {
            print("hit distance " + hit.distance);
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

        if (other.tag == "Tiny")
        {
            transform.localScale += new Vector3(0.15f, 0.15f, 0.15f);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            print("hit distance " + hit.distance);

        }

        if (other.tag == "Small")
        {
            transform.localScale += new Vector3(0.25f, 0.25f, 0.25f);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            print("hit distance " + hit.distance);

        }

        if (other.tag == "Normal")
        {
            transform.localScale += new Vector3(0.35f, 0.35f, 0.35f);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            print("hit distance " + hit.distance);

        }

        if (other.tag == "Big")
        {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            print("hit distance " + hit.distance);

        }
        if (other.tag == "House")
        {
            transform.localScale += new Vector3(0.75f, 0.75f, 0.75f);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            print("hit distance " + hit.distance);

        }

        if (other.tag == "Giant")
        {
            transform.localScale += new Vector3(1, 1, 1);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            print("hit distance " + hit.distance);

        }
        if (other.tag == "Castle")
        {
            transform.localScale += new Vector3(1.5f, 1.5f, 1.5f);
            Destroy(other.gameObject);
            jumpDistance += jumpDistance * 3;
            Physics.Raycast(transform.position, down, out hit, jumpDistance);
            print("hit distance " + hit.distance);

        }
    }
}
