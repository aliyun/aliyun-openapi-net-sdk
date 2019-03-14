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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListExecutePlanMigrateInfoResponse : AcsResponse
	{

		private long? total;

		private List<ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo> executePlanMigrateInfoList;

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

		public List<ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo> ExecutePlanMigrateInfoList
		{
			get
			{
				return executePlanMigrateInfoList;
			}
			set	
			{
				executePlanMigrateInfoList = value;
			}
		}

		public class ListExecutePlanMigrateInfo_ExecutePlanMigrateInfo
		{

			private long? id;

			private string bizId;

			private string createTime;

			private string name;

			private long? status;

			private string cronExpr;

			private string startScheduleTime;

			private long? isCycle;

			private string buildClusterCondition;

			private List<ListExecutePlanMigrateInfo_JobInfo> jobList;

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

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
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

			public long? Status
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

			public string CronExpr
			{
				get
				{
					return cronExpr;
				}
				set	
				{
					cronExpr = value;
				}
			}

			public string StartScheduleTime
			{
				get
				{
					return startScheduleTime;
				}
				set	
				{
					startScheduleTime = value;
				}
			}

			public long? IsCycle
			{
				get
				{
					return isCycle;
				}
				set	
				{
					isCycle = value;
				}
			}

			public string BuildClusterCondition
			{
				get
				{
					return buildClusterCondition;
				}
				set	
				{
					buildClusterCondition = value;
				}
			}

			public List<ListExecutePlanMigrateInfo_JobInfo> JobList
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

			public class ListExecutePlanMigrateInfo_JobInfo
			{

				private string clusterId;

				private string jobId;

				private string description;

				private long? indexNO;

				private long? status;

				public string ClusterId
				{
					get
					{
						return clusterId;
					}
					set	
					{
						clusterId = value;
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

				public long? IndexNO
				{
					get
					{
						return indexNO;
					}
					set	
					{
						indexNO = value;
					}
				}

				public long? Status
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
			}
		}
	}
}
