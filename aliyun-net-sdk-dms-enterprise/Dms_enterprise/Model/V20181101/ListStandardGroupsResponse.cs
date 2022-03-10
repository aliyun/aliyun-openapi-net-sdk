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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListStandardGroupsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private List<ListStandardGroups_StandardGroupListItem> standardGroupList;

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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "StandardGroupList")]
		public List<ListStandardGroups_StandardGroupListItem> StandardGroupList
		{
			get
			{
				return standardGroupList;
			}
			set	
			{
				standardGroupList = value;
			}
		}

		public class ListStandardGroups_StandardGroupListItem
		{

			private string groupName;

			private string description;

			private string dbType;

			private long? lastMenderId;

			private string groupMode;

			[JsonProperty(PropertyName = "GroupName")]
			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "DbType")]
			public string DbType
			{
				get
				{
					return dbType;
				}
				set	
				{
					dbType = value;
				}
			}

			[JsonProperty(PropertyName = "LastMenderId")]
			public long? LastMenderId
			{
				get
				{
					return lastMenderId;
				}
				set	
				{
					lastMenderId = value;
				}
			}

			[JsonProperty(PropertyName = "GroupMode")]
			public string GroupMode
			{
				get
				{
					return groupMode;
				}
				set	
				{
					groupMode = value;
				}
			}
		}
	}
}
