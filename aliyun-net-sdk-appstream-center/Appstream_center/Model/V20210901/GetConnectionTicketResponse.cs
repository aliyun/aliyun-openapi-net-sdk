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
	public class GetConnectionTicketResponse : AcsResponse
	{

		private string requestId;

		private string taskStatus;

		private string taskId;

		private string bizRegionId;

		private string ticket;

		private string appInstanceGroupId;

		private string appInstanceId;

		private string osType;

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

		[JsonProperty(PropertyName = "TaskStatus")]
		public string TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
			}
		}

		[JsonProperty(PropertyName = "TaskId")]
		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		[JsonProperty(PropertyName = "BizRegionId")]
		public string BizRegionId
		{
			get
			{
				return bizRegionId;
			}
			set	
			{
				bizRegionId = value;
			}
		}

		[JsonProperty(PropertyName = "Ticket")]
		public string Ticket
		{
			get
			{
				return ticket;
			}
			set	
			{
				ticket = value;
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

		[JsonProperty(PropertyName = "OsType")]
		public string OsType
		{
			get
			{
				return osType;
			}
			set	
			{
				osType = value;
			}
		}
	}
}
