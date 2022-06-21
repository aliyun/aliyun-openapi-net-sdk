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
	public class DescribeLiveStreamOptimizedFeatureConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamOptimizedFeatureConfig_LiveStreamOptimizedFeatureConfig> liveStreamOptimizedFeatureConfigList;

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

		public List<DescribeLiveStreamOptimizedFeatureConfig_LiveStreamOptimizedFeatureConfig> LiveStreamOptimizedFeatureConfigList
		{
			get
			{
				return liveStreamOptimizedFeatureConfigList;
			}
			set	
			{
				liveStreamOptimizedFeatureConfigList = value;
			}
		}

		public class DescribeLiveStreamOptimizedFeatureConfig_LiveStreamOptimizedFeatureConfig
		{

			private string domainName;

			private string configName;

			private string configStatus;

			private string configValue;

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

			public string ConfigName
			{
				get
				{
					return configName;
				}
				set	
				{
					configName = value;
				}
			}

			public string ConfigStatus
			{
				get
				{
					return configStatus;
				}
				set	
				{
					configStatus = value;
				}
			}

			public string ConfigValue
			{
				get
				{
					return configValue;
				}
				set	
				{
					configValue = value;
				}
			}
		}
	}
}
