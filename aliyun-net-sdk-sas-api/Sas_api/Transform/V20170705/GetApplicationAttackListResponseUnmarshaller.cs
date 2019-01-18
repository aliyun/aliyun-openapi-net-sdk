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
    public class GetApplicationAttackListResponseUnmarshaller
    {
        public static GetApplicationAttackListResponse Unmarshall(UnmarshallerContext context)
        {
			GetApplicationAttackListResponse getApplicationAttackListResponse = new GetApplicationAttackListResponse();

			getApplicationAttackListResponse.HttpResponse = context.HttpResponse;
			getApplicationAttackListResponse.Code = context.StringValue("GetApplicationAttackList.Code");
			getApplicationAttackListResponse.Message = context.StringValue("GetApplicationAttackList.Message");
			getApplicationAttackListResponse.Success = context.BooleanValue("GetApplicationAttackList.Success");

			GetApplicationAttackListResponse.GetApplicationAttackList_Data data = new GetApplicationAttackListResponse.GetApplicationAttackList_Data();
			data.Total = context.LongValue("GetApplicationAttackList.Data.Total");

			List<GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item> data_items = new List<GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item>();
			for (int i = 0; i < context.Length("GetApplicationAttackList.Data.Items.Length"); i++) {
				GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item item = new GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item();
				item.Id = context.LongValue("GetApplicationAttackList.Data.Items["+ i +"].Id");
				item.Level = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Level");
				item.Uuid = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Uuid");
				item.Product = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Product");
				item.VmIp = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].VmIp");
				item.Url = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Url");
				item.Method = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Method");
				item.SourceIp = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].SourceIp");
				item.SourceUuid = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].SourceUuid");
				item.SourceDomain = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].SourceDomain");
				item.SourcePort = context.IntegerValue("GetApplicationAttackList.Data.Items["+ i +"].SourcePort");
				item.SourceLocal = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].SourceLocal");
				item.DstIp = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].DstIp");
				item.DstUuid = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].DstUuid");
				item.DstDomain = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].DstDomain");
				item.DstPort = context.IntegerValue("GetApplicationAttackList.Data.Items["+ i +"].DstPort");
				item.DstLocal = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].DstLocal");
				item.AttackCount = context.LongValue("GetApplicationAttackList.Data.Items["+ i +"].AttackCount");
				item.ThreatRate = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].ThreatRate");
				item.AttackStartTime = context.LongValue("GetApplicationAttackList.Data.Items["+ i +"].AttackStartTime");
				item.AttackEndTime = context.LongValue("GetApplicationAttackList.Data.Items["+ i +"].AttackEndTime");
				item.AttackCategory = context.IntegerValue("GetApplicationAttackList.Data.Items["+ i +"].AttackCategory");
				item.AttackCategoryName = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].AttackCategoryName");
				item.AttackType = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].AttackType");
				item.AttackTypeName = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].AttackTypeName");
				item.AttackStatus = context.IntegerValue("GetApplicationAttackList.Data.Items["+ i +"].AttackStatus");
				item.AttackSource = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].AttackSource");

				List<GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item.GetApplicationAttackList_Detail> item_details = new List<GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item.GetApplicationAttackList_Detail>();
				for (int j = 0; j < context.Length("GetApplicationAttackList.Data.Items["+ i +"].Details.Length"); j++) {
					GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item.GetApplicationAttackList_Detail detail = new GetApplicationAttackListResponse.GetApplicationAttackList_Data.GetApplicationAttackList_Item.GetApplicationAttackList_Detail();
					detail._Value = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Details["+ j +"].Value");
					detail.Type = context.IntegerValue("GetApplicationAttackList.Data.Items["+ i +"].Details["+ j +"].Type");
					detail.Label = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Details["+ j +"].Label");
					detail.LinkText = context.StringValue("GetApplicationAttackList.Data.Items["+ i +"].Details["+ j +"].LinkText");

					item_details.Add(detail);
				}
				item.Details = item_details;

				data_items.Add(item);
			}
			data.Items = data_items;
			getApplicationAttackListResponse.Data = data;
        
			return getApplicationAttackListResponse;
        }
    }
}