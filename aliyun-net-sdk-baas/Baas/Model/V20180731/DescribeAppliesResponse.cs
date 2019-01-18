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
	public class DescribeAppliesResponse : AcsResponse
	{

		private string requestId;

		private DescribeApplies_Result result;

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

		public DescribeApplies_Result Result
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

		public class DescribeApplies_Result
		{

			private List<DescribeApplies_ApplyHistoryListItem> applyHistoryList;

			private DescribeApplies_Pagination pagination;

			public List<DescribeApplies_ApplyHistoryListItem> ApplyHistoryList
			{
				get
				{
					return applyHistoryList;
				}
				set	
				{
					applyHistoryList = value;
				}
			}

			public DescribeApplies_Pagination Pagination
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

			public class DescribeApplies_ApplyHistoryListItem
			{

				private int? id;

				private string bizid;

				private string username;

				private string reqAddr;

				private string signedAddr;

				private int? status;

				private string rejectReason;

				private long? createtime;

				private long? updatetime;

				public int? Id
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

				public string Username
				{
					get
					{
						return username;
					}
					set	
					{
						username = value;
					}
				}

				public string ReqAddr
				{
					get
					{
						return reqAddr;
					}
					set	
					{
						reqAddr = value;
					}
				}

				public string SignedAddr
				{
					get
					{
						return signedAddr;
					}
					set	
					{
						signedAddr = value;
					}
				}

				public int? Status
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

				public string RejectReason
				{
					get
					{
						return rejectReason;
					}
					set	
					{
						rejectReason = value;
					}
				}

				public long? Createtime
				{
					get
					{
						return createtime;
					}
					set	
					{
						createtime = value;
					}
				}

				public long? Updatetime
				{
					get
					{
						return updatetime;
					}
					set	
					{
						updatetime = value;
					}
				}
			}

			public class DescribeApplies_Pagination
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