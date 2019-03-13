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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20180104
{
	public class ListUserQuotasResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private ListUserQuotas_Data data;

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

		public ListUserQuotas_Data Data
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

		public class ListUserQuotas_Data
		{

			private List<ListUserQuotas_Quotas> detail;

			private ListUserQuotas_Error error;

			public List<ListUserQuotas_Quotas> Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public ListUserQuotas_Error Error
			{
				get
				{
					return error;
				}
				set	
				{
					error = value;
				}
			}

			public class ListUserQuotas_Quotas
			{

				private long? quotaid;

				private string cluster;

				private string region;

				private string name;

				private long? parentid;

				private string nick;

				public long? Quotaid
				{
					get
					{
						return quotaid;
					}
					set	
					{
						quotaid = value;
					}
				}

				public string Cluster
				{
					get
					{
						return cluster;
					}
					set	
					{
						cluster = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
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

				public long? Parentid
				{
					get
					{
						return parentid;
					}
					set	
					{
						parentid = value;
					}
				}

				public string Nick
				{
					get
					{
						return nick;
					}
					set	
					{
						nick = value;
					}
				}
			}

			public class ListUserQuotas_Error
			{

				private string code;

				private string message;

				private string timestamp;

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

				public string Timestamp
				{
					get
					{
						return timestamp;
					}
					set	
					{
						timestamp = value;
					}
				}
			}
		}
	}
}