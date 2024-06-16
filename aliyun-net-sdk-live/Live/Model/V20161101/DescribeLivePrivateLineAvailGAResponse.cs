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
	public class DescribeLivePrivateLineAvailGAResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLivePrivateLineAvailGA_LivePrivateLineAvailGA> livePrivateLineAvailGAs;

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

		[JsonProperty(PropertyName = "LivePrivateLineAvailGAs")]
		public List<DescribeLivePrivateLineAvailGA_LivePrivateLineAvailGA> LivePrivateLineAvailGAs
		{
			get
			{
				return livePrivateLineAvailGAs;
			}
			set	
			{
				livePrivateLineAvailGAs = value;
			}
		}

		public class DescribeLivePrivateLineAvailGA_LivePrivateLineAvailGA
		{

			private string accelerationArea;

			private string accelerationType;

			private string appName;

			private string bindingStatus;

			private string domainName;

			private string iP;

			private string instanceId;

			private string status;

			private string streamName;

			private string uid;

			private string videoCenter;

			[JsonProperty(PropertyName = "AccelerationArea")]
			public string AccelerationArea
			{
				get
				{
					return accelerationArea;
				}
				set	
				{
					accelerationArea = value;
				}
			}

			[JsonProperty(PropertyName = "AccelerationType")]
			public string AccelerationType
			{
				get
				{
					return accelerationType;
				}
				set	
				{
					accelerationType = value;
				}
			}

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

			[JsonProperty(PropertyName = "BindingStatus")]
			public string BindingStatus
			{
				get
				{
					return bindingStatus;
				}
				set	
				{
					bindingStatus = value;
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

			[JsonProperty(PropertyName = "IP")]
			public string IP
			{
				get
				{
					return iP;
				}
				set	
				{
					iP = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
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

			[JsonProperty(PropertyName = "Uid")]
			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
				}
			}

			[JsonProperty(PropertyName = "VideoCenter")]
			public string VideoCenter
			{
				get
				{
					return videoCenter;
				}
				set	
				{
					videoCenter = value;
				}
			}
		}
	}
}
