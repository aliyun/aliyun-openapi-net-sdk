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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class CapacityPlanResponse : AcsResponse
	{

		private string requestId;

		private CapacityPlan_Result result;

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

		public CapacityPlan_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class CapacityPlan_Result
		{

			private string instanceCategory;

			private bool? oversizedCluster;

			private List<CapacityPlan_ExtendConfigsItem> extendConfigs;

			private List<CapacityPlan_NodeConfigurationsItem> nodeConfigurations;

			public string InstanceCategory
			{
				get
				{
					return instanceCategory;
				}
				set	
				{
					instanceCategory = value;
				}
			}

			public bool? OversizedCluster
			{
				get
				{
					return oversizedCluster;
				}
				set	
				{
					oversizedCluster = value;
				}
			}

			public List<CapacityPlan_ExtendConfigsItem> ExtendConfigs
			{
				get
				{
					return extendConfigs;
				}
				set	
				{
					extendConfigs = value;
				}
			}

			public List<CapacityPlan_NodeConfigurationsItem> NodeConfigurations
			{
				get
				{
					return nodeConfigurations;
				}
				set	
				{
					nodeConfigurations = value;
				}
			}

			public class CapacityPlan_ExtendConfigsItem
			{

				private string configType;

				private long? disk;

				private string diskType;

				public string ConfigType
				{
					get
					{
						return configType;
					}
					set	
					{
						configType = value;
					}
				}

				public long? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}
			}

			public class CapacityPlan_NodeConfigurationsItem
			{

				private long? amount;

				private long? cpu;

				private long? disk;

				private string diskType;

				private long? memory;

				private string nodeType;

				public long? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public long? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public long? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public long? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				public string NodeType
				{
					get
					{
						return nodeType;
					}
					set	
					{
						nodeType = value;
					}
				}
			}
		}
	}
}
