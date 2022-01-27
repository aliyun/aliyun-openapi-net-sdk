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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class QueryEccInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private QueryEccInfo_EccInfo eccInfo;

		public int? Code
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

		public QueryEccInfo_EccInfo EccInfo
		{
			get
			{
				return eccInfo;
			}
			set	
			{
				eccInfo = value;
			}
		}

		public class QueryEccInfo_EccInfo
		{

			private string appId;

			private string eccId;

			private string ecuId;

			private string groupId;

			private string groupName;

			private string packageMd5;

			private string packageVersion;

			private string vpcId;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string EccId
			{
				get
				{
					return eccId;
				}
				set	
				{
					eccId = value;
				}
			}

			public string EcuId
			{
				get
				{
					return ecuId;
				}
				set	
				{
					ecuId = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string PackageMd5
			{
				get
				{
					return packageMd5;
				}
				set	
				{
					packageMd5 = value;
				}
			}

			public string PackageVersion
			{
				get
				{
					return packageVersion;
				}
				set	
				{
					packageVersion = value;
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
		}
	}
}
