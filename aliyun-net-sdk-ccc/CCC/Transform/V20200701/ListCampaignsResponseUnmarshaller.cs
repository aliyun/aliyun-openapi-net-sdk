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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListCampaignsResponseUnmarshaller
    {
        public static ListCampaignsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCampaignsResponse listCampaignsResponse = new ListCampaignsResponse();

			listCampaignsResponse.HttpResponse = _ctx.HttpResponse;
			listCampaignsResponse.RequestId = _ctx.StringValue("ListCampaigns.RequestId");
			listCampaignsResponse.Message = _ctx.StringValue("ListCampaigns.Message");
			listCampaignsResponse.HttpStatusCode = _ctx.LongValue("ListCampaigns.HttpStatusCode");
			listCampaignsResponse.Code = _ctx.StringValue("ListCampaigns.Code");
			listCampaignsResponse.Success = _ctx.BooleanValue("ListCampaigns.Success");

			ListCampaignsResponse.ListCampaigns_Data data = new ListCampaignsResponse.ListCampaigns_Data();
			data.PageNumber = _ctx.LongValue("ListCampaigns.Data.PageNumber");
			data.PageSize = _ctx.LongValue("ListCampaigns.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListCampaigns.Data.TotalCount");

			List<ListCampaignsResponse.ListCampaigns_Data.ListCampaigns_ListItem> data_list = new List<ListCampaignsResponse.ListCampaigns_Data.ListCampaigns_ListItem>();
			for (int i = 0; i < _ctx.Length("ListCampaigns.Data.List.Length"); i++) {
				ListCampaignsResponse.ListCampaigns_Data.ListCampaigns_ListItem listItem = new ListCampaignsResponse.ListCampaigns_Data.ListCampaigns_ListItem();
				listItem.ActualEndTime = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].ActualEndTime");
				listItem.ActualStartTime = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].ActualStartTime");
				listItem.CasesAborted = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].CasesAborted");
				listItem.CasesUncompleted = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].CasesUncompleted");
				listItem.CasesConnected = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].CasesConnected");
				listItem.CompletedRate = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].CompletedRate");
				listItem.MaxAttemptCount = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].MaxAttemptCount");
				listItem.MinAttemptInterval = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].MinAttemptInterval");
				listItem.Name = _ctx.StringValue("ListCampaigns.Data.List["+ i +"].Name");
				listItem.PlanedEndTime = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].PlanedEndTime");
				listItem.PlanedStartTime = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].PlanedStartTime");
				listItem.QueueName = _ctx.StringValue("ListCampaigns.Data.List["+ i +"].QueueName");
				listItem.TotalCases = _ctx.LongValue("ListCampaigns.Data.List["+ i +"].TotalCases");
				listItem.State = _ctx.StringValue("ListCampaigns.Data.List["+ i +"].State");
				listItem.CampaignId = _ctx.StringValue("ListCampaigns.Data.List["+ i +"].CampaignId");
				listItem.StrategyType = _ctx.StringValue("ListCampaigns.Data.List["+ i +"].StrategyType");
				listItem.StrategyParameters = _ctx.StringValue("ListCampaigns.Data.List["+ i +"].StrategyParameters");
				listItem.QueueId = _ctx.StringValue("ListCampaigns.Data.List["+ i +"].QueueId");
				listItem.Simulation = _ctx.BooleanValue("ListCampaigns.Data.List["+ i +"].Simulation");

				data_list.Add(listItem);
			}
			data.List = data_list;
			listCampaignsResponse.Data = data;
        
			return listCampaignsResponse;
        }
    }
}
