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
	public class DescribeMixStreamListResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeMixStreamList_MixStreamInfo> mixStreamList;

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

		[JsonProperty(PropertyName = "Total")]
		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		[JsonProperty(PropertyName = "MixStreamList")]
		public List<DescribeMixStreamList_MixStreamInfo> MixStreamList
		{
			get
			{
				return mixStreamList;
			}
			set	
			{
				mixStreamList = value;
			}
		}

		public class DescribeMixStreamList_MixStreamInfo
		{

			private string appName;

			private string domainName;

			private string gmtCreate;

			private string gmtModified;

			private int? inputStreamNumber;

			private string layoutId;

			private string mixStreamTemplate;

			private string mixstreamId;

			private string streamName;

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

			[JsonProperty(PropertyName = "GmtCreate")]
			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			[JsonProperty(PropertyName = "GmtModified")]
			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			[JsonProperty(PropertyName = "InputStreamNumber")]
			public int? InputStreamNumber
			{
				get
				{
					return inputStreamNumber;
				}
				set	
				{
					inputStreamNumber = value;
				}
			}

			[JsonProperty(PropertyName = "LayoutId")]
			public string LayoutId
			{
				get
				{
					return layoutId;
				}
				set	
				{
					layoutId = value;
				}
			}

			[JsonProperty(PropertyName = "MixStreamTemplate")]
			public string MixStreamTemplate
			{
				get
				{
					return mixStreamTemplate;
				}
				set	
				{
					mixStreamTemplate = value;
				}
			}

			[JsonProperty(PropertyName = "MixstreamId")]
			public string MixstreamId
			{
				get
				{
					return mixstreamId;
				}
				set	
				{
					mixstreamId = value;
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
		}
	}
}
