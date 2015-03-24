﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuberLib
{
	public class SlicingOptions
	{
		public string OverrideMtl { get; set; }
		public bool GenerateEbo { get; set; }
		public bool GenerateObj { get; set; }
		public bool AttemptResume { get; set; }
	}
}