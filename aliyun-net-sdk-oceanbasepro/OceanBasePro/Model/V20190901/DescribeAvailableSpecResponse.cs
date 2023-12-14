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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeAvailableSpecResponse : AcsResponse
	{

		private string requestId;

		private DescribeAvailableSpec_Data data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public DescribeAvailableSpec_Data Data
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

		public class DescribeAvailableSpec_Data
		{

			private List<DescribeAvailableSpec_AvailableSpecificationsItem> availableSpecifications;

			[JsonProperty(PropertyName = "AvailableSpecifications")]
			public List<DescribeAvailableSpec_AvailableSpecificationsItem> AvailableSpecifications
			{
				get
				{
					return availableSpecifications;
				}
				set	
				{
					availableSpecifications = value;
				}
			}

			public class DescribeAvailableSpec_AvailableSpecificationsItem
			{

				private string spec;

				private string instanceClass;

				private List<string> nodeNum;

				private DescribeAvailableSpec_DiskSizeRange diskSizeRange;

				private DescribeAvailableSpec_LogDiskSizeRange logDiskSizeRange;

				[JsonProperty(PropertyName = "Spec")]
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

				[JsonProperty(PropertyName = "InstanceClass")]
				public string InstanceClass
				{
					get
					{
						return instanceClass;
					}
					set	
					{
						instanceClass = value;
					}
				}

				[JsonProperty(PropertyName = "NodeNum")]
				public List<string> NodeNum
				{
					get
					{
						return nodeNum;
					}
					set	
					{
						nodeNum = value;
					}
				}

				[JsonProperty(PropertyName = "DiskSizeRange")]
				public DescribeAvailableSpec_DiskSizeRange DiskSizeRange
				{
					get
					{
						return diskSizeRange;
					}
					set	
					{
						diskSizeRange = value;
					}
				}

				[JsonProperty(PropertyName = "LogDiskSizeRange")]
				public DescribeAvailableSpec_LogDiskSizeRange LogDiskSizeRange
				{
					get
					{
						return logDiskSizeRange;
					}
					set	
					{
						logDiskSizeRange = value;
					}
				}

				public class DescribeAvailableSpec_DiskSizeRange
				{

					private long? step;

					private long? max;

					private long? min;

					[JsonProperty(PropertyName = "Step")]
					public long? Step
					{
						get
						{
							return step;
						}
						set	
						{
							step = value;
						}
					}

					[JsonProperty(PropertyName = "Max")]
					public long? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					[JsonProperty(PropertyName = "Min")]
					public long? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}
				}

				public class DescribeAvailableSpec_LogDiskSizeRange
				{

					private long? step;

					private long? max;

					private long? min;

					[JsonProperty(PropertyName = "Step")]
					public long? Step
					{
						get
						{
							return step;
						}
						set	
						{
							step = value;
						}
					}

					[JsonProperty(PropertyName = "Max")]
					public long? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					[JsonProperty(PropertyName = "Min")]
					public long? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}
				}
			}
		}
	}
}
