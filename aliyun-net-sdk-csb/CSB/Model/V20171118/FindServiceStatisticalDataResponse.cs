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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindServiceStatisticalDataResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindServiceStatisticalData_Data data;

		public int? Code
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

		public FindServiceStatisticalData_Data Data
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

		public class FindServiceStatisticalData_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private List<FindServiceStatisticalData_ServiceStatisticData> monitorStatisticData;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public int? PageNumber
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

			public List<FindServiceStatisticalData_ServiceStatisticData> MonitorStatisticData
			{
				get
				{
					return monitorStatisticData;
				}
				set	
				{
					monitorStatisticData = value;
				}
			}

			public class FindServiceStatisticalData_ServiceStatisticData
			{

				private float? avgRt;

				private float? maxRt;

				private float? minRt;

				private long? requestTime;

				private string serviceName;

				private string userId;

				private FindServiceStatisticalData_Total total;

				public float? AvgRt
				{
					get
					{
						return avgRt;
					}
					set	
					{
						avgRt = value;
					}
				}

				public float? MaxRt
				{
					get
					{
						return maxRt;
					}
					set	
					{
						maxRt = value;
					}
				}

				public float? MinRt
				{
					get
					{
						return minRt;
					}
					set	
					{
						minRt = value;
					}
				}

				public long? RequestTime
				{
					get
					{
						return requestTime;
					}
					set	
					{
						requestTime = value;
					}
				}

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public FindServiceStatisticalData_Total Total
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

				public class FindServiceStatisticalData_Total
				{

					private int? errorNum;

					private int? total;

					public int? ErrorNum
					{
						get
						{
							return errorNum;
						}
						set	
						{
							errorNum = value;
						}
					}

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
				}
			}
		}
	}
}
