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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeGadInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGadInstances_GadInstancesItem> gadInstances;

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

		public List<DescribeGadInstances_GadInstancesItem> GadInstances
		{
			get
			{
				return gadInstances;
			}
			set	
			{
				gadInstances = value;
			}
		}

		public class DescribeGadInstances_GadInstancesItem
		{

			private string gadInstanceName;

			private string description;

			private string status;

			private string creationTime;

			private string modificationTime;

			private string service;

			private List<DescribeGadInstances_GadInstanceMembersItem> gadInstanceMembers;

			public string GadInstanceName
			{
				get
				{
					return gadInstanceName;
				}
				set	
				{
					gadInstanceName = value;
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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ModificationTime
			{
				get
				{
					return modificationTime;
				}
				set	
				{
					modificationTime = value;
				}
			}

			public string Service
			{
				get
				{
					return service;
				}
				set	
				{
					service = value;
				}
			}

			public List<DescribeGadInstances_GadInstanceMembersItem> GadInstanceMembers
			{
				get
				{
					return gadInstanceMembers;
				}
				set	
				{
					gadInstanceMembers = value;
				}
			}

			public class DescribeGadInstances_GadInstanceMembersItem
			{

				private string dBInstanceID;

				private string engine;

				private string engineVersion;

				private string regionId;

				private string role;

				private string status;

				private string dtsInstance;

				public string DBInstanceID
				{
					get
					{
						return dBInstanceID;
					}
					set	
					{
						dBInstanceID = value;
					}
				}

				public string Engine
				{
					get
					{
						return engine;
					}
					set	
					{
						engine = value;
					}
				}

				public string EngineVersion
				{
					get
					{
						return engineVersion;
					}
					set	
					{
						engineVersion = value;
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

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
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

				public string DtsInstance
				{
					get
					{
						return dtsInstance;
					}
					set	
					{
						dtsInstance = value;
					}
				}
			}
		}
	}
}
