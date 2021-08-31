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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class InsertDeployGroupResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private InsertDeployGroup_DeployGroupEntity deployGroupEntity;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public InsertDeployGroup_DeployGroupEntity DeployGroupEntity
		{
			get
			{
				return deployGroupEntity;
			}
			set	
			{
				deployGroupEntity = value;
			}
		}

		public class InsertDeployGroup_DeployGroupEntity
		{

			private string id;

			private string groupName;

			private int? groupType;

			private string appId;

			private string clusterId;

			private string packageVersionId;

			private string appVersionId;

			private long? createTime;

			private long? updateTime;

			public string Id
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

			public int? GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

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

			public string PackageVersionId
			{
				get
				{
					return packageVersionId;
				}
				set	
				{
					packageVersionId = value;
				}
			}

			public string AppVersionId
			{
				get
				{
					return appVersionId;
				}
				set	
				{
					appVersionId = value;
				}
			}

			public long? CreateTime
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

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
