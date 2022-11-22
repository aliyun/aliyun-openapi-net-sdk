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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeAvailableMemResourceResponse : AcsResponse
	{

		private string requestId;

		private DescribeAvailableMemResource_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public DescribeAvailableMemResource_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeAvailableMemResource_Data
		{

			private long? minMem;

			private long? maxMem;

			private long? usedMem;

			[JsonProperty(PropertyName = "MinMem")]
			public long? MinMem
			{
				get
				{
					return minMem;
				}
				set	
				{
					minMem = value;
				}
			}

			[JsonProperty(PropertyName = "MaxMem")]
			public long? MaxMem
			{
				get
				{
					return maxMem;
				}
				set	
				{
					maxMem = value;
				}
			}

			[JsonProperty(PropertyName = "UsedMem")]
			public long? UsedMem
			{
				get
				{
					return usedMem;
				}
				set	
				{
					usedMem = value;
				}
			}
		}
	}
}
