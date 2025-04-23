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
	public class DescribeUsersResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeUsers_Data> users;

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
		public List<DescribeUsers_Data> Users
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

		public class DescribeUsers_Data
		{

			private long? id;

			private string endUserId;

			private string email;

			private string phone;

			private long? status;

			private string ownerType;

			private string remark;

			private string orgId;

			private string wyId;

			private bool? isTenantManager;

			private string avatar;

			private string address;

			private string nickName;

			private string realNickName;

			private string jobNumber;

			private string externalName;

			private List<DescribeUsers_Group> groups;

			private List<DescribeUsers_Org> orgs;

			private List<DescribeUsers_Property> properties;

			private DescribeUsers_Extras extras;

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

			[JsonProperty(PropertyName = "WyId")]
			public string WyId
			{
				get
				{
					return wyId;
				}
				set	
				{
					wyId = value;
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

			[JsonProperty(PropertyName = "Avatar")]
			public string Avatar
			{
				get
				{
					return avatar;
				}
				set	
				{
					avatar = value;
				}
			}

			[JsonProperty(PropertyName = "Address")]
			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			[JsonProperty(PropertyName = "NickName")]
			public string NickName
			{
				get
				{
					return nickName;
				}
				set	
				{
					nickName = value;
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

			[JsonProperty(PropertyName = "Groups")]
			public List<DescribeUsers_Group> Groups
			{
				get
				{
					return groups;
				}
				set	
				{
					groups = value;
				}
			}

			[JsonProperty(PropertyName = "Orgs")]
			public List<DescribeUsers_Org> Orgs
			{
				get
				{
					return orgs;
				}
				set	
				{
					orgs = value;
				}
			}

			[JsonProperty(PropertyName = "Properties")]
			public List<DescribeUsers_Property> Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}

			[JsonProperty(PropertyName = "Extras")]
			public DescribeUsers_Extras Extras
			{
				get
				{
					return extras;
				}
				set	
				{
					extras = value;
				}
			}

			public class DescribeUsers_Group
			{

				private string groupId;

				private string groupName;

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
			}

			public class DescribeUsers_Org
			{

				private string orgId;

				private string orgName;

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
			}

			public class DescribeUsers_Property
			{

				private string key;

				private string _value;

				[JsonProperty(PropertyName = "Key")]
				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeUsers_Extras
			{

				private string assignedResourceCount;

				[JsonProperty(PropertyName = "AssignedResourceCount")]
				public string AssignedResourceCount
				{
					get
					{
						return assignedResourceCount;
					}
					set	
					{
						assignedResourceCount = value;
					}
				}
			}
		}
	}
}
