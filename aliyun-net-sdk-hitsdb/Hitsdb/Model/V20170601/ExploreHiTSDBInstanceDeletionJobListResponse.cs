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

namespace Aliyun.Acs.hitsdb.Model.V20170601
{
	public class ExploreHiTSDBInstanceDeletionJobListResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private long? total;

		private List<ExploreHiTSDBInstanceDeletionJobList_JobItem> jobList;

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

		public List<ExploreHiTSDBInstanceDeletionJobList_JobItem> JobList
		{
			get
			{
				return jobList;
			}
			set	
			{
				jobList = value;
			}
		}

		public class ExploreHiTSDBInstanceDeletionJobList_JobItem
		{

			private long? id;

			private string instanceId;

			private string ip;

			private int? port;

			private string metric;

			private string tags;

			private long? startTime;

			private long? endTime;

			private string status;

			private string jobTyp;

			private long? jobCreationTime;

			private long? jobStartTime;

			private long? jobEndTime;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

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

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string Metric
			{
				get
				{
					return metric;
				}
				set	
				{
					metric = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public long? StartTime
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

			public long? EndTime
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

			public string JobTyp
			{
				get
				{
					return jobTyp;
				}
				set	
				{
					jobTyp = value;
				}
			}

			public long? JobCreationTime
			{
				get
				{
					return jobCreationTime;
				}
				set	
				{
					jobCreationTime = value;
				}
			}

			public long? JobStartTime
			{
				get
				{
					return jobStartTime;
				}
				set	
				{
					jobStartTime = value;
				}
			}

			public long? JobEndTime
			{
				get
				{
					return jobEndTime;
				}
				set	
				{
					jobEndTime = value;
				}
			}
		}
	}
}
