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

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20180104
{
	public class GetQuotaHistoryInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<GetQuotaHistoryInfo_DataItem> data;

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

		public List<GetQuotaHistoryInfo_DataItem> Data
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

		public class GetQuotaHistoryInfo_DataItem
		{

			private int? times;

			private GetQuotaHistoryInfo_Point point;

			public int? Times
			{
				get
				{
					return times;
				}
				set	
				{
					times = value;
				}
			}

			public GetQuotaHistoryInfo_Point Point
			{
				get
				{
					return point;
				}
				set	
				{
					point = value;
				}
			}

			public class GetQuotaHistoryInfo_Point
			{

				private GetQuotaHistoryInfo_CpuMaxQuota cpuMaxQuota;

				private GetQuotaHistoryInfo_CpuMinQuota cpuMinQuota;

				private GetQuotaHistoryInfo_MemUsed memUsed;

				private GetQuotaHistoryInfo_CpuUsed cpuUsed;

				private GetQuotaHistoryInfo_MemMaxQuota memMaxQuota;

				private GetQuotaHistoryInfo_MemMinQuota memMinQuota;

				public GetQuotaHistoryInfo_CpuMaxQuota CpuMaxQuota
				{
					get
					{
						return cpuMaxQuota;
					}
					set	
					{
						cpuMaxQuota = value;
					}
				}

				public GetQuotaHistoryInfo_CpuMinQuota CpuMinQuota
				{
					get
					{
						return cpuMinQuota;
					}
					set	
					{
						cpuMinQuota = value;
					}
				}

				public GetQuotaHistoryInfo_MemUsed MemUsed
				{
					get
					{
						return memUsed;
					}
					set	
					{
						memUsed = value;
					}
				}

				public GetQuotaHistoryInfo_CpuUsed CpuUsed
				{
					get
					{
						return cpuUsed;
					}
					set	
					{
						cpuUsed = value;
					}
				}

				public GetQuotaHistoryInfo_MemMaxQuota MemMaxQuota
				{
					get
					{
						return memMaxQuota;
					}
					set	
					{
						memMaxQuota = value;
					}
				}

				public GetQuotaHistoryInfo_MemMinQuota MemMinQuota
				{
					get
					{
						return memMinQuota;
					}
					set	
					{
						memMinQuota = value;
					}
				}

				public class GetQuotaHistoryInfo_CpuMaxQuota
				{

					private float? min;

					private float? max;

					private float? avg;

					public float? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public float? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public float? Avg
					{
						get
						{
							return avg;
						}
						set	
						{
							avg = value;
						}
					}
				}

				public class GetQuotaHistoryInfo_CpuMinQuota
				{

					private float? min;

					private float? max;

					private float? avg;

					public float? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public float? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public float? Avg
					{
						get
						{
							return avg;
						}
						set	
						{
							avg = value;
						}
					}
				}

				public class GetQuotaHistoryInfo_MemUsed
				{

					private float? min;

					private float? max;

					private float? avg;

					public float? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public float? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public float? Avg
					{
						get
						{
							return avg;
						}
						set	
						{
							avg = value;
						}
					}
				}

				public class GetQuotaHistoryInfo_CpuUsed
				{

					private float? min;

					private float? max;

					private float? avg;

					public float? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public float? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public float? Avg
					{
						get
						{
							return avg;
						}
						set	
						{
							avg = value;
						}
					}
				}

				public class GetQuotaHistoryInfo_MemMaxQuota
				{

					private float? min;

					private float? max;

					private float? avg;

					public float? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public float? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public float? Avg
					{
						get
						{
							return avg;
						}
						set	
						{
							avg = value;
						}
					}
				}

				public class GetQuotaHistoryInfo_MemMinQuota
				{

					private float? min;

					private float? max;

					private float? avg;

					public float? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public float? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public float? Avg
					{
						get
						{
							return avg;
						}
						set	
						{
							avg = value;
						}
					}
				}
			}
		}
	}
}