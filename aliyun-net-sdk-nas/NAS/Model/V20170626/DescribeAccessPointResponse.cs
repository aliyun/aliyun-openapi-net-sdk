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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeAccessPointResponse : AcsResponse
	{

		private string requestId;

		private DescribeAccessPoint_AccessPoint accessPoint;

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

		public DescribeAccessPoint_AccessPoint AccessPoint
		{
			get
			{
				return accessPoint;
			}
			set	
			{
				accessPoint = value;
			}
		}

		public class DescribeAccessPoint_AccessPoint
		{

			private string aRN;

			private string accessGroup;

			private string accessPointId;

			private string accessPointName;

			private string createTime;

			private string domainName;

			private bool? enabledRam;

			private string fileSystemId;

			private string modifyTime;

			private string rootPath;

			private string rootPathStatus;

			private string status;

			private string vSwitchId;

			private string vpcId;

			private string regionId;

			private List<DescribeAccessPoint_Tag> tags;

			private DescribeAccessPoint_RootPathPermission rootPathPermission;

			private DescribeAccessPoint_PosixUser posixUser;

			public string ARN
			{
				get
				{
					return aRN;
				}
				set	
				{
					aRN = value;
				}
			}

			public string AccessGroup
			{
				get
				{
					return accessGroup;
				}
				set	
				{
					accessGroup = value;
				}
			}

			public string AccessPointId
			{
				get
				{
					return accessPointId;
				}
				set	
				{
					accessPointId = value;
				}
			}

			public string AccessPointName
			{
				get
				{
					return accessPointName;
				}
				set	
				{
					accessPointName = value;
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

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public bool? EnabledRam
			{
				get
				{
					return enabledRam;
				}
				set	
				{
					enabledRam = value;
				}
			}

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string RootPath
			{
				get
				{
					return rootPath;
				}
				set	
				{
					rootPath = value;
				}
			}

			public string RootPathStatus
			{
				get
				{
					return rootPathStatus;
				}
				set	
				{
					rootPathStatus = value;
				}
			}

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

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public List<DescribeAccessPoint_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public DescribeAccessPoint_RootPathPermission RootPathPermission
			{
				get
				{
					return rootPathPermission;
				}
				set	
				{
					rootPathPermission = value;
				}
			}

			public DescribeAccessPoint_PosixUser PosixUser
			{
				get
				{
					return posixUser;
				}
				set	
				{
					posixUser = value;
				}
			}

			public class DescribeAccessPoint_Tag
			{

				private string key;

				private string _value;

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

			public class DescribeAccessPoint_RootPathPermission
			{

				private int? ownerGroupId;

				private int? ownerUserId;

				private string permission;

				public int? OwnerGroupId
				{
					get
					{
						return ownerGroupId;
					}
					set	
					{
						ownerGroupId = value;
					}
				}

				public int? OwnerUserId
				{
					get
					{
						return ownerUserId;
					}
					set	
					{
						ownerUserId = value;
					}
				}

				public string Permission
				{
					get
					{
						return permission;
					}
					set	
					{
						permission = value;
					}
				}
			}

			public class DescribeAccessPoint_PosixUser
			{

				private int? posixGroupId;

				private int? posixUserId;

				private List<string> posixSecondaryGroupIds;

				public int? PosixGroupId
				{
					get
					{
						return posixGroupId;
					}
					set	
					{
						posixGroupId = value;
					}
				}

				public int? PosixUserId
				{
					get
					{
						return posixUserId;
					}
					set	
					{
						posixUserId = value;
					}
				}

				public List<string> PosixSecondaryGroupIds
				{
					get
					{
						return posixSecondaryGroupIds;
					}
					set	
					{
						posixSecondaryGroupIds = value;
					}
				}
			}
		}
	}
}
