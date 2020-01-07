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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribeSlbAPDetailResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private DescribeSlbAPDetail_Result result;

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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public DescribeSlbAPDetail_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeSlbAPDetail_Result
		{

			private long? appId;

			private int? cookieTimeout;

			private long? envId;

			private int? establishedTimeout;

			private int? listenerPort;

			private string name;

			private string networkMode;

			private string protocol;

			private int? realServerPort;

			private long? slbAPId;

			private string slbId;

			private string slbIp;

			private string sslCertId;

			private int? stickySession;

			public long? AppId
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

			public int? CookieTimeout
			{
				get
				{
					return cookieTimeout;
				}
				set	
				{
					cookieTimeout = value;
				}
			}

			public long? EnvId
			{
				get
				{
					return envId;
				}
				set	
				{
					envId = value;
				}
			}

			public int? EstablishedTimeout
			{
				get
				{
					return establishedTimeout;
				}
				set	
				{
					establishedTimeout = value;
				}
			}

			public int? ListenerPort
			{
				get
				{
					return listenerPort;
				}
				set	
				{
					listenerPort = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string NetworkMode
			{
				get
				{
					return networkMode;
				}
				set	
				{
					networkMode = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public int? RealServerPort
			{
				get
				{
					return realServerPort;
				}
				set	
				{
					realServerPort = value;
				}
			}

			public long? SlbAPId
			{
				get
				{
					return slbAPId;
				}
				set	
				{
					slbAPId = value;
				}
			}

			public string SlbId
			{
				get
				{
					return slbId;
				}
				set	
				{
					slbId = value;
				}
			}

			public string SlbIp
			{
				get
				{
					return slbIp;
				}
				set	
				{
					slbIp = value;
				}
			}

			public string SslCertId
			{
				get
				{
					return sslCertId;
				}
				set	
				{
					sslCertId = value;
				}
			}

			public int? StickySession
			{
				get
				{
					return stickySession;
				}
				set	
				{
					stickySession = value;
				}
			}
		}
	}
}
