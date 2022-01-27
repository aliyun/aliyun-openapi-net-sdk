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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsDbInstancesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string pageNumber;

		private string pageSize;

		private string total;

		private List<DescribeDrdsDbInstances_DbInstance> dbInstances;

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

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public string PageSize
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

		public string Total
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

		public List<DescribeDrdsDbInstances_DbInstance> DbInstances
		{
			get
			{
				return dbInstances;
			}
			set	
			{
				dbInstances = value;
			}
		}

		public class DescribeDrdsDbInstances_DbInstance
		{

			private string dBInstanceId;

			private string dmInstanceId;

			private string connectUrl;

			private int? port;

			private string dBInstanceStatus;

			private string dbInstType;

			private int? readWeight;

			private string networkType;

			private string engine;

			private string engineVersion;

			private string rdsInstType;

			private string payType;

			private string expireTime;

			private int? remainDays;

			private List<DescribeDrdsDbInstances_ReadOnlyInstance> readOnlyInstances;

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

			public string DmInstanceId
			{
				get
				{
					return dmInstanceId;
				}
				set	
				{
					dmInstanceId = value;
				}
			}

			public string ConnectUrl
			{
				get
				{
					return connectUrl;
				}
				set	
				{
					connectUrl = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string DBInstanceStatus
			{
				get
				{
					return dBInstanceStatus;
				}
				set	
				{
					dBInstanceStatus = value;
				}
			}

			public string DbInstType
			{
				get
				{
					return dbInstType;
				}
				set	
				{
					dbInstType = value;
				}
			}

			public int? ReadWeight
			{
				get
				{
					return readWeight;
				}
				set	
				{
					readWeight = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string RdsInstType
			{
				get
				{
					return rdsInstType;
				}
				set	
				{
					rdsInstType = value;
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

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public int? RemainDays
			{
				get
				{
					return remainDays;
				}
				set	
				{
					remainDays = value;
				}
			}

			public List<DescribeDrdsDbInstances_ReadOnlyInstance> ReadOnlyInstances
			{
				get
				{
					return readOnlyInstances;
				}
				set	
				{
					readOnlyInstances = value;
				}
			}

			public class DescribeDrdsDbInstances_ReadOnlyInstance
			{

				private string instanceName;

				private string dmInstanceId;

				private string connectUrl;

				private int? port;

				private string dBInstanceStatus;

				private string dbInstType;

				private int? readWeight;

				private string networkType;

				private string engine;

				private string engineVersion;

				private string rdsInstType;

				private string payType;

				private string expireTime;

				private int? remainDays;

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public string DmInstanceId
				{
					get
					{
						return dmInstanceId;
					}
					set	
					{
						dmInstanceId = value;
					}
				}

				public string ConnectUrl
				{
					get
					{
						return connectUrl;
					}
					set	
					{
						connectUrl = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string DBInstanceStatus
				{
					get
					{
						return dBInstanceStatus;
					}
					set	
					{
						dBInstanceStatus = value;
					}
				}

				public string DbInstType
				{
					get
					{
						return dbInstType;
					}
					set	
					{
						dbInstType = value;
					}
				}

				public int? ReadWeight
				{
					get
					{
						return readWeight;
					}
					set	
					{
						readWeight = value;
					}
				}

				public string NetworkType
				{
					get
					{
						return networkType;
					}
					set	
					{
						networkType = value;
					}
				}

				public string Engine
				{
					get
					{
						return engine;
					}
					set	
					{
						engine = value;
					}
				}

				public string EngineVersion
				{
					get
					{
						return engineVersion;
					}
					set	
					{
						engineVersion = value;
					}
				}

				public string RdsInstType
				{
					get
					{
						return rdsInstType;
					}
					set	
					{
						rdsInstType = value;
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

				public string ExpireTime
				{
					get
					{
						return expireTime;
					}
					set	
					{
						expireTime = value;
					}
				}

				public int? RemainDays
				{
					get
					{
						return remainDays;
					}
					set	
					{
						remainDays = value;
					}
				}
			}
		}
	}
}
