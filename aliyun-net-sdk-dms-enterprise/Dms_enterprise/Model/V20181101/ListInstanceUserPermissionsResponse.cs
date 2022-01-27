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
	public class ListInstanceUserPermissionsResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListInstanceUserPermissions_UserPermission> userPermissions;

		[JsonProperty(PropertyName = "TotalCount")]
		public long? TotalCount
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

		[JsonProperty(PropertyName = "UserPermissions")]
		public List<ListInstanceUserPermissions_UserPermission> UserPermissions
		{
			get
			{
				return userPermissions;
			}
			set	
			{
				userPermissions = value;
			}
		}

		public class ListInstanceUserPermissions_UserPermission
		{

			private string userId;

			private string userNickName;

			private string instanceId;

			private List<ListInstanceUserPermissions_PermDetail> permDetails;

			[JsonProperty(PropertyName = "UserId")]
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

			[JsonProperty(PropertyName = "UserNickName")]
			public string UserNickName
			{
				get
				{
					return userNickName;
				}
				set	
				{
					userNickName = value;
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

			[JsonProperty(PropertyName = "PermDetails")]
			public List<ListInstanceUserPermissions_PermDetail> PermDetails
			{
				get
				{
					return permDetails;
				}
				set	
				{
					permDetails = value;
				}
			}

			public class ListInstanceUserPermissions_PermDetail
			{

				private string originFrom;

				private string permType;

				private string expireDate;

				private string createDate;

				private string userAccessId;

				private string extraData;

				[JsonProperty(PropertyName = "OriginFrom")]
				public string OriginFrom
				{
					get
					{
						return originFrom;
					}
					set	
					{
						originFrom = value;
					}
				}

				[JsonProperty(PropertyName = "PermType")]
				public string PermType
				{
					get
					{
						return permType;
					}
					set	
					{
						permType = value;
					}
				}

				[JsonProperty(PropertyName = "ExpireDate")]
				public string ExpireDate
				{
					get
					{
						return expireDate;
					}
					set	
					{
						expireDate = value;
					}
				}

				[JsonProperty(PropertyName = "CreateDate")]
				public string CreateDate
				{
					get
					{
						return createDate;
					}
					set	
					{
						createDate = value;
					}
				}

				[JsonProperty(PropertyName = "UserAccessId")]
				public string UserAccessId
				{
					get
					{
						return userAccessId;
					}
					set	
					{
						userAccessId = value;
					}
				}

				[JsonProperty(PropertyName = "ExtraData")]
				public string ExtraData
				{
					get
					{
						return extraData;
					}
					set	
					{
						extraData = value;
					}
				}
			}
		}
	}
}
