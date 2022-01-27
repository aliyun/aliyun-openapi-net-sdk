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

namespace Aliyun.Acs.quickbi_public.Model.V20200808
{
	public class ListPortalMenuAuthorizationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListPortalMenuAuthorization_Data> result;

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

		public List<ListPortalMenuAuthorization_Data> Result
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

		public class ListPortalMenuAuthorization_Data
		{

			private string menuId;

			private bool? showOnlyWithAccess;

			private List<ListPortalMenuAuthorization_ReceiversItem> receivers;

			public string MenuId
			{
				get
				{
					return menuId;
				}
				set	
				{
					menuId = value;
				}
			}

			public bool? ShowOnlyWithAccess
			{
				get
				{
					return showOnlyWithAccess;
				}
				set	
				{
					showOnlyWithAccess = value;
				}
			}

			public List<ListPortalMenuAuthorization_ReceiversItem> Receivers
			{
				get
				{
					return receivers;
				}
				set	
				{
					receivers = value;
				}
			}

			public class ListPortalMenuAuthorization_ReceiversItem
			{

				private string receiverId;

				private int? receiverType;

				public string ReceiverId
				{
					get
					{
						return receiverId;
					}
					set	
					{
						receiverId = value;
					}
				}

				public int? ReceiverType
				{
					get
					{
						return receiverType;
					}
					set	
					{
						receiverType = value;
					}
				}
			}
		}
	}
}
