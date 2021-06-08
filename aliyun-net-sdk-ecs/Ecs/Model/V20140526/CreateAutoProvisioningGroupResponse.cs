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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class CreateAutoProvisioningGroupResponse : AcsResponse
	{

		private string autoProvisioningGroupId;

		private string requestId;

		private List<CreateAutoProvisioningGroup_LaunchResult> launchResults;

		public string AutoProvisioningGroupId
		{
			get
			{
				return autoProvisioningGroupId;
			}
			set	
			{
				autoProvisioningGroupId = value;
			}
		}

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

		public List<CreateAutoProvisioningGroup_LaunchResult> LaunchResults
		{
			get
			{
				return launchResults;
			}
			set	
			{
				launchResults = value;
			}
		}

		public class CreateAutoProvisioningGroup_LaunchResult
		{

			private string zoneId;

			private string errorMsg;

			private string instanceType;

			private string errorCode;

			private string spotStrategy;

			private List<string> instanceIds;

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public List<string> InstanceIds
			{
				get
				{
					return instanceIds;
				}
				set	
				{
					instanceIds = value;
				}
			}
		}
	}
}
