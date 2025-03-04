using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GamePlayDLL
{
    /// <summary>
    /// Manages the spawning of game objects.
    /// </summary>
    public class SpawningManager
    {
        /// <summary>
        /// Spawns a GameObject at a random position within the specified bounds.
        /// </summary>
        /// <param name="prefab">The prefab to instantiate.</param>
        /// <param name="minPosition">The minimum position for spawning.</param>
        /// <param name="maxPosition">The maximum position for spawning.</param>
        /// <returns>The instantiated GameObject.</returns>
        public GameObject Spawn(GameObject prefab, Vector3 minPosition, Vector3 maxPosition)
        {
            if (prefab == null)
            {
                Debug.LogError("Prefab cannot be null!");
                return null;
            }

            float x = UnityEngine.Random.Range(minPosition.x, maxPosition.x);
            float y = UnityEngine.Random.Range(minPosition.y, maxPosition.y);
            float z = UnityEngine.Random.Range(minPosition.z, maxPosition.z);

            Vector3 spawnPosition = new Vector3(x, y, z);

            GameObject spawnedObject = UnityEngine.Object.Instantiate(prefab, spawnPosition, Quaternion.identity);
            return spawnedObject;
        }
    }

}
