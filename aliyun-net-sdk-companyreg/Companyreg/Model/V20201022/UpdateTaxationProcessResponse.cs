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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class UpdateTaxationProcessResponse : AcsResponse
	{

		private string declareProcessType;

		private string requestId;

		private List<UpdateTaxationProcess_TaxItemDetailListItem> taxItemDetailList;

		public string DeclareProcessType
		{
			get
			{
				return declareProcessType;
			}
			set	
			{
				declareProcessType = value;
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

		public List<UpdateTaxationProcess_TaxItemDetailListItem> TaxItemDetailList
		{
			get
			{
				return taxItemDetailList;
			}
			set	
			{
				taxItemDetailList = value;
			}
		}

		public class UpdateTaxationProcess_TaxItemDetailListItem
		{

			private long? id;

			private bool? isDeclared;

			private bool? isDeclaredThisPeriod;

			private bool? isPaid;

			private string taxAmount;

			private int? taxTypeId;

			private string taxTypeName;

			public long? Id
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

			public bool? IsDeclared
			{
				get
				{
					return isDeclared;
				}
				set	
				{
					isDeclared = value;
				}
			}

			public bool? IsDeclaredThisPeriod
			{
				get
				{
					return isDeclaredThisPeriod;
				}
				set	
				{
					isDeclaredThisPeriod = value;
				}
			}

			public bool? IsPaid
			{
				get
				{
					return isPaid;
				}
				set	
				{
					isPaid = value;
				}
			}

			public string TaxAmount
			{
				get
				{
					return taxAmount;
				}
				set	
				{
					taxAmount = value;
				}
			}

			public int? TaxTypeId
			{
				get
				{
					return taxTypeId;
				}
				set	
				{
					taxTypeId = value;
				}
			}

			public string TaxTypeName
			{
				get
				{
					return taxTypeName;
				}
				set	
				{
					taxTypeName = value;
				}
			}
		}
	}
}
