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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListCityMapCameraStatisticsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<ListCityMapCameraStatistics_Datas> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListCityMapCameraStatistics_Datas> Data
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

		public class ListCityMapCameraStatistics_Datas
		{

			private string dataSourceId;

			private string latitude;

			private string longitude;

			private string dataSourceName;

			private string corpId;

			private string adultValue;

			private string womanValue;

			private string motorValue;

			private string manValue;

			private string oldValue;

			private string childValue;

			private string statisticTime;

			public string DataSourceId
			{
				get
				{
					return dataSourceId;
				}
				set	
				{
					dataSourceId = value;
				}
			}

			public string Latitude
			{
				get
				{
					return latitude;
				}
				set	
				{
					latitude = value;
				}
			}

			public string Longitude
			{
				get
				{
					return longitude;
				}
				set	
				{
					longitude = value;
				}
			}

			public string DataSourceName
			{
				get
				{
					return dataSourceName;
				}
				set	
				{
					dataSourceName = value;
				}
			}

			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
				}
			}

			public string AdultValue
			{
				get
				{
					return adultValue;
				}
				set	
				{
					adultValue = value;
				}
			}

			public string WomanValue
			{
				get
				{
					return womanValue;
				}
				set	
				{
					womanValue = value;
				}
			}

			public string MotorValue
			{
				get
				{
					return motorValue;
				}
				set	
				{
					motorValue = value;
				}
			}

			public string ManValue
			{
				get
				{
					return manValue;
				}
				set	
				{
					manValue = value;
				}
			}

			public string OldValue
			{
				get
				{
					return oldValue;
				}
				set	
				{
					oldValue = value;
				}
			}

			public string ChildValue
			{
				get
				{
					return childValue;
				}
				set	
				{
					childValue = value;
				}
			}

			public string StatisticTime
			{
				get
				{
					return statisticTime;
				}
				set	
				{
					statisticTime = value;
				}
			}
		}
	}
}
