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
	public class DescribeLiveLazyPullStreamConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveLazyPullStreamConfig_LiveLazyPullConfig> liveLazyPullConfigList;

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

		public List<DescribeLiveLazyPullStreamConfig_LiveLazyPullConfig> LiveLazyPullConfigList
		{
			get
			{
				return liveLazyPullConfigList;
			}
			set	
			{
				liveLazyPullConfigList = value;
			}
		}

		public class DescribeLiveLazyPullStreamConfig_LiveLazyPullConfig
		{

			private string domainName;

			private string appName;

			private string pullDomainName;

			private string pullAppName;

			private string pullProtocol;

			private string pullAuthType;

			private string pullAuthKey;

			private string pullArgs;

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

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string PullDomainName
			{
				get
				{
					return pullDomainName;
				}
				set	
				{
					pullDomainName = value;
				}
			}

			public string PullAppName
			{
				get
				{
					return pullAppName;
				}
				set	
				{
					pullAppName = value;
				}
			}

			public string PullProtocol
			{
				get
				{
					return pullProtocol;
				}
				set	
				{
					pullProtocol = value;
				}
			}

			public string PullAuthType
			{
				get
				{
					return pullAuthType;
				}
				set	
				{
					pullAuthType = value;
				}
			}

			public string PullAuthKey
			{
				get
				{
					return pullAuthKey;
				}
				set	
				{
					pullAuthKey = value;
				}
			}

			public string PullArgs
			{
				get
				{
					return pullArgs;
				}
				set	
				{
					pullArgs = value;
				}
			}
		}
	}
}
