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
	public class FindCredentialStatisticalDataResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindCredentialStatisticalData_Data data;

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

		public FindCredentialStatisticalData_Data Data
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

		public class FindCredentialStatisticalData_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private long? total;

			private List<FindCredentialStatisticalData_ServiceStatisticData> monitorStatisticData;

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

			public long? Total
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

			public List<FindCredentialStatisticalData_ServiceStatisticData> MonitorStatisticData
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

			public class FindCredentialStatisticalData_ServiceStatisticData
			{

				private float? avgRt;

				private float? maxRt;

				private float? minRt;

				private FindCredentialStatisticalData_Total total;

				private FindCredentialStatisticalData_CredentialInfoData credentialInfoData;

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

				public FindCredentialStatisticalData_Total Total
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

				public FindCredentialStatisticalData_CredentialInfoData CredentialInfoData
				{
					get
					{
						return credentialInfoData;
					}
					set	
					{
						credentialInfoData = value;
					}
				}

				public class FindCredentialStatisticalData_Total
				{

					private long? total;

					private long? errorNum;

					public long? Total
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

					public long? ErrorNum
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
				}

				public class FindCredentialStatisticalData_CredentialInfoData
				{

					private string currentAk;

					private string credentialName;

					public string CurrentAk
					{
						get
						{
							return currentAk;
						}
						set	
						{
							currentAk = value;
						}
					}

					public string CredentialName
					{
						get
						{
							return credentialName;
						}
						set	
						{
							credentialName = value;
						}
					}
				}
			}
		}
	}
}
