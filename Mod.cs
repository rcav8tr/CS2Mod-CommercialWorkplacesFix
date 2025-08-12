using Game;
using Game.Modding;
using Game.Simulation;
using Unity.Entities;

namespace CommercialWorkplacesFix
{
    /// <summary>
    /// The main entry point for this mod.
    /// </summary>
    public class Mod : IMod
    {
        /// <summary>
        /// One-time mod loading.
        /// </summary>
        public void OnLoad(UpdateSystem updateSystem)
        {
            // Replace the game's system with this mod's modified system.
            World.DefaultGameObjectInjectionWorld.GetOrCreateSystemManaged<CommercialAISystem>().Enabled = false;
			updateSystem.UpdateAfter<ModifiedCommercialAISystem, CommercialAISystem>(SystemUpdatePhase.GameSimulation);
        }

        /// <summary>
        /// One-time mod disposing.
        /// </summary>
        public void OnDispose()
        {
            // Nothing to do here, but implementation is required.
        }
    }
}
