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

namespace Aliyun.Acs.ResourceSharing.Model.V20200110
{
	public class ListSharedResourcesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<ListSharedResources_SharedResource> sharedResources;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public List<ListSharedResources_SharedResource> SharedResources
		{
			get
			{
				return sharedResources;
			}
			set	
			{
				sharedResources = value;
			}
		}

		public class ListSharedResources_SharedResource
		{

			private string updateTime;

			private string resourceType;

			private string createTime;

			private string resourceShareId;

			private string resourceId;

			private string resourceStatus;

			private string resourceStatusMessage;

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ResourceShareId
			{
				get
				{
					return resourceShareId;
				}
				set	
				{
					resourceShareId = value;
				}
			}

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			public string ResourceStatus
			{
				get
				{
					return resourceStatus;
				}
				set	
				{
					resourceStatus = value;
				}
			}

			public string ResourceStatusMessage
			{
				get
				{
					return resourceStatusMessage;
				}
				set	
				{
					resourceStatusMessage = value;
				}
			}
		}
	}
}
