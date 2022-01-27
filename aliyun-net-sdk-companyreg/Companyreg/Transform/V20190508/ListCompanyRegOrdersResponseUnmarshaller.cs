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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class ListCompanyRegOrdersResponseUnmarshaller
    {
        public static ListCompanyRegOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCompanyRegOrdersResponse listCompanyRegOrdersResponse = new ListCompanyRegOrdersResponse();

			listCompanyRegOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listCompanyRegOrdersResponse.RequestId = _ctx.StringValue("ListCompanyRegOrders.RequestId");
			listCompanyRegOrdersResponse.TotalItemNum = _ctx.IntegerValue("ListCompanyRegOrders.TotalItemNum");
			listCompanyRegOrdersResponse.CurrentPageNum = _ctx.IntegerValue("ListCompanyRegOrders.CurrentPageNum");
			listCompanyRegOrdersResponse.PageSize = _ctx.IntegerValue("ListCompanyRegOrders.PageSize");
			listCompanyRegOrdersResponse.TotalPageNum = _ctx.IntegerValue("ListCompanyRegOrders.TotalPageNum");
			listCompanyRegOrdersResponse.PrePage = _ctx.BooleanValue("ListCompanyRegOrders.PrePage");
			listCompanyRegOrdersResponse.NextPage = _ctx.BooleanValue("ListCompanyRegOrders.NextPage");

			List<ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder> listCompanyRegOrdersResponse_data = new List<ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder>();
			for (int i = 0; i < _ctx.Length("ListCompanyRegOrders.Data.Length"); i++) {
				ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder companyRegOrder = new ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder();
				companyRegOrder.BizId = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].BizId");
				companyRegOrder.CompanyName = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].CompanyName");
				companyRegOrder.BizStatus = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].BizStatus");
				companyRegOrder.BizInfo = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].BizInfo");
				companyRegOrder.SupplementBizInfo = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].SupplementBizInfo");
				companyRegOrder.AliyunOrderId = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].AliyunOrderId");
				companyRegOrder.GmtModified = _ctx.LongValue("ListCompanyRegOrders.Data["+ i +"].GmtModified");
				companyRegOrder.Extend = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].Extend");
				companyRegOrder.BizSubCode = _ctx.StringValue("ListCompanyRegOrders.Data["+ i +"].BizSubCode");

				listCompanyRegOrdersResponse_data.Add(companyRegOrder);
			}
			listCompanyRegOrdersResponse.Data = listCompanyRegOrdersResponse_data;
        
			return listCompanyRegOrdersResponse;
        }
    }
}
