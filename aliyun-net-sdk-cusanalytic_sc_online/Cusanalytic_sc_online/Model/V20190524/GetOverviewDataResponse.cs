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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class GetOverviewDataResponse : AcsResponse
	{

		private float? stayDeepAvg;

		private float? uvWeekGrowthPercent;

		private float? stayDeepAvgWeekGrowthPercent;

		private long? uv;

		private float? stayAvgPeriodWeekGrowthPercent;

		private float? uvEverySqm;

		private float? uvAvgWeekGrowthPercent;

		private float? stayAvgPeriod;

		private float? uvAvg;

		private float? uvEverySqmGrowthWeekPercent;

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

		public float? UvWeekGrowthPercent
		{
			get
			{
				return uvWeekGrowthPercent;
			}
			set	
			{
				uvWeekGrowthPercent = value;
			}
		}

		public float? StayDeepAvgWeekGrowthPercent
		{
			get
			{
				return stayDeepAvgWeekGrowthPercent;
			}
			set	
			{
				stayDeepAvgWeekGrowthPercent = value;
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

		public float? StayAvgPeriodWeekGrowthPercent
		{
			get
			{
				return stayAvgPeriodWeekGrowthPercent;
			}
			set	
			{
				stayAvgPeriodWeekGrowthPercent = value;
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

		public float? UvAvgWeekGrowthPercent
		{
			get
			{
				return uvAvgWeekGrowthPercent;
			}
			set	
			{
				uvAvgWeekGrowthPercent = value;
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

		public float? UvEverySqmGrowthWeekPercent
		{
			get
			{
				return uvEverySqmGrowthWeekPercent;
			}
			set	
			{
				uvEverySqmGrowthWeekPercent = value;
			}
		}
	}
}
