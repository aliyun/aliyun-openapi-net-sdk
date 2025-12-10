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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeAlertsWithEventResponseUnmarshaller
    {
        public static DescribeAlertsWithEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertsWithEventResponse describeAlertsWithEventResponse = new DescribeAlertsWithEventResponse();

			describeAlertsWithEventResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertsWithEventResponse.Success = _ctx.BooleanValue("DescribeAlertsWithEvent.Success");
			describeAlertsWithEventResponse.Code = _ctx.IntegerValue("DescribeAlertsWithEvent.Code");
			describeAlertsWithEventResponse.Message = _ctx.StringValue("DescribeAlertsWithEvent.Message");
			describeAlertsWithEventResponse.RequestId = _ctx.StringValue("DescribeAlertsWithEvent.RequestId");

			DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data data = new DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data();

			DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_PageInfo pageInfo = new DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeAlertsWithEvent.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeAlertsWithEvent.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("DescribeAlertsWithEvent.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem> data_responseData = new List<DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlertsWithEvent.Data.ResponseData.Length"); i++) {
				DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem responseDataItem = new DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.MainUserId = _ctx.LongValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].MainUserId");
				responseDataItem.IncidentUuid = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.AlertUuid = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertUuid");
				responseDataItem.LogTime = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].LogTime");
				responseDataItem.AlertSrcProd = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertSrcProd");
				responseDataItem.AlertTitle = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertTitle");
				responseDataItem.AlertTitleEn = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertTitleEn");
				responseDataItem.AlertType = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertType");
				responseDataItem.AlertTypeEn = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertTypeEn");
				responseDataItem.AlertTypeCode = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertTypeCode");
				responseDataItem.AlertName = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertName");
				responseDataItem.AlertNameEn = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertNameEn");
				responseDataItem.AlertNameCode = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertNameCode");
				responseDataItem.AlertLevel = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertLevel");
				responseDataItem.AssetList = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AssetList");
				responseDataItem.OccurTime = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].OccurTime");
				responseDataItem.StartTime = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].StartTime");
				responseDataItem.EndTime = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].EndTime");
				responseDataItem.AlertSrcProdModule = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertSrcProdModule");
				responseDataItem.AlertDesc = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertDesc");
				responseDataItem.AlertDescEn = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertDescEn");
				responseDataItem.AlertDescCode = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertDescCode");
				responseDataItem.AlertDetail = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertDetail");
				responseDataItem.LogUuid = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].LogUuid");
				responseDataItem.EntityList = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].EntityList");
				responseDataItem.AttCk = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AttCk");
				responseDataItem.SubUserId = _ctx.LongValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].SubUserId");
				responseDataItem.SubUserName = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].SubUserName");
				responseDataItem.CloudCode = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].CloudCode");
				responseDataItem.IsDefend = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].IsDefend");
				responseDataItem.ExtendContent = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].ExtendContent");
				responseDataItem.ProductId = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].ProductId");
				responseDataItem.VendorId = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].VendorId");
				responseDataItem.DetectionRuleId = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].DetectionRuleId");

				List<DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem.DescribeAlertsWithEvent_AlertInfoListItem> responseDataItem_alertInfoList = new List<DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem.DescribeAlertsWithEvent_AlertInfoListItem>();
				for (int j = 0; j < _ctx.Length("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertInfoList.Length"); j++) {
					DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem.DescribeAlertsWithEvent_AlertInfoListItem alertInfoListItem = new DescribeAlertsWithEventResponse.DescribeAlertsWithEvent_Data.DescribeAlertsWithEvent_ResponseDataItem.DescribeAlertsWithEvent_AlertInfoListItem();
					alertInfoListItem.Key = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].Key");
					alertInfoListItem.KeyName = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].KeyName");
					alertInfoListItem.Values = _ctx.StringValue("DescribeAlertsWithEvent.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].Values");

					responseDataItem_alertInfoList.Add(alertInfoListItem);
				}
				responseDataItem.AlertInfoList = responseDataItem_alertInfoList;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			describeAlertsWithEventResponse.Data = data;
        
			return describeAlertsWithEventResponse;
        }
    }
}
