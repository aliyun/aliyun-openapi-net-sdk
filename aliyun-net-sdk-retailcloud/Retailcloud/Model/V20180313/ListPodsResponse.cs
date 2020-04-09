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
	public class ListPodsResponse : AcsResponse
	{

		private int? code;

		private string errorMsg;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private long? totalCount;

		private List<ListPods_PodDetail> data;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public int? PageSize
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

		public List<ListPods_PodDetail> Data
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

		public class ListPods_PodDetail
		{

			private string appInstanceId;

			private long? deployOrderId;

			private int? deployPartitionNum;

			private string groupName;

			private string hostIp;

			private string hostName;

			private string podIp;

			private string region;

			private int? result;

			private string resultName;

			private string startTime;

			private int? status;

			private string statusName;

			private string updateTime;

			private List<ListPods_DeployStep> deploySteps;

			public string AppInstanceId
			{
				get
				{
					return appInstanceId;
				}
				set	
				{
					appInstanceId = value;
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

			public int? DeployPartitionNum
			{
				get
				{
					return deployPartitionNum;
				}
				set	
				{
					deployPartitionNum = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string HostIp
			{
				get
				{
					return hostIp;
				}
				set	
				{
					hostIp = value;
				}
			}

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			public string PodIp
			{
				get
				{
					return podIp;
				}
				set	
				{
					podIp = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
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

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public List<ListPods_DeployStep> DeploySteps
			{
				get
				{
					return deploySteps;
				}
				set	
				{
					deploySteps = value;
				}
			}

			public class ListPods_DeployStep
			{

				private string status;

				private string stepCode;

				private string stepName;

				public string Status
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

				public string StepCode
				{
					get
					{
						return stepCode;
					}
					set	
					{
						stepCode = value;
					}
				}

				public string StepName
				{
					get
					{
						return stepName;
					}
					set	
					{
						stepName = value;
					}
				}
			}
		}
	}
}
