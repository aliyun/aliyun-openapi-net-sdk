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

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class ListStackOperationRisksResponse : AcsResponse
	{

		private string requestId;

		private List<ListStackOperationRisks_Resource> riskResources;

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

		public List<ListStackOperationRisks_Resource> RiskResources
		{
			get
			{
				return riskResources;
			}
			set	
			{
				riskResources = value;
			}
		}

		public class ListStackOperationRisks_Resource
		{

			private string logicalResourceId;

			private string physicalResourceId;

			private string resourceType;

			private string reason;

			private string riskType;

			private string code;

			private string message;

			private string requestId;

			public string LogicalResourceId
			{
				get
				{
					return logicalResourceId;
				}
				set	
				{
					logicalResourceId = value;
				}
			}

			public string PhysicalResourceId
			{
				get
				{
					return physicalResourceId;
				}
				set	
				{
					physicalResourceId = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

			public string RiskType
			{
				get
				{
					return riskType;
				}
				set	
				{
					riskType = value;
				}
			}

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
		}
	}
}
