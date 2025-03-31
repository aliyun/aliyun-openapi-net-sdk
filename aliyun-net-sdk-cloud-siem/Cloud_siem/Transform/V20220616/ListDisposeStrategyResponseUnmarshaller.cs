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
    public class ListDisposeStrategyResponseUnmarshaller
    {
        public static ListDisposeStrategyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDisposeStrategyResponse listDisposeStrategyResponse = new ListDisposeStrategyResponse();

			listDisposeStrategyResponse.HttpResponse = _ctx.HttpResponse;
			listDisposeStrategyResponse.Success = _ctx.BooleanValue("ListDisposeStrategy.Success");
			listDisposeStrategyResponse.Code = _ctx.IntegerValue("ListDisposeStrategy.Code");
			listDisposeStrategyResponse.Message = _ctx.StringValue("ListDisposeStrategy.Message");
			listDisposeStrategyResponse.RequestId = _ctx.StringValue("ListDisposeStrategy.RequestId");

			ListDisposeStrategyResponse.ListDisposeStrategy_Data data = new ListDisposeStrategyResponse.ListDisposeStrategy_Data();

			ListDisposeStrategyResponse.ListDisposeStrategy_Data.ListDisposeStrategy_PageInfo pageInfo = new ListDisposeStrategyResponse.ListDisposeStrategy_Data.ListDisposeStrategy_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListDisposeStrategy.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListDisposeStrategy.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("ListDisposeStrategy.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<ListDisposeStrategyResponse.ListDisposeStrategy_Data.ListDisposeStrategy_ResponseDataItem> data_responseData = new List<ListDisposeStrategyResponse.ListDisposeStrategy_Data.ListDisposeStrategy_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("ListDisposeStrategy.Data.ResponseData.Length"); i++) {
				ListDisposeStrategyResponse.ListDisposeStrategy_Data.ListDisposeStrategy_ResponseDataItem responseDataItem = new ListDisposeStrategyResponse.ListDisposeStrategy_Data.ListDisposeStrategy_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("ListDisposeStrategy.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.Aliuid = _ctx.LongValue("ListDisposeStrategy.Data.ResponseData["+ i +"].Aliuid");
				responseDataItem.SubAliuid = _ctx.LongValue("ListDisposeStrategy.Data.ResponseData["+ i +"].SubAliuid");
				responseDataItem.IncidentName = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].IncidentName");
				responseDataItem.IncidentUuid = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].IncidentUuid");
				responseDataItem.AlertUuid = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].AlertUuid");
				responseDataItem.SophonTaskId = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].SophonTaskId");
				responseDataItem.PlaybookName = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].PlaybookName");
				responseDataItem.PlaybookUuid = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].PlaybookUuid");
				responseDataItem.PlaybookType = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].PlaybookType");
				responseDataItem.TaskUrl = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].TaskUrl");
				responseDataItem.EntityId = _ctx.LongValue("ListDisposeStrategy.Data.ResponseData["+ i +"].EntityId");
				responseDataItem.EntityType = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].EntityType");
				responseDataItem.TaskParam = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].TaskParam");
				responseDataItem.ErrorMessage = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].ErrorMessage");
				responseDataItem.FinishTime = _ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].FinishTime");
				responseDataItem.EffectiveStatus = _ctx.IntegerValue("ListDisposeStrategy.Data.ResponseData["+ i +"].EffectiveStatus");
				responseDataItem.Status = _ctx.IntegerValue("ListDisposeStrategy.Data.ResponseData["+ i +"].Status");

				List<string> responseDataItem_scope = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDisposeStrategy.Data.ResponseData["+ i +"].Scope.Length"); j++) {
					responseDataItem_scope.Add(_ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].Scope["+ j +"]"));
				}
				responseDataItem.Scope = responseDataItem_scope;

				List<string> responseDataItem_entity = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDisposeStrategy.Data.ResponseData["+ i +"].Entity.Length"); j++) {
					responseDataItem_entity.Add(_ctx.StringValue("ListDisposeStrategy.Data.ResponseData["+ i +"].Entity["+ j +"]"));
				}
				responseDataItem.Entity = responseDataItem_entity;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			listDisposeStrategyResponse.Data = data;
        
			return listDisposeStrategyResponse;
        }
    }
}
