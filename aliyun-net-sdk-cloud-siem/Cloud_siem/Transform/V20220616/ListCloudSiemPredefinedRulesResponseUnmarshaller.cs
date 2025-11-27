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
    public class ListCloudSiemPredefinedRulesResponseUnmarshaller
    {
        public static ListCloudSiemPredefinedRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCloudSiemPredefinedRulesResponse listCloudSiemPredefinedRulesResponse = new ListCloudSiemPredefinedRulesResponse();

			listCloudSiemPredefinedRulesResponse.HttpResponse = _ctx.HttpResponse;
			listCloudSiemPredefinedRulesResponse.Success = _ctx.BooleanValue("ListCloudSiemPredefinedRules.Success");
			listCloudSiemPredefinedRulesResponse.Code = _ctx.IntegerValue("ListCloudSiemPredefinedRules.Code");
			listCloudSiemPredefinedRulesResponse.Message = _ctx.StringValue("ListCloudSiemPredefinedRules.Message");
			listCloudSiemPredefinedRulesResponse.RequestId = _ctx.StringValue("ListCloudSiemPredefinedRules.RequestId");

			ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data data = new ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data();

			ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data.ListCloudSiemPredefinedRules_PageInfo pageInfo = new ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data.ListCloudSiemPredefinedRules_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListCloudSiemPredefinedRules.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListCloudSiemPredefinedRules.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("ListCloudSiemPredefinedRules.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data.ListCloudSiemPredefinedRules_ResponseDataItem> data_responseData = new List<ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data.ListCloudSiemPredefinedRules_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("ListCloudSiemPredefinedRules.Data.ResponseData.Length"); i++) {
				ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data.ListCloudSiemPredefinedRules_ResponseDataItem responseDataItem = new ListCloudSiemPredefinedRulesResponse.ListCloudSiemPredefinedRules_Data.ListCloudSiemPredefinedRules_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.RuleName = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].RuleName");
				responseDataItem.RuleNameCn = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].RuleNameCn");
				responseDataItem.RuleNameEn = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].RuleNameEn");
				responseDataItem.RuleNameMds = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].RuleNameMds");
				responseDataItem.RuleDescMds = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].RuleDescMds");
				responseDataItem.ThreatLevel = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].ThreatLevel");
				responseDataItem.AlertType = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].AlertType");
				responseDataItem.Source = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].Source");
				responseDataItem.EventTransferType = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].EventTransferType");
				responseDataItem.AttCk = _ctx.StringValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].AttCk");
				responseDataItem.Status = _ctx.IntegerValue("ListCloudSiemPredefinedRules.Data.ResponseData["+ i +"].Status");

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			listCloudSiemPredefinedRulesResponse.Data = data;
        
			return listCloudSiemPredefinedRulesResponse;
        }
    }
}
