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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeMasterSlaveServerGroupsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeMasterSlaveServerGroups_MasterSlaveServerGroup> masterSlaveServerGroups;

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

		public List<DescribeMasterSlaveServerGroups_MasterSlaveServerGroup> MasterSlaveServerGroups
		{
			get
			{
				return masterSlaveServerGroups;
			}
			set	
			{
				masterSlaveServerGroups = value;
			}
		}

		public class DescribeMasterSlaveServerGroups_MasterSlaveServerGroup
		{

			private string masterSlaveServerGroupId;

			private string masterSlaveServerGroupName;

			private DescribeMasterSlaveServerGroups_AssociatedObjects associatedObjects;

			public string MasterSlaveServerGroupId
			{
				get
				{
					return masterSlaveServerGroupId;
				}
				set	
				{
					masterSlaveServerGroupId = value;
				}
			}

			public string MasterSlaveServerGroupName
			{
				get
				{
					return masterSlaveServerGroupName;
				}
				set	
				{
					masterSlaveServerGroupName = value;
				}
			}

			public DescribeMasterSlaveServerGroups_AssociatedObjects AssociatedObjects
			{
				get
				{
					return associatedObjects;
				}
				set	
				{
					associatedObjects = value;
				}
			}

			public class DescribeMasterSlaveServerGroups_AssociatedObjects
			{

				private List<DescribeMasterSlaveServerGroups_Listener> listeners;

				public List<DescribeMasterSlaveServerGroups_Listener> Listeners
				{
					get
					{
						return listeners;
					}
					set	
					{
						listeners = value;
					}
				}

				public class DescribeMasterSlaveServerGroups_Listener
				{

					private string protocol;

					private int? port;

					public string Protocol
					{
						get
						{
							return protocol;
						}
						set	
						{
							protocol = value;
						}
					}

					public int? Port
					{
						get
						{
							return port;
						}
						set	
						{
							port = value;
						}
					}
				}
			}
		}
	}
}
