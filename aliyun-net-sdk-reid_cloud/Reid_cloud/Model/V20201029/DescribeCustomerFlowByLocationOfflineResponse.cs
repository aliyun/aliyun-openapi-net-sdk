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

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
	public class DescribeCustomerFlowByLocationOfflineResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string dynamicMessage;

		private string code;

		private bool? success;

		private long? storeId;

		private string summaryDay;

		private string dynamicCode;

		private string errorCode;

		private string errorMessage;

		private List<DescribeCustomerFlowByLocationOffline_CustomerSummaryItem> customerSummary;

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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public long? StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
			}
		}

		public string SummaryDay
		{
			get
			{
				return summaryDay;
			}
			set	
			{
				summaryDay = value;
			}
		}

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public List<DescribeCustomerFlowByLocationOffline_CustomerSummaryItem> CustomerSummary
		{
			get
			{
				return customerSummary;
			}
			set	
			{
				customerSummary = value;
			}
		}

		public class DescribeCustomerFlowByLocationOffline_CustomerSummaryItem
		{

			private long? summaryStartTime;

			private long? summaryEndTime;

			private List<DescribeCustomerFlowByLocationOffline_CustomerFlow> customerFlows;

			public long? SummaryStartTime
			{
				get
				{
					return summaryStartTime;
				}
				set	
				{
					summaryStartTime = value;
				}
			}

			public long? SummaryEndTime
			{
				get
				{
					return summaryEndTime;
				}
				set	
				{
					summaryEndTime = value;
				}
			}

			public List<DescribeCustomerFlowByLocationOffline_CustomerFlow> CustomerFlows
			{
				get
				{
					return customerFlows;
				}
				set	
				{
					customerFlows = value;
				}
			}

			public class DescribeCustomerFlowByLocationOffline_CustomerFlow
			{

				private long? currentLocationId;

				private long? count;

				private List<DescribeCustomerFlowByLocationOffline_CustomerFlowItem> customerFlowItems;

				public long? CurrentLocationId
				{
					get
					{
						return currentLocationId;
					}
					set	
					{
						currentLocationId = value;
					}
				}

				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public List<DescribeCustomerFlowByLocationOffline_CustomerFlowItem> CustomerFlowItems
				{
					get
					{
						return customerFlowItems;
					}
					set	
					{
						customerFlowItems = value;
					}
				}

				public class DescribeCustomerFlowByLocationOffline_CustomerFlowItem
				{

					private long? locationId;

					private List<string> ukId;

					public long? LocationId
					{
						get
						{
							return locationId;
						}
						set	
						{
							locationId = value;
						}
					}

					public List<string> UkId
					{
						get
						{
							return ukId;
						}
						set	
						{
							ukId = value;
						}
					}
				}
			}
		}
	}
}
