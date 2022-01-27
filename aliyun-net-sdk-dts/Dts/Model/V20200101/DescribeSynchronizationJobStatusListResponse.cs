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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeSynchronizationJobStatusListResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private int? pageNumber;

		private int? pageRecordCount;

		private string requestId;

		private string success;

		private long? totalRecordCount;

		private List<DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo> synchronizationJobListStatusList;

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
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

		public string Success
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

		public long? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public List<DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo> SynchronizationJobListStatusList
		{
			get
			{
				return synchronizationJobListStatusList;
			}
			set	
			{
				synchronizationJobListStatusList = value;
			}
		}

		public class DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo
		{

			private string synchronizationJobId;

			private List<DescribeSynchronizationJobStatusList_SynchronizationDirectionInfo> synchronizationDirectionInfoList;

			public string SynchronizationJobId
			{
				get
				{
					return synchronizationJobId;
				}
				set	
				{
					synchronizationJobId = value;
				}
			}

			public List<DescribeSynchronizationJobStatusList_SynchronizationDirectionInfo> SynchronizationDirectionInfoList
			{
				get
				{
					return synchronizationDirectionInfoList;
				}
				set	
				{
					synchronizationDirectionInfoList = value;
				}
			}

			public class DescribeSynchronizationJobStatusList_SynchronizationDirectionInfo
			{

				private string checkpoint;

				private string status;

				private string synchronizationDirection;

				public string Checkpoint
				{
					get
					{
						return checkpoint;
					}
					set	
					{
						checkpoint = value;
					}
				}

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

				public string SynchronizationDirection
				{
					get
					{
						return synchronizationDirection;
					}
					set	
					{
						synchronizationDirection = value;
					}
				}
			}
		}
	}
}
