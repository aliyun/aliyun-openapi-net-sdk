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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class ListJobsResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string errorCode;

		private string code;

		private bool? success;

		private int? currentPage;

		private int? totalSize;

		private int? pageSize;

		private ListJobs_Data data;

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

		public ListJobs_Data Data
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

		public class ListJobs_Data
		{

			private int? currentPage;

			private int? totalSize;

			private int? pageSize;

			private List<ListJobs_Application> applications;

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

			public List<ListJobs_Application> Applications
			{
				get
				{
					return applications;
				}
				set	
				{
					applications = value;
				}
			}

			public class ListJobs_Application
			{

				private string appName;

				private string namespaceId;

				private bool? appDeletingStatus;

				private string appId;

				private bool? scaleRuleEnabled;

				private string scaleRuleType;

				private int? runningInstances;

				private int? instances;

				private string regionId;

				private string appDescription;

				private string triggerConfig;

				private bool? suspend;

				private long? active;

				private long? succeeded;

				private long? failed;

				private long? lastStartTime;

				private long? completionTime;

				private string lastChangeorderState;

				private string lastJobState;

				private int? cpu;

				private int? mem;

				private string message;

				private List<ListJobs_TagsItem> tags;

				public string AppName
				{
					get
					{
						return appName;
					}
					set	
					{
						appName = value;
					}
				}

				public string NamespaceId
				{
					get
					{
						return namespaceId;
					}
					set	
					{
						namespaceId = value;
					}
				}

				public bool? AppDeletingStatus
				{
					get
					{
						return appDeletingStatus;
					}
					set	
					{
						appDeletingStatus = value;
					}
				}

				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}

				public bool? ScaleRuleEnabled
				{
					get
					{
						return scaleRuleEnabled;
					}
					set	
					{
						scaleRuleEnabled = value;
					}
				}

				public string ScaleRuleType
				{
					get
					{
						return scaleRuleType;
					}
					set	
					{
						scaleRuleType = value;
					}
				}

				public int? RunningInstances
				{
					get
					{
						return runningInstances;
					}
					set	
					{
						runningInstances = value;
					}
				}

				public int? Instances
				{
					get
					{
						return instances;
					}
					set	
					{
						instances = value;
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

				public string AppDescription
				{
					get
					{
						return appDescription;
					}
					set	
					{
						appDescription = value;
					}
				}

				public string TriggerConfig
				{
					get
					{
						return triggerConfig;
					}
					set	
					{
						triggerConfig = value;
					}
				}

				public bool? Suspend
				{
					get
					{
						return suspend;
					}
					set	
					{
						suspend = value;
					}
				}

				public long? Active
				{
					get
					{
						return active;
					}
					set	
					{
						active = value;
					}
				}

				public long? Succeeded
				{
					get
					{
						return succeeded;
					}
					set	
					{
						succeeded = value;
					}
				}

				public long? Failed
				{
					get
					{
						return failed;
					}
					set	
					{
						failed = value;
					}
				}

				public long? LastStartTime
				{
					get
					{
						return lastStartTime;
					}
					set	
					{
						lastStartTime = value;
					}
				}

				public long? CompletionTime
				{
					get
					{
						return completionTime;
					}
					set	
					{
						completionTime = value;
					}
				}

				public string LastChangeorderState
				{
					get
					{
						return lastChangeorderState;
					}
					set	
					{
						lastChangeorderState = value;
					}
				}

				public string LastJobState
				{
					get
					{
						return lastJobState;
					}
					set	
					{
						lastJobState = value;
					}
				}

				public int? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public int? Mem
				{
					get
					{
						return mem;
					}
					set	
					{
						mem = value;
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

				public List<ListJobs_TagsItem> Tags
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

				public class ListJobs_TagsItem
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
