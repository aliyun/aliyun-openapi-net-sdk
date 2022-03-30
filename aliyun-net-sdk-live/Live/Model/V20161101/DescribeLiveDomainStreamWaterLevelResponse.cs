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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveDomainStreamWaterLevelResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainStreamWaterLevel_LiveDomainWaterLevel> liveDomainWaterLevelList;

		private DescribeLiveDomainStreamWaterLevel_LiveUidWaterLevel liveUidWaterLevel;

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

		public List<DescribeLiveDomainStreamWaterLevel_LiveDomainWaterLevel> LiveDomainWaterLevelList
		{
			get
			{
				return liveDomainWaterLevelList;
			}
			set	
			{
				liveDomainWaterLevelList = value;
			}
		}

		public DescribeLiveDomainStreamWaterLevel_LiveUidWaterLevel LiveUidWaterLevel
		{
			get
			{
				return liveUidWaterLevel;
			}
			set	
			{
				liveUidWaterLevel = value;
			}
		}

		public class DescribeLiveDomainStreamWaterLevel_LiveDomainWaterLevel
		{

			private int? domainRawLimit;

			private int? domainRawCount;

			private int? domainTranscodeCount;

			private string domainName;

			private int? domainTranscodeLimit;

			public int? DomainRawLimit
			{
				get
				{
					return domainRawLimit;
				}
				set	
				{
					domainRawLimit = value;
				}
			}

			public int? DomainRawCount
			{
				get
				{
					return domainRawCount;
				}
				set	
				{
					domainRawCount = value;
				}
			}

			public int? DomainTranscodeCount
			{
				get
				{
					return domainTranscodeCount;
				}
				set	
				{
					domainTranscodeCount = value;
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

			public int? DomainTranscodeLimit
			{
				get
				{
					return domainTranscodeLimit;
				}
				set	
				{
					domainTranscodeLimit = value;
				}
			}
		}

		public class DescribeLiveDomainStreamWaterLevel_LiveUidWaterLevel
		{

			private int? uidTranscodeLimit;

			private string aliUid;

			private int? uidTranscodeCount;

			private int? uidRawLimit;

			private int? uidRawCount;

			public int? UidTranscodeLimit
			{
				get
				{
					return uidTranscodeLimit;
				}
				set	
				{
					uidTranscodeLimit = value;
				}
			}

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public int? UidTranscodeCount
			{
				get
				{
					return uidTranscodeCount;
				}
				set	
				{
					uidTranscodeCount = value;
				}
			}

			public int? UidRawLimit
			{
				get
				{
					return uidRawLimit;
				}
				set	
				{
					uidRawLimit = value;
				}
			}

			public int? UidRawCount
			{
				get
				{
					return uidRawCount;
				}
				set	
				{
					uidRawCount = value;
				}
			}
		}
	}
}
