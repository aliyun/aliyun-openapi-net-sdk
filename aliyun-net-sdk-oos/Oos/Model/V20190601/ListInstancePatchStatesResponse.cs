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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListInstancePatchStatesResponse : AcsResponse
	{

		private int? maxResults;

		private string nextToken;

		private string requestId;

		private List<ListInstancePatchStates_InstancePatchState> instancePatchStates;

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

			private string instanceId;

			private string patchGroup;

			private string baselineId;

			private string ownerInformation;

			private string installedCount;

			private string installedOtherCount;

			private string installedPendingRebootCount;

			private string installedRejectedCount;

			private string missingCount;

			private string failedCount;

			private string operationType;

			private string operationStartTime;

			private string operationEndTime;

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
		}
	}
}
