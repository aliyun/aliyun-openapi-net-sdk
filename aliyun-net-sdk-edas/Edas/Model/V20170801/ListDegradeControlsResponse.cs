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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListDegradeControlsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListDegradeControls_FlowControlsMap flowControlsMap;

		public int? Code
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

		public ListDegradeControls_FlowControlsMap FlowControlsMap
		{
			get
			{
				return flowControlsMap;
			}
			set	
			{
				flowControlsMap = value;
			}
		}

		public class ListDegradeControls_FlowControlsMap
		{

			private string appId;

			private string appName;

			private List<ListDegradeControls_InterfaceMethod> interfaceMethods;

			private ListDegradeControls_RuleList ruleList;

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

			public List<ListDegradeControls_InterfaceMethod> InterfaceMethods
			{
				get
				{
					return interfaceMethods;
				}
				set	
				{
					interfaceMethods = value;
				}
			}

			public ListDegradeControls_RuleList RuleList
			{
				get
				{
					return ruleList;
				}
				set	
				{
					ruleList = value;
				}
			}

			public class ListDegradeControls_InterfaceMethod
			{

				private string name;

				private string version;

				private List<string> methods;

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

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public List<string> Methods
				{
					get
					{
						return methods;
					}
					set	
					{
						methods = value;
					}
				}
			}

			public class ListDegradeControls_RuleList
			{

				private int? currentPage;

				private int? pageSize;

				private int? totalSize;

				private List<ListDegradeControls_Rule> ruleResultList;

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

				public List<ListDegradeControls_Rule> RuleResultList
				{
					get
					{
						return ruleResultList;
					}
					set	
					{
						ruleResultList = value;
					}
				}

				public class ListDegradeControls_Rule
				{

					private string appId;

					private string ruleId;

					private long? createTime;

					private long? updateTime;

					private string resource;

					private int? rtThreshold;

					private int? duration;

					private int? state;

					private string ruleType;

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

					public string RuleId
					{
						get
						{
							return ruleId;
						}
						set	
						{
							ruleId = value;
						}
					}

					public long? CreateTime
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

					public long? UpdateTime
					{
						get
						{
							return updateTime;
						}
						set	
						{
							updateTime = value;
						}
					}

					public string Resource
					{
						get
						{
							return resource;
						}
						set	
						{
							resource = value;
						}
					}

					public int? RtThreshold
					{
						get
						{
							return rtThreshold;
						}
						set	
						{
							rtThreshold = value;
						}
					}

					public int? Duration
					{
						get
						{
							return duration;
						}
						set	
						{
							duration = value;
						}
					}

					public int? State
					{
						get
						{
							return state;
						}
						set	
						{
							state = value;
						}
					}

					public string RuleType
					{
						get
						{
							return ruleType;
						}
						set	
						{
							ruleType = value;
						}
					}
				}
			}
		}
	}
}
