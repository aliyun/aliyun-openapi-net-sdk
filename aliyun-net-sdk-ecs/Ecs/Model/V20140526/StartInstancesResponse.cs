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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class StartInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<StartInstances_InstanceResponse> instanceResponses;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "InstanceResponses")]
		public List<StartInstances_InstanceResponse> InstanceResponses
		{
			get
			{
				return instanceResponses;
			}
			set	
			{
				instanceResponses = value;
			}
		}

		public class StartInstances_InstanceResponse
		{

			private string code;

			private string message;

			private string instanceId;

			private string currentStatus;

			private string previousStatus;

			[JsonProperty(PropertyName = "Code")]
			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			[JsonProperty(PropertyName = "Message")]
			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "CurrentStatus")]
			public string CurrentStatus
			{
				get
				{
					return currentStatus;
				}
				set	
				{
					currentStatus = value;
				}
			}

			[JsonProperty(PropertyName = "PreviousStatus")]
			public string PreviousStatus
			{
				get
				{
					return previousStatus;
				}
				set	
				{
					previousStatus = value;
				}
			}
		}
	}
}
