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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.LinkFace.Model.V20180720;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.LinkFace.Transform.V20180720
{
    public class QueryLicensesResponseUnmarshaller
    {
        public static QueryLicensesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryLicensesResponse queryLicensesResponse = new QueryLicensesResponse();

			queryLicensesResponse.HttpResponse = context.HttpResponse;
			queryLicensesResponse.RequestId = context.StringValue("QueryLicenses.RequestId");
			queryLicensesResponse.Code = context.IntegerValue("QueryLicenses.Code");
			queryLicensesResponse.Message = context.StringValue("QueryLicenses.Message");
			queryLicensesResponse.PageCount = context.IntegerValue("QueryLicenses.PageCount");
			queryLicensesResponse.PageSize = context.IntegerValue("QueryLicenses.PageSize");
			queryLicensesResponse.Page = context.IntegerValue("QueryLicenses.Page");
			queryLicensesResponse.Total = context.IntegerValue("QueryLicenses.Total");
			queryLicensesResponse.Success = context.BooleanValue("QueryLicenses.Success");

			List<QueryLicensesResponse.QueryLicenses_DataItem> queryLicensesResponse_data = new List<QueryLicensesResponse.QueryLicenses_DataItem>();
			for (int i = 0; i < context.Length("QueryLicenses.Data.Length"); i++) {
				QueryLicensesResponse.QueryLicenses_DataItem dataItem = new QueryLicensesResponse.QueryLicenses_DataItem();
				dataItem.LicenseType = context.IntegerValue("QueryLicenses.Data["+ i +"].LicenseType");
				dataItem.Quantity = context.IntegerValue("QueryLicenses.Data["+ i +"].Quantity");
				dataItem.CostQuantity = context.IntegerValue("QueryLicenses.Data["+ i +"].CostQuantity");

				queryLicensesResponse_data.Add(dataItem);
			}
			queryLicensesResponse.Data = queryLicensesResponse_data;
        
			return queryLicensesResponse;
        }
    }
}