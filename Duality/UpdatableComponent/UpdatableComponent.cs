using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq; $endif$

using Duality;
using Duality.Components;
using Duality.Components.Physics;
using Duality.Resources;
using Duality.Editor;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : Component, ICmpInitializable, ICmpUpdatable
	{
		public void OnUpdate()
		{
		
		}
		
		public void OnInit(Component.InitContext context)
		{

		}

		public void OnShutdown(Component.ShutdownContext context)
		{

		}
	}
}