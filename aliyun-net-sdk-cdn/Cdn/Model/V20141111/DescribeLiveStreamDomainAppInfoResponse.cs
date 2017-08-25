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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeLiveStreamDomainAppInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamDomainAppInfo_DomainAppInfo> domainAppList;

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

		public List<DescribeLiveStreamDomainAppInfo_DomainAppInfo> DomainAppList
		{
			get
			{
				return domainAppList;
			}
			set	
			{
				domainAppList = value;
			}
		}

		public class DescribeLiveStreamDomainAppInfo_DomainAppInfo
		{

			private string appDomain;

			private string appId;

			private string appKey;

			private string appOssBucket;

			private string appOssHost;

			private string appOwnerId;

			private string appSecret;

			private string updateTime;

			public string AppDomain
			{
				get
				{
					return appDomain;
				}
				set	
				{
					appDomain = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string AppKey
			{
				get
				{
					return appKey;
				}
				set	
				{
					appKey = value;
				}
			}

			public string AppOssBucket
			{
				get
				{
					return appOssBucket;
				}
				set	
				{
					appOssBucket = value;
				}
			}

			public string AppOssHost
			{
				get
				{
					return appOssHost;
				}
				set	
				{
					appOssHost = value;
				}
			}

			public string AppOwnerId
			{
				get
				{
					return appOwnerId;
				}
				set	
				{
					appOwnerId = value;
				}
			}

			public string AppSecret
			{
				get
				{
					return appSecret;
				}
				set	
				{
					appSecret = value;
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
		}
	}
}