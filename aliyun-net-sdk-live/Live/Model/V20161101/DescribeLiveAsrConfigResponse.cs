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
	public class DescribeLiveAsrConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveAsrConfig_LiveAsrConfigList> liveAsrConfig;

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

		public List<DescribeLiveAsrConfig_LiveAsrConfigList> LiveAsrConfig
		{
			get
			{
				return liveAsrConfig;
			}
			set	
			{
				liveAsrConfig = value;
			}
		}

		public class DescribeLiveAsrConfig_LiveAsrConfigList
		{

			private int? domainName;

			private string appName;

			private string streamName;

			private int? period;

			private string mnsTopic;

			private string mnsRegion;

			private string httpCallbackURL;

			public int? DomainName
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

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string MnsTopic
			{
				get
				{
					return mnsTopic;
				}
				set	
				{
					mnsTopic = value;
				}
			}

			public string MnsRegion
			{
				get
				{
					return mnsRegion;
				}
				set	
				{
					mnsRegion = value;
				}
			}

			public string HttpCallbackURL
			{
				get
				{
					return httpCallbackURL;
				}
				set	
				{
					httpCallbackURL = value;
				}
			}
		}
	}
}
