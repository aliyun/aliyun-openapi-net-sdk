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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
	public class DescribeSpecialEcsResponse : AcsResponse
	{

		private string requestId;

		private bool? ecsFound;

		private string module;

		private DescribeSpecialEcs_EcsInfo ecsInfo;

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

		public bool? EcsFound
		{
			get
			{
				return ecsFound;
			}
			set	
			{
				ecsFound = value;
			}
		}

		public string Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public DescribeSpecialEcs_EcsInfo EcsInfo
		{
			get
			{
				return ecsInfo;
			}
			set	
			{
				ecsInfo = value;
			}
		}

		public class DescribeSpecialEcs_EcsInfo
		{

			private string instanceId;

			private string instanceName;

			private string iP;

			private string region;

			private string itemSign;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string IP
			{
				get
				{
					return iP;
				}
				set	
				{
					iP = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string ItemSign
			{
				get
				{
					return itemSign;
				}
				set	
				{
					itemSign = value;
				}
			}
		}
	}
}
