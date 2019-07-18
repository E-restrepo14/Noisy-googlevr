using UnityEngine;
using System.Collections;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;
    public GameObject Waypoint;
    public GameObject TemporalWaypoint;

    public float fireRate;
    private float nextFire;


    public float height = 2;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	private bool moving = false;

    public void CallTeleport(GameObject temporalwaypoint)
    {
        TemporalWaypoint = temporalwaypoint;
        StartCoroutine(Teleporting());
    }

    public void CancelTeleport()
    {
        TemporalWaypoint = null;
        StopAllCoroutines();
    }

    public IEnumerator Teleporting()
    {
        yield return new WaitForSeconds(1.5f);

        if (Waypoint != null) Waypoint.SetActive(true);

        player.transform.position = new Vector3(TemporalWaypoint.transform.position.x,
            TemporalWaypoint.transform.position.y + height / 2,
            TemporalWaypoint.transform.position.z);
        Waypoint = TemporalWaypoint;

        if (Waypoint != null) Waypoint.SetActive(false);

    }

}

