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
    public class ListEntitiesResponseUnmarshaller
    {
        public static ListEntitiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEntitiesResponse listEntitiesResponse = new ListEntitiesResponse();

			listEntitiesResponse.HttpResponse = _ctx.HttpResponse;
			listEntitiesResponse.Success = _ctx.BooleanValue("ListEntities.Success");
			listEntitiesResponse.Code = _ctx.IntegerValue("ListEntities.Code");
			listEntitiesResponse.Message = _ctx.StringValue("ListEntities.Message");
			listEntitiesResponse.RequestId = _ctx.StringValue("ListEntities.RequestId");

			ListEntitiesResponse.ListEntities_Data data = new ListEntitiesResponse.ListEntities_Data();

			ListEntitiesResponse.ListEntities_Data.ListEntities_PageInfo pageInfo = new ListEntitiesResponse.ListEntities_Data.ListEntities_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListEntities.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListEntities.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("ListEntities.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<ListEntitiesResponse.ListEntities_Data.ListEntities_ResponseDataItem> data_responseData = new List<ListEntitiesResponse.ListEntities_Data.ListEntities_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("ListEntities.Data.ResponseData.Length"); i++) {
				ListEntitiesResponse.ListEntities_Data.ListEntities_ResponseDataItem responseDataItem = new ListEntitiesResponse.ListEntities_Data.ListEntities_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("ListEntities.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.Aliuid = _ctx.LongValue("ListEntities.Data.ResponseData["+ i +"].Aliuid");
				responseDataItem.IncidentUuid = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.AlertUuid = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].AlertUuid");
				responseDataItem.AlertNum = _ctx.IntegerValue("ListEntities.Data.ResponseData["+ i +"].AlertNum");
				responseDataItem.EventNum = _ctx.IntegerValue("ListEntities.Data.ResponseData["+ i +"].EventNum");
				responseDataItem.CloudCode = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].CloudCode");
				responseDataItem.EntityType = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].EntityType");
				responseDataItem.EntityName = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].EntityName");
				responseDataItem.EntityInfo = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].EntityInfo");
				responseDataItem.SubUserId = _ctx.LongValue("ListEntities.Data.ResponseData["+ i +"].SubUserId");
				responseDataItem.EntityId = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].EntityId");
				responseDataItem.EntityUuid = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].EntityUuid");
				responseDataItem.MalwareType = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].MalwareType");
				responseDataItem.IsAsset = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].IsAsset");
				responseDataItem.IsMalware = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].IsMalware");
				responseDataItem.Tags = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].Tags");
				responseDataItem.AgentDisposalMethod = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].AgentDisposalMethod");
				responseDataItem.AgentDisposalPlaybookUuid = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].AgentDisposalPlaybookUuid");
				responseDataItem.AgentDisposalSuggestion = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].AgentDisposalSuggestion");
				responseDataItem.AgentConfidence = _ctx.StringValue("ListEntities.Data.ResponseData["+ i +"].AgentConfidence");

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			listEntitiesResponse.Data = data;
        
			return listEntitiesResponse;
        }
    }
}
