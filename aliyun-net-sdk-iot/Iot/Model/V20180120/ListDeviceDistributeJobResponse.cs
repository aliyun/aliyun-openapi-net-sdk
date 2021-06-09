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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class ListDeviceDistributeJobResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private ListDeviceDistributeJob_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public ListDeviceDistributeJob_Data Data
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

		public class ListDeviceDistributeJob_Data
		{

			private int? total;

			private string nextToken;

			private List<ListDeviceDistributeJob_Items> jobInfo;

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

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public List<ListDeviceDistributeJob_Items> JobInfo
			{
				get
				{
					return jobInfo;
				}
				set	
				{
					jobInfo = value;
				}
			}

			public class ListDeviceDistributeJob_Items
			{

				private long? gmtCreate;

				private string sourceUid;

				private string targetUid;

				private string jobId;

				private string sourceInstanceId;

				private string productKey;

				private int? total;

				private int? status;

				private int? strategy;

				private string sourceRegion;

				private string sourceInstanceName;

				private List<ListDeviceDistributeJob_TargetInstanceConfigsItem> targetInstanceConfigs;

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string SourceUid
				{
					get
					{
						return sourceUid;
					}
					set	
					{
						sourceUid = value;
					}
				}

				public string TargetUid
				{
					get
					{
						return targetUid;
					}
					set	
					{
						targetUid = value;
					}
				}

				public string JobId
				{
					get
					{
						return jobId;
					}
					set	
					{
						jobId = value;
					}
				}

				public string SourceInstanceId
				{
					get
					{
						return sourceInstanceId;
					}
					set	
					{
						sourceInstanceId = value;
					}
				}

				public string ProductKey
				{
					get
					{
						return productKey;
					}
					set	
					{
						productKey = value;
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

				public int? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public int? Strategy
				{
					get
					{
						return strategy;
					}
					set	
					{
						strategy = value;
					}
				}

				public string SourceRegion
				{
					get
					{
						return sourceRegion;
					}
					set	
					{
						sourceRegion = value;
					}
				}

				public string SourceInstanceName
				{
					get
					{
						return sourceInstanceName;
					}
					set	
					{
						sourceInstanceName = value;
					}
				}

				public List<ListDeviceDistributeJob_TargetInstanceConfigsItem> TargetInstanceConfigs
				{
					get
					{
						return targetInstanceConfigs;
					}
					set	
					{
						targetInstanceConfigs = value;
					}
				}

				public class ListDeviceDistributeJob_TargetInstanceConfigsItem
				{

					private string targetInstanceId;

					private string targetRegion;

					private string targetInstanceName;

					public string TargetInstanceId
					{
						get
						{
							return targetInstanceId;
						}
						set	
						{
							targetInstanceId = value;
						}
					}

					public string TargetRegion
					{
						get
						{
							return targetRegion;
						}
						set	
						{
							targetRegion = value;
						}
					}

					public string TargetInstanceName
					{
						get
						{
							return targetInstanceName;
						}
						set	
						{
							targetInstanceName = value;
						}
					}
				}
			}
		}
	}
}
