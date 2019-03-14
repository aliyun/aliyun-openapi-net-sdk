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
	public class ListJobMigrateInfoResponse : AcsResponse
	{

		private long? total;

		private List<ListJobMigrateInfo_JobMigrateInfo> jobMigrateInfoList;

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

		public List<ListJobMigrateInfo_JobMigrateInfo> JobMigrateInfoList
		{
			get
			{
				return jobMigrateInfoList;
			}
			set	
			{
				jobMigrateInfoList = value;
			}
		}

		public class ListJobMigrateInfo_JobMigrateInfo
		{

			private string id;

			private string name;

			private string type;

			private int? maxRetry;

			private string failedAction;

			private string _params;

			private string newId;

			private string premigratedDate;

			private string migratedDate;

			private string createTime;

			public string Id
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? MaxRetry
			{
				get
				{
					return maxRetry;
				}
				set	
				{
					maxRetry = value;
				}
			}

			public string FailedAction
			{
				get
				{
					return failedAction;
				}
				set	
				{
					failedAction = value;
				}
			}

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}

			public string NewId
			{
				get
				{
					return newId;
				}
				set	
				{
					newId = value;
				}
			}

			public string PremigratedDate
			{
				get
				{
					return premigratedDate;
				}
				set	
				{
					premigratedDate = value;
				}
			}

			public string MigratedDate
			{
				get
				{
					return migratedDate;
				}
				set	
				{
					migratedDate = value;
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
		}
	}
}
