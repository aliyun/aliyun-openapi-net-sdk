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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class DescribeResourceCoverageTotalResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeResourceCoverageTotal_Data data;

		[JsonProperty(PropertyName = "Code")]
		public string Code
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public DescribeResourceCoverageTotal_Data Data
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

		public class DescribeResourceCoverageTotal_Data
		{

			private List<DescribeResourceCoverageTotal_Item> periodCoverage;

			private DescribeResourceCoverageTotal_TotalCoverage totalCoverage;

			[JsonProperty(PropertyName = "PeriodCoverage")]
			public List<DescribeResourceCoverageTotal_Item> PeriodCoverage
			{
				get
				{
					return periodCoverage;
				}
				set	
				{
					periodCoverage = value;
				}
			}

			[JsonProperty(PropertyName = "TotalCoverage")]
			public DescribeResourceCoverageTotal_TotalCoverage TotalCoverage
			{
				get
				{
					return totalCoverage;
				}
				set	
				{
					totalCoverage = value;
				}
			}

			public class DescribeResourceCoverageTotal_Item
			{

				private float? coveragePercentage;

				private string period;

				[JsonProperty(PropertyName = "CoveragePercentage")]
				public float? CoveragePercentage
				{
					get
					{
						return coveragePercentage;
					}
					set	
					{
						coveragePercentage = value;
					}
				}

				[JsonProperty(PropertyName = "Period")]
				public string Period
				{
					get
					{
						return period;
					}
					set	
					{
						period = value;
					}
				}
			}

			public class DescribeResourceCoverageTotal_TotalCoverage
			{

				private string capacityUnit;

				private float? deductQuantity;

				private float? coveragePercentage;

				private float? totalQuantity;

				[JsonProperty(PropertyName = "CapacityUnit")]
				public string CapacityUnit
				{
					get
					{
						return capacityUnit;
					}
					set	
					{
						capacityUnit = value;
					}
				}

				[JsonProperty(PropertyName = "DeductQuantity")]
				public float? DeductQuantity
				{
					get
					{
						return deductQuantity;
					}
					set	
					{
						deductQuantity = value;
					}
				}

				[JsonProperty(PropertyName = "CoveragePercentage")]
				public float? CoveragePercentage
				{
					get
					{
						return coveragePercentage;
					}
					set	
					{
						coveragePercentage = value;
					}
				}

				[JsonProperty(PropertyName = "TotalQuantity")]
				public float? TotalQuantity
				{
					get
					{
						return totalQuantity;
					}
					set	
					{
						totalQuantity = value;
					}
				}
			}
		}
	}
}
