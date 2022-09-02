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
	public class DescribeDomainQpsDataByLayerResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private string layer;

		private string domainName;

		private string dataInterval;

		private List<DescribeDomainQpsDataByLayer_DataModule> qpsDataInterval;

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
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

		public string Layer
		{
			get
			{
				return layer;
			}
			set	
			{
				layer = value;
			}
		}

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

		public List<DescribeDomainQpsDataByLayer_DataModule> QpsDataInterval
		{
			get
			{
				return qpsDataInterval;
			}
			set	
			{
				qpsDataInterval = value;
			}
		}

		public class DescribeDomainQpsDataByLayer_DataModule
		{

			private string _value;

			private string accValue;

			private string accDomesticValue;

			private string overseasValue;

			private string accOverseasValue;

			private string timeStamp;

			private string domesticValue;

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

			public string AccValue
			{
				get
				{
					return accValue;
				}
				set	
				{
					accValue = value;
				}
			}

			public string AccDomesticValue
			{
				get
				{
					return accDomesticValue;
				}
				set	
				{
					accDomesticValue = value;
				}
			}

			public string OverseasValue
			{
				get
				{
					return overseasValue;
				}
				set	
				{
					overseasValue = value;
				}
			}

			public string AccOverseasValue
			{
				get
				{
					return accOverseasValue;
				}
				set	
				{
					accOverseasValue = value;
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

			public string DomesticValue
			{
				get
				{
					return domesticValue;
				}
				set	
				{
					domesticValue = value;
				}
			}
		}
	}
}
