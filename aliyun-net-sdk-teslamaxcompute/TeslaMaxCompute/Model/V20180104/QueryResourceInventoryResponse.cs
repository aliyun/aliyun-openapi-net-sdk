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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20180104
{
	public class QueryResourceInventoryResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private QueryResourceInventory_Data data;

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

		public QueryResourceInventory_Data Data
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

		public class QueryResourceInventory_Data
		{

			private string lastUpdate;

			private List<QueryResourceInventory_Cluster> clusters;

			public string LastUpdate
			{
				get
				{
					return lastUpdate;
				}
				set	
				{
					lastUpdate = value;
				}
			}

			public List<QueryResourceInventory_Cluster> Clusters
			{
				get
				{
					return clusters;
				}
				set	
				{
					clusters = value;
				}
			}

			public class QueryResourceInventory_Cluster
			{

				private string status;

				private string cluster;

				private string machineRoom;

				private string region;

				private List<QueryResourceInventory_ResourceParameter> resourceParameters;

				private List<QueryResourceInventory_ResourceInventory> resourceInventories;

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

				public string Cluster
				{
					get
					{
						return cluster;
					}
					set	
					{
						cluster = value;
					}
				}

				public string MachineRoom
				{
					get
					{
						return machineRoom;
					}
					set	
					{
						machineRoom = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public List<QueryResourceInventory_ResourceParameter> ResourceParameters
				{
					get
					{
						return resourceParameters;
					}
					set	
					{
						resourceParameters = value;
					}
				}

				public List<QueryResourceInventory_ResourceInventory> ResourceInventories
				{
					get
					{
						return resourceInventories;
					}
					set	
					{
						resourceInventories = value;
					}
				}

				public class QueryResourceInventory_ResourceParameter
				{

					private string paraName;

					private string paraValue;

					public string ParaName
					{
						get
						{
							return paraName;
						}
						set	
						{
							paraName = value;
						}
					}

					public string ParaValue
					{
						get
						{
							return paraValue;
						}
						set	
						{
							paraValue = value;
						}
					}
				}

				public class QueryResourceInventory_ResourceInventory
				{

					private long? total;

					private long? available;

					private long? used;

					private string resourceType;

					public long? Total
					{
						get
						{
							return total;
						}
						set	
						{
							total = value;
						}
					}

					public long? Available
					{
						get
						{
							return available;
						}
						set	
						{
							available = value;
						}
					}

					public long? Used
					{
						get
						{
							return used;
						}
						set	
						{
							used = value;
						}
					}

					public string ResourceType
					{
						get
						{
							return resourceType;
						}
						set	
						{
							resourceType = value;
						}
					}
				}
			}
		}
	}
}