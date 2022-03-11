//Written by: Sammy Ricketts
//Created: 2/20/22
//Edited by: N/A
//Last Edited: 2/20/22
//Description: rigidbody code
using UnityEngine;
public class RigidBodySleep : MonoBehaviour {
void Start () {
Rigidbody rb = GetComponent<Rigidbody>();
if (rb != null) rb.Sleep();
}
}

