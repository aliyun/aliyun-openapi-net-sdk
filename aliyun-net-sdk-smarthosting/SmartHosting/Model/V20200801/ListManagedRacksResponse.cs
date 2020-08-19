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

namespace Aliyun.Acs.SmartHosting.Model.V20200801
{
	public class ListManagedRacksResponse : AcsResponse
	{

		private string nextToken;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private List<ListManagedRacks_ManagedRacksSet> managedRacksSets;

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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public int? TotalCount
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

		public List<ListManagedRacks_ManagedRacksSet> ManagedRacksSets
		{
			get
			{
				return managedRacksSets;
			}
			set	
			{
				managedRacksSets = value;
			}
		}

		public class ListManagedRacks_ManagedRacksSet
		{

			private string managedRackId;

			private string zoneId;

			private List<ListManagedRacks_ManagedHostSet> managedHostSets;

			public string ManagedRackId
			{
				get
				{
					return managedRackId;
				}
				set	
				{
					managedRackId = value;
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

			public List<ListManagedRacks_ManagedHostSet> ManagedHostSets
			{
				get
				{
					return managedHostSets;
				}
				set	
				{
					managedHostSets = value;
				}
			}

			public class ListManagedRacks_ManagedHostSet
			{

				private string description;

				private string managedHostId;

				private string status;

				private ListManagedRacks_HostAttribute hostAttribute;

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

				public string ManagedHostId
				{
					get
					{
						return managedHostId;
					}
					set	
					{
						managedHostId = value;
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

				public ListManagedRacks_HostAttribute HostAttribute
				{
					get
					{
						return hostAttribute;
					}
					set	
					{
						hostAttribute = value;
					}
				}

				public class ListManagedRacks_HostAttribute
				{

					private string cpuModelName;

					private string hostType;

					public string CpuModelName
					{
						get
						{
							return cpuModelName;
						}
						set	
						{
							cpuModelName = value;
						}
					}

					public string HostType
					{
						get
						{
							return hostType;
						}
						set	
						{
							hostType = value;
						}
					}
				}
			}
		}
	}
}
