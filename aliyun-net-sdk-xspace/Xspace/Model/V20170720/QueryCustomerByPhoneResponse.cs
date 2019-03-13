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

namespace Aliyun.Acs.xspace.Model.V20170720
{
	public class QueryCustomerByPhoneResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<QueryCustomerByPhone_DataItem> data;

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

		public List<QueryCustomerByPhone_DataItem> Data
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

		public class QueryCustomerByPhone_DataItem
		{

			private string detail;

			private string photo;

			private string id;

			private string phone;

			private string gender;

			private string email;

			private string nick;

			private string realName;

			private List<string> tags;

			private QueryCustomerByPhone_CustomizeFields customizeFields;

			public string Detail
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

			public string Photo
			{
				get
				{
					return photo;
				}
				set	
				{
					photo = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
				}
			}

			public string Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
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

			public string RealName
			{
				get
				{
					return realName;
				}
				set	
				{
					realName = value;
				}
			}

			public List<string> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public QueryCustomerByPhone_CustomizeFields CustomizeFields
			{
				get
				{
					return customizeFields;
				}
				set	
				{
					customizeFields = value;
				}
			}

			public class QueryCustomerByPhone_CustomizeFields
			{

				private string cid;

				private string abcUrl;

				private string distributionLevel;

				private string mainAccountUid;

				private List<string> associatePersonList;

				public string Cid
				{
					get
					{
						return cid;
					}
					set	
					{
						cid = value;
					}
				}

				public string AbcUrl
				{
					get
					{
						return abcUrl;
					}
					set	
					{
						abcUrl = value;
					}
				}

				public string DistributionLevel
				{
					get
					{
						return distributionLevel;
					}
					set	
					{
						distributionLevel = value;
					}
				}

				public string MainAccountUid
				{
					get
					{
						return mainAccountUid;
					}
					set	
					{
						mainAccountUid = value;
					}
				}

				public List<string> AssociatePersonList
				{
					get
					{
						return associatePersonList;
					}
					set	
					{
						associatePersonList = value;
					}
				}
			}
		}
	}
}