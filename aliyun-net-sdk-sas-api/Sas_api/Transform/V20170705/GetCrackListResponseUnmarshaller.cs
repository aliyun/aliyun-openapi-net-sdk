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
    public class GetCrackListResponseUnmarshaller
    {
        public static GetCrackListResponse Unmarshall(UnmarshallerContext context)
        {
			GetCrackListResponse getCrackListResponse = new GetCrackListResponse();

			getCrackListResponse.HttpResponse = context.HttpResponse;
			getCrackListResponse.Code = context.StringValue("GetCrackList.Code");
			getCrackListResponse.Message = context.StringValue("GetCrackList.Message");
			getCrackListResponse.Success = context.BooleanValue("GetCrackList.Success");

			GetCrackListResponse.GetCrackList_Data data = new GetCrackListResponse.GetCrackList_Data();
			data.Total = context.LongValue("GetCrackList.Data.Total");

			List<GetCrackListResponse.GetCrackList_Data.GetCrackList_Item> data_items = new List<GetCrackListResponse.GetCrackList_Data.GetCrackList_Item>();
			for (int i = 0; i < context.Length("GetCrackList.Data.Items.Length"); i++) {
				GetCrackListResponse.GetCrackList_Data.GetCrackList_Item item = new GetCrackListResponse.GetCrackList_Data.GetCrackList_Item();
				item.Id = context.LongValue("GetCrackList.Data.Items["+ i +"].Id");
				item.Level = context.StringValue("GetCrackList.Data.Items["+ i +"].Level");
				item.Uuid = context.StringValue("GetCrackList.Data.Items["+ i +"].Uuid");
				item.Product = context.StringValue("GetCrackList.Data.Items["+ i +"].Product");
				item.VmIp = context.StringValue("GetCrackList.Data.Items["+ i +"].VmIp");
				item.Url = context.StringValue("GetCrackList.Data.Items["+ i +"].Url");
				item.Method = context.StringValue("GetCrackList.Data.Items["+ i +"].Method");
				item.SourceIp = context.StringValue("GetCrackList.Data.Items["+ i +"].SourceIp");
				item.SourceUuid = context.StringValue("GetCrackList.Data.Items["+ i +"].SourceUuid");
				item.SourceDomain = context.StringValue("GetCrackList.Data.Items["+ i +"].SourceDomain");
				item.SourcePort = context.IntegerValue("GetCrackList.Data.Items["+ i +"].SourcePort");
				item.SourceLocal = context.StringValue("GetCrackList.Data.Items["+ i +"].SourceLocal");
				item.DstIp = context.StringValue("GetCrackList.Data.Items["+ i +"].DstIp");
				item.DstUuid = context.StringValue("GetCrackList.Data.Items["+ i +"].DstUuid");
				item.DstDomain = context.StringValue("GetCrackList.Data.Items["+ i +"].DstDomain");
				item.DstPort = context.IntegerValue("GetCrackList.Data.Items["+ i +"].DstPort");
				item.DstLocal = context.StringValue("GetCrackList.Data.Items["+ i +"].DstLocal");
				item.AttackCount = context.LongValue("GetCrackList.Data.Items["+ i +"].AttackCount");
				item.ThreatRate = context.StringValue("GetCrackList.Data.Items["+ i +"].ThreatRate");
				item.AttackStartTime = context.LongValue("GetCrackList.Data.Items["+ i +"].AttackStartTime");
				item.AttackEndTime = context.LongValue("GetCrackList.Data.Items["+ i +"].AttackEndTime");
				item.AttackCategory = context.IntegerValue("GetCrackList.Data.Items["+ i +"].AttackCategory");
				item.AttackCategoryName = context.StringValue("GetCrackList.Data.Items["+ i +"].AttackCategoryName");
				item.AttackType = context.StringValue("GetCrackList.Data.Items["+ i +"].AttackType");
				item.AttackTypeName = context.StringValue("GetCrackList.Data.Items["+ i +"].AttackTypeName");
				item.AttackStatus = context.IntegerValue("GetCrackList.Data.Items["+ i +"].AttackStatus");
				item.AttackSource = context.StringValue("GetCrackList.Data.Items["+ i +"].AttackSource");

				List<GetCrackListResponse.GetCrackList_Data.GetCrackList_Item.GetCrackList_Detail> item_details = new List<GetCrackListResponse.GetCrackList_Data.GetCrackList_Item.GetCrackList_Detail>();
				for (int j = 0; j < context.Length("GetCrackList.Data.Items["+ i +"].Details.Length"); j++) {
					GetCrackListResponse.GetCrackList_Data.GetCrackList_Item.GetCrackList_Detail detail = new GetCrackListResponse.GetCrackList_Data.GetCrackList_Item.GetCrackList_Detail();
					detail._Value = context.StringValue("GetCrackList.Data.Items["+ i +"].Details["+ j +"].Value");
					detail.Type = context.IntegerValue("GetCrackList.Data.Items["+ i +"].Details["+ j +"].Type");
					detail.Label = context.StringValue("GetCrackList.Data.Items["+ i +"].Details["+ j +"].Label");
					detail.LinkText = context.StringValue("GetCrackList.Data.Items["+ i +"].Details["+ j +"].LinkText");

					item_details.Add(detail);
				}
				item.Details = item_details;

				data_items.Add(item);
			}
			data.Items = data_items;
			getCrackListResponse.Data = data;
        
			return getCrackListResponse;
        }
    }
}