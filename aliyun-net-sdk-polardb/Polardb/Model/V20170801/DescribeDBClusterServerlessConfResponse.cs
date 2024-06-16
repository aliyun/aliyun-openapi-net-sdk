/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterServerlessConfResponse : AcsResponse
	{

		private string requestId;

		private string scaleMin;

		private string scaleMax;

		private string scaleRoNumMin;

		private string scaleRoNumMax;

		private string allowShutDown;

		private string secondsUntilAutoPause;

		private string dBClusterId;

		private string scaleApRoNumMin;

		private string scaleApRoNumMax;

		private string switchs;

		private string dBMaxscaleId;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string ScaleMin
		{
			get
			{
				return scaleMin;
			}
			set	
			{
				scaleMin = value;
			}
		}

		public string ScaleMax
		{
			get
			{
				return scaleMax;
			}
			set	
			{
				scaleMax = value;
			}
		}

		public string ScaleRoNumMin
		{
			get
			{
				return scaleRoNumMin;
			}
			set	
			{
				scaleRoNumMin = value;
			}
		}

		public string ScaleRoNumMax
		{
			get
			{
				return scaleRoNumMax;
			}
			set	
			{
				scaleRoNumMax = value;
			}
		}

		public string AllowShutDown
		{
			get
			{
				return allowShutDown;
			}
			set	
			{
				allowShutDown = value;
			}
		}

		public string SecondsUntilAutoPause
		{
			get
			{
				return secondsUntilAutoPause;
			}
			set	
			{
				secondsUntilAutoPause = value;
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public string ScaleApRoNumMin
		{
			get
			{
				return scaleApRoNumMin;
			}
			set	
			{
				scaleApRoNumMin = value;
			}
		}

		public string ScaleApRoNumMax
		{
			get
			{
				return scaleApRoNumMax;
			}
			set	
			{
				scaleApRoNumMax = value;
			}
		}

		public string Switchs
		{
			get
			{
				return switchs;
			}
			set	
			{
				switchs = value;
			}
		}

		public string DBMaxscaleId
		{
			get
			{
				return dBMaxscaleId;
			}
			set	
			{
				dBMaxscaleId = value;
			}
		}
	}
}
