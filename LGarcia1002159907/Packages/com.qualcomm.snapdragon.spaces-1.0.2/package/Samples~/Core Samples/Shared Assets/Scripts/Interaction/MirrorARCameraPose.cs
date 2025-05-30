/*
 * Copyright (c) 2022-2024 Qualcomm Technologies, Inc. and/or its subsidiaries.
 * All rights reserved.
 */

using UnityEngine;

namespace Qualcomm.Snapdragon.Spaces.Samples
{
    public class MirrorARCameraPose : MonoBehaviour
    {
        public bool TrackPosition = true;
        public bool TrackRotation = true;
        public Vector3 PositionOffset = new Vector3(0.0f, -0.5f, 0.0f);
        private Transform _arCameraTransform;

        private void Start()
        {
            _arCameraTransform = OriginLocationUtility.GetOriginCamera().transform;
        }

        private void Update()
        {
            if (TrackPosition)
            {
                transform.position = _arCameraTransform.position + PositionOffset;
            }

            if (TrackRotation)
            {
                transform.rotation = _arCameraTransform.rotation;
            }
        }
    }
}
