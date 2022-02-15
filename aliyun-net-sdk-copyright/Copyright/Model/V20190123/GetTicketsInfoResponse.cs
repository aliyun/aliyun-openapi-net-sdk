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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetTicketsInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<GetTicketsInfo_Tickets> data;

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

		public List<GetTicketsInfo_Tickets> Data
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

		public class GetTicketsInfo_Tickets
		{

			private string fee;

			private string invoiceUrl;

			private int? invoiceYear;

			private long? patentNo;

			private string remark;

			public string Fee
			{
				get
				{
					return fee;
				}
				set	
				{
					fee = value;
				}
			}

			public string InvoiceUrl
			{
				get
				{
					return invoiceUrl;
				}
				set	
				{
					invoiceUrl = value;
				}
			}

			public int? InvoiceYear
			{
				get
				{
					return invoiceYear;
				}
				set	
				{
					invoiceYear = value;
				}
			}

			public long? PatentNo
			{
				get
				{
					return patentNo;
				}
				set	
				{
					patentNo = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}
		}
	}
}
