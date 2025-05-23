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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsDbInstanceResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private DescribeDrdsDbInstance_DbInstance dbInstance;

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

		public DescribeDrdsDbInstance_DbInstance DbInstance
		{
			get
			{
				return dbInstance;
			}
			set	
			{
				dbInstance = value;
			}
		}

		public class DescribeDrdsDbInstance_DbInstance
		{

			private string expireTime;

			private string payType;

			private string dBInstanceStatus;

			private string networkType;

			private int? port;

			private string engineVersion;

			private string dmInstanceId;

			private string connectUrl;

			private int? readWeight;

			private string rdsInstType;

			private string remainDays;

			private string dBInstanceId;

			private string dbInstType;

			private string engine;

			private List<DescribeDrdsDbInstance_ReadOnlyInstance> readOnlyInstances;

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

			public string RemainDays
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

			public List<DescribeDrdsDbInstance_ReadOnlyInstance> ReadOnlyInstances
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

			public class DescribeDrdsDbInstance_ReadOnlyInstance
			{

				private string expireTime;

				private string payType;

				private int? versionAction;

				private string dBInstanceStatus;

				private string networkType;

				private int? port;

				private string engineVersion;

				private string dmInstanceId;

				private string connectUrl;

				private int? readWeight;

				private string rdsInstType;

				private string remainDays;

				private string dBInstanceId;

				private string dbInstType;

				private string engine;

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

				public int? VersionAction
				{
					get
					{
						return versionAction;
					}
					set	
					{
						versionAction = value;
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

				public string RemainDays
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
			}
		}
	}
}
