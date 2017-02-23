﻿#if UNITY_EDITOR
using UnityEngine;
using Button = UnityEditor.Experimental.EditorVR.UI.Button;

namespace UnityEditor.Experimental.EditorVR.Workspaces
{
	sealed class InspectorArrayHeaderItem : InspectorPropertyItem
	{
		const float kExpandArrowRotateSpeed = 0.4f;
		static readonly Quaternion kExpandedRotation = Quaternion.AngleAxis(90f, Vector3.forward);
		static readonly Quaternion kNormalRotation = Quaternion.identity;

		[SerializeField]
		Button m_ExpandArrow;

		public override void UpdateSelf(float width, int depth, bool expanded)
		{
			base.UpdateSelf(width, depth, expanded);

			// Rotate arrow for expand state
			m_ExpandArrow.transform.localRotation = Quaternion.Lerp(m_ExpandArrow.transform.localRotation,
				expanded ? kExpandedRotation : kNormalRotation,
				kExpandArrowRotateSpeed);
		}
	}
}
#endif
