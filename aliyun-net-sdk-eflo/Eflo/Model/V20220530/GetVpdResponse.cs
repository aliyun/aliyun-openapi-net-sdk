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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetVpdResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetVpd_Content content;

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

		public GetVpd_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class GetVpd_Content
		{

			private string regionId;

			private string vpdId;

			private string name;

			private string cidr;

			private string serviceCidr;

			private string status;

			private string description;

			private string message;

			private int? route;

			private long? ncCount;

			private long? subnetCount;

			private long? lbCount;

			private long? vccCount;

			private string gmtCreate;

			private string gmtModified;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string VpdId
			{
				get
				{
					return vpdId;
				}
				set	
				{
					vpdId = value;
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

			public string Cidr
			{
				get
				{
					return cidr;
				}
				set	
				{
					cidr = value;
				}
			}

			public string ServiceCidr
			{
				get
				{
					return serviceCidr;
				}
				set	
				{
					serviceCidr = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public int? Route
			{
				get
				{
					return route;
				}
				set	
				{
					route = value;
				}
			}

			public long? NcCount
			{
				get
				{
					return ncCount;
				}
				set	
				{
					ncCount = value;
				}
			}

			public long? SubnetCount
			{
				get
				{
					return subnetCount;
				}
				set	
				{
					subnetCount = value;
				}
			}

			public long? LbCount
			{
				get
				{
					return lbCount;
				}
				set	
				{
					lbCount = value;
				}
			}

			public long? VccCount
			{
				get
				{
					return vccCount;
				}
				set	
				{
					vccCount = value;
				}
			}

			public string GmtCreate
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

			public string GmtModified
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
		}
	}
}
