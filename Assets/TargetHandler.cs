#region Licensed
// Copyright (c) HAVELSAN. All rights reserved.
// Created by Caner Gezgez
#endregion
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class TargetHandler : MonoBehaviour
    {
        #region Fields
        TrackerController trackerController = null;
        #endregion

        #region MonoBehaviour Methods
        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        private void OnDestroy()
        {
            trackerController.TrackableEventHandler.OnTargetFound.RemoveListener(OnTargetFound);
            trackerController.TrackableEventHandler.OnTargetFound.RemoveListener(OnTargetLost);
        }
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods
        void Init()
        {
            if (trackerController == null)
            {

                trackerController = GameObject.FindObjectOfType<TrackerController>();
                trackerController.TrackableEventHandler.OnTargetFound.AddListener(OnTargetFound);
                trackerController.TrackableEventHandler.OnTargetFound.AddListener(OnTargetLost);
                trackerController.GetPositionAndRotationForTarget(this.gameObject);
            }
        }

        private void OnTargetFound()
        {
            if (trackerController == null)
            {
                trackerController = GameObject.FindObjectOfType<TrackerController>();
                trackerController.GetPositionAndRotationForTarget(this.gameObject);
                Debug.Log("TargetHandler::OnTargetFound");
            }
            else
            {
                trackerController.GetPositionAndRotationForTarget(this.gameObject);
                Debug.Log("TargetHandler::OnTargetFound");
            }

        }

        private void OnTargetLost()
        {
            if (trackerController == null)
            {
                trackerController = GameObject.FindObjectOfType<TrackerController>();
                trackerController.GetLostPositionAndRotationForTarget(this.gameObject);
                Debug.Log("TargetHandler::OnTargetLost");
            }
            else
            {
                trackerController.GetLostPositionAndRotationForTarget(this.gameObject);
                Debug.Log("TargetHandler::OnTargetLost");
            }

        }
        #endregion
    }


