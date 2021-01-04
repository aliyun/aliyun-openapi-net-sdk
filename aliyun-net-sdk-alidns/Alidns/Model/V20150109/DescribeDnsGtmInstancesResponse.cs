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
	public class DescribeDnsGtmInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalItems;

		private int? totalPages;

		private List<DescribeDnsGtmInstances_GtmInstance> gtmInstances;

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

		public int? PageNumber
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

		public int? PageSize
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

		public int? TotalItems
		{
			get
			{
				return totalItems;
			}
			set	
			{
				totalItems = value;
			}
		}

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
			}
		}

		public List<DescribeDnsGtmInstances_GtmInstance> GtmInstances
		{
			get
			{
				return gtmInstances;
			}
			set	
			{
				gtmInstances = value;
			}
		}

		public class DescribeDnsGtmInstances_GtmInstance
		{

			private string instanceId;

			private string versionCode;

			private int? smsQuota;

			private string createTime;

			private long? createTimestamp;

			private string expireTime;

			private long? expireTimestamp;

			private int? taskQuota;

			private string resourceGroupId;

			private string paymentType;

			private DescribeDnsGtmInstances_Config config;

			private DescribeDnsGtmInstances_UsedQuota usedQuota;

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

			public int? SmsQuota
			{
				get
				{
					return smsQuota;
				}
				set	
				{
					smsQuota = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public long? ExpireTimestamp
			{
				get
				{
					return expireTimestamp;
				}
				set	
				{
					expireTimestamp = value;
				}
			}

			public int? TaskQuota
			{
				get
				{
					return taskQuota;
				}
				set	
				{
					taskQuota = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
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

			public DescribeDnsGtmInstances_Config Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public DescribeDnsGtmInstances_UsedQuota UsedQuota
			{
				get
				{
					return usedQuota;
				}
				set	
				{
					usedQuota = value;
				}
			}

			public class DescribeDnsGtmInstances_Config
			{

				private string instanceName;

				private string cnameType;

				private string publicUserDomainName;

				private string publicCnameMode;

				private string publicZoneName;

				private int? ttl;

				private string alertGroup;

				private string strategyMode;

				private List<DescribeDnsGtmInstances_AlertConfigItem> alertConfig;

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

				public string CnameType
				{
					get
					{
						return cnameType;
					}
					set	
					{
						cnameType = value;
					}
				}

				public string PublicUserDomainName
				{
					get
					{
						return publicUserDomainName;
					}
					set	
					{
						publicUserDomainName = value;
					}
				}

				public string PublicCnameMode
				{
					get
					{
						return publicCnameMode;
					}
					set	
					{
						publicCnameMode = value;
					}
				}

				public string PublicZoneName
				{
					get
					{
						return publicZoneName;
					}
					set	
					{
						publicZoneName = value;
					}
				}

				public int? Ttl
				{
					get
					{
						return ttl;
					}
					set	
					{
						ttl = value;
					}
				}

				public string AlertGroup
				{
					get
					{
						return alertGroup;
					}
					set	
					{
						alertGroup = value;
					}
				}

				public string StrategyMode
				{
					get
					{
						return strategyMode;
					}
					set	
					{
						strategyMode = value;
					}
				}

				public List<DescribeDnsGtmInstances_AlertConfigItem> AlertConfig
				{
					get
					{
						return alertConfig;
					}
					set	
					{
						alertConfig = value;
					}
				}

				public class DescribeDnsGtmInstances_AlertConfigItem
				{

					private string noticeType;

					private string smsNotice;

					private string emailNotice;

					public string NoticeType
					{
						get
						{
							return noticeType;
						}
						set	
						{
							noticeType = value;
						}
					}

					public string SmsNotice
					{
						get
						{
							return smsNotice;
						}
						set	
						{
							smsNotice = value;
						}
					}

					public string EmailNotice
					{
						get
						{
							return emailNotice;
						}
						set	
						{
							emailNotice = value;
						}
					}
				}
			}

			public class DescribeDnsGtmInstances_UsedQuota
			{

				private int? taskUsedCount;

				private int? smsUsedCount;

				private int? emailUsedCount;

				public int? TaskUsedCount
				{
					get
					{
						return taskUsedCount;
					}
					set	
					{
						taskUsedCount = value;
					}
				}

				public int? SmsUsedCount
				{
					get
					{
						return smsUsedCount;
					}
					set	
					{
						smsUsedCount = value;
					}
				}

				public int? EmailUsedCount
				{
					get
					{
						return emailUsedCount;
					}
					set	
					{
						emailUsedCount = value;
					}
				}
			}
		}
	}
}
