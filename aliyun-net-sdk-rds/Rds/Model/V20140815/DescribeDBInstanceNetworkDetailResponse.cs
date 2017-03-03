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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceNetworkDetailResponse : AcsResponse
	{

		private string dBInstanceId;

		private string startTime;

		private string endTime;

		private string newConnection;

		private string activeConnection;

		private string abortedConnection;

		private string networkRequest;

		private string networkTrafficIn;

		private string networkTrafficOut;

		private string networkLatency;

		private string backendLatency;

		private string networkErrors;

		private List<NetworkKey> networkDetail;

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string NewConnection
		{
			get
			{
				return newConnection;
			}
			set	
			{
				newConnection = value;
			}
		}

		public string ActiveConnection
		{
			get
			{
				return activeConnection;
			}
			set	
			{
				activeConnection = value;
			}
		}

		public string AbortedConnection
		{
			get
			{
				return abortedConnection;
			}
			set	
			{
				abortedConnection = value;
			}
		}

		public string NetworkRequest
		{
			get
			{
				return networkRequest;
			}
			set	
			{
				networkRequest = value;
			}
		}

		public string NetworkTrafficIn
		{
			get
			{
				return networkTrafficIn;
			}
			set	
			{
				networkTrafficIn = value;
			}
		}

		public string NetworkTrafficOut
		{
			get
			{
				return networkTrafficOut;
			}
			set	
			{
				networkTrafficOut = value;
			}
		}

		public string NetworkLatency
		{
			get
			{
				return networkLatency;
			}
			set	
			{
				networkLatency = value;
			}
		}

		public string BackendLatency
		{
			get
			{
				return backendLatency;
			}
			set	
			{
				backendLatency = value;
			}
		}

		public string NetworkErrors
		{
			get
			{
				return networkErrors;
			}
			set	
			{
				networkErrors = value;
			}
		}

		public List<NetworkKey> NetworkDetail
		{
			get
			{
				return networkDetail;
			}
			set	
			{
				networkDetail = value;
			}
		}

		public class NetworkKey{

			private string key;

			private string unit;

			private List<NetworkValue> values;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Unit
			{
				get
				{
					return unit;
				}
				set	
				{
					unit = value;
				}
			}

			public List<NetworkValue> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}

			public class NetworkValue{

				private string value_;

				private string dateTime;

				public string Value
				{
					get
					{
						return value_;
					}
					set	
					{
						value_ = value;
					}
				}

				public string DateTime
				{
					get
					{
						return dateTime;
					}
					set	
					{
						dateTime = value;
					}
				}
			}
		}
	}
}