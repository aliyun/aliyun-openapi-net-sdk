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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainFileSizeProportionDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private List<DescribeDomainFileSizeProportionData_UsageData> fileSizeProportionDataInterval;

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

		public List<DescribeDomainFileSizeProportionData_UsageData> FileSizeProportionDataInterval
		{
			get
			{
				return fileSizeProportionDataInterval;
			}
			set	
			{
				fileSizeProportionDataInterval = value;
			}
		}

		public class DescribeDomainFileSizeProportionData_UsageData
		{

			private string timeStamp;

			private List<DescribeDomainFileSizeProportionData_FileSizeProportionData> _value;

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

			public List<DescribeDomainFileSizeProportionData_FileSizeProportionData> _Value
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

			public class DescribeDomainFileSizeProportionData_FileSizeProportionData
			{

				private string fileSize;

				private string proportion;

				public string FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public string Proportion
				{
					get
					{
						return proportion;
					}
					set	
					{
						proportion = value;
					}
				}
			}
		}
	}
}