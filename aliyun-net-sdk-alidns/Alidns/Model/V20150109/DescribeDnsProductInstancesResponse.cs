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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDnsProductInstancesResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private string domainType;

		private List<DescribeDnsProductInstances_DnsProduct> dnsProducts;

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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public string DomainType
		{
			get
			{
				return domainType;
			}
			set	
			{
				domainType = value;
			}
		}

		public List<DescribeDnsProductInstances_DnsProduct> DnsProducts
		{
			get
			{
				return dnsProducts;
			}
			set	
			{
				dnsProducts = value;
			}
		}

		public class DescribeDnsProductInstances_DnsProduct
		{

			private string instanceId;

			private string versionCode;

			private string versionName;

			private string startTime;

			private string endTime;

			private long? startTimestamp;

			private long? endTimestamp;

			private string domain;

			private long? bindCount;

			private long? bindUsedCount;

			private long? tTLMinValue;

			private long? subDomainLevel;

			private long? dnsSLBCount;

			private long? uRLForwardCount;

			private long? dDosDefendFlow;

			private long? dDosDefendQuery;

			private long? overseaDDosDefendFlow;

			private string searchEngineLines;

			private string iSPLines;

			private string iSPRegionLines;

			private string overseaLine;

			private long? monitorNodeCount;

			private long? monitorFrequency;

			private long? monitorTaskCount;

			private bool? regionLines;

			private bool? gslb;

			private bool? inClean;

			private bool? inBlackHole;

			private long? bindDomainCount;

			private long? bindDomainUsedCount;

			private string dnsSecurity;

			private string paymentType;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string VersionCode
			{
				get
				{
					return versionCode;
				}
				set	
				{
					versionCode = value;
				}
			}

			public string VersionName
			{
				get
				{
					return versionName;
				}
				set	
				{
					versionName = value;
				}
			}

			public string StartTime
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

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? StartTimestamp
			{
				get
				{
					return startTimestamp;
				}
				set	
				{
					startTimestamp = value;
				}
			}

			public long? EndTimestamp
			{
				get
				{
					return endTimestamp;
				}
				set	
				{
					endTimestamp = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public long? BindCount
			{
				get
				{
					return bindCount;
				}
				set	
				{
					bindCount = value;
				}
			}

			public long? BindUsedCount
			{
				get
				{
					return bindUsedCount;
				}
				set	
				{
					bindUsedCount = value;
				}
			}

			public long? TTLMinValue
			{
				get
				{
					return tTLMinValue;
				}
				set	
				{
					tTLMinValue = value;
				}
			}

			public long? SubDomainLevel
			{
				get
				{
					return subDomainLevel;
				}
				set	
				{
					subDomainLevel = value;
				}
			}

			public long? DnsSLBCount
			{
				get
				{
					return dnsSLBCount;
				}
				set	
				{
					dnsSLBCount = value;
				}
			}

			public long? URLForwardCount
			{
				get
				{
					return uRLForwardCount;
				}
				set	
				{
					uRLForwardCount = value;
				}
			}

			public long? DDosDefendFlow
			{
				get
				{
					return dDosDefendFlow;
				}
				set	
				{
					dDosDefendFlow = value;
				}
			}

			public long? DDosDefendQuery
			{
				get
				{
					return dDosDefendQuery;
				}
				set	
				{
					dDosDefendQuery = value;
				}
			}

			public long? OverseaDDosDefendFlow
			{
				get
				{
					return overseaDDosDefendFlow;
				}
				set	
				{
					overseaDDosDefendFlow = value;
				}
			}

			public string SearchEngineLines
			{
				get
				{
					return searchEngineLines;
				}
				set	
				{
					searchEngineLines = value;
				}
			}

			public string ISPLines
			{
				get
				{
					return iSPLines;
				}
				set	
				{
					iSPLines = value;
				}
			}

			public string ISPRegionLines
			{
				get
				{
					return iSPRegionLines;
				}
				set	
				{
					iSPRegionLines = value;
				}
			}

			public string OverseaLine
			{
				get
				{
					return overseaLine;
				}
				set	
				{
					overseaLine = value;
				}
			}

			public long? MonitorNodeCount
			{
				get
				{
					return monitorNodeCount;
				}
				set	
				{
					monitorNodeCount = value;
				}
			}

			public long? MonitorFrequency
			{
				get
				{
					return monitorFrequency;
				}
				set	
				{
					monitorFrequency = value;
				}
			}

			public long? MonitorTaskCount
			{
				get
				{
					return monitorTaskCount;
				}
				set	
				{
					monitorTaskCount = value;
				}
			}

			public bool? RegionLines
			{
				get
				{
					return regionLines;
				}
				set	
				{
					regionLines = value;
				}
			}

			public bool? Gslb
			{
				get
				{
					return gslb;
				}
				set	
				{
					gslb = value;
				}
			}

			public bool? InClean
			{
				get
				{
					return inClean;
				}
				set	
				{
					inClean = value;
				}
			}

			public bool? InBlackHole
			{
				get
				{
					return inBlackHole;
				}
				set	
				{
					inBlackHole = value;
				}
			}

			public long? BindDomainCount
			{
				get
				{
					return bindDomainCount;
				}
				set	
				{
					bindDomainCount = value;
				}
			}

			public long? BindDomainUsedCount
			{
				get
				{
					return bindDomainUsedCount;
				}
				set	
				{
					bindDomainUsedCount = value;
				}
			}

			public string DnsSecurity
			{
				get
				{
					return dnsSecurity;
				}
				set	
				{
					dnsSecurity = value;
				}
			}

			public string PaymentType
			{
				get
				{
					return paymentType;
				}
				set	
				{
					paymentType = value;
				}
			}
		}
	}
}
