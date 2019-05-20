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

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
	public class DescribeFlowTotalCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeFlowTotalCount_FlowCount flowCount;

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

		public DescribeFlowTotalCount_FlowCount FlowCount
		{
			get
			{
				return flowCount;
			}
			set	
			{
				flowCount = value;
			}
		}

		public class DescribeFlowTotalCount_FlowCount
		{

			private DescribeFlowTotalCount_DataHub dataHub;

			private DescribeFlowTotalCount_CDP cDP;

			public DescribeFlowTotalCount_DataHub DataHub
			{
				get
				{
					return dataHub;
				}
				set	
				{
					dataHub = value;
				}
			}

			public DescribeFlowTotalCount_CDP CDP
			{
				get
				{
					return cDP;
				}
				set	
				{
					cDP = value;
				}
			}

			public class DescribeFlowTotalCount_DataHub
			{

				private DescribeFlowTotalCount_Project project;

				private DescribeFlowTotalCount_Topic topic;

				private DescribeFlowTotalCount_Subscription subscription;

				private DescribeFlowTotalCount_Connector connector;

				public DescribeFlowTotalCount_Project Project
				{
					get
					{
						return project;
					}
					set	
					{
						project = value;
					}
				}

				public DescribeFlowTotalCount_Topic Topic
				{
					get
					{
						return topic;
					}
					set	
					{
						topic = value;
					}
				}

				public DescribeFlowTotalCount_Subscription Subscription
				{
					get
					{
						return subscription;
					}
					set	
					{
						subscription = value;
					}
				}

				public DescribeFlowTotalCount_Connector Connector
				{
					get
					{
						return connector;
					}
					set	
					{
						connector = value;
					}
				}

				public class DescribeFlowTotalCount_Project
				{

					private long? totalCount;

					private long? lastCount;

					public long? TotalCount
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

					public long? LastCount
					{
						get
						{
							return lastCount;
						}
						set	
						{
							lastCount = value;
						}
					}
				}

				public class DescribeFlowTotalCount_Topic
				{

					private long? totalCount;

					private long? lastCount;

					public long? TotalCount
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

					public long? LastCount
					{
						get
						{
							return lastCount;
						}
						set	
						{
							lastCount = value;
						}
					}
				}

				public class DescribeFlowTotalCount_Subscription
				{

					private long? totalCount;

					private long? lastCount;

					public long? TotalCount
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

					public long? LastCount
					{
						get
						{
							return lastCount;
						}
						set	
						{
							lastCount = value;
						}
					}
				}

				public class DescribeFlowTotalCount_Connector
				{

					private long? totalCount;

					private long? lastCount;

					public long? TotalCount
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

					public long? LastCount
					{
						get
						{
							return lastCount;
						}
						set	
						{
							lastCount = value;
						}
					}
				}
			}

			public class DescribeFlowTotalCount_CDP
			{

				private DescribeFlowTotalCount_InputInstanceCount inputInstanceCount;

				private DescribeFlowTotalCount_InputRecordCount inputRecordCount;

				private DescribeFlowTotalCount_OutputInstanceCount outputInstanceCount;

				private DescribeFlowTotalCount_OutputRecordCount outputRecordCount;

				public DescribeFlowTotalCount_InputInstanceCount InputInstanceCount
				{
					get
					{
						return inputInstanceCount;
					}
					set	
					{
						inputInstanceCount = value;
					}
				}

				public DescribeFlowTotalCount_InputRecordCount InputRecordCount
				{
					get
					{
						return inputRecordCount;
					}
					set	
					{
						inputRecordCount = value;
					}
				}

				public DescribeFlowTotalCount_OutputInstanceCount OutputInstanceCount
				{
					get
					{
						return outputInstanceCount;
					}
					set	
					{
						outputInstanceCount = value;
					}
				}

				public DescribeFlowTotalCount_OutputRecordCount OutputRecordCount
				{
					get
					{
						return outputRecordCount;
					}
					set	
					{
						outputRecordCount = value;
					}
				}

				public class DescribeFlowTotalCount_InputInstanceCount
				{

					private long? totalCount;

					public long? TotalCount
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
				}

				public class DescribeFlowTotalCount_InputRecordCount
				{

					private long? totalCount;

					public long? TotalCount
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
				}

				public class DescribeFlowTotalCount_OutputInstanceCount
				{

					private long? totalCount;

					public long? TotalCount
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
				}

				public class DescribeFlowTotalCount_OutputRecordCount
				{

					private long? totalCount;

					public long? TotalCount
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
				}
			}
		}
	}
}
