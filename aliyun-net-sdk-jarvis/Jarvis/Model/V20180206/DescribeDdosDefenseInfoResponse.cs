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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
	public class DescribeDdosDefenseInfoResponse : AcsResponse
	{

		private string requestId;

		private string module;

		private int? blackTimes;

		private int? duration;

		private string bgpPkgState;

		private List<DescribeDdosDefenseInfo_DdosDefenseThresholdItem> ddosDefenseThreshold;

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

		public string Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public int? BlackTimes
		{
			get
			{
				return blackTimes;
			}
			set	
			{
				blackTimes = value;
			}
		}

		public int? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
			}
		}

		public string BgpPkgState
		{
			get
			{
				return bgpPkgState;
			}
			set	
			{
				bgpPkgState = value;
			}
		}

		public List<DescribeDdosDefenseInfo_DdosDefenseThresholdItem> DdosDefenseThreshold
		{
			get
			{
				return ddosDefenseThreshold;
			}
			set	
			{
				ddosDefenseThreshold = value;
			}
		}

		public class DescribeDdosDefenseInfo_DdosDefenseThresholdItem
		{

			private string regionId;

			private int? currThreshold;

			private int? recommendThreshold;

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

			public int? CurrThreshold
			{
				get
				{
					return currThreshold;
				}
				set	
				{
					currThreshold = value;
				}
			}

			public int? RecommendThreshold
			{
				get
				{
					return recommendThreshold;
				}
				set	
				{
					recommendThreshold = value;
				}
			}
		}
	}
}