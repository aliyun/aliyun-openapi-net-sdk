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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeDomainDetailResponse : AcsResponse
	{

		private string domain;

		private string requestId;

		private int? vulCount;

		private int? alarmCount;

		private string rootDomain;

		private List<DescribeDomainDetail_DomainDetailItem> domainDetailItems;

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

		public int? VulCount
		{
			get
			{
				return vulCount;
			}
			set	
			{
				vulCount = value;
			}
		}

		public int? AlarmCount
		{
			get
			{
				return alarmCount;
			}
			set	
			{
				alarmCount = value;
			}
		}

		public string RootDomain
		{
			get
			{
				return rootDomain;
			}
			set	
			{
				rootDomain = value;
			}
		}

		public List<DescribeDomainDetail_DomainDetailItem> DomainDetailItems
		{
			get
			{
				return domainDetailItems;
			}
			set	
			{
				domainDetailItems = value;
			}
		}

		public class DescribeDomainDetail_DomainDetailItem
		{

			private string uuid;

			private string internetIp;

			private string machineIp;

			private string instanceName;

			private string instanceId;

			private string intranetIp;

			private string assetType;

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string MachineIp
			{
				get
				{
					return machineIp;
				}
				set	
				{
					machineIp = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

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

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string AssetType
			{
				get
				{
					return assetType;
				}
				set	
				{
					assetType = value;
				}
			}
		}
	}
}
