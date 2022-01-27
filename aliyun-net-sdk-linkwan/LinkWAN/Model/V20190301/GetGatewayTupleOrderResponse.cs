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
	public class GetGatewayTupleOrderResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetGatewayTupleOrder_Data data;

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

		public GetGatewayTupleOrder_Data Data
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

		public class GetGatewayTupleOrder_Data
		{

			private string orderId;

			private string orderState;

			private long? requiredCount;

			private long? createdMillis;

			private long? acceptedMillis;

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
		}
	}
}
