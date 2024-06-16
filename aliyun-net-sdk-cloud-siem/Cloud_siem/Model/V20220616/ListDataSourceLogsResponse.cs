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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListDataSourceLogsResponse : AcsResponse
	{

		private string requestId;

		private ListDataSourceLogs_Data data;

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

		public ListDataSourceLogs_Data Data
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

		public class ListDataSourceLogs_Data
		{

			private long? subUserId;

			private string dataSourceInstanceId;

			private string dataSourceInstanceName;

			private string dataSourceInstanceRemark;

			private string accountId;

			private string cloudCode;

			private List<ListDataSourceLogs_DataSourceInstanceLog> dataSourceInstanceLogs;

			public long? SubUserId
			{
				get
				{
					return subUserId;
				}
				set	
				{
					subUserId = value;
				}
			}

			public string DataSourceInstanceId
			{
				get
				{
					return dataSourceInstanceId;
				}
				set	
				{
					dataSourceInstanceId = value;
				}
			}

			public string DataSourceInstanceName
			{
				get
				{
					return dataSourceInstanceName;
				}
				set	
				{
					dataSourceInstanceName = value;
				}
			}

			public string DataSourceInstanceRemark
			{
				get
				{
					return dataSourceInstanceRemark;
				}
				set	
				{
					dataSourceInstanceRemark = value;
				}
			}

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public string CloudCode
			{
				get
				{
					return cloudCode;
				}
				set	
				{
					cloudCode = value;
				}
			}

			public List<ListDataSourceLogs_DataSourceInstanceLog> DataSourceInstanceLogs
			{
				get
				{
					return dataSourceInstanceLogs;
				}
				set	
				{
					dataSourceInstanceLogs = value;
				}
			}

			public class ListDataSourceLogs_DataSourceInstanceLog
			{

				private string logInstanceId;

				private string logCode;

				private string logMdsCode;

				private int? taskStatus;

				private List<ListDataSourceLogs_LogParam> logParams;

				public string LogInstanceId
				{
					get
					{
						return logInstanceId;
					}
					set	
					{
						logInstanceId = value;
					}
				}

				public string LogCode
				{
					get
					{
						return logCode;
					}
					set	
					{
						logCode = value;
					}
				}

				public string LogMdsCode
				{
					get
					{
						return logMdsCode;
					}
					set	
					{
						logMdsCode = value;
					}
				}

				public int? TaskStatus
				{
					get
					{
						return taskStatus;
					}
					set	
					{
						taskStatus = value;
					}
				}

				public List<ListDataSourceLogs_LogParam> LogParams
				{
					get
					{
						return logParams;
					}
					set	
					{
						logParams = value;
					}
				}

				public class ListDataSourceLogs_LogParam
				{

					private string paraCode;

					private string paraValue;

					public string ParaCode
					{
						get
						{
							return paraCode;
						}
						set	
						{
							paraCode = value;
						}
					}

					public string ParaValue
					{
						get
						{
							return paraValue;
						}
						set	
						{
							paraValue = value;
						}
					}
				}
			}
		}
	}
}
