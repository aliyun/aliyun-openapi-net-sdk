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
	public class DescribeSavingsPlansCoverageTotalResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeSavingsPlansCoverageTotal_Data data;

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
		public DescribeSavingsPlansCoverageTotal_Data Data
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

		public class DescribeSavingsPlansCoverageTotal_Data
		{

			private List<DescribeSavingsPlansCoverageTotal_Item> periodCoverage;

			private DescribeSavingsPlansCoverageTotal_TotalCoverage totalCoverage;

			[JsonProperty(PropertyName = "PeriodCoverage")]
			public List<DescribeSavingsPlansCoverageTotal_Item> PeriodCoverage
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
			public DescribeSavingsPlansCoverageTotal_TotalCoverage TotalCoverage
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

			public class DescribeSavingsPlansCoverageTotal_Item
			{

				private float? percentage;

				private string period;

				[JsonProperty(PropertyName = "Percentage")]
				public float? Percentage
				{
					get
					{
						return percentage;
					}
					set	
					{
						percentage = value;
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

			public class DescribeSavingsPlansCoverageTotal_TotalCoverage
			{

				private float? coveragePercentage;

				private float? deductAmount;

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

				[JsonProperty(PropertyName = "DeductAmount")]
				public float? DeductAmount
				{
					get
					{
						return deductAmount;
					}
					set	
					{
						deductAmount = value;
					}
				}
			}
		}
	}
}
