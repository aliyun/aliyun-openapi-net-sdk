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
	public class ListLniPrivateIpAddressResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListLniPrivateIpAddress_Content content;

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

		public ListLniPrivateIpAddress_Content Content
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

		public class ListLniPrivateIpAddress_Content
		{

			private long? total;

			private List<ListLniPrivateIpAddress_DataItem> data;

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<ListLniPrivateIpAddress_DataItem> Data
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

			public class ListLniPrivateIpAddress_DataItem
			{

				private string regionId;

				private string gmtCreate;

				private string networkInterfaceId;

				private string ipName;

				private string privateIpAddress;

				private string ipAddressMac;

				private string status;

				private string description;

				private string message;

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

				public string NetworkInterfaceId
				{
					get
					{
						return networkInterfaceId;
					}
					set	
					{
						networkInterfaceId = value;
					}
				}

				public string IpName
				{
					get
					{
						return ipName;
					}
					set	
					{
						ipName = value;
					}
				}

				public string PrivateIpAddress
				{
					get
					{
						return privateIpAddress;
					}
					set	
					{
						privateIpAddress = value;
					}
				}

				public string IpAddressMac
				{
					get
					{
						return ipAddressMac;
					}
					set	
					{
						ipAddressMac = value;
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
			}
		}
	}
}
