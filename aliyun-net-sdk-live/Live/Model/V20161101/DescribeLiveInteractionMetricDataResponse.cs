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
	public class DescribeLiveInteractionMetricDataResponse : AcsResponse
	{

		private string requestId;

		private string summaryData;

		private List<DescribeLiveInteractionMetricData_Data> nodes;

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

		[JsonProperty(PropertyName = "SummaryData")]
		public string SummaryData
		{
			get
			{
				return summaryData;
			}
			set	
			{
				summaryData = value;
			}
		}

		[JsonProperty(PropertyName = "Nodes")]
		public List<DescribeLiveInteractionMetricData_Data> Nodes
		{
			get
			{
				return nodes;
			}
			set	
			{
				nodes = value;
			}
		}

		public class DescribeLiveInteractionMetricData_Data
		{

			private string timestamp;

			private string _value;

			[JsonProperty(PropertyName = "Timestamp")]
			public string Timestamp
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

			[JsonProperty(PropertyName = "_Value")]
			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
