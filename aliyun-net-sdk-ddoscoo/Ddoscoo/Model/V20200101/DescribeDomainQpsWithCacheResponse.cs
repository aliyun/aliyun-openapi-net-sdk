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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeDomainQpsWithCacheResponse : AcsResponse
	{

		private string requestId;

		private int? interval;

		private long? startTime;

		private List<string> totals;

		private List<string> blocks;

		private List<string> cacheHits;

		private List<string> preciseBlocks;

		private List<string> regionBlocks;

		private List<string> ipBlockQps;

		private List<string> ccJsQps;

		private List<string> preciseJsQps;

		private List<string> ccBlockQps;

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

		public int? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public List<string> Totals
		{
			get
			{
				return totals;
			}
			set	
			{
				totals = value;
			}
		}

		public List<string> Blocks
		{
			get
			{
				return blocks;
			}
			set	
			{
				blocks = value;
			}
		}

		public List<string> CacheHits
		{
			get
			{
				return cacheHits;
			}
			set	
			{
				cacheHits = value;
			}
		}

		public List<string> PreciseBlocks
		{
			get
			{
				return preciseBlocks;
			}
			set	
			{
				preciseBlocks = value;
			}
		}

		public List<string> RegionBlocks
		{
			get
			{
				return regionBlocks;
			}
			set	
			{
				regionBlocks = value;
			}
		}

		public List<string> IpBlockQps
		{
			get
			{
				return ipBlockQps;
			}
			set	
			{
				ipBlockQps = value;
			}
		}

		public List<string> CcJsQps
		{
			get
			{
				return ccJsQps;
			}
			set	
			{
				ccJsQps = value;
			}
		}

		public List<string> PreciseJsQps
		{
			get
			{
				return preciseJsQps;
			}
			set	
			{
				preciseJsQps = value;
			}
		}

		public List<string> CcBlockQps
		{
			get
			{
				return ccBlockQps;
			}
			set	
			{
				ccBlockQps = value;
			}
		}
	}
}
