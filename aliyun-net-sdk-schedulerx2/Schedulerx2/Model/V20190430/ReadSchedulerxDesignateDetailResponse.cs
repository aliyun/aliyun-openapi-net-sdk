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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class ReadSchedulerxDesignateDetailResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private ReadSchedulerxDesignateDetail_Data data;

		private ReadSchedulerxDesignateDetail_AccessDeniedDetail accessDeniedDetail;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public ReadSchedulerxDesignateDetail_Data Data
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

		public ReadSchedulerxDesignateDetail_AccessDeniedDetail AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public class ReadSchedulerxDesignateDetail_Data
		{

			private List<ReadSchedulerxDesignateDetail_DesignateDetailVo> designateDetailVos;

			public List<ReadSchedulerxDesignateDetail_DesignateDetailVo> DesignateDetailVos
			{
				get
				{
					return designateDetailVos;
				}
				set	
				{
					designateDetailVos = value;
				}
			}

			public class ReadSchedulerxDesignateDetail_DesignateDetailVo
			{

				private bool? offline;

				private int? size;

				private string starter;

				private string busy;

				private bool? _checked;

				private string version;

				private string key;

				private ReadSchedulerxDesignateDetail_Metrics metrics;

				public bool? Offline
				{
					get
					{
						return offline;
					}
					set	
					{
						offline = value;
					}
				}

				public int? Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public string Starter
				{
					get
					{
						return starter;
					}
					set	
					{
						starter = value;
					}
				}

				public string Busy
				{
					get
					{
						return busy;
					}
					set	
					{
						busy = value;
					}
				}

				public bool? _Checked
				{
					get
					{
						return _checked;
					}
					set	
					{
						_checked = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public ReadSchedulerxDesignateDetail_Metrics Metrics
				{
					get
					{
						return metrics;
					}
					set	
					{
						metrics = value;
					}
				}

				public class ReadSchedulerxDesignateDetail_Metrics
				{

					private double? cpuLoad1;

					private double? cpuLoad5;

					private int? cpuProcessors;

					private double? heap1Usage;

					private double? heap5Usage;

					private double? heap1Used;

					private int? heapMax;

					private double? diskUsage;

					private int? diskUsed;

					private int? diskMax;

					private int? sharePoolQueueSize;

					private int? sharePoolAvailableSize;

					private long? execCount;

					public double? CpuLoad1
					{
						get
						{
							return cpuLoad1;
						}
						set	
						{
							cpuLoad1 = value;
						}
					}

					public double? CpuLoad5
					{
						get
						{
							return cpuLoad5;
						}
						set	
						{
							cpuLoad5 = value;
						}
					}

					public int? CpuProcessors
					{
						get
						{
							return cpuProcessors;
						}
						set	
						{
							cpuProcessors = value;
						}
					}

					public double? Heap1Usage
					{
						get
						{
							return heap1Usage;
						}
						set	
						{
							heap1Usage = value;
						}
					}

					public double? Heap5Usage
					{
						get
						{
							return heap5Usage;
						}
						set	
						{
							heap5Usage = value;
						}
					}

					public double? Heap1Used
					{
						get
						{
							return heap1Used;
						}
						set	
						{
							heap1Used = value;
						}
					}

					public int? HeapMax
					{
						get
						{
							return heapMax;
						}
						set	
						{
							heapMax = value;
						}
					}

					public double? DiskUsage
					{
						get
						{
							return diskUsage;
						}
						set	
						{
							diskUsage = value;
						}
					}

					public int? DiskUsed
					{
						get
						{
							return diskUsed;
						}
						set	
						{
							diskUsed = value;
						}
					}

					public int? DiskMax
					{
						get
						{
							return diskMax;
						}
						set	
						{
							diskMax = value;
						}
					}

					public int? SharePoolQueueSize
					{
						get
						{
							return sharePoolQueueSize;
						}
						set	
						{
							sharePoolQueueSize = value;
						}
					}

					public int? SharePoolAvailableSize
					{
						get
						{
							return sharePoolAvailableSize;
						}
						set	
						{
							sharePoolAvailableSize = value;
						}
					}

					public long? ExecCount
					{
						get
						{
							return execCount;
						}
						set	
						{
							execCount = value;
						}
					}
				}
			}
		}

		public class ReadSchedulerxDesignateDetail_AccessDeniedDetail
		{

			private string authAction;

			private string authPrincipalDisplayName;

			private string authPrincipalOwnerId;

			private string authPrincipalType;

			private string encodedDiagnosticMessage;

			private string noPermissionType;

			private string policyType;

			public string AuthAction
			{
				get
				{
					return authAction;
				}
				set	
				{
					authAction = value;
				}
			}

			public string AuthPrincipalDisplayName
			{
				get
				{
					return authPrincipalDisplayName;
				}
				set	
				{
					authPrincipalDisplayName = value;
				}
			}

			public string AuthPrincipalOwnerId
			{
				get
				{
					return authPrincipalOwnerId;
				}
				set	
				{
					authPrincipalOwnerId = value;
				}
			}

			public string AuthPrincipalType
			{
				get
				{
					return authPrincipalType;
				}
				set	
				{
					authPrincipalType = value;
				}
			}

			public string EncodedDiagnosticMessage
			{
				get
				{
					return encodedDiagnosticMessage;
				}
				set	
				{
					encodedDiagnosticMessage = value;
				}
			}

			public string NoPermissionType
			{
				get
				{
					return noPermissionType;
				}
				set	
				{
					noPermissionType = value;
				}
			}

			public string PolicyType
			{
				get
				{
					return policyType;
				}
				set	
				{
					policyType = value;
				}
			}
		}
	}
}
