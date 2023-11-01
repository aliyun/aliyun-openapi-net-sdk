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
    public class DescribeCloudSiemEventsResponseUnmarshaller
    {
        public static DescribeCloudSiemEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudSiemEventsResponse describeCloudSiemEventsResponse = new DescribeCloudSiemEventsResponse();

			describeCloudSiemEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudSiemEventsResponse.Success = _ctx.BooleanValue("DescribeCloudSiemEvents.Success");
			describeCloudSiemEventsResponse.Code = _ctx.IntegerValue("DescribeCloudSiemEvents.Code");
			describeCloudSiemEventsResponse.Message = _ctx.StringValue("DescribeCloudSiemEvents.Message");
			describeCloudSiemEventsResponse.RequestId = _ctx.StringValue("DescribeCloudSiemEvents.RequestId");

			DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data data = new DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data();

			DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data.DescribeCloudSiemEvents_PageInfo pageInfo = new DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data.DescribeCloudSiemEvents_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeCloudSiemEvents.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeCloudSiemEvents.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("DescribeCloudSiemEvents.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data.DescribeCloudSiemEvents_ResponseDataItem> data_responseData = new List<DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data.DescribeCloudSiemEvents_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCloudSiemEvents.Data.ResponseData.Length"); i++) {
				DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data.DescribeCloudSiemEvents_ResponseDataItem responseDataItem = new DescribeCloudSiemEventsResponse.DescribeCloudSiemEvents_Data.DescribeCloudSiemEvents_ResponseDataItem();
				responseDataItem.GmtCreate = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.Aliuid = _ctx.LongValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].Aliuid");
				responseDataItem.AlertNum = _ctx.IntegerValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].AlertNum");
				responseDataItem.AssetNum = _ctx.IntegerValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].AssetNum");
				responseDataItem.IncidentUuid = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.IncidentName = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].IncidentName");
				responseDataItem.IncidentNameEn = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].IncidentNameEn");
				responseDataItem.Description = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].Description");
				responseDataItem.DescriptionEn = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].DescriptionEn");
				responseDataItem.ThreatLevel = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].ThreatLevel");
				responseDataItem.ThreatScore = _ctx.FloatValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].ThreatScore");
				responseDataItem.ExtContent = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].ExtContent");
				responseDataItem.Status = _ctx.IntegerValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].Status");
				responseDataItem.Remark = _ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].Remark");

				List<string> responseDataItem_dataSources = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].DataSources.Length"); j++) {
					responseDataItem_dataSources.Add(_ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].DataSources["+ j +"]"));
				}
				responseDataItem.DataSources = responseDataItem_dataSources;

				List<string> responseDataItem_attCkLabels = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].AttCkLabels.Length"); j++) {
					responseDataItem_attCkLabels.Add(_ctx.StringValue("DescribeCloudSiemEvents.Data.ResponseData["+ i +"].AttCkLabels["+ j +"]"));
				}
				responseDataItem.AttCkLabels = responseDataItem_attCkLabels;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			describeCloudSiemEventsResponse.Data = data;
        
			return describeCloudSiemEventsResponse;
        }
    }
}
