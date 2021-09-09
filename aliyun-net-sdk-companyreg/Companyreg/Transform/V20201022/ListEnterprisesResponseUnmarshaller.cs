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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class ListEnterprisesResponseUnmarshaller
    {
        public static ListEnterprisesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEnterprisesResponse listEnterprisesResponse = new ListEnterprisesResponse();

			listEnterprisesResponse.HttpResponse = _ctx.HttpResponse;
			listEnterprisesResponse.RequestId = _ctx.StringValue("ListEnterprises.RequestId");

			List<ListEnterprisesResponse.ListEnterprises_EnterprisesListItem> listEnterprisesResponse_enterprisesList = new List<ListEnterprisesResponse.ListEnterprises_EnterprisesListItem>();
			for (int i = 0; i < _ctx.Length("ListEnterprises.EnterprisesList.Length"); i++) {
				ListEnterprisesResponse.ListEnterprises_EnterprisesListItem enterprisesListItem = new ListEnterprisesResponse.ListEnterprises_EnterprisesListItem();
				enterprisesListItem.TaxNo = _ctx.StringValue("ListEnterprises.EnterprisesList["+ i +"].TaxNo");
				enterprisesListItem.EnterpriseName = _ctx.StringValue("ListEnterprises.EnterprisesList["+ i +"].EnterpriseName");

				listEnterprisesResponse_enterprisesList.Add(enterprisesListItem);
			}
			listEnterprisesResponse.EnterprisesList = listEnterprisesResponse_enterprisesList;
        
			return listEnterprisesResponse;
        }
    }
}
