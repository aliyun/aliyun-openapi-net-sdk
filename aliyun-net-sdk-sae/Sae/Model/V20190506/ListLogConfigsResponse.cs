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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class ListLogConfigsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private string errorCode;

		private string traceId;

		private ListLogConfigs_Data data;

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

		public string Code
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public ListLogConfigs_Data Data
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

		public class ListLogConfigs_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalSize;

			private List<ListLogConfigs_LogConfig> logConfigs;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public List<ListLogConfigs_LogConfig> LogConfigs
			{
				get
				{
					return logConfigs;
				}
				set	
				{
					logConfigs = value;
				}
			}

			public class ListLogConfigs_LogConfig
			{

				private string configName;

				private string logDir;

				private string slsProject;

				private string slsLogStore;

				private string storeType;

				private string logType;

				private string regionId;

				private string createTime;

				public string ConfigName
				{
					get
					{
						return configName;
					}
					set	
					{
						configName = value;
					}
				}

				public string LogDir
				{
					get
					{
						return logDir;
					}
					set	
					{
						logDir = value;
					}
				}

				public string SlsProject
				{
					get
					{
						return slsProject;
					}
					set	
					{
						slsProject = value;
					}
				}

				public string SlsLogStore
				{
					get
					{
						return slsLogStore;
					}
					set	
					{
						slsLogStore = value;
					}
				}

				public string StoreType
				{
					get
					{
						return storeType;
					}
					set	
					{
						storeType = value;
					}
				}

				public string LogType
				{
					get
					{
						return logType;
					}
					set	
					{
						logType = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
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
}
