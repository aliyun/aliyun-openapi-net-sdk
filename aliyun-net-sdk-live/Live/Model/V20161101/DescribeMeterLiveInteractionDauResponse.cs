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
	public class DescribeMeterLiveInteractionDauResponse : AcsResponse
	{

		private string requestId;

		private double? peakDau;

		private List<DescribeMeterLiveInteractionDau_DataItem> data;

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

		[JsonProperty(PropertyName = "PeakDau")]
		public double? PeakDau
		{
			get
			{
				return peakDau;
			}
			set	
			{
				peakDau = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public List<DescribeMeterLiveInteractionDau_DataItem> Data
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

		public class DescribeMeterLiveInteractionDau_DataItem
		{

			private long? timestamp;

			private double? dau;

			[JsonProperty(PropertyName = "Timestamp")]
			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			[JsonProperty(PropertyName = "Dau")]
			public double? Dau
			{
				get
				{
					return dau;
				}
				set	
				{
					dau = value;
				}
			}
		}
	}
}
