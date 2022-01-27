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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListTableGranteesResponse : AcsResponse
	{

		private string requestId;

		private List<ListTableGrantees_GranteeItem> grantee;

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

		public List<ListTableGrantees_GranteeItem> Grantee
		{
			get
			{
				return grantee;
			}
			set	
			{
				grantee = value;
			}
		}

		public class ListTableGrantees_GranteeItem
		{

			private string granteeTypeDescription;

			private string granteeName;

			private string granteeId;

			private List<string> actions;

			public string GranteeTypeDescription
			{
				get
				{
					return granteeTypeDescription;
				}
				set	
				{
					granteeTypeDescription = value;
				}
			}

			public string GranteeName
			{
				get
				{
					return granteeName;
				}
				set	
				{
					granteeName = value;
				}
			}

			public string GranteeId
			{
				get
				{
					return granteeId;
				}
				set	
				{
					granteeId = value;
				}
			}

			public List<string> Actions
			{
				get
				{
					return actions;
				}
				set	
				{
					actions = value;
				}
			}
		}
	}
}
