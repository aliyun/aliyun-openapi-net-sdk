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
        public static ListCompanyRegOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListCompanyRegOrdersResponse listCompanyRegOrdersResponse = new ListCompanyRegOrdersResponse();

			listCompanyRegOrdersResponse.HttpResponse = context.HttpResponse;
			listCompanyRegOrdersResponse.RequestId = context.StringValue("ListCompanyRegOrders.RequestId");
			listCompanyRegOrdersResponse.TotalItemNum = context.IntegerValue("ListCompanyRegOrders.TotalItemNum");
			listCompanyRegOrdersResponse.CurrentPageNum = context.IntegerValue("ListCompanyRegOrders.CurrentPageNum");
			listCompanyRegOrdersResponse.PageSize = context.IntegerValue("ListCompanyRegOrders.PageSize");
			listCompanyRegOrdersResponse.TotalPageNum = context.IntegerValue("ListCompanyRegOrders.TotalPageNum");
			listCompanyRegOrdersResponse.PrePage = context.BooleanValue("ListCompanyRegOrders.PrePage");
			listCompanyRegOrdersResponse.NextPage = context.BooleanValue("ListCompanyRegOrders.NextPage");

			List<ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder> listCompanyRegOrdersResponse_data = new List<ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder>();
			for (int i = 0; i < context.Length("ListCompanyRegOrders.Data.Length"); i++) {
				ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder companyRegOrder = new ListCompanyRegOrdersResponse.ListCompanyRegOrders_CompanyRegOrder();
				companyRegOrder.BizId = context.StringValue("ListCompanyRegOrders.Data["+ i +"].BizId");
				companyRegOrder.CompanyName = context.StringValue("ListCompanyRegOrders.Data["+ i +"].CompanyName");
				companyRegOrder.BizStatus = context.StringValue("ListCompanyRegOrders.Data["+ i +"].BizStatus");
				companyRegOrder.BizInfo = context.StringValue("ListCompanyRegOrders.Data["+ i +"].BizInfo");
				companyRegOrder.SupplementBizInfo = context.StringValue("ListCompanyRegOrders.Data["+ i +"].SupplementBizInfo");
				companyRegOrder.AliyunOrderId = context.StringValue("ListCompanyRegOrders.Data["+ i +"].AliyunOrderId");
				companyRegOrder.GmtModified = context.LongValue("ListCompanyRegOrders.Data["+ i +"].GmtModified");
				companyRegOrder.Extend = context.StringValue("ListCompanyRegOrders.Data["+ i +"].Extend");
				companyRegOrder.BizSubCode = context.StringValue("ListCompanyRegOrders.Data["+ i +"].BizSubCode");

				listCompanyRegOrdersResponse_data.Add(companyRegOrder);
			}
			listCompanyRegOrdersResponse.Data = listCompanyRegOrdersResponse_data;
        
			return listCompanyRegOrdersResponse;
        }
    }
}
