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

namespace Aliyun.Acs.eds_user.Model.V20210308
{
	public class FilterUsersResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<FilterUsers_Data> users;

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

		[JsonProperty(PropertyName = "NextToken")]
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

		[JsonProperty(PropertyName = "Users")]
		public List<FilterUsers_Data> Users
		{
			get
			{
				return users;
			}
			set	
			{
				users = value;
			}
		}

		public class FilterUsers_Data
		{

			private long? id;

			private string endUserId;

			private string email;

			private string phone;

			private long? status;

			private long? desktopCount;

			private long? desktopGroupCount;

			private string ownerType;

			private string remark;

			private bool? isTenantManager;

			private bool? enableAdminAccess;

			private string realNickName;

			private string autoLockTime;

			private int? passwordExpireDays;

			private int? passwordExpireRestDays;

			private List<FilterUsers_UserSetPropertiesModelsItem> userSetPropertiesModels;

			private List<FilterUsers_OrgListItem> orgList;

			private List<FilterUsers_IdpInfo> supportLoginIdps;

			private FilterUsers_ExternalInfo externalInfo;

			[JsonProperty(PropertyName = "Id")]
			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			[JsonProperty(PropertyName = "EndUserId")]
			public string EndUserId
			{
				get
				{
					return endUserId;
				}
				set	
				{
					endUserId = value;
				}
			}

			[JsonProperty(PropertyName = "Email")]
			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			[JsonProperty(PropertyName = "Phone")]
			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public long? Status
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

			[JsonProperty(PropertyName = "DesktopCount")]
			public long? DesktopCount
			{
				get
				{
					return desktopCount;
				}
				set	
				{
					desktopCount = value;
				}
			}

			[JsonProperty(PropertyName = "DesktopGroupCount")]
			public long? DesktopGroupCount
			{
				get
				{
					return desktopGroupCount;
				}
				set	
				{
					desktopGroupCount = value;
				}
			}

			[JsonProperty(PropertyName = "OwnerType")]
			public string OwnerType
			{
				get
				{
					return ownerType;
				}
				set	
				{
					ownerType = value;
				}
			}

			[JsonProperty(PropertyName = "Remark")]
			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			[JsonProperty(PropertyName = "IsTenantManager")]
			public bool? IsTenantManager
			{
				get
				{
					return isTenantManager;
				}
				set	
				{
					isTenantManager = value;
				}
			}

			[JsonProperty(PropertyName = "EnableAdminAccess")]
			public bool? EnableAdminAccess
			{
				get
				{
					return enableAdminAccess;
				}
				set	
				{
					enableAdminAccess = value;
				}
			}

			[JsonProperty(PropertyName = "RealNickName")]
			public string RealNickName
			{
				get
				{
					return realNickName;
				}
				set	
				{
					realNickName = value;
				}
			}

			[JsonProperty(PropertyName = "AutoLockTime")]
			public string AutoLockTime
			{
				get
				{
					return autoLockTime;
				}
				set	
				{
					autoLockTime = value;
				}
			}

			[JsonProperty(PropertyName = "PasswordExpireDays")]
			public int? PasswordExpireDays
			{
				get
				{
					return passwordExpireDays;
				}
				set	
				{
					passwordExpireDays = value;
				}
			}

			[JsonProperty(PropertyName = "PasswordExpireRestDays")]
			public int? PasswordExpireRestDays
			{
				get
				{
					return passwordExpireRestDays;
				}
				set	
				{
					passwordExpireRestDays = value;
				}
			}

			[JsonProperty(PropertyName = "UserSetPropertiesModels")]
			public List<FilterUsers_UserSetPropertiesModelsItem> UserSetPropertiesModels
			{
				get
				{
					return userSetPropertiesModels;
				}
				set	
				{
					userSetPropertiesModels = value;
				}
			}

			[JsonProperty(PropertyName = "OrgList")]
			public List<FilterUsers_OrgListItem> OrgList
			{
				get
				{
					return orgList;
				}
				set	
				{
					orgList = value;
				}
			}

