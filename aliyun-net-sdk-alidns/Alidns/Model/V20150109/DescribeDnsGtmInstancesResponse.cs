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

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalPages;

		private int? totalItems;

		private List<DescribeDnsGtmInstances_GtmInstance> gtmInstances;

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

			private string paymentType;

			private string expireTime;

			private string createTime;

			private int? smsQuota;

			private string instanceId;

			private long? expireTimestamp;

			private string resourceGroupId;

			private string versionCode;

			private int? taskQuota;

			private long? createTimestamp;

			private DescribeDnsGtmInstances_Config config;

			private DescribeDnsGtmInstances_UsedQuota usedQuota;

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

				private int? ttl;

				private string alertGroup;

				private string publicZoneName;

				private string cnameType;

				private string strategyMode;

				private string instanceName;

				private string publicCnameMode;

				private string publicUserDomainName;

				private string publicRr;

				private List<DescribeDnsGtmInstances_AlertConfigItem> alertConfig;

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

				public string PublicRr
				{
					get
					{
						return publicRr;
					}
					set	
					{
						publicRr = value;
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

					private string smsNotice;

					private string noticeType;

					private string emailNotice;

					private string dingtalkNotice;

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

					public string DingtalkNotice
					{
						get
						{
							return dingtalkNotice;
						}
						set	
						{
							dingtalkNotice = value;
						}
					}
				}
			}

			public class DescribeDnsGtmInstances_UsedQuota
			{

				private int? emailUsedCount;

				private int? taskUsedCount;

				private int? smsUsedCount;

				private int? dingtalkUsedCount;

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

				public int? DingtalkUsedCount
				{
					get
					{
						return dingtalkUsedCount;
					}
					set	
					{
						dingtalkUsedCount = value;
					}
				}
			}
		}
	}
}
