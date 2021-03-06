using System;
using Nomad.Utils;
namespace Nomad.Components
{
	public class GameModeDash
	{
		public static bool ValidateIngame()
		{
			return Binding.FCE_Dash_ValidateIngame();
		}
		public static void SetDebugMode(int debugIndex)
		{
			Binding.FCE_Dash_SetDebugMode(debugIndex);
		}
		public static GameModeDashNodeParams GetNodeParams(int nodeIndex)
		{
			return new GameModeDashNodeParams(nodeIndex);
		}
	}
}
