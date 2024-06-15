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

namespace Aliyun.Acs.dms_dg.Model.V20230914
{
	public class ListDatabaseAccessPointResponse : AcsResponse
	{

		private string requestId;

		private string success;

		private string code;

		private string errorMsg;

		private int? count;

		private List<ListDatabaseAccessPoint_DbInstanceAccessPoint> dbInstanceAccessPointList;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public int? Count
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

		public List<ListDatabaseAccessPoint_DbInstanceAccessPoint> DbInstanceAccessPointList
		{
			get
			{
				return dbInstanceAccessPointList;
			}
			set	
			{
				dbInstanceAccessPointList = value;
			}
		}

		public class ListDatabaseAccessPoint_DbInstanceAccessPoint
		{

			private string accessAddr;

			private int? accessPort;

			private string dbInstanceId;

			private long? gmtCreate;

			private long? gmtModified;

			private string routerId;

			private string vpcAzoneId;

			private string vpcId;

			private string vswitchId;

			public string AccessAddr
			{
				get
				{
					return accessAddr;
				}
				set	
				{
					accessAddr = value;
				}
			}

			public int? AccessPort
			{
				get
				{
					return accessPort;
				}
				set	
				{
					accessPort = value;
				}
			}

			public string DbInstanceId
			{
				get
				{
					return dbInstanceId;
				}
				set	
				{
					dbInstanceId = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string RouterId
			{
				get
				{
					return routerId;
				}
				set	
				{
					routerId = value;
				}
			}

			public string VpcAzoneId
			{
				get
				{
					return vpcAzoneId;
				}
				set	
				{
					vpcAzoneId = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VswitchId
			{
				get
				{
					return vswitchId;
				}
				set	
				{
					vswitchId = value;
				}
			}
		}
	}
}
