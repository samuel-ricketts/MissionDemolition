//Written by: Sammy Ricketts
//Created: 2/20/22
//Edited by: N/A
//Last Edited: 2/20/22
//Description: goal code
using UnityEngine;
using System.Collections;
public class Goal : MonoBehaviour {

static public bool goalMet = false;
void OnTriggerEnter( Collider other ) {


if ( other.gameObject.tag == "Projectile" ) {

Goal.goalMet = true;

Material mat = GetComponent<Renderer>().material;
Color c = mat.color;
c.a = 1 ;
mat.color = c;
}
}
}
