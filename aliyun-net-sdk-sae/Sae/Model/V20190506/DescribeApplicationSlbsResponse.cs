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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationSlbsResponse : AcsResponse
	{

		private string code;

		private string errorCode;

		private string message;

		private bool? success;

		private string traceId;

		private string requestId;

		private DescribeApplicationSlbs_Data data;

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

			private string intranetIp;

			private string internetSlbId;

			private string intranetSlbId;

			private List<DescribeApplicationSlbs_InternetItem> internet;

			private List<DescribeApplicationSlbs_IntranetItem> intranet;

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

			public class DescribeApplicationSlbs_InternetItem
			{

				private int? port;

				private string protocol;

				private int? targetPort;

				private string httpsCertId;

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
			}

			public class DescribeApplicationSlbs_IntranetItem
			{

				private int? port;

				private string protocol;

				private int? targetPort;

				private string httpsCertId;

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
			}
		}
	}
}
