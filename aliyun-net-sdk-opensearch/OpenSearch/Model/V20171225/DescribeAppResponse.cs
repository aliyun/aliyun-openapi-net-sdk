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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class DescribeAppResponse : AcsResponse
	{

		private string requestId;

		private DescribeApp_Result result;

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

		public DescribeApp_Result Result
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

		public class DescribeApp_Result
		{

			private string id;

			private string description;

			private string status;

			private string type;

			private string clusterName;

			private int? algoDeploymentId;

			private int? created;

			private bool? autoSwitch;

			private int? progressPercent;

			private string schema;

			private List<string> fetchFields;

			private DescribeApp_Quota quota;

			private DescribeApp_Domain domain;

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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public int? AlgoDeploymentId
			{
				get
				{
					return algoDeploymentId;
				}
				set	
				{
					algoDeploymentId = value;
				}
			}

			public int? Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public bool? AutoSwitch
			{
				get
				{
					return autoSwitch;
				}
				set	
				{
					autoSwitch = value;
				}
			}

			public int? ProgressPercent
			{
				get
				{
					return progressPercent;
				}
				set	
				{
					progressPercent = value;
				}
			}

			public string Schema
			{
				get
				{
					return schema;
				}
				set	
				{
					schema = value;
				}
			}

			public List<string> FetchFields
			{
				get
				{
					return fetchFields;
				}
				set	
				{
					fetchFields = value;
				}
			}

			public DescribeApp_Quota Quota
			{
				get
				{
					return quota;
				}
				set	
				{
					quota = value;
				}
			}

			public DescribeApp_Domain Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public class DescribeApp_Quota
			{

				private int? docSize;

				private int? computeResource;

				private int? qps;

				private string spec;

				public int? DocSize
				{
					get
					{
						return docSize;
					}
					set	
					{
						docSize = value;
					}
				}

				public int? ComputeResource
				{
					get
					{
						return computeResource;
					}
					set	
					{
						computeResource = value;
					}
				}

				public int? Qps
				{
					get
					{
						return qps;
					}
					set	
					{
						qps = value;
					}
				}

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}
			}

			public class DescribeApp_Domain
			{

				private string name;

				private string category;

				private DescribeApp_Functions functions;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public DescribeApp_Functions Functions
				{
					get
					{
						return functions;
					}
					set	
					{
						functions = value;
					}
				}

				public class DescribeApp_Functions
				{

					private List<string> qp;

					private List<string> algo;

					private List<string> service;

					public List<string> Qp
					{
						get
						{
							return qp;
						}
						set	
						{
							qp = value;
						}
					}

					public List<string> Algo
					{
						get
						{
							return algo;
						}
						set	
						{
							algo = value;
						}
					}

					public List<string> Service
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
				}
			}
		}
	}
}
