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
    public class ListCloudSiemCustomizeRulesResponseUnmarshaller
    {
        public static ListCloudSiemCustomizeRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCloudSiemCustomizeRulesResponse listCloudSiemCustomizeRulesResponse = new ListCloudSiemCustomizeRulesResponse();

			listCloudSiemCustomizeRulesResponse.HttpResponse = _ctx.HttpResponse;
			listCloudSiemCustomizeRulesResponse.Success = _ctx.BooleanValue("ListCloudSiemCustomizeRules.Success");
			listCloudSiemCustomizeRulesResponse.Code = _ctx.IntegerValue("ListCloudSiemCustomizeRules.Code");
			listCloudSiemCustomizeRulesResponse.Message = _ctx.StringValue("ListCloudSiemCustomizeRules.Message");
			listCloudSiemCustomizeRulesResponse.RequestId = _ctx.StringValue("ListCloudSiemCustomizeRules.RequestId");

			ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data data = new ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data();

			ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data.ListCloudSiemCustomizeRules_PageInfo pageInfo = new ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data.ListCloudSiemCustomizeRules_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListCloudSiemCustomizeRules.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListCloudSiemCustomizeRules.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("ListCloudSiemCustomizeRules.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data.ListCloudSiemCustomizeRules_ResponseDataItem> data_responseData = new List<ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data.ListCloudSiemCustomizeRules_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("ListCloudSiemCustomizeRules.Data.ResponseData.Length"); i++) {
				ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data.ListCloudSiemCustomizeRules_ResponseDataItem responseDataItem = new ListCloudSiemCustomizeRulesResponse.ListCloudSiemCustomizeRules_Data.ListCloudSiemCustomizeRules_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.Aliuid = _ctx.LongValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].Aliuid");
				responseDataItem.RuleName = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].RuleName");
				responseDataItem.RuleDesc = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].RuleDesc");
				responseDataItem.RuleType = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].RuleType");
				responseDataItem.ThreatLevel = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].ThreatLevel");
				responseDataItem.AlertType = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].AlertType");
				responseDataItem.AlertTypeMds = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].AlertTypeMds");
				responseDataItem.LogType = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].LogType");
				responseDataItem.LogTypeMds = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].LogTypeMds");
				responseDataItem.LogSource = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].LogSource");
				responseDataItem.LogSourceMds = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].LogSourceMds");
				responseDataItem.RuleCondition = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].RuleCondition");
				responseDataItem.RuleGroup = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].RuleGroup");
				responseDataItem.RuleThreshold = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].RuleThreshold");
				responseDataItem.QueryCycle = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].QueryCycle");
				responseDataItem.AttCk = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].AttCk");
				responseDataItem.EventTransferSwitch = _ctx.IntegerValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].EventTransferSwitch");
				responseDataItem.EventTransferType = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].EventTransferType");
				responseDataItem.EventTransferExt = _ctx.StringValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].EventTransferExt");
				responseDataItem.Status = _ctx.IntegerValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].Status");
				responseDataItem.DataType = _ctx.IntegerValue("ListCloudSiemCustomizeRules.Data.ResponseData["+ i +"].DataType");

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			listCloudSiemCustomizeRulesResponse.Data = data;
        
			return listCloudSiemCustomizeRulesResponse;
        }
    }
}
