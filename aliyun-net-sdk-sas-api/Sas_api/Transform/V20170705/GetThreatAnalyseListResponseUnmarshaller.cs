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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Sas_api.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class GetThreatAnalyseListResponseUnmarshaller
    {
        public static GetThreatAnalyseListResponse Unmarshall(UnmarshallerContext context)
        {
			GetThreatAnalyseListResponse getThreatAnalyseListResponse = new GetThreatAnalyseListResponse();

			getThreatAnalyseListResponse.HttpResponse = context.HttpResponse;
			getThreatAnalyseListResponse.Code = context.StringValue("GetThreatAnalyseList.Code");
			getThreatAnalyseListResponse.Message = context.StringValue("GetThreatAnalyseList.Message");
			getThreatAnalyseListResponse.Success = context.BooleanValue("GetThreatAnalyseList.Success");

			GetThreatAnalyseListResponse.GetThreatAnalyseList_Data data = new GetThreatAnalyseListResponse.GetThreatAnalyseList_Data();
			data.Total = context.LongValue("GetThreatAnalyseList.Data.Total");

			List<GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item> data_items = new List<GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item>();
			for (int i = 0; i < context.Length("GetThreatAnalyseList.Data.Items.Length"); i++) {
				GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item item = new GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item();
				item.Id = context.LongValue("GetThreatAnalyseList.Data.Items["+ i +"].Id");
				item.Level = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Level");
				item.Uuid = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Uuid");
				item.Product = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Product");
				item.VmIp = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].VmIp");
				item.Url = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Url");
				item.Method = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Method");
				item.SourceIp = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].SourceIp");
				item.SourceUuid = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].SourceUuid");
				item.SourceDomain = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].SourceDomain");
				item.SourcePort = context.IntegerValue("GetThreatAnalyseList.Data.Items["+ i +"].SourcePort");
				item.SourceLocal = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].SourceLocal");
				item.DstIp = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].DstIp");
				item.DstUuid = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].DstUuid");
				item.DstDomain = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].DstDomain");
				item.DstPort = context.IntegerValue("GetThreatAnalyseList.Data.Items["+ i +"].DstPort");
				item.DstLocal = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].DstLocal");
				item.AttackCount = context.LongValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackCount");
				item.ThreatRate = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].ThreatRate");
				item.AttackStartTime = context.LongValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackStartTime");
				item.AttackEndTime = context.LongValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackEndTime");
				item.AttackCategory = context.IntegerValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackCategory");
				item.AttackCategoryName = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackCategoryName");
				item.AttackType = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackType");
				item.AttackTypeName = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackTypeName");
				item.AttackStatus = context.IntegerValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackStatus");
				item.AttackSource = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].AttackSource");

				List<GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item.GetThreatAnalyseList_Detail> item_details = new List<GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item.GetThreatAnalyseList_Detail>();
				for (int j = 0; j < context.Length("GetThreatAnalyseList.Data.Items["+ i +"].Details.Length"); j++) {
					GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item.GetThreatAnalyseList_Detail detail = new GetThreatAnalyseListResponse.GetThreatAnalyseList_Data.GetThreatAnalyseList_Item.GetThreatAnalyseList_Detail();
					detail._Value = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Details["+ j +"].Value");
					detail.Type = context.IntegerValue("GetThreatAnalyseList.Data.Items["+ i +"].Details["+ j +"].Type");
					detail.Label = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Details["+ j +"].Label");
					detail.LinkText = context.StringValue("GetThreatAnalyseList.Data.Items["+ i +"].Details["+ j +"].LinkText");

					item_details.Add(detail);
				}
				item.Details = item_details;

				data_items.Add(item);
			}
			data.Items = data_items;
			getThreatAnalyseListResponse.Data = data;
        
			return getThreatAnalyseListResponse;
        }
    }
}