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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListVodRealtimeLogDeliveryInfosResponse : AcsResponse
	{

		private string requestId;

		private List<ListVodRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos> content;

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

		public List<ListVodRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos> Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class ListVodRealtimeLogDeliveryInfos_RealtimeLogDeliveryInfos
		{

			private string project;

			private string logstore;

			private string region;

			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			public string Logstore
			{
				get
				{
					return logstore;
				}
				set	
				{
					logstore = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}
		}
	}
}
