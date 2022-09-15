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
	public class DescribeLiveDomainLimitResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainLimit_LiveDomainLimit> liveDomainLimitList;

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

		[JsonProperty(PropertyName = "LiveDomainLimitList")]
		public List<DescribeLiveDomainLimit_LiveDomainLimit> LiveDomainLimitList
		{
			get
			{
				return liveDomainLimitList;
			}
			set	
			{
				liveDomainLimitList = value;
			}
		}

		public class DescribeLiveDomainLimit_LiveDomainLimit
		{

			private int? limitTranscodeNum;

			private int? currentTranscodeNum;

			private int? limitNum;

			private int? limitTransferNum;

			private int? currentNum;

			private int? currentTransferNum;

			private string domainName;

			[JsonProperty(PropertyName = "LimitTranscodeNum")]
			public int? LimitTranscodeNum
			{
				get
				{
					return limitTranscodeNum;
				}
				set	
				{
					limitTranscodeNum = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentTranscodeNum")]
			public int? CurrentTranscodeNum
			{
				get
				{
					return currentTranscodeNum;
				}
				set	
				{
					currentTranscodeNum = value;
				}
			}

			[JsonProperty(PropertyName = "LimitNum")]
			public int? LimitNum
			{
				get
				{
					return limitNum;
				}
				set	
				{
					limitNum = value;
				}
			}

			[JsonProperty(PropertyName = "LimitTransferNum")]
			public int? LimitTransferNum
			{
				get
				{
					return limitTransferNum;
				}
				set	
				{
					limitTransferNum = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentNum")]
			public int? CurrentNum
			{
				get
				{
					return currentNum;
				}
				set	
				{
					currentNum = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentTransferNum")]
			public int? CurrentTransferNum
			{
				get
				{
					return currentTransferNum;
				}
				set	
				{
					currentTransferNum = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
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
		}
	}
}
