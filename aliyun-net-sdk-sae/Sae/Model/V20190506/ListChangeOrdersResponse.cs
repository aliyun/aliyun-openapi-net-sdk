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
	public class ListChangeOrdersResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private ListChangeOrders_Data data;

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

		public ListChangeOrders_Data Data
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

		public class ListChangeOrders_Data
		{

			private int? currentPage;

			private int? totalSize;

			private int? pageSize;

			private List<ListChangeOrders_ChangeOrder> changeOrderList;

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

			public List<ListChangeOrders_ChangeOrder> ChangeOrderList
			{
				get
				{
					return changeOrderList;
				}
				set	
				{
					changeOrderList = value;
				}
			}

			public class ListChangeOrders_ChangeOrder
			{

				private int? status;

				private string finishTime;

				private string createTime;

				private string userId;

				private string source;

				private int? batchCount;

				private string createUserId;

				private string coTypeCode;

				private string changeOrderId;

				private string batchType;

				private string groupId;

				private string description;

				private string coType;

				private string appId;

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

				public string FinishTime
				{
					get
					{
						return finishTime;
					}
					set	
					{
						finishTime = value;
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

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

				public int? BatchCount
				{
					get
					{
						return batchCount;
					}
					set	
					{
						batchCount = value;
					}
				}

				public string CreateUserId
				{
					get
					{
						return createUserId;
					}
					set	
					{
						createUserId = value;
					}
				}

				public string CoTypeCode
				{
					get
					{
						return coTypeCode;
					}
					set	
					{
						coTypeCode = value;
					}
				}

				public string ChangeOrderId
				{
					get
					{
						return changeOrderId;
					}
					set	
					{
						changeOrderId = value;
					}
				}

				public string BatchType
				{
					get
					{
						return batchType;
					}
					set	
					{
						batchType = value;
					}
				}

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
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

				public string CoType
				{
					get
					{
						return coType;
					}
					set	
					{
						coType = value;
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
			}
		}
	}
}
