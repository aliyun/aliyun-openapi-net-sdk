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

namespace Aliyun.Acs.waf_openapi.Model.V20180117
{
	public class DescribeDomainConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeDomainConfig_Result result;

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

		public DescribeDomainConfig_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeDomainConfig_Result
		{

			private string wafTaskId;

			private int? status;

			private DescribeDomainConfig_DomainConfig domainConfig;

			public string WafTaskId
			{
				get
				{
					return wafTaskId;
				}
				set	
				{
					wafTaskId = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public DescribeDomainConfig_DomainConfig DomainConfig
			{
				get
				{
					return domainConfig;
				}
				set	
				{
					domainConfig = value;
				}
			}

			public class DescribeDomainConfig_DomainConfig
			{

				private string cname;

				private int? protocolType;

				private string sourceIps;

				public string Cname
				{
					get
					{
						return cname;
					}
					set	
					{
						cname = value;
					}
				}

				public int? ProtocolType
				{
					get
					{
						return protocolType;
					}
					set	
					{
						protocolType = value;
					}
				}

				public string SourceIps
				{
					get
					{
						return sourceIps;
					}
					set	
					{
						sourceIps = value;
					}
				}
			}
		}
	}
}
