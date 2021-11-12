using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    //public GameObject[] houses;
    //private BoxCollider backtoEnd;
    //private Vector3 screenBounds;
   
    //// Start is called before the first frame update
    //void Start()
    //{
    //    backtoEnd = gameObject.GetComponent<BoxCollider>();
    //    screenBounds = new Vector3(backtoEnd.size.x, backtoEnd.size.y,backtoEnd.size.z);

    //    foreach (GameObject obj in houses)
    //    {
    //        loadchildObjects(obj);
    //    }
    //}


    //void loadchildObjects(GameObject obj)
    //{
    //    //Debug.Log(obj.name);
    //    float objectWidht = obj.GetComponent<MeshRenderer>().bounds.size.z; //Houses z value

    //    //How many clone we need to
    //    int childsNeeded = 1; /*(int)Mathf.Ceil(screenBounds.z / objectWidht);*/
    //    GameObject clone = Instantiate(obj) as GameObject;

    //    // How many clone we need to full screen?
    //    for (int i = 0; i <= childsNeeded; i++)
    //    {
    //        GameObject c = Instantiate(clone) as GameObject;
    //        c.transform.SetParent(obj.transform);
    //        c.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, objectWidht * i);
    //        c.name = obj.name + i;
    //    }

    //    Destroy(clone);
    //    Destroy(obj.GetComponent<MeshRenderer>());
    //}

    //void RepositionChildObject(GameObject obj)
    //{
    //    Transform[] children = obj.GetComponentsInChildren<Transform>();
    //    if (children.Length > 1)
    //    {
    //        GameObject firstChild = children[1].gameObject;
    //        GameObject lastChild = children[children.Length - 1].gameObject;
    //        float halfObjectWidth = lastChild.GetComponent<MeshRenderer>().bounds.extents.z;
    //        if (transform.position.z + screenBounds.z > lastChild.transform.position.z + halfObjectWidth)
    //        {
    //            firstChild.transform.SetAsLastSibling();
    //            firstChild.transform.position = new Vector3(lastChild.transform.position.z,
    //                lastChild.transform.position.y, lastChild.transform.position.z + halfObjectWidth*2);
    //        }
    //        else if (transform.position.z -screenBounds.z<firstChild.transform.position.z - halfObjectWidth)
    //        {
    //            lastChild.transform.SetAsFirstSibling();
    //            lastChild.transform.position = new Vector3(firstChild.transform.position.x,
    //                firstChild.transform.position.y, firstChild.transform.position.z - halfObjectWidth * 2);
    //        }

    //    }
    //}

    //private void LateUpdate()
    //{
    //    foreach (GameObject obj in houses)
    //    {
    //        RepositionChildObject(obj);
    //    }
    //}
}
