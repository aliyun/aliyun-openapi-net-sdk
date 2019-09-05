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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class GetClusterDetailsResponse : AcsResponse
	{

		private string requestId;

		private GetClusterDetails_Details details;

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

		public GetClusterDetails_Details Details
		{
			get
			{
				return details;
			}
			set	
			{
				details = value;
			}
		}

		public class GetClusterDetails_Details
		{

			private string clusterId;

			private string regionId;

			private string zoneId;

			private string state;

			private string description;

			private string displayName;

			private string ownerId;

			private string _operator;

			private string storageType;

			private long? gmtCreate;

			private long? gmtModified;

			private string userOssInfo;

			private string userVpcId;

			private string userSGId;

			private string userVSwitchList;

			private bool? isMixDeploy;

			private string instanceInfos;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

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

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public string _Operator
			{
				get
				{
					return _operator;
				}
				set	
				{
					_operator = value;
				}
			}

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

			public long? GmtCreate
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

			public long? GmtModified
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

			public string UserOssInfo
			{
				get
				{
					return userOssInfo;
				}
				set	
				{
					userOssInfo = value;
				}
			}

			public string UserVpcId
			{
				get
				{
					return userVpcId;
				}
				set	
				{
					userVpcId = value;
				}
			}

			public string UserSGId
			{
				get
				{
					return userSGId;
				}
				set	
				{
					userSGId = value;
				}
			}

			public string UserVSwitchList
			{
				get
				{
					return userVSwitchList;
				}
				set	
				{
					userVSwitchList = value;
				}
			}

			public bool? IsMixDeploy
			{
				get
				{
					return isMixDeploy;
				}
				set	
				{
					isMixDeploy = value;
				}
			}

			public string InstanceInfos
			{
				get
				{
					return instanceInfos;
				}
				set	
				{
					instanceInfos = value;
				}
			}
		}
	}
}
