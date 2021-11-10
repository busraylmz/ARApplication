using UnityEngine;
using UnityEngine.Events;
using Vuforia;
public class TrackerController : MonoBehaviour
    {
        [SerializeField]
        GameObject targetObject;
       // [SerializeField]
       // GameObject calibrationObject;

        public DefaultTrackableEventHandler TrackableEventHandler { get; private set; }
        private void Start()
        {

            if (targetObject == null)
            {
                Debug.LogError($"TrackerController:: Null Component: targetObject");
            }
            else
            {
                TrackableLostTarget();
            }

           // if (calibrationObject != null)
          //  {
          //      calibrationObject.SetActive(true);
          //  }

            try
            {
                TrackableEventHandler = GetComponent<DefaultTrackableEventHandler>();
                TrackableEventHandler.OnTargetFound.AddListener(TrackableFoundTarget);
                TrackableEventHandler.OnTargetLost.AddListener(TrackableLostTarget);
            }
            catch (System.NullReferenceException)
            {
                Debug.LogError($"TrackerController:: Null Component");
            }
            catch (MissingComponentException)
            {
                Debug.LogError($"TrackerController:: Missing Component");
            }

        }
        private void TrackableFoundTarget()
        {

        Debug.Log("TrackableFoundTarget::TrackableFoundTarget");
        targetObject.transform.position = transform.position;
            targetObject.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 1);

          //  if (calibrationObject != null)
           //{
            //    calibrationObject.SetActive(false);
           // }
        }

        private void TrackableLostTarget()
        {
            targetObject.transform.position = Vector3.one * 9999;

           // if (calibrationObject != null)
          //  {
           //     calibrationObject.SetActive(true);
           // }
        }

        public void TESTTrackableFoundTarget()
        {
            targetObject.transform.position = transform.position;
            targetObject.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 1);
        }

        public void GetPositionAndRotationForTarget(GameObject gameObject)
        {
            if (gameObject.transform != null)
            {
                gameObject.transform.position = transform.position;
                gameObject.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 1);
            }
            else
            {
                Debug.LogError("TrackerController::GetPositionAndRotationForTarget: transform is null.");
            }

        }

        public void GetLostPositionAndRotationForTarget(GameObject gameObject)
        {
            if (gameObject != null)
            {
                gameObject.transform.position = Vector3.one * 9999;
            }
            else
            {
                Debug.LogError("TrackerController::GetPositionAndRotationForTarget: transform is null.");
            }

        }

    }


