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
	public class BindSlbResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private BindSlb_Data data;

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

		public BindSlb_Data Data
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

		public class BindSlb_Data
		{

			private string extSlbId;

			private string extSlbIp;

			private string extSlbName;

			private string extVServerGroupId;

			private string slbId;

			private string slbIp;

			private string slbName;

			private int? slbPort;

			private string vServerGroupId;

			public string ExtSlbId
			{
				get
				{
					return extSlbId;
				}
				set	
				{
					extSlbId = value;
				}
			}

			public string ExtSlbIp
			{
				get
				{
					return extSlbIp;
				}
				set	
				{
					extSlbIp = value;
				}
			}

			public string ExtSlbName
			{
				get
				{
					return extSlbName;
				}
				set	
				{
					extSlbName = value;
				}
			}

			public string ExtVServerGroupId
			{
				get
				{
					return extVServerGroupId;
				}
				set	
				{
					extVServerGroupId = value;
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

			public string SlbName
			{
				get
				{
					return slbName;
				}
				set	
				{
					slbName = value;
				}
			}

			public int? SlbPort
			{
				get
				{
					return slbPort;
				}
				set	
				{
					slbPort = value;
				}
			}

			public string VServerGroupId
			{
				get
				{
					return vServerGroupId;
				}
				set	
				{
					vServerGroupId = value;
				}
			}
		}
	}
}
