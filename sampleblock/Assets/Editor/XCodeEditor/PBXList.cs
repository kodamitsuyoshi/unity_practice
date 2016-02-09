using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Lobi.XCodeEditor
{
	public class PBXList : ArrayList
	{
		public bool internalNewlines;
		public PBXList()
		{
			internalNewlines=true;
		}
		
		public PBXList( object firstValue )
		{
			this.Add( firstValue );
			internalNewlines=true;
		}
	}
}
