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
	public class ListPayrollResponse : AcsResponse
	{

		private string requestId;

		private List<ListPayroll_PayrollListItem> payrollList;

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

		public List<ListPayroll_PayrollListItem> PayrollList
		{
			get
			{
				return payrollList;
			}
			set	
			{
				payrollList = value;
			}
		}

		public class ListPayroll_PayrollListItem
		{

			private string name;

			private string income;

			private string personHousingAccumulationFund;

			private long? id;

			private string personSocialInsurance;

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

			public string Income
			{
				get
				{
					return income;
				}
				set	
				{
					income = value;
				}
			}

			public string PersonHousingAccumulationFund
			{
				get
				{
					return personHousingAccumulationFund;
				}
				set	
				{
					personHousingAccumulationFund = value;
				}
			}

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

			public string PersonSocialInsurance
			{
				get
				{
					return personSocialInsurance;
				}
				set	
				{
					personSocialInsurance = value;
				}
			}
		}
	}
}
