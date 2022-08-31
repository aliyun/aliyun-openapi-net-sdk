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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeDomainHttpCodeDataByLayerResponse : AcsResponse
	{

		private string dataInterval;

		private string requestId;

		private List<DescribeDomainHttpCodeDataByLayer_DataModule> httpCodeDataInterval;

		public string DataInterval
		{
			get
			{
				return dataInterval;
			}
			set	
			{
				dataInterval = value;
			}
		}

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

		public List<DescribeDomainHttpCodeDataByLayer_DataModule> HttpCodeDataInterval
		{
			get
			{
				return httpCodeDataInterval;
			}
			set	
			{
				httpCodeDataInterval = value;
			}
		}

		public class DescribeDomainHttpCodeDataByLayer_DataModule
		{

			private string _value;

			private string timeStamp;

			private string totalValue;

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

			public string TotalValue
			{
				get
				{
					return totalValue;
				}
				set	
				{
					totalValue = value;
				}
			}
		}
	}
}
