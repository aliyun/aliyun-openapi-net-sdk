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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveMessageGroupResponse : AcsResponse
	{

		private string requestId;

		private string groupId;

		private string creatorId;

		private long? createtime;

		private string groupName;

		private string groupInfo;

		private bool? delete;

		private long? totalTimes;

		private long? onlineUserCounts;

		private string msgAmount;

		private long? deletatime;

		private string deletor;

		private List<string> adminList;

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

		[JsonProperty(PropertyName = "GroupId")]
		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		[JsonProperty(PropertyName = "CreatorId")]
		public string CreatorId
		{
			get
			{
				return creatorId;
			}
			set	
			{
				creatorId = value;
			}
		}

		[JsonProperty(PropertyName = "Createtime")]
		public long? Createtime
		{
			get
			{
				return createtime;
			}
			set	
			{
				createtime = value;
			}
		}

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

		[JsonProperty(PropertyName = "GroupInfo")]
		public string GroupInfo
		{
			get
			{
				return groupInfo;
			}
			set	
			{
				groupInfo = value;
			}
		}

		[JsonProperty(PropertyName = "Delete")]
		public bool? Delete
		{
			get
			{
				return delete;
			}
			set	
			{
				delete = value;
			}
		}

		[JsonProperty(PropertyName = "TotalTimes")]
		public long? TotalTimes
		{
			get
			{
				return totalTimes;
			}
			set	
			{
				totalTimes = value;
			}
		}

		[JsonProperty(PropertyName = "OnlineUserCounts")]
		public long? OnlineUserCounts
		{
			get
			{
				return onlineUserCounts;
			}
			set	
			{
				onlineUserCounts = value;
			}
		}

		[JsonProperty(PropertyName = "MsgAmount")]
		public string MsgAmount
		{
			get
			{
				return msgAmount;
			}
			set	
			{
				msgAmount = value;
			}
		}

		[JsonProperty(PropertyName = "Deletatime")]
		public long? Deletatime
		{
			get
			{
				return deletatime;
			}
			set	
			{
				deletatime = value;
			}
		}

		[JsonProperty(PropertyName = "Deletor")]
		public string Deletor
		{
			get
			{
				return deletor;
			}
			set	
			{
				deletor = value;
			}
		}

		[JsonProperty(PropertyName = "AdminList")]
		public List<string> AdminList
		{
			get
			{
				return adminList;
			}
			set	
			{
				adminList = value;
			}
		}
	}
}
