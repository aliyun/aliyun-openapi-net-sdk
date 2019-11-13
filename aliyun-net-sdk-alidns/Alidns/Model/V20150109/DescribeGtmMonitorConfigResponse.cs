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
	public class DescribeGtmMonitorConfigResponse : AcsResponse
	{

		private string requestId;

		private string monitorConfigId;

		private string createTime;

		private long? createTimestamp;

		private string updateTime;

		private long? updateTimestamp;

		private string protocolType;

		private int? interval;

		private int? evaluationCount;

		private int? timeout;

		private string monitorExtendInfo;

		private List<DescribeGtmMonitorConfig_IspCityNode> ispCityNodes;

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

		public string MonitorConfigId
		{
			get
			{
				return monitorConfigId;
			}
			set	
			{
				monitorConfigId = value;
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

		public string UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public long? UpdateTimestamp
		{
			get
			{
				return updateTimestamp;
			}
			set	
			{
				updateTimestamp = value;
			}
		}

		public string ProtocolType
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

		public int? EvaluationCount
		{
			get
			{
				return evaluationCount;
			}
			set	
			{
				evaluationCount = value;
			}
		}

		public int? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
			}
		}

		public string MonitorExtendInfo
		{
			get
			{
				return monitorExtendInfo;
			}
			set	
			{
				monitorExtendInfo = value;
			}
		}

		public List<DescribeGtmMonitorConfig_IspCityNode> IspCityNodes
		{
			get
			{
				return ispCityNodes;
			}
			set	
			{
				ispCityNodes = value;
			}
		}

		public class DescribeGtmMonitorConfig_IspCityNode
		{

			private string countryName;

			private string countryCode;

			private string cityName;

			private string cityCode;

			private string ispCode;

			private string ispName;

			public string CountryName
			{
				get
				{
					return countryName;
				}
				set	
				{
					countryName = value;
				}
			}

			public string CountryCode
			{
				get
				{
					return countryCode;
				}
				set	
				{
					countryCode = value;
				}
			}

			public string CityName
			{
				get
				{
					return cityName;
				}
				set	
				{
					cityName = value;
				}
			}

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
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
		}
	}
}
