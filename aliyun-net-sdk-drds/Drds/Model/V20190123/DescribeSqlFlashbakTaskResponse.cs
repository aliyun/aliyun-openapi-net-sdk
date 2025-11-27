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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeSqlFlashbakTaskResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<DescribeSqlFlashbakTask_SqlFlashbackTask> sqlFlashbackTasks;

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

		public List<DescribeSqlFlashbakTask_SqlFlashbackTask> SqlFlashbackTasks
		{
			get
			{
				return sqlFlashbackTasks;
			}
			set	
			{
				sqlFlashbackTasks = value;
			}
		}

		public class DescribeSqlFlashbakTask_SqlFlashbackTask
		{

			private string tableName;

			private long? searchEndTime;

			private long? expireTime;

			private string downloadUrl;

			private int? recallProgress;

			private string sqlPk;

			private string instId;

			private int? recallType;

			private long? searchStartTime;

			private long? gmtModified;

			private long? sqlCounter;

			private string dbName;

			private int? recallRestoreType;

			private long? gmtCreate;

			private string traceId;

			private long? id;

			private int? recallStatus;

			private string sqlType;

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}

			public long? SearchEndTime
			{
				get
				{
					return searchEndTime;
				}
				set	
				{
					searchEndTime = value;
				}
			}

			public long? ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string DownloadUrl
			{
				get
				{
					return downloadUrl;
				}
				set	
				{
					downloadUrl = value;
				}
			}

			public int? RecallProgress
			{
				get
				{
					return recallProgress;
				}
				set	
				{
					recallProgress = value;
				}
			}

			public string SqlPk
			{
				get
				{
					return sqlPk;
				}
				set	
				{
					sqlPk = value;
				}
			}

			public string InstId
			{
				get
				{
					return instId;
				}
				set	
				{
					instId = value;
				}
			}

			public int? RecallType
			{
				get
				{
					return recallType;
				}
				set	
				{
					recallType = value;
				}
			}

			public long? SearchStartTime
			{
				get
				{
					return searchStartTime;
				}
				set	
				{
					searchStartTime = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public long? SqlCounter
			{
				get
				{
					return sqlCounter;
				}
				set	
				{
					sqlCounter = value;
				}
			}

			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			public int? RecallRestoreType
			{
				get
				{
					return recallRestoreType;
				}
				set	
				{
					recallRestoreType = value;
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

			public string TraceId
			{
				get
				{
					return traceId;
				}
				set	
				{
					traceId = value;
				}
			}

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

			public int? RecallStatus
			{
				get
				{
					return recallStatus;
				}
				set	
				{
					recallStatus = value;
				}
			}

			public string SqlType
			{
				get
				{
					return sqlType;
				}
				set	
				{
					sqlType = value;
				}
			}
		}
	}
}
