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

namespace Aliyun.Acs.Drds.Model.V20171016
{
	public class DescribeDrdsInstanceNetInfoForInnerResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string drdsInstanceId;

		private string networkType;

		private List<DescribeDrdsInstanceNetInfoForInner_NetInfo> netInfos;

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

		public string DrdsInstanceId
		{
			get
			{
				return drdsInstanceId;
			}
			set	
			{
				drdsInstanceId = value;
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

		public List<DescribeDrdsInstanceNetInfoForInner_NetInfo> NetInfos
		{
			get
			{
				return netInfos;
			}
			set	
			{
				netInfos = value;
			}
		}

		public class DescribeDrdsInstanceNetInfoForInner_NetInfo
		{

			private string iP;

			private string port;

			private string type;

			private bool? isForVpc;

			public string IP
			{
				get
				{
					return iP;
				}
				set	
				{
					iP = value;
				}
			}

			public string Port
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public bool? IsForVpc
			{
				get
				{
					return isForVpc;
				}
				set	
				{
					isForVpc = value;
				}
			}
		}
	}
}
