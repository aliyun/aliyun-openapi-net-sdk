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

namespace Aliyun.Acs.eais.Model.V20190624
{
	public class DescribeEaisResponse : AcsResponse
	{

		private int? pageNumber;

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private List<DescribeEais_Instance> instances;

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public List<DescribeEais_Instance> Instances
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

		public class DescribeEais_Instance
		{

			private string regionId;

			private string zoneId;

			private string creationTime;

			private string instanceName;

			private string description;

			private string status;

			private string elasticAcceleratedInstanceId;

			private string clientInstanceId;

			private string instanceType;

			private string clientInstanceType;

			private string clientInstanceName;

			private List<DescribeEais_Tag> tags;

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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
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

			public string ElasticAcceleratedInstanceId
			{
				get
				{
					return elasticAcceleratedInstanceId;
				}
				set	
				{
					elasticAcceleratedInstanceId = value;
				}
			}

			public string ClientInstanceId
			{
				get
				{
					return clientInstanceId;
				}
				set	
				{
					clientInstanceId = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string ClientInstanceType
			{
				get
				{
					return clientInstanceType;
				}
				set	
				{
					clientInstanceType = value;
				}
			}

			public string ClientInstanceName
			{
				get
				{
					return clientInstanceName;
				}
				set	
				{
					clientInstanceName = value;
				}
			}

			public List<DescribeEais_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeEais_Tag
			{

				private string tagValue;

				private string tagKey;

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}
			}
		}
	}
}
