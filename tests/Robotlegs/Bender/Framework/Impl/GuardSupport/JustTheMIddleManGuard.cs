//------------------------------------------------------------------------------
//  Copyright (c) 2014-2016 the original author or authors. All Rights Reserved. 
// 
//  NOTICE: You are permitted to use, modify, and distribute this file 
//  in accordance with the terms of the license agreement accompanying it. 
//------------------------------------------------------------------------------

﻿using System;

namespace Robotlegs.Bender.Framework.Impl.GuardSupport
{
	public class BossGuard
	{
		protected bool _approve = false;

		public BossGuard(bool approve)
		{
			_approve = approve;
		}

		public bool Approve()
		{
			return _approve;
		}
	}
}

