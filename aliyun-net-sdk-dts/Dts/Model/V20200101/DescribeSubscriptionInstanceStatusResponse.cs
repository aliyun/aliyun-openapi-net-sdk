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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeSubscriptionInstanceStatusResponse : AcsResponse
	{

		private string beginTimestamp;

		private string consumptionCheckpoint;

		private string consumptionClient;

		private string endTimestamp;

		private string errMessage;

		private string payType;

		private string requestId;

		private string status;

		private string subscribeTopic;

		private string subscriptionInstanceID;

		private string subscriptionInstanceName;

		private string errCode;

		private string success;

		private string errorMessage;

		private string taskId;

		private List<DescribeSubscriptionInstanceStatus_SynchronousObject> subscriptionObject;

		private DescribeSubscriptionInstanceStatus_SourceEndpoint sourceEndpoint;

		private DescribeSubscriptionInstanceStatus_SubscriptionDataType subscriptionDataType;

		private DescribeSubscriptionInstanceStatus_SubscriptionHost subscriptionHost;

		public string BeginTimestamp
		{
			get
			{
				return beginTimestamp;
			}
			set	
			{
				beginTimestamp = value;
			}
		}

		public string ConsumptionCheckpoint
		{
			get
			{
				return consumptionCheckpoint;
			}
			set	
			{
				consumptionCheckpoint = value;
			}
		}

		public string ConsumptionClient
		{
			get
			{
				return consumptionClient;
			}
			set	
			{
				consumptionClient = value;
			}
		}

		public string EndTimestamp
		{
			get
			{
				return endTimestamp;
			}
			set	
			{
				endTimestamp = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
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

		public string SubscribeTopic
		{
			get
			{
				return subscribeTopic;
			}
			set	
			{
				subscribeTopic = value;
			}
		}

		public string SubscriptionInstanceID
		{
			get
			{
				return subscriptionInstanceID;
			}
			set	
			{
				subscriptionInstanceID = value;
			}
		}

		public string SubscriptionInstanceName
		{
			get
			{
				return subscriptionInstanceName;
			}
			set	
			{
				subscriptionInstanceName = value;
			}
		}

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string Success
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

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		public List<DescribeSubscriptionInstanceStatus_SynchronousObject> SubscriptionObject
		{
			get
			{
				return subscriptionObject;
			}
			set	
			{
				subscriptionObject = value;
			}
		}

		public DescribeSubscriptionInstanceStatus_SourceEndpoint SourceEndpoint
		{
			get
			{
				return sourceEndpoint;
			}
			set	
			{
				sourceEndpoint = value;
			}
		}

		public DescribeSubscriptionInstanceStatus_SubscriptionDataType SubscriptionDataType
		{
			get
			{
				return subscriptionDataType;
			}
			set	
			{
				subscriptionDataType = value;
			}
		}

		public DescribeSubscriptionInstanceStatus_SubscriptionHost SubscriptionHost
		{
			get
			{
				return subscriptionHost;
			}
			set	
			{
				subscriptionHost = value;
			}
		}

		public class DescribeSubscriptionInstanceStatus_SynchronousObject
		{

			private string databaseName;

			private string wholeDatabase;

			private List<string> tableList;

			public string DatabaseName
			{
				get
				{
					return databaseName;
				}
				set	
				{
					databaseName = value;
				}
			}

			public string WholeDatabase
			{
				get
				{
					return wholeDatabase;
				}
				set	
				{
					wholeDatabase = value;
				}
			}

			public List<string> TableList
			{
				get
				{
					return tableList;
				}
				set	
				{
					tableList = value;
				}
			}
		}

		public class DescribeSubscriptionInstanceStatus_SourceEndpoint
		{

			private string instanceID;

			private string instanceType;

			public string InstanceID
			{
				get
				{
					return instanceID;
				}
				set	
				{
					instanceID = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}
		}

		public class DescribeSubscriptionInstanceStatus_SubscriptionDataType
		{

			private bool? dDL;

			private bool? dML;

			public bool? DDL
			{
				get
				{
					return dDL;
				}
				set	
				{
					dDL = value;
				}
			}

			public bool? DML
			{
				get
				{
					return dML;
				}
				set	
				{
					dML = value;
				}
			}
		}

		public class DescribeSubscriptionInstanceStatus_SubscriptionHost
		{

			private string privateHost;

			private string publicHost;

			private string vPCHost;

			public string PrivateHost
			{
				get
				{
					return privateHost;
				}
				set	
				{
					privateHost = value;
				}
			}

			public string PublicHost
			{
				get
				{
					return publicHost;
				}
				set	
				{
					publicHost = value;
				}
			}

			public string VPCHost
			{
				get
				{
					return vPCHost;
				}
				set	
				{
					vPCHost = value;
				}
			}
		}
	}
}
