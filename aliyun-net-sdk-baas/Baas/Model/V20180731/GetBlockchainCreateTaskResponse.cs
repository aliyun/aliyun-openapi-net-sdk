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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class GetBlockchainCreateTaskResponse : AcsResponse
	{

		private string requestId;

		private GetBlockchainCreateTask_Result result;

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

		public GetBlockchainCreateTask_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetBlockchainCreateTask_Result
		{

			private List<GetBlockchainCreateTask_BlockchainCreateTasksItem> blockchainCreateTasks;

			private GetBlockchainCreateTask_Pagination pagination;

			public List<GetBlockchainCreateTask_BlockchainCreateTasksItem> BlockchainCreateTasks
			{
				get
				{
					return blockchainCreateTasks;
				}
				set	
				{
					blockchainCreateTasks = value;
				}
			}

			public GetBlockchainCreateTask_Pagination Pagination
			{
				get
				{
					return pagination;
				}
				set	
				{
					pagination = value;
				}
			}

			public class GetBlockchainCreateTask_BlockchainCreateTasksItem
			{

				private string bizid;

				private string name;

				private string status;

				private string memo;

				private long? createTime;

				public string Bizid
				{
					get
					{
						return bizid;
					}
					set	
					{
						bizid = value;
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

				public string Status
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

				public string Memo
				{
					get
					{
						return memo;
					}
					set	
					{
						memo = value;
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
			}

			public class GetBlockchainCreateTask_Pagination
			{

				private int? pageSize;

				private int? current;

				private int? total;

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

				public int? Current
				{
					get
					{
						return current;
					}
					set	
					{
						current = value;
					}
				}

				public int? Total
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
			}
		}
	}
}