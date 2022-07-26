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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListInstancePatchStatesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListInstancePatchStates_InstancePatchState> instancePatchStates;

		[JsonProperty(PropertyName = "NextToken")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "InstancePatchStates")]
		public List<ListInstancePatchStates_InstancePatchState> InstancePatchStates
		{
			get
			{
				return instancePatchStates;
			}
			set	
			{
				instancePatchStates = value;
			}
		}

		public class ListInstancePatchStates_InstancePatchState
		{

			private string missingCount;

			private string operationEndTime;

			private string ownerInformation;

			private string installedOtherCount;

			private string instanceId;

			private string operationType;

			private string operationStartTime;

			private string failedCount;

			private string baselineId;

			private string installedPendingRebootCount;

			private string installedRejectedCount;

			private string patchGroup;

			private string installedCount;

			[JsonProperty(PropertyName = "MissingCount")]
			public string MissingCount
			{
				get
				{
					return missingCount;
				}
				set	
				{
					missingCount = value;
				}
			}

			[JsonProperty(PropertyName = "OperationEndTime")]
			public string OperationEndTime
			{
				get
				{
					return operationEndTime;
				}
				set	
				{
					operationEndTime = value;
				}
			}

			[JsonProperty(PropertyName = "OwnerInformation")]
			public string OwnerInformation
			{
				get
				{
					return ownerInformation;
				}
				set	
				{
					ownerInformation = value;
				}
			}

			[JsonProperty(PropertyName = "InstalledOtherCount")]
			public string InstalledOtherCount
			{
				get
				{
					return installedOtherCount;
				}
				set	
				{
					installedOtherCount = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "OperationType")]
			public string OperationType
			{
				get
				{
					return operationType;
				}
				set	
				{
					operationType = value;
				}
			}

			[JsonProperty(PropertyName = "OperationStartTime")]
			public string OperationStartTime
			{
				get
				{
					return operationStartTime;
				}
				set	
				{
					operationStartTime = value;
				}
			}

			[JsonProperty(PropertyName = "FailedCount")]
			public string FailedCount
			{
				get
				{
					return failedCount;
				}
				set	
				{
					failedCount = value;
				}
			}

			[JsonProperty(PropertyName = "BaselineId")]
			public string BaselineId
			{
				get
				{
					return baselineId;
				}
				set	
				{
					baselineId = value;
				}
			}

			[JsonProperty(PropertyName = "InstalledPendingRebootCount")]
			public string InstalledPendingRebootCount
			{
				get
				{
					return installedPendingRebootCount;
				}
				set	
				{
					installedPendingRebootCount = value;
				}
			}

			[JsonProperty(PropertyName = "InstalledRejectedCount")]
			public string InstalledRejectedCount
			{
				get
				{
					return installedRejectedCount;
				}
				set	
				{
					installedRejectedCount = value;
				}
			}

			[JsonProperty(PropertyName = "PatchGroup")]
			public string PatchGroup
			{
				get
				{
					return patchGroup;
				}
				set	
				{
					patchGroup = value;
				}
			}

			[JsonProperty(PropertyName = "InstalledCount")]
			public string InstalledCount
			{
				get
				{
					return installedCount;
				}
				set	
				{
					installedCount = value;
				}
			}
		}
	}
}
