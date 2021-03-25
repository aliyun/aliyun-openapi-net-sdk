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
	public class ListApplicationsResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string errorCode;

		private string code;

		private bool? success;

		private ListApplications_Data data;

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

		public ListApplications_Data Data
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

		public class ListApplications_Data
		{

			private int? pageSize;

			private int? currentPage;

			private int? totalSize;

			private List<ListApplications_Application> applications;

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

			public List<ListApplications_Application> Applications
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

			public class ListApplications_Application
			{

				private int? instances;

				private bool? scaleRuleEnabled;

				private string appDescription;

				private string appId;

				private int? runningInstances;

				private string regionId;

				private string namespaceId;

				private string scaleRuleType;

				private bool? appDeletingStatus;

				private string appName;

				private List<ListApplications_TagsItem> tags;

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

				public List<ListApplications_TagsItem> Tags
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

				public class ListApplications_TagsItem
				{

					private string _value;

					private string key;

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
				}
			}
		}
	}
}
