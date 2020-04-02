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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryAddressResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<QueryAddress_DivisionAddressItem> divisionAddress;

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

		public List<QueryAddress_DivisionAddressItem> DivisionAddress
		{
			get
			{
				return divisionAddress;
			}
			set	
			{
				divisionAddress = value;
			}
		}

		public class QueryAddress_DivisionAddressItem
		{

			private long? divisionCode;

			private string divisionName;

			private int? divisionLevel;

			private long? parentId;

			public long? DivisionCode
			{
				get
				{
					return divisionCode;
				}
				set	
				{
					divisionCode = value;
				}
			}

			public string DivisionName
			{
				get
				{
					return divisionName;
				}
				set	
				{
					divisionName = value;
				}
			}

			public int? DivisionLevel
			{
				get
				{
					return divisionLevel;
				}
				set	
				{
					divisionLevel = value;
				}
			}

			public long? ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}
		}
	}
}
