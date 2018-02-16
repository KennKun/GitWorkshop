namespace GitWorkshop
{
    using UnityEngine;

    // New Comment
    // merge conflict
    public class LightSwitch : MonoBehaviour
    {
        public GameObject lightswitchObj;
        // Update is called once per frame
        void Update()
        {
            if (this.lightswitchObj != null)
            {
                if (Input.GetKeyUp(KeyCode.Space))
                    this.lightswitchObj.SetActive(!this.lightswitchObj.activeSelf);
            }
        }
    }

}