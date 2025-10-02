using UnityEngine;

public class PlateRegister : MonoBehaviour
{
    public OVRPassthroughLayer passthrough;
    public MeshRenderer[] plates;

    void Start()
    {
        if (passthrough == null) passthrough = FindObjectOfType<OVRPassthroughLayer>();

        foreach (var plate in plates)
        {
            if (plate != null && passthrough != null)
                passthrough.AddSurfaceGeometry(plate.gameObject, false);
        }
    }
}
