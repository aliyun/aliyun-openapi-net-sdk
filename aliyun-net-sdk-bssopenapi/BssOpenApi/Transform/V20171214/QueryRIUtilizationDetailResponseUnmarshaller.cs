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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryRIUtilizationDetailResponseUnmarshaller
    {
        public static QueryRIUtilizationDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryRIUtilizationDetailResponse queryRIUtilizationDetailResponse = new QueryRIUtilizationDetailResponse();

			queryRIUtilizationDetailResponse.HttpResponse = context.HttpResponse;
			queryRIUtilizationDetailResponse.RequestId = context.StringValue("QueryRIUtilizationDetail.RequestId");
			queryRIUtilizationDetailResponse.Success = context.BooleanValue("QueryRIUtilizationDetail.Success");
			queryRIUtilizationDetailResponse.Code = context.StringValue("QueryRIUtilizationDetail.Code");
			queryRIUtilizationDetailResponse.Message = context.StringValue("QueryRIUtilizationDetail.Message");

			QueryRIUtilizationDetailResponse.QueryRIUtilizationDetail_Data data = new QueryRIUtilizationDetailResponse.QueryRIUtilizationDetail_Data();
			data.PageNum = context.LongValue("QueryRIUtilizationDetail.Data.PageNum");
			data.PageSize = context.LongValue("QueryRIUtilizationDetail.Data.PageSize");
			data.TotalCount = context.LongValue("QueryRIUtilizationDetail.Data.TotalCount");

			List<QueryRIUtilizationDetailResponse.QueryRIUtilizationDetail_Data.QueryRIUtilizationDetail_DetailListItem> data_detailList = new List<QueryRIUtilizationDetailResponse.QueryRIUtilizationDetail_Data.QueryRIUtilizationDetail_DetailListItem>();
			for (int i = 0; i < context.Length("QueryRIUtilizationDetail.Data.DetailList.Length"); i++) {
				QueryRIUtilizationDetailResponse.QueryRIUtilizationDetail_Data.QueryRIUtilizationDetail_DetailListItem detailListItem = new QueryRIUtilizationDetailResponse.QueryRIUtilizationDetail_Data.QueryRIUtilizationDetail_DetailListItem();
				detailListItem.RIInstanceId = context.StringValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].RIInstanceId");
				detailListItem.InstanceSpec = context.StringValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].InstanceSpec");
				detailListItem.DeductedInstanceId = context.StringValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].DeductedInstanceId");
				detailListItem.DeductedCommodityCode = context.StringValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].DeductedCommodityCode");
				detailListItem.DeductDate = context.StringValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].DeductDate");
				detailListItem.DeductHours = context.StringValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].DeductHours");
				detailListItem.DeductedProductDetail = context.StringValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].DeductedProductDetail");
				detailListItem.DeductQuantity = context.FloatValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].DeductQuantity");
				detailListItem.DeductFactorTotal = context.FloatValue("QueryRIUtilizationDetail.Data.DetailList["+ i +"].DeductFactorTotal");

				data_detailList.Add(detailListItem);
			}
			data.DetailList = data_detailList;
			queryRIUtilizationDetailResponse.Data = data;
        
			return queryRIUtilizationDetailResponse;
        }
    }
}
