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

namespace Aliyun.Acs.finmall.Model.V20180723
{
	public class GetRepayPlanTrialResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetRepayPlanTrial_Data data;

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

		public GetRepayPlanTrial_Data Data
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

		public class GetRepayPlanTrial_Data
		{

			private string amount;

			private string plan;

			private string terms;

			private string loanRate;

			private string repayMethod;

			private string prepayment;

			public string Amount
			{
				get
				{
					return amount;
				}
				set	
				{
					amount = value;
				}
			}

			public string Plan
			{
				get
				{
					return plan;
				}
				set	
				{
					plan = value;
				}
			}

			public string Terms
			{
				get
				{
					return terms;
				}
				set	
				{
					terms = value;
				}
			}

			public string LoanRate
			{
				get
				{
					return loanRate;
				}
				set	
				{
					loanRate = value;
				}
			}

			public string RepayMethod
			{
				get
				{
					return repayMethod;
				}
				set	
				{
					repayMethod = value;
				}
			}

			public string Prepayment
			{
				get
				{
					return prepayment;
				}
				set	
				{
					prepayment = value;
				}
			}
		}
	}
}
