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
	public class DescribeLiveRecordNotifyConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeLiveRecordNotifyConfig_LiveRecordNotifyConfig liveRecordNotifyConfig;

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

		public DescribeLiveRecordNotifyConfig_LiveRecordNotifyConfig LiveRecordNotifyConfig
		{
			get
			{
				return liveRecordNotifyConfig;
			}
			set	
			{
				liveRecordNotifyConfig = value;
			}
		}

		public class DescribeLiveRecordNotifyConfig_LiveRecordNotifyConfig
		{

			private bool? needStatusNotify;

			private string onDemandUrl;

			private string domainName;

			private string notifyUrl;

			public bool? NeedStatusNotify
			{
				get
				{
					return needStatusNotify;
				}
				set	
				{
					needStatusNotify = value;
				}
			}

			public string OnDemandUrl
			{
				get
				{
					return onDemandUrl;
				}
				set	
				{
					onDemandUrl = value;
				}
			}

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

			public string NotifyUrl
			{
				get
				{
					return notifyUrl;
				}
				set	
				{
					notifyUrl = value;
				}
			}
		}
	}
}
