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
	public class DescribeLiveAudioAuditConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveAudioAuditConfig_LiveAudioAuditConfig> liveAudioAuditConfigList;

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

		public List<DescribeLiveAudioAuditConfig_LiveAudioAuditConfig> LiveAudioAuditConfigList
		{
			get
			{
				return liveAudioAuditConfigList;
			}
			set	
			{
				liveAudioAuditConfigList = value;
			}
		}

		public class DescribeLiveAudioAuditConfig_LiveAudioAuditConfig
		{

			private string domainName;

			private string appName;

			private string streamName;

			private string bizType;

			private List<string> scenes;

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

			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public List<string> Scenes
			{
				get
				{
					return scenes;
				}
				set	
				{
					scenes = value;
				}
			}
		}
	}
}
