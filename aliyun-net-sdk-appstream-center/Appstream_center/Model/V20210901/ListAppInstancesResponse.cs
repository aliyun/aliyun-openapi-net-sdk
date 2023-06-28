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

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
	public class ListAppInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<ListAppInstances_Data> appInstanceModels;

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

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		[JsonProperty(PropertyName = "AppInstanceModels")]
		public List<ListAppInstances_Data> AppInstanceModels
		{
			get
			{
				return appInstanceModels;
			}
			set	
			{
				appInstanceModels = value;
			}
		}

		public class ListAppInstances_Data
		{

			private string appInstanceId;

			private string appInstanceGroupId;

			private string status;

			private string mainEthPublicIp;

			private string gmtCreate;

			private string gmtModified;

			private string sessionStatus;

			[JsonProperty(PropertyName = "AppInstanceId")]
			public string AppInstanceId
			{
				get
				{
					return appInstanceId;
				}
				set	
				{
					appInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "AppInstanceGroupId")]
			public string AppInstanceGroupId
			{
				get
				{
					return appInstanceGroupId;
				}
				set	
				{
					appInstanceGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "MainEthPublicIp")]
			public string MainEthPublicIp
			{
				get
				{
					return mainEthPublicIp;
				}
				set	
				{
					mainEthPublicIp = value;
				}
			}

			[JsonProperty(PropertyName = "GmtCreate")]
			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			[JsonProperty(PropertyName = "GmtModified")]
			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			[JsonProperty(PropertyName = "SessionStatus")]
			public string SessionStatus
			{
				get
				{
					return sessionStatus;
				}
				set	
				{
					sessionStatus = value;
				}
			}
		}
	}
}
