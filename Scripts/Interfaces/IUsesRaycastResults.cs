﻿#if UNITY_EDITOR
using System;
using UnityEngine;

namespace UnityEditor.Experimental.EditorVR
{
	/// <summary>
	/// Gives decorated class access to hover/intersection detection
	/// </summary>
	public interface IUsesRaycastResults
	{
		/// <summary>
		/// Delegate used to test hover/intersection
		/// Transform = object in test
		/// Returns the first GameObject being hovered over, or intersected with
		/// </summary>
		Func<Transform, GameObject> getFirstGameObject { set; }
	}
}
#endif
