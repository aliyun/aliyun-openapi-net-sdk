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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationSlbsResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeApplicationSlbs_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public DescribeApplicationSlbs_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeApplicationSlbs_Data
		{

			private string internetIp;

			private string internetSlbId;

			private string intranetSlbId;

			private string intranetIp;

			private List<DescribeApplicationSlbs_IntranetItem> intranet;

			private List<DescribeApplicationSlbs_InternetItem> internet;

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string InternetSlbId
			{
				get
				{
					return internetSlbId;
				}
				set	
				{
					internetSlbId = value;
				}
			}

			public string IntranetSlbId
			{
				get
				{
					return intranetSlbId;
				}
				set	
				{
					intranetSlbId = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public List<DescribeApplicationSlbs_IntranetItem> Intranet
			{
				get
				{
					return intranet;
				}
				set	
				{
					intranet = value;
				}
			}

			public List<DescribeApplicationSlbs_InternetItem> Internet
			{
				get
				{
					return internet;
				}
				set	
				{
					internet = value;
				}
			}

			public class DescribeApplicationSlbs_IntranetItem
			{

				private string httpsCertId;

				private string protocol;

				private int? targetPort;

				private int? port;

				public string HttpsCertId
				{
					get
					{
						return httpsCertId;
					}
					set	
					{
						httpsCertId = value;
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

				public int? TargetPort
				{
					get
					{
						return targetPort;
					}
					set	
					{
						targetPort = value;
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
			}

			public class DescribeApplicationSlbs_InternetItem
			{

				private string httpsCertId;

				private string protocol;

				private int? targetPort;

				private int? port;

				public string HttpsCertId
				{
					get
					{
						return httpsCertId;
					}
					set	
					{
						httpsCertId = value;
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

				public int? TargetPort
				{
					get
					{
						return targetPort;
					}
					set	
					{
						targetPort = value;
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
			}
		}
	}
}