			[JsonProperty(PropertyName = "SupportLoginIdps")]
			public List<FilterUsers_IdpInfo> SupportLoginIdps
			{
				get
				{
					return supportLoginIdps;
				}
				set	
				{
					supportLoginIdps = value;
				}
			}

			[JsonProperty(PropertyName = "ExternalInfo")]
			public FilterUsers_ExternalInfo ExternalInfo
			{
				get
				{
					return externalInfo;
				}
				set	
				{
					externalInfo = value;
				}
			}

			public class FilterUsers_UserSetPropertiesModelsItem
			{

				private long? userId;

				private string userName;

				private long? propertyId;

				private string propertyKey;

				private int? propertyType;

				private List<FilterUsers_PropertyValuesItem> propertyValues;

				[JsonProperty(PropertyName = "UserId")]
				public long? UserId
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

				[JsonProperty(PropertyName = "UserName")]
				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				[JsonProperty(PropertyName = "PropertyId")]
				public long? PropertyId
				{
					get
					{
						return propertyId;
					}
					set	
					{
						propertyId = value;
					}
				}

				[JsonProperty(PropertyName = "PropertyKey")]
				public string PropertyKey
				{
					get
					{
						return propertyKey;
					}
					set	
					{
						propertyKey = value;
					}
				}

				[JsonProperty(PropertyName = "PropertyType")]
				public int? PropertyType
				{
					get
					{
						return propertyType;
					}
					set	
					{
						propertyType = value;
					}
				}

				[JsonProperty(PropertyName = "PropertyValues")]
				public List<FilterUsers_PropertyValuesItem> PropertyValues
				{
					get
					{
						return propertyValues;
					}
					set	
					{
						propertyValues = value;
					}
				}

				public class FilterUsers_PropertyValuesItem
				{

					private long? propertyValueId;

					private string propertyValue;

					[JsonProperty(PropertyName = "PropertyValueId")]
					public long? PropertyValueId
					{
						get
						{
							return propertyValueId;
						}
						set	
						{
							propertyValueId = value;
						}
					}

					[JsonProperty(PropertyName = "PropertyValue")]
					public string PropertyValue
					{
						get
						{
							return propertyValue;
						}
						set	
						{
							propertyValue = value;
						}
					}
				}
			}

			public class FilterUsers_OrgListItem
			{

				private string orgId;

				private string orgName;

				private string orgNamePath;

				[JsonProperty(PropertyName = "OrgId")]
				public string OrgId
				{
					get
					{
						return orgId;
					}
					set	
					{
						orgId = value;
					}
				}

				[JsonProperty(PropertyName = "OrgName")]
				public string OrgName
				{
					get
					{
						return orgName;
					}
					set	
					{
						orgName = value;
					}
				}

				[JsonProperty(PropertyName = "OrgNamePath")]
				public string OrgNamePath
				{
					get
					{
						return orgNamePath;
					}
					set	
					{
						orgNamePath = value;
					}
				}
			}

			public class FilterUsers_IdpInfo
			{

				private string idpId;

				private string idpName;

				[JsonProperty(PropertyName = "IdpId")]
				public string IdpId
				{
					get
					{
						return idpId;
					}
					set	
					{
						idpId = value;
					}
				}

				[JsonProperty(PropertyName = "IdpName")]
				public string IdpName
				{
					get
					{
						return idpName;
					}
					set	
					{
						idpName = value;
					}
				}
			}

			public class FilterUsers_ExternalInfo
			{

				private string externalName;

				private string jobNumber;

				[JsonProperty(PropertyName = "ExternalName")]
				public string ExternalName
				{
					get
					{
						return externalName;
					}
					set	
					{
						externalName = value;
					}
				}

				[JsonProperty(PropertyName = "JobNumber")]
				public string JobNumber
				{
					get
					{
						return jobNumber;
					}
					set	
					{
						jobNumber = value;
					}
				}
			}
		}
	}
}
