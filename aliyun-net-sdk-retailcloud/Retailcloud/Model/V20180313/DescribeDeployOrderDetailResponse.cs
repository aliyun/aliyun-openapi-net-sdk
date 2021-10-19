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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribeDeployOrderDetailResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private DescribeDeployOrderDetail_Result result;

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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public DescribeDeployOrderDetail_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeDeployOrderDetail_Result
		{

			private int? status;

			private string appInstanceType;

			private string deployType;

			private string userId;

			private string partitionTypeName;

			private string statusName;

			private string envType;

			private int? totalAppInstanceCt;

			private int? elapsedTime;

			private string description;

			private string name;

			private string deployTypeName;

			private int? finishAppInstanceCt;

			private long? schemaId;

			private string deployPauseType;

			private int? result;

			private string failureRate;

			private int? totalPartitions;

			private string userNick;

			private string endTime;

			private string startTime;

			private long? deployOrderId;

			private string deployPauseTypeName;

			private string resultName;

			private int? currentPartitionNum;

			private string partitionType;

			private long? envId;

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

			public string AppInstanceType
			{
				get
				{
					return appInstanceType;
				}
				set	
				{
					appInstanceType = value;
				}
			}

			public string DeployType
			{
				get
				{
					return deployType;
				}
				set	
				{
					deployType = value;
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

			public string PartitionTypeName
			{
				get
				{
					return partitionTypeName;
				}
				set	
				{
					partitionTypeName = value;
				}
			}

			public string StatusName
			{
				get
				{
					return statusName;
				}
				set	
				{
					statusName = value;
				}
			}

			public string EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
				}
			}

			public int? TotalAppInstanceCt
			{
				get
				{
					return totalAppInstanceCt;
				}
				set	
				{
					totalAppInstanceCt = value;
				}
			}

			public int? ElapsedTime
			{
				get
				{
					return elapsedTime;
				}
				set	
				{
					elapsedTime = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string DeployTypeName
			{
				get
				{
					return deployTypeName;
				}
				set	
				{
					deployTypeName = value;
				}
			}

			public int? FinishAppInstanceCt
			{
				get
				{
					return finishAppInstanceCt;
				}
				set	
				{
					finishAppInstanceCt = value;
				}
			}

			public long? SchemaId
			{
				get
				{
					return schemaId;
				}
				set	
				{
					schemaId = value;
				}
			}

			public string DeployPauseType
			{
				get
				{
					return deployPauseType;
				}
				set	
				{
					deployPauseType = value;
				}
			}

			public int? Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public string FailureRate
			{
				get
				{
					return failureRate;
				}
				set	
				{
					failureRate = value;
				}
			}

			public int? TotalPartitions
			{
				get
				{
					return totalPartitions;
				}
				set	
				{
					totalPartitions = value;
				}
			}

			public string UserNick
			{
				get
				{
					return userNick;
				}
				set	
				{
					userNick = value;
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

			public long? DeployOrderId
			{
				get
				{
					return deployOrderId;
				}
				set	
				{
					deployOrderId = value;
				}
			}

			public string DeployPauseTypeName
			{
				get
				{
					return deployPauseTypeName;
				}
				set	
				{
					deployPauseTypeName = value;
				}
			}

			public string ResultName
			{
				get
				{
					return resultName;
				}
				set	
				{
					resultName = value;
				}
			}

			public int? CurrentPartitionNum
			{
				get
				{
					return currentPartitionNum;
				}
				set	
				{
					currentPartitionNum = value;
				}
			}

			public string PartitionType
			{
				get
				{
					return partitionType;
				}
				set	
				{
					partitionType = value;
				}
			}

			public long? EnvId
			{
				get
				{
					return envId;
				}
				set	
				{
					envId = value;
				}
			}
		}
	}
}
