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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListAllTenantBindNumberBindingResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private string requestId;

		private ListAllTenantBindNumberBinding_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListAllTenantBindNumberBinding_Data Data
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

		public class ListAllTenantBindNumberBinding_Data
		{

			private List<ListAllTenantBindNumberBinding_ListItem> list;

			public List<ListAllTenantBindNumberBinding_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListAllTenantBindNumberBinding_ListItem
			{

				private string bindingId;

				private string number;

				private string trunkName;

				private string serializedParams;

				private List<string> instanceNameList;

				public string BindingId
				{
					get
					{
						return bindingId;
					}
					set	
					{
						bindingId = value;
					}
				}

				public string Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
					}
				}

				public string TrunkName
				{
					get
					{
						return trunkName;
					}
					set	
					{
						trunkName = value;
					}
				}

				public string SerializedParams
				{
					get
					{
						return serializedParams;
					}
					set	
					{
						serializedParams = value;
					}
				}

				public List<string> InstanceNameList
				{
					get
					{
						return instanceNameList;
					}
					set	
					{
						instanceNameList = value;
					}
				}
			}
		}
	}
}
