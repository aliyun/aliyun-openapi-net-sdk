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
	public class DescribeLiveShiftConfigsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveShiftConfigs_Config> content;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Content")]
		public List<DescribeLiveShiftConfigs_Config> Content
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

		public class DescribeLiveShiftConfigs_Config
		{

			private string appName;

			private int? vision;

			private string domainName;

			private string streamName;

			private bool? ignoreTranscode;

			[JsonProperty(PropertyName = "AppName")]
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

			[JsonProperty(PropertyName = "Vision")]
			public int? Vision
			{
				get
				{
					return vision;
				}
				set	
				{
					vision = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
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

			[JsonProperty(PropertyName = "StreamName")]
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

			[JsonProperty(PropertyName = "IgnoreTranscode")]
			public bool? IgnoreTranscode
			{
				get
				{
					return ignoreTranscode;
				}
				set	
				{
					ignoreTranscode = value;
				}
			}
		}
	}
}
