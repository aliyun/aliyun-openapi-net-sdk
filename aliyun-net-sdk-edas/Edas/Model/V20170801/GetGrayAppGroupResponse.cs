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
	public class GetGrayAppGroupResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private List<GetGrayAppGroup_DataItem> data;

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

		public List<GetGrayAppGroup_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetGrayAppGroup_DataItem
		{

			private string appId;

			private string appName;

			private string regionId;

			private string regionName;

			private List<GetGrayAppGroup_GroupListItem> groupList;

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

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
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

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public List<GetGrayAppGroup_GroupListItem> GroupList
			{
				get
				{
					return groupList;
				}
				set	
				{
					groupList = value;
				}
			}

			public class GetGrayAppGroup_GroupListItem
			{

				private string id;

				private string groupName;

				private string packageVersion;

				private int? instances;

				private string clusterId;

				private string dpathPointcutName;

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

				public string PackageVersion
				{
					get
					{
						return packageVersion;
					}
					set	
					{
						packageVersion = value;
					}
				}

				public int? Instances
				{
					get
					{
						return instances;
					}
					set	
					{
						instances = value;
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

				public string DpathPointcutName
				{
					get
					{
						return dpathPointcutName;
					}
					set	
					{
						dpathPointcutName = value;
					}
				}
			}
		}
	}
}
