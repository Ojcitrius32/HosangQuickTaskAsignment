using UnityEngine;


public class FollowPlayer : MonoBehaviour

{
    public GameObject Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0,8,-12);
    }
}
