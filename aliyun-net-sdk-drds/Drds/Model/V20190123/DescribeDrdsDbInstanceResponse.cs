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
	public class DescribeDrdsDbInstanceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeDrdsDbInstance_DbInstance dbInstance;

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

			private string dBInstanceId;

			private string dmInstanceId;

			private string connectUrl;

			private int? port;

			private string dBInstanceStatus;

			private string dbInstType;

			private int? readWeight;

			private string engine;

			private string engineVersion;

			private string rdsInstType;

			private string payType;

			private string expireTime;

			private string remainDays;

			private string networkType;

			private List<DescribeDrdsDbInstance_ReadOnlyInstance> readOnlyInstances;

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

				private string dBInstanceId;

				private string dmInstanceId;

				private string connectUrl;

				private int? port;

				private string dBInstanceStatus;

				private string dbInstType;

				private int? readWeight;

				private string engine;

				private string engineVersion;

				private string rdsInstType;

				private string payType;

				private string expireTime;

				private string remainDays;

				private string networkType;

				private int? versionAction;

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
			}
		}
	}
}
