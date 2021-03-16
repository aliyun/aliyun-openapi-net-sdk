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

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
	public class DescribeOverviewDataResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string message;

		private string code;

		private string dynamicCode;

		private string requestId;

		private bool? success;

		private string dynamicMessage;

		private DescribeOverviewData_OverviewDetail overviewDetail;

		private DescribeOverviewData_AccurateOverviewDetail accurateOverviewDetail;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public DescribeOverviewData_OverviewDetail OverviewDetail
		{
			get
			{
				return overviewDetail;
			}
			set	
			{
				overviewDetail = value;
			}
		}

		public DescribeOverviewData_AccurateOverviewDetail AccurateOverviewDetail
		{
			get
			{
				return accurateOverviewDetail;
			}
			set	
			{
				accurateOverviewDetail = value;
			}
		}

		public class DescribeOverviewData_OverviewDetail
		{

			private float? stayDeepAvgWOWPercent;

			private float? stayDeepAvg;

			private float? uvAvgWOWPercent;

			private float? stayAvgPeriodWOWPercent;

			private float? uvEverySqmGrowthWOWPercent;

			private float? uvWOWPercent;

			private long? uv;

			private float? uvEverySqm;

			private float? uvAvg;

			private float? stayAvgPeriod;

			public float? StayDeepAvgWOWPercent
			{
				get
				{
					return stayDeepAvgWOWPercent;
				}
				set	
				{
					stayDeepAvgWOWPercent = value;
				}
			}

			public float? StayDeepAvg
			{
				get
				{
					return stayDeepAvg;
				}
				set	
				{
					stayDeepAvg = value;
				}
			}

			public float? UvAvgWOWPercent
			{
				get
				{
					return uvAvgWOWPercent;
				}
				set	
				{
					uvAvgWOWPercent = value;
				}
			}

			public float? StayAvgPeriodWOWPercent
			{
				get
				{
					return stayAvgPeriodWOWPercent;
				}
				set	
				{
					stayAvgPeriodWOWPercent = value;
				}
			}

			public float? UvEverySqmGrowthWOWPercent
			{
				get
				{
					return uvEverySqmGrowthWOWPercent;
				}
				set	
				{
					uvEverySqmGrowthWOWPercent = value;
				}
			}

			public float? UvWOWPercent
			{
				get
				{
					return uvWOWPercent;
				}
				set	
				{
					uvWOWPercent = value;
				}
			}

			public long? Uv
			{
				get
				{
					return uv;
				}
				set	
				{
					uv = value;
				}
			}

			public float? UvEverySqm
			{
				get
				{
					return uvEverySqm;
				}
				set	
				{
					uvEverySqm = value;
				}
			}

			public float? UvAvg
			{
				get
				{
					return uvAvg;
				}
				set	
				{
					uvAvg = value;
				}
			}

			public float? StayAvgPeriod
			{
				get
				{
					return stayAvgPeriod;
				}
				set	
				{
					stayAvgPeriod = value;
				}
			}
		}

		public class DescribeOverviewData_AccurateOverviewDetail
		{

			private string stayDeepAvgWOWPercent;

			private string stayDeepAvg;

			private string uvAvgWOWPercent;

			private string stayAvgPeriodWOWPercent;

			private string uvWOWPercent;

			private string uvEverySqmGrowthWOWPercent;

			private long? uv;

			private string uvEverySqm;

			private string uvAvg;

			private string stayAvgPeriod;

			public string StayDeepAvgWOWPercent
			{
				get
				{
					return stayDeepAvgWOWPercent;
				}
				set	
				{
					stayDeepAvgWOWPercent = value;
				}
			}

			public string StayDeepAvg
			{
				get
				{
					return stayDeepAvg;
				}
				set	
				{
					stayDeepAvg = value;
				}
			}

			public string UvAvgWOWPercent
			{
				get
				{
					return uvAvgWOWPercent;
				}
				set	
				{
					uvAvgWOWPercent = value;
				}
			}

			public string StayAvgPeriodWOWPercent
			{
				get
				{
					return stayAvgPeriodWOWPercent;
				}
				set	
				{
					stayAvgPeriodWOWPercent = value;
				}
			}

			public string UvWOWPercent
			{
				get
				{
					return uvWOWPercent;
				}
				set	
				{
					uvWOWPercent = value;
				}
			}

			public string UvEverySqmGrowthWOWPercent
			{
				get
				{
					return uvEverySqmGrowthWOWPercent;
				}
				set	
				{
					uvEverySqmGrowthWOWPercent = value;
				}
			}

			public long? Uv
			{
				get
				{
					return uv;
				}
				set	
				{
					uv = value;
				}
			}

			public string UvEverySqm
			{
				get
				{
					return uvEverySqm;
				}
				set	
				{
					uvEverySqm = value;
				}
			}

			public string UvAvg
			{
				get
				{
					return uvAvg;
				}
				set	
				{
					uvAvg = value;
				}
			}

			public string StayAvgPeriod
			{
				get
				{
					return stayAvgPeriod;
				}
				set	
				{
					stayAvgPeriod = value;
				}
			}
		}
	}
}
