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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveDomainBpsDataByTimeStampResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string timeStamp;

		private List<DescribeLiveDomainBpsDataByTimeStamp_BpsDataModel> bpsDataList;

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

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public string TimeStamp
		{
			get
			{
				return timeStamp;
			}
			set	
			{
				timeStamp = value;
			}
		}

		public List<DescribeLiveDomainBpsDataByTimeStamp_BpsDataModel> BpsDataList
		{
			get
			{
				return bpsDataList;
			}
			set	
			{
				bpsDataList = value;
			}
		}

		public class DescribeLiveDomainBpsDataByTimeStamp_BpsDataModel
		{

			private string timeStamp;

			private string locationName;

			private string ispName;

			private long? bps;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string LocationName
			{
				get
				{
					return locationName;
				}
				set	
				{
					locationName = value;
				}
			}

			public string IspName
			{
				get
				{
					return ispName;
				}
				set	
				{
					ispName = value;
				}
			}

			public long? Bps
			{
				get
				{
					return bps;
				}
				set	
				{
					bps = value;
				}
			}
		}
	}
}
