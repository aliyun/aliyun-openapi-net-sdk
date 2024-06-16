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
	public class DescribeDisposeAndPlaybookResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeDisposeAndPlaybook_Data data;

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

		public DescribeDisposeAndPlaybook_Data Data
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

		public class DescribeDisposeAndPlaybook_Data
		{

			private List<DescribeDisposeAndPlaybook_ResponseDataItem> responseData;

			private DescribeDisposeAndPlaybook_PageInfo pageInfo;

			public List<DescribeDisposeAndPlaybook_ResponseDataItem> ResponseData
			{
				get
				{
					return responseData;
				}
				set	
				{
					responseData = value;
				}
			}

			public DescribeDisposeAndPlaybook_PageInfo PageInfo
			{
				get
				{
					return pageInfo;
				}
				set	
				{
					pageInfo = value;
				}
			}

			public class DescribeDisposeAndPlaybook_ResponseDataItem
			{

				private long? entityId;

				private string opcodeMap;

				private string entityInfo;

				private string dispose;

				private int? alertNum;

				private List<DescribeDisposeAndPlaybook_PlaybookListItem> playbookList;

				private List<string> opcodeSet;

				private List<string> scope;

				public long? EntityId
				{
					get
					{
						return entityId;
					}
					set	
					{
						entityId = value;
					}
				}

				public string OpcodeMap
				{
					get
					{
						return opcodeMap;
					}
					set	
					{
						opcodeMap = value;
					}
				}

				public string EntityInfo
				{
					get
					{
						return entityInfo;
					}
					set	
					{
						entityInfo = value;
					}
				}

				public string Dispose
				{
					get
					{
						return dispose;
					}
					set	
					{
						dispose = value;
					}
				}

				public int? AlertNum
				{
					get
					{
						return alertNum;
					}
					set	
					{
						alertNum = value;
					}
				}

				public List<DescribeDisposeAndPlaybook_PlaybookListItem> PlaybookList
				{
					get
					{
						return playbookList;
					}
					set	
					{
						playbookList = value;
					}
				}

				public List<string> OpcodeSet
				{
					get
					{
						return opcodeSet;
					}
					set	
					{
						opcodeSet = value;
					}
				}

				public List<string> Scope
				{
					get
					{
						return scope;
					}
					set	
					{
						scope = value;
					}
				}

				public class DescribeDisposeAndPlaybook_PlaybookListItem
				{

					private string opCode;

					private string opLevel;

					private string description;

					private string displayName;

					private string taskConfig;

					private string name;

					private bool? wafPlaybook;

					public string OpCode
					{
						get
						{
							return opCode;
						}
						set	
						{
							opCode = value;
						}
					}

					public string OpLevel
					{
						get
						{
							return opLevel;
						}
						set	
						{
							opLevel = value;
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

					public string DisplayName
					{
						get
						{
							return displayName;
						}
						set	
						{
							displayName = value;
						}
					}

					public string TaskConfig
					{
						get
						{
							return taskConfig;
						}
						set	
						{
							taskConfig = value;
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

					public bool? WafPlaybook
					{
						get
						{
							return wafPlaybook;
						}
						set	
						{
							wafPlaybook = value;
						}
					}
				}
			}

			public class DescribeDisposeAndPlaybook_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private long? totalCount;

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

				public long? TotalCount
				{
					get
					{
						return totalCount;
					}
					set	
					{
						totalCount = value;
					}
				}
			}
		}
	}
}
