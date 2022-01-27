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
    public class QueryDPUtilizationDetailResponseUnmarshaller
    {
        public static QueryDPUtilizationDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDPUtilizationDetailResponse queryDPUtilizationDetailResponse = new QueryDPUtilizationDetailResponse();

			queryDPUtilizationDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryDPUtilizationDetailResponse.RequestId = _ctx.StringValue("QueryDPUtilizationDetail.RequestId");
			queryDPUtilizationDetailResponse.Success = _ctx.BooleanValue("QueryDPUtilizationDetail.Success");
			queryDPUtilizationDetailResponse.Code = _ctx.StringValue("QueryDPUtilizationDetail.Code");
			queryDPUtilizationDetailResponse.Message = _ctx.StringValue("QueryDPUtilizationDetail.Message");

			QueryDPUtilizationDetailResponse.QueryDPUtilizationDetail_Data data = new QueryDPUtilizationDetailResponse.QueryDPUtilizationDetail_Data();
			data.NextToken = _ctx.StringValue("QueryDPUtilizationDetail.Data.NextToken");

			List<QueryDPUtilizationDetailResponse.QueryDPUtilizationDetail_Data.QueryDPUtilizationDetail_DetailListItem> data_detailList = new List<QueryDPUtilizationDetailResponse.QueryDPUtilizationDetail_Data.QueryDPUtilizationDetail_DetailListItem>();
			for (int i = 0; i < _ctx.Length("QueryDPUtilizationDetail.Data.DetailList.Length"); i++) {
				QueryDPUtilizationDetailResponse.QueryDPUtilizationDetail_Data.QueryDPUtilizationDetail_DetailListItem detailListItem = new QueryDPUtilizationDetailResponse.QueryDPUtilizationDetail_Data.QueryDPUtilizationDetail_DetailListItem();
				detailListItem.Uid = _ctx.LongValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].Uid");
				detailListItem.InstanceId = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].InstanceId");
				detailListItem.InstanceSpec = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].InstanceSpec");
				detailListItem.DeductedInstanceId = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductedInstanceId");
				detailListItem.DeductedCommodityCode = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductedCommodityCode");
				detailListItem.DeductedProductDetail = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductedProductDetail");
				detailListItem.ResCode = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].ResCode");
				detailListItem.DeductDate = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductDate");
				detailListItem.DeductQuantity = _ctx.FloatValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductQuantity");
				detailListItem.DeductMeasure = _ctx.FloatValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductMeasure");
				detailListItem.DeductHours = _ctx.FloatValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductHours");
				detailListItem.DeductFactorTotal = _ctx.FloatValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].DeductFactorTotal");
				detailListItem.Region = _ctx.StringValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].Region");
				detailListItem.ShareUid = _ctx.LongValue("QueryDPUtilizationDetail.Data.DetailList["+ i +"].ShareUid");

				data_detailList.Add(detailListItem);
			}
			data.DetailList = data_detailList;
			queryDPUtilizationDetailResponse.Data = data;
        
			return queryDPUtilizationDetailResponse;
        }
    }
}
