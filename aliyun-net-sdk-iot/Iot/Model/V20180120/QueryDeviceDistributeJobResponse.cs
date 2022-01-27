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
	public class QueryDeviceDistributeJobResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryDeviceDistributeJob_Data data;

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

		public QueryDeviceDistributeJob_Data Data
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

		public class QueryDeviceDistributeJob_Data
		{

			private string sourceUid;

			private string targetUid;

			private string sourceInstanceId;

			private string jobId;

			private string productKey;

			private int? total;

			private int? status;

			private long? gmtCreate;

			private int? strategy;

			private List<QueryDeviceDistributeJob_TargetInstanceConfigsItem> targetInstanceConfigs;

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

			public List<QueryDeviceDistributeJob_TargetInstanceConfigsItem> TargetInstanceConfigs
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

			public class QueryDeviceDistributeJob_TargetInstanceConfigsItem
			{

				private string targetInstanceId;

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
			}
		}
	}
}
