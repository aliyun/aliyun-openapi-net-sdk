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

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class CheckDomainResponse : AcsResponse
	{

		private string name;

		private int? avail;

		private string reason;

		private string feeCurrency;

		private int? feePeriod;

		private string feeFee;

		private string rmbFee;

		private string feeCommand;

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

		public int? Avail
		{
			get
			{
				return avail;
			}
			set	
			{
				avail = value;
			}
		}

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
			}
		}

		public string FeeCurrency
		{
			get
			{
				return feeCurrency;
			}
			set	
			{
				feeCurrency = value;
			}
		}

		public int? FeePeriod
		{
			get
			{
				return feePeriod;
			}
			set	
			{
				feePeriod = value;
			}
		}

		public string FeeFee
		{
			get
			{
				return feeFee;
			}
			set	
			{
				feeFee = value;
			}
		}

		public string RmbFee
		{
			get
			{
				return rmbFee;
			}
			set	
			{
				rmbFee = value;
			}
		}

		public string FeeCommand
		{
			get
			{
				return feeCommand;
			}
			set	
			{
				feeCommand = value;
			}
		}
	}
}