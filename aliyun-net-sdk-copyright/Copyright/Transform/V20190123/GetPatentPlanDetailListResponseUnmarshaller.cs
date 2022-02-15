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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetPatentPlanDetailListResponseUnmarshaller
    {
        public static GetPatentPlanDetailListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentPlanDetailListResponse getPatentPlanDetailListResponse = new GetPatentPlanDetailListResponse();

			getPatentPlanDetailListResponse.HttpResponse = _ctx.HttpResponse;
			getPatentPlanDetailListResponse.PageNum = _ctx.IntegerValue("GetPatentPlanDetailList.PageNum");
			getPatentPlanDetailListResponse.RequestId = _ctx.StringValue("GetPatentPlanDetailList.RequestId");
			getPatentPlanDetailListResponse.Success = _ctx.BooleanValue("GetPatentPlanDetailList.Success");
			getPatentPlanDetailListResponse.TotalItemNum = _ctx.IntegerValue("GetPatentPlanDetailList.TotalItemNum");
			getPatentPlanDetailListResponse.PageSize = _ctx.IntegerValue("GetPatentPlanDetailList.PageSize");
			getPatentPlanDetailListResponse.TotalPageNum = _ctx.IntegerValue("GetPatentPlanDetailList.TotalPageNum");

			List<GetPatentPlanDetailListResponse.GetPatentPlanDetailList_DataItem> getPatentPlanDetailListResponse_data = new List<GetPatentPlanDetailListResponse.GetPatentPlanDetailList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetPatentPlanDetailList.Data.Length"); i++) {
				GetPatentPlanDetailListResponse.GetPatentPlanDetailList_DataItem dataItem = new GetPatentPlanDetailListResponse.GetPatentPlanDetailList_DataItem();
				dataItem.Type = _ctx.IntegerValue("GetPatentPlanDetailList.Data["+ i +"].Type");
				dataItem.Owner = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].Owner");
				dataItem.PaidDate = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].PaidDate");
				dataItem.EndPayDate = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].EndPayDate");
				dataItem.PlanPayDate = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].PlanPayDate");
				dataItem.SoldStatus = _ctx.IntegerValue("GetPatentPlanDetailList.Data["+ i +"].SoldStatus");
				dataItem.ApplyNumber = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].ApplyNumber");
				dataItem.GmtExpireDate = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].GmtExpireDate");
				dataItem.BizId = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].BizId");
				dataItem.Label = _ctx.IntegerValue("GetPatentPlanDetailList.Data["+ i +"].Label");
				dataItem.PlanId = _ctx.LongValue("GetPatentPlanDetailList.Data["+ i +"].PlanId");
				dataItem.Year = _ctx.IntegerValue("GetPatentPlanDetailList.Data["+ i +"].Year");
				dataItem.PlanDetailId = _ctx.LongValue("GetPatentPlanDetailList.Data["+ i +"].PlanDetailId");
				dataItem.PayStatus = _ctx.IntegerValue("GetPatentPlanDetailList.Data["+ i +"].PayStatus");
				dataItem.PatentStatus = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].PatentStatus");
				dataItem.Agency = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].Agency");
				dataItem.Discount = _ctx.IntegerValue("GetPatentPlanDetailList.Data["+ i +"].Discount");
				dataItem.UidAgreement = _ctx.BooleanValue("GetPatentPlanDetailList.Data["+ i +"].UidAgreement");
				dataItem.PatentDiscard = _ctx.BooleanValue("GetPatentPlanDetailList.Data["+ i +"].PatentDiscard");
				dataItem.Name = _ctx.StringValue("GetPatentPlanDetailList.Data["+ i +"].Name");
				dataItem.UpdateTime = _ctx.LongValue("GetPatentPlanDetailList.Data["+ i +"].UpdateTime");

				getPatentPlanDetailListResponse_data.Add(dataItem);
			}
			getPatentPlanDetailListResponse.Data = getPatentPlanDetailListResponse_data;
        
			return getPatentPlanDetailListResponse;
        }
    }
}
