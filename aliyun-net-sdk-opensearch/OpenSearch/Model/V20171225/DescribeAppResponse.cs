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
using Newtonsoft.Json;
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

			private int? created;

			private string clusterName;

			private bool? autoSwitch;

			private int? algoDeploymentId;

			private string type;

			private string description;

			private string status;

			private string schema;

			private int? progressPercent;

			private string id;

			private List<string> fetchFields;

			private DescribeApp_Quota quota;

			private DescribeApp_Domain domain;

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

				private string spec;

				private int? qps;

				private int? docSize;

				private int? computeResource;

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
			}

			public class DescribeApp_Domain
			{

				private string category;

				private string name;

				private DescribeApp_Functions functions;

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

					private List<string> service;

					private List<string> qp;

					private List<string> algo;

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
				}
			}
		}
	}
}
