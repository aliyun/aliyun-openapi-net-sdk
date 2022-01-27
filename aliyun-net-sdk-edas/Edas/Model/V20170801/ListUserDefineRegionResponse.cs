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
	public class ListUserDefineRegionResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListUserDefineRegion_UserDefineRegionEntity> userDefineRegionList;

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

		public List<ListUserDefineRegion_UserDefineRegionEntity> UserDefineRegionList
		{
			get
			{
				return userDefineRegionList;
			}
			set	
			{
				userDefineRegionList = value;
			}
		}

		public class ListUserDefineRegion_UserDefineRegionEntity
		{

			private long? id;

			private string userId;

			private string regionId;

			private string regionName;

			private string description;

			private string belongRegion;

			private bool? debugEnable;

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

			public string BelongRegion
			{
				get
				{
					return belongRegion;
				}
				set	
				{
					belongRegion = value;
				}
			}

			public bool? DebugEnable
			{
				get
				{
					return debugEnable;
				}
				set	
				{
					debugEnable = value;
				}
			}
		}
	}
}
