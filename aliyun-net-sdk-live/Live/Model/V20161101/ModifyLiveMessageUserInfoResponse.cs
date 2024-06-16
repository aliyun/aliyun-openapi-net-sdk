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
	public class ModifyLiveMessageUserInfoResponse : AcsResponse
	{

		private string requestId;

		private List<ModifyLiveMessageUserInfo_FailGroups> failList;

		private List<ModifyLiveMessageUserInfo_SuccessGroups> successList;

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

		[JsonProperty(PropertyName = "FailList")]
		public List<ModifyLiveMessageUserInfo_FailGroups> FailList
		{
			get
			{
				return failList;
			}
			set	
			{
				failList = value;
			}
		}

		[JsonProperty(PropertyName = "SuccessList")]
		public List<ModifyLiveMessageUserInfo_SuccessGroups> SuccessList
		{
			get
			{
				return successList;
			}
			set	
			{
				successList = value;
			}
		}

		public class ModifyLiveMessageUserInfo_FailGroups
		{

			private int? code;

			private string groupId;

			private string reason;

			private bool? success;

			[JsonProperty(PropertyName = "Code")]
			public int? Code
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

			[JsonProperty(PropertyName = "Reason")]
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
		}

		public class ModifyLiveMessageUserInfo_SuccessGroups
		{

			private string groupId;

			private bool? success;

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
		}
	}
}
