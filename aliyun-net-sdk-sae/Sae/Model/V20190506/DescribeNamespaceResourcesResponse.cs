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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeNamespaceResourcesResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string errorCode;

		private string traceId;

		private bool? success;

		private DescribeNamespaceResources_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeNamespaceResources_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeNamespaceResources_Data
		{

			private string namespaceId;

			private string namespaceName;

			private string description;

			private string userId;

			private string belongRegion;

			private string tenantId;

			private string vpcId;

			private string vSwitchId;

			private string securityGroupId;

			private long? appCount;

			private string lastChangeOrderId;

			private string lastChangeOrderStatus;

			private bool? lastChangeOrderRunning;

			private string vpcName;

			private string vSwitchName;

			private bool? notificationExpired;

			public string NamespaceId
			{
				get
				{
					return namespaceId;
				}
				set	
				{
					namespaceId = value;
				}
			}

			public string NamespaceName
			{
				get
				{
					return namespaceName;
				}
				set	
				{
					namespaceName = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string BelongRegion
			{
				get
				{
					return belongRegion;
				}
				set	
				{
					belongRegion = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public long? AppCount
			{
				get
				{
					return appCount;
				}
				set	
				{
					appCount = value;
				}
			}

			public string LastChangeOrderId
			{
				get
				{
					return lastChangeOrderId;
				}
				set	
				{
					lastChangeOrderId = value;
				}
			}

			public string LastChangeOrderStatus
			{
				get
				{
					return lastChangeOrderStatus;
				}
				set	
				{
					lastChangeOrderStatus = value;
				}
			}

			public bool? LastChangeOrderRunning
			{
				get
				{
					return lastChangeOrderRunning;
				}
				set	
				{
					lastChangeOrderRunning = value;
				}
			}

			public string VpcName
			{
				get
				{
					return vpcName;
				}
				set	
				{
					vpcName = value;
				}
			}

			public string VSwitchName
			{
				get
				{
					return vSwitchName;
				}
				set	
				{
					vSwitchName = value;
				}
			}

			public bool? NotificationExpired
			{
				get
				{
					return notificationExpired;
				}
				set	
				{
					notificationExpired = value;
				}
			}
		}
	}
}
