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
	public class ListNamespaceChangeOrdersResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string errorCode;

		private string traceId;

		private bool? success;

		private ListNamespaceChangeOrders_Data data;

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

		public ListNamespaceChangeOrders_Data Data
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

		public class ListNamespaceChangeOrders_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalSize;

			private List<ListNamespaceChangeOrders_ChangeOrder> changeOrderList;

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

			public List<ListNamespaceChangeOrders_ChangeOrder> ChangeOrderList
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

			public class ListNamespaceChangeOrders_ChangeOrder
			{

				private string namespaceId;

				private int? batchCount;

				private string batchType;

				private string changeOrderId;

				private string coType;

				private string coTypeCode;

				private string createTime;

				private string description;

				private string finishTime;

				private string groupId;

				private string pipelines;

				private string source;

				private int? status;

				private string createUserId;

				private string userId;

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

				public string Pipelines
				{
					get
					{
						return pipelines;
					}
					set	
					{
						pipelines = value;
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
			}
		}
	}
}
