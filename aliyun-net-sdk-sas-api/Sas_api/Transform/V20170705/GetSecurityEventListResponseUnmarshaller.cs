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
    public class GetSecurityEventListResponseUnmarshaller
    {
        public static GetSecurityEventListResponse Unmarshall(UnmarshallerContext context)
        {
			GetSecurityEventListResponse getSecurityEventListResponse = new GetSecurityEventListResponse();

			getSecurityEventListResponse.HttpResponse = context.HttpResponse;
			getSecurityEventListResponse.Code = context.StringValue("GetSecurityEventList.Code");
			getSecurityEventListResponse.Message = context.StringValue("GetSecurityEventList.Message");
			getSecurityEventListResponse.Success = context.BooleanValue("GetSecurityEventList.Success");

			GetSecurityEventListResponse.GetSecurityEventList_Data data = new GetSecurityEventListResponse.GetSecurityEventList_Data();
			data.Total = context.LongValue("GetSecurityEventList.Data.Total");

			List<GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item> data_items = new List<GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item>();
			for (int i = 0; i < context.Length("GetSecurityEventList.Data.Items.Length"); i++) {
				GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item item = new GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item();
				item.Id = context.LongValue("GetSecurityEventList.Data.Items["+ i +"].Id");
				item.Level = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Level");
				item.Uuid = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Uuid");
				item.Product = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Product");
				item.VmIp = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].VmIp");
				item.Url = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Url");
				item.Method = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Method");
				item.SourceIp = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].SourceIp");
				item.SourceUuid = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].SourceUuid");
				item.SourceDomain = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].SourceDomain");
				item.SourcePort = context.IntegerValue("GetSecurityEventList.Data.Items["+ i +"].SourcePort");
				item.SourceLocal = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].SourceLocal");
				item.DstIp = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].DstIp");
				item.DstUuid = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].DstUuid");
				item.DstDomain = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].DstDomain");
				item.DstPort = context.IntegerValue("GetSecurityEventList.Data.Items["+ i +"].DstPort");
				item.DstLocal = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].DstLocal");
				item.AttackCount = context.LongValue("GetSecurityEventList.Data.Items["+ i +"].AttackCount");
				item.ThreatRate = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].ThreatRate");
				item.AttackStartTime = context.LongValue("GetSecurityEventList.Data.Items["+ i +"].AttackStartTime");
				item.AttackEndTime = context.LongValue("GetSecurityEventList.Data.Items["+ i +"].AttackEndTime");
				item.AttackCategory = context.IntegerValue("GetSecurityEventList.Data.Items["+ i +"].AttackCategory");
				item.AttackCategoryName = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].AttackCategoryName");
				item.AttackType = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].AttackType");
				item.AttackTypeName = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].AttackTypeName");
				item.AttackStatus = context.IntegerValue("GetSecurityEventList.Data.Items["+ i +"].AttackStatus");
				item.AttackSource = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].AttackSource");

				List<GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item.GetSecurityEventList_Detail> item_details = new List<GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item.GetSecurityEventList_Detail>();
				for (int j = 0; j < context.Length("GetSecurityEventList.Data.Items["+ i +"].Details.Length"); j++) {
					GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item.GetSecurityEventList_Detail detail = new GetSecurityEventListResponse.GetSecurityEventList_Data.GetSecurityEventList_Item.GetSecurityEventList_Detail();
					detail._Value = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Details["+ j +"].Value");
					detail.Type = context.IntegerValue("GetSecurityEventList.Data.Items["+ i +"].Details["+ j +"].Type");
					detail.Label = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Details["+ j +"].Label");
					detail.LinkText = context.StringValue("GetSecurityEventList.Data.Items["+ i +"].Details["+ j +"].LinkText");

					item_details.Add(detail);
				}
				item.Details = item_details;

				data_items.Add(item);
			}
			data.Items = data_items;
			getSecurityEventListResponse.Data = data;
        
			return getSecurityEventListResponse;
        }
    }
}