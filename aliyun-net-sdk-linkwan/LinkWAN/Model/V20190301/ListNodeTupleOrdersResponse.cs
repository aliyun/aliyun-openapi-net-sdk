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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class ListNodeTupleOrdersResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListNodeTupleOrders_Data data;

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

		public ListNodeTupleOrders_Data Data
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

		public class ListNodeTupleOrders_Data
		{

			private long? totalCount;

			private List<ListNodeTupleOrders_Order> list;

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

			public List<ListNodeTupleOrders_Order> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListNodeTupleOrders_Order
			{

				private string orderId;

				private bool? isKpm;

				private string orderState;

				private long? requiredCount;

				private long? createdMillis;

				private long? acceptedMillis;

				private string loraVersion;

				private long? successCount;

				private long? failedCount;

				private string tupleType;

				public string OrderId
				{
					get
					{
						return orderId;
					}
					set	
					{
						orderId = value;
					}
				}

				public bool? IsKpm
				{
					get
					{
						return isKpm;
					}
					set	
					{
						isKpm = value;
					}
				}

				public string OrderState
				{
					get
					{
						return orderState;
					}
					set	
					{
						orderState = value;
					}
				}

				public long? RequiredCount
				{
					get
					{
						return requiredCount;
					}
					set	
					{
						requiredCount = value;
					}
				}

				public long? CreatedMillis
				{
					get
					{
						return createdMillis;
					}
					set	
					{
						createdMillis = value;
					}
				}

				public long? AcceptedMillis
				{
					get
					{
						return acceptedMillis;
					}
					set	
					{
						acceptedMillis = value;
					}
				}

				public string LoraVersion
				{
					get
					{
						return loraVersion;
					}
					set	
					{
						loraVersion = value;
					}
				}

				public long? SuccessCount
				{
					get
					{
						return successCount;
					}
					set	
					{
						successCount = value;
					}
				}

				public long? FailedCount
				{
					get
					{
						return failedCount;
					}
					set	
					{
						failedCount = value;
					}
				}

				public string TupleType
				{
					get
					{
						return tupleType;
					}
					set	
					{
						tupleType = value;
					}
				}
			}
		}
	}
}
