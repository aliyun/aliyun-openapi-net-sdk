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
	public class DescribeFlowJobResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private long? gmtCreate;

		private long? gmtModified;

		private string name;

		private string type;

		private string description;

		private string failAct;

		private int? maxRetry;

		private long? retryInterval;

		private string retryPolicy;

		private string _params;

		private string paramConf;

		private string customVariables;

		private string envConf;

		private string runConf;

		private string monitorConf;

		private string categoryId;

		private string mode;

		private string lastInstanceId;

		private string adhoc;

		private string alertConf;

		private string editLockDetail;

		private long? maxRunningTimeSec;

		private List<DescribeFlowJob_Resource> resourceList;

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

		public string FailAct
		{
			get
			{
				return failAct;
			}
			set	
			{
				failAct = value;
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

		public long? RetryInterval
		{
			get
			{
				return retryInterval;
			}
			set	
			{
				retryInterval = value;
			}
		}

		public string RetryPolicy
		{
			get
			{
				return retryPolicy;
			}
			set	
			{
				retryPolicy = value;
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

		public string ParamConf
		{
			get
			{
				return paramConf;
			}
			set	
			{
				paramConf = value;
			}
		}

		public string CustomVariables
		{
			get
			{
				return customVariables;
			}
			set	
			{
				customVariables = value;
			}
		}

		public string EnvConf
		{
			get
			{
				return envConf;
			}
			set	
			{
				envConf = value;
			}
		}

		public string RunConf
		{
			get
			{
				return runConf;
			}
			set	
			{
				runConf = value;
			}
		}

		public string MonitorConf
		{
			get
			{
				return monitorConf;
			}
			set	
			{
				monitorConf = value;
			}
		}

		public string CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
			}
		}

		public string LastInstanceId
		{
			get
			{
				return lastInstanceId;
			}
			set	
			{
				lastInstanceId = value;
			}
		}

		public string Adhoc
		{
			get
			{
				return adhoc;
			}
			set	
			{
				adhoc = value;
			}
		}

		public string AlertConf
		{
			get
			{
				return alertConf;
			}
			set	
			{
				alertConf = value;
			}
		}

		public string EditLockDetail
		{
			get
			{
				return editLockDetail;
			}
			set	
			{
				editLockDetail = value;
			}
		}

		public long? MaxRunningTimeSec
		{
			get
			{
				return maxRunningTimeSec;
			}
			set	
			{
				maxRunningTimeSec = value;
			}
		}

		public List<DescribeFlowJob_Resource> ResourceList
		{
			get
			{
				return resourceList;
			}
			set	
			{
				resourceList = value;
			}
		}

		public class DescribeFlowJob_Resource
		{

			private string path;

			private string alias;

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
				}
			}
		}
	}
}
