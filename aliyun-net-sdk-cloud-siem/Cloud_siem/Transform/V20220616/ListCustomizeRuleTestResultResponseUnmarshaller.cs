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
    public class ListCustomizeRuleTestResultResponseUnmarshaller
    {
        public static ListCustomizeRuleTestResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCustomizeRuleTestResultResponse listCustomizeRuleTestResultResponse = new ListCustomizeRuleTestResultResponse();

			listCustomizeRuleTestResultResponse.HttpResponse = _ctx.HttpResponse;
			listCustomizeRuleTestResultResponse.Success = _ctx.BooleanValue("ListCustomizeRuleTestResult.Success");
			listCustomizeRuleTestResultResponse.Code = _ctx.IntegerValue("ListCustomizeRuleTestResult.Code");
			listCustomizeRuleTestResultResponse.Message = _ctx.StringValue("ListCustomizeRuleTestResult.Message");
			listCustomizeRuleTestResultResponse.RequestId = _ctx.StringValue("ListCustomizeRuleTestResult.RequestId");

			ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data data = new ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data();

			ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data.ListCustomizeRuleTestResult_PageInfo pageInfo = new ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data.ListCustomizeRuleTestResult_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListCustomizeRuleTestResult.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListCustomizeRuleTestResult.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("ListCustomizeRuleTestResult.Data.PageInfo.TotalCount");
			pageInfo.VerifiedCount = _ctx.LongValue("ListCustomizeRuleTestResult.Data.PageInfo.VerifiedCount");
			data.PageInfo = pageInfo;

			List<ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data.ListCustomizeRuleTestResult_ResponseDataItem> data_responseData = new List<ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data.ListCustomizeRuleTestResult_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("ListCustomizeRuleTestResult.Data.ResponseData.Length"); i++) {
				ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data.ListCustomizeRuleTestResult_ResponseDataItem responseDataItem = new ListCustomizeRuleTestResultResponse.ListCustomizeRuleTestResult_Data.ListCustomizeRuleTestResult_ResponseDataItem();
				responseDataItem.Uuid = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].Uuid");
				responseDataItem.MainUserId = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].MainUserId");
				responseDataItem.SubUserId = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].SubUserId");
				responseDataItem.LogType = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].LogType");
				responseDataItem.LogSource = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].LogSource");
				responseDataItem.AlertSrcProd = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].AlertSrcProd");
				responseDataItem.AlertSrcProdModule = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].AlertSrcProdModule");
				responseDataItem.AttCk = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].AttCk");
				responseDataItem.AlertDesc = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].AlertDesc");
				responseDataItem.OnlineStatus = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].OnlineStatus");
				responseDataItem.EventName = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].EventName");
				responseDataItem.Level = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].Level");
				responseDataItem.EventType = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].EventType");
				responseDataItem.AlertDetail = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].AlertDetail");
				responseDataItem.LogTime = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].LogTime");
				responseDataItem.VerifyType = _ctx.StringValue("ListCustomizeRuleTestResult.Data.ResponseData["+ i +"].VerifyType");

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			listCustomizeRuleTestResultResponse.Data = data;
        
			return listCustomizeRuleTestResultResponse;
        }
    }
}
