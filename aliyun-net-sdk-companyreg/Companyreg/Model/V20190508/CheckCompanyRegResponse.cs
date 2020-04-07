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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class CheckCompanyRegResponse : AcsResponse
	{

		private string requestId;

		private string matchCity;

		private string matchBrand;

		private string matchSensitive;

		private string level;

		private List<CheckCompanyReg_Company> similarCompanies;

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

		public string MatchCity
		{
			get
			{
				return matchCity;
			}
			set	
			{
				matchCity = value;
			}
		}

		public string MatchBrand
		{
			get
			{
				return matchBrand;
			}
			set	
			{
				matchBrand = value;
			}
		}

		public string MatchSensitive
		{
			get
			{
				return matchSensitive;
			}
			set	
			{
				matchSensitive = value;
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
			}
		}

		public List<CheckCompanyReg_Company> SimilarCompanies
		{
			get
			{
				return similarCompanies;
			}
			set	
			{
				similarCompanies = value;
			}
		}

		public class CheckCompanyReg_Company
		{

			private string companyName;

			private string level;

			public string CompanyName
			{
				get
				{
					return companyName;
				}
				set	
				{
					companyName = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}
		}
	}
}
