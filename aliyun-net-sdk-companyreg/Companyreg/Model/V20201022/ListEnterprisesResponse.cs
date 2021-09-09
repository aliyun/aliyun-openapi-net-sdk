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
	public class ListEnterprisesResponse : AcsResponse
	{

		private string requestId;

		private List<ListEnterprises_EnterprisesListItem> enterprisesList;

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

		public List<ListEnterprises_EnterprisesListItem> EnterprisesList
		{
			get
			{
				return enterprisesList;
			}
			set	
			{
				enterprisesList = value;
			}
		}

		public class ListEnterprises_EnterprisesListItem
		{

			private string taxNo;

			private string enterpriseName;

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
		}
	}
}
