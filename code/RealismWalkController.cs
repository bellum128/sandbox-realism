using Sandbox;

namespace SandboxRealism
{
	internal class RealismWalkController : WalkController
	{
		public RealismWalkController()
		{
			this.SprintSpeed = 180.0f;
			this.WalkSpeed = 122.0f;
			this.DefaultSpeed = 64.0f;
			this.BodyGirth = 24.0f;
		}
	}
}
