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
    public class DescribeAlertsWithEntityResponseUnmarshaller
    {
        public static DescribeAlertsWithEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertsWithEntityResponse describeAlertsWithEntityResponse = new DescribeAlertsWithEntityResponse();

			describeAlertsWithEntityResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertsWithEntityResponse.Success = _ctx.BooleanValue("DescribeAlertsWithEntity.Success");
			describeAlertsWithEntityResponse.Code = _ctx.IntegerValue("DescribeAlertsWithEntity.Code");
			describeAlertsWithEntityResponse.Message = _ctx.StringValue("DescribeAlertsWithEntity.Message");
			describeAlertsWithEntityResponse.RequestId = _ctx.StringValue("DescribeAlertsWithEntity.RequestId");

			DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data data = new DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data();

			DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_PageInfo pageInfo = new DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeAlertsWithEntity.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeAlertsWithEntity.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("DescribeAlertsWithEntity.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem> data_responseData = new List<DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlertsWithEntity.Data.ResponseData.Length"); i++) {
				DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem responseDataItem = new DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.MainUserId = _ctx.LongValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].MainUserId");
				responseDataItem.IncidentUuid = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.AlertUuid = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertUuid");
				responseDataItem.LogTime = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].LogTime");
				responseDataItem.AlertSrcProd = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertSrcProd");
				responseDataItem.AlertTitle = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertTitle");
				responseDataItem.AlertTitleEn = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertTitleEn");
				responseDataItem.AlertType = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertType");
				responseDataItem.AlertTypeEn = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertTypeEn");
				responseDataItem.AlertTypeCode = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertTypeCode");
				responseDataItem.AlertName = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertName");
				responseDataItem.AlertNameEn = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertNameEn");
				responseDataItem.AlertNameCode = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertNameCode");
				responseDataItem.AlertLevel = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertLevel");
				responseDataItem.AssetList = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AssetList");
				responseDataItem.OccurTime = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].OccurTime");
				responseDataItem.StartTime = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].StartTime");
				responseDataItem.EndTime = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].EndTime");
				responseDataItem.AlertSrcProdModule = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertSrcProdModule");
				responseDataItem.AlertDesc = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertDesc");
				responseDataItem.AlertDescEn = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertDescEn");
				responseDataItem.AlertDescCode = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertDescCode");
				responseDataItem.AlertDetail = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertDetail");
				responseDataItem.LogUuid = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].LogUuid");
				responseDataItem.EntityList = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].EntityList");
				responseDataItem.AttCk = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AttCk");
				responseDataItem.SubUserId = _ctx.LongValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].SubUserId");
				responseDataItem.SubUserName = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].SubUserName");
				responseDataItem.IsDefend = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].IsDefend");
				responseDataItem.CloudCode = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].CloudCode");
				responseDataItem.ProductId = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].ProductId");
				responseDataItem.VendorId = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].VendorId");
				responseDataItem.DetectionRuleId = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].DetectionRuleId");

				List<DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem.DescribeAlertsWithEntity_AlertInfoListItem> responseDataItem_alertInfoList = new List<DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem.DescribeAlertsWithEntity_AlertInfoListItem>();
				for (int j = 0; j < _ctx.Length("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertInfoList.Length"); j++) {
					DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem.DescribeAlertsWithEntity_AlertInfoListItem alertInfoListItem = new DescribeAlertsWithEntityResponse.DescribeAlertsWithEntity_Data.DescribeAlertsWithEntity_ResponseDataItem.DescribeAlertsWithEntity_AlertInfoListItem();
					alertInfoListItem.Key = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].Key");
					alertInfoListItem.KeyName = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].KeyName");
					alertInfoListItem.Values = _ctx.StringValue("DescribeAlertsWithEntity.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].Values");

					responseDataItem_alertInfoList.Add(alertInfoListItem);
				}
				responseDataItem.AlertInfoList = responseDataItem_alertInfoList;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			describeAlertsWithEntityResponse.Data = data;
        
			return describeAlertsWithEntityResponse;
        }
    }
}
