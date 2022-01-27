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
	public class GetEnterprisesInfoResponse : AcsResponse
	{

		private string requestId;

		private string enterpriseName;

		private string taxNo;

		private string corporation;

		private string establishDate;

		private string enterpriseType;

		private string registeredCapital;

		private string address;

		private string businessScope;

		private string fromBusinessTerm;

		private string toBusinessTerm;

		private string enterpriseStatus;

		private string industryCoName;

		private string industryCode;

		private string entityType;

		private string areaName;

		private string regCityName;

		private string changeDate;

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

		public string EnterpriseName
		{
			get
			{
				return enterpriseName;
			}
			set	
			{
				enterpriseName = value;
			}
		}

		public string TaxNo
		{
			get
			{
				return taxNo;
			}
			set	
			{
				taxNo = value;
			}
		}

		public string Corporation
		{
			get
			{
				return corporation;
			}
			set	
			{
				corporation = value;
			}
		}

		public string EstablishDate
		{
			get
			{
				return establishDate;
			}
			set	
			{
				establishDate = value;
			}
		}

		public string EnterpriseType
		{
			get
			{
				return enterpriseType;
			}
			set	
			{
				enterpriseType = value;
			}
		}

		public string RegisteredCapital
		{
			get
			{
				return registeredCapital;
			}
			set	
			{
				registeredCapital = value;
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
			}
		}

		public string BusinessScope
		{
			get
			{
				return businessScope;
			}
			set	
			{
				businessScope = value;
			}
		}

		public string FromBusinessTerm
		{
			get
			{
				return fromBusinessTerm;
			}
			set	
			{
				fromBusinessTerm = value;
			}
		}

		public string ToBusinessTerm
		{
			get
			{
				return toBusinessTerm;
			}
			set	
			{
				toBusinessTerm = value;
			}
		}

		public string EnterpriseStatus
		{
			get
			{
				return enterpriseStatus;
			}
			set	
			{
				enterpriseStatus = value;
			}
		}

		public string IndustryCoName
		{
			get
			{
				return industryCoName;
			}
			set	
			{
				industryCoName = value;
			}
		}

		public string IndustryCode
		{
			get
			{
				return industryCode;
			}
			set	
			{
				industryCode = value;
			}
		}

		public string EntityType
		{
			get
			{
				return entityType;
			}
			set	
			{
				entityType = value;
			}
		}

		public string AreaName
		{
			get
			{
				return areaName;
			}
			set	
			{
				areaName = value;
			}
		}

		public string RegCityName
		{
			get
			{
				return regCityName;
			}
			set	
			{
				regCityName = value;
			}
		}

		public string ChangeDate
		{
			get
			{
				return changeDate;
			}
			set	
			{
				changeDate = value;
			}
		}
	}
}
