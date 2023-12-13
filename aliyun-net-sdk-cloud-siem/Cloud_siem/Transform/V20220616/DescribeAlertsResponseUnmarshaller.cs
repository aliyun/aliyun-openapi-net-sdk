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
    public class DescribeAlertsResponseUnmarshaller
    {
        public static DescribeAlertsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertsResponse describeAlertsResponse = new DescribeAlertsResponse();

			describeAlertsResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertsResponse.Success = _ctx.BooleanValue("DescribeAlerts.Success");
			describeAlertsResponse.Code = _ctx.IntegerValue("DescribeAlerts.Code");
			describeAlertsResponse.Message = _ctx.StringValue("DescribeAlerts.Message");
			describeAlertsResponse.RequestId = _ctx.StringValue("DescribeAlerts.RequestId");

			DescribeAlertsResponse.DescribeAlerts_Data data = new DescribeAlertsResponse.DescribeAlerts_Data();

			DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_PageInfo pageInfo = new DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeAlerts.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeAlerts.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("DescribeAlerts.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem> data_responseData = new List<DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlerts.Data.ResponseData.Length"); i++) {
				DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem responseDataItem = new DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("DescribeAlerts.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.MainUserId = _ctx.LongValue("DescribeAlerts.Data.ResponseData["+ i +"].MainUserId");
				responseDataItem.IncidentUuid = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.AlertUuid = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertUuid");
				responseDataItem.LogTime = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].LogTime");
				responseDataItem.AlertSrcProd = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertSrcProd");
				responseDataItem.AlertTitle = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertTitle");
				responseDataItem.AlertTitleEn = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertTitleEn");
				responseDataItem.AlertType = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertType");
				responseDataItem.AlertTypeEn = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertTypeEn");
				responseDataItem.AlertTypeCode = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertTypeCode");
				responseDataItem.AlertName = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertName");
				responseDataItem.AlertNameEn = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertNameEn");
				responseDataItem.AlertNameCode = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertNameCode");
				responseDataItem.AlertLevel = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertLevel");
				responseDataItem.AssetList = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AssetList");
				responseDataItem.OccurTime = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].OccurTime");
				responseDataItem.StartTime = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].StartTime");
				responseDataItem.EndTime = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].EndTime");
				responseDataItem.AlertSrcProdModule = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertSrcProdModule");
				responseDataItem.AlertDesc = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertDesc");
				responseDataItem.AlertDescEn = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertDescEn");
				responseDataItem.AlertDescCode = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertDescCode");
				responseDataItem.AlertDetail = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertDetail");
				responseDataItem.LogUuid = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].LogUuid");
				responseDataItem.AttCk = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AttCk");
				responseDataItem.SubUserId = _ctx.LongValue("DescribeAlerts.Data.ResponseData["+ i +"].SubUserId");
				responseDataItem.CloudCode = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].CloudCode");
				responseDataItem.IsDefend = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].IsDefend");

				List<DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem.DescribeAlerts_AlertInfoListItem> responseDataItem_alertInfoList = new List<DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem.DescribeAlerts_AlertInfoListItem>();
				for (int j = 0; j < _ctx.Length("DescribeAlerts.Data.ResponseData["+ i +"].AlertInfoList.Length"); j++) {
					DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem.DescribeAlerts_AlertInfoListItem alertInfoListItem = new DescribeAlertsResponse.DescribeAlerts_Data.DescribeAlerts_ResponseDataItem.DescribeAlerts_AlertInfoListItem();
					alertInfoListItem.Key = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].Key");
					alertInfoListItem.KeyName = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].KeyName");
					alertInfoListItem.Values = _ctx.StringValue("DescribeAlerts.Data.ResponseData["+ i +"].AlertInfoList["+ j +"].Values");

					responseDataItem_alertInfoList.Add(alertInfoListItem);
				}
				responseDataItem.AlertInfoList = responseDataItem_alertInfoList;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			describeAlertsResponse.Data = data;
        
			return describeAlertsResponse;
        }
    }
}
