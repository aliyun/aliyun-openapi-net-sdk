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
	public class DescribeLiveDetectPornDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDetectPornData_DataModule> detectPornData;

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

		[JsonProperty(PropertyName = "DetectPornData")]
		public List<DescribeLiveDetectPornData_DataModule> DetectPornData
		{
			get
			{
				return detectPornData;
			}
			set	
			{
				detectPornData = value;
			}
		}

		public class DescribeLiveDetectPornData_DataModule
		{

			private string domain;

			private string region;

			private string app;

			private string stream;

			private string timeStamp;

			private long? count;

			private string scene;

			private string fee;

			[JsonProperty(PropertyName = "Domain")]
			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			[JsonProperty(PropertyName = "Region")]
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

			[JsonProperty(PropertyName = "App")]
			public string App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
				}
			}

			[JsonProperty(PropertyName = "Stream")]
			public string Stream
			{
				get
				{
					return stream;
				}
				set	
				{
					stream = value;
				}
			}

			[JsonProperty(PropertyName = "TimeStamp")]
			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			[JsonProperty(PropertyName = "Count")]
			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			[JsonProperty(PropertyName = "Scene")]
			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
				}
			}

			[JsonProperty(PropertyName = "Fee")]
			public string Fee
			{
				get
				{
					return fee;
				}
				set	
				{
					fee = value;
				}
			}
		}
	}
}
