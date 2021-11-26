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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetTaskRuleListResponseUnmarshaller
    {
        public static GetTaskRuleListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskRuleListResponse getTaskRuleListResponse = new GetTaskRuleListResponse();

			getTaskRuleListResponse.HttpResponse = _ctx.HttpResponse;
			getTaskRuleListResponse.CurrentPage = _ctx.IntegerValue("GetTaskRuleList.CurrentPage");
			getTaskRuleListResponse.DataSize = _ctx.IntegerValue("GetTaskRuleList.DataSize");
			getTaskRuleListResponse.RequestId = _ctx.StringValue("GetTaskRuleList.RequestId");
			getTaskRuleListResponse.Success = _ctx.BooleanValue("GetTaskRuleList.Success");
			getTaskRuleListResponse.ReviewStatus = _ctx.IntegerValue("GetTaskRuleList.ReviewStatus");
			getTaskRuleListResponse.CompSubTaskCount = _ctx.IntegerValue("GetTaskRuleList.CompSubTaskCount");
			getTaskRuleListResponse.Code = _ctx.StringValue("GetTaskRuleList.Code");
			getTaskRuleListResponse.TotalSubTaskCount = _ctx.IntegerValue("GetTaskRuleList.TotalSubTaskCount");
			getTaskRuleListResponse.Message = _ctx.StringValue("GetTaskRuleList.Message");
			getTaskRuleListResponse.PageSize = _ctx.IntegerValue("GetTaskRuleList.PageSize");
			getTaskRuleListResponse.TotalCount = _ctx.IntegerValue("GetTaskRuleList.TotalCount");

			List<GetTaskRuleListResponse.GetTaskRuleList_RuleCountInfo> getTaskRuleListResponse_data = new List<GetTaskRuleListResponse.GetTaskRuleList_RuleCountInfo>();
			for (int i = 0; i < _ctx.Length("GetTaskRuleList.Data.Length"); i++) {
				GetTaskRuleListResponse.GetTaskRuleList_RuleCountInfo ruleCountInfo = new GetTaskRuleListResponse.GetTaskRuleList_RuleCountInfo();
				ruleCountInfo.Type = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].Type");
				ruleCountInfo.Status = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].Status");
				ruleCountInfo.PreReviewNumber = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].PreReviewNumber");
				ruleCountInfo.HitNumber = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].HitNumber");
				ruleCountInfo.Select = _ctx.BooleanValue("GetTaskRuleList.Data["+ i +"].Select");
				ruleCountInfo.CreateTime = _ctx.LongValue("GetTaskRuleList.Data["+ i +"].CreateTime");
				ruleCountInfo.CreateEmpid = _ctx.StringValue("GetTaskRuleList.Data["+ i +"].CreateEmpid");
				ruleCountInfo.RealViolationNumber = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].RealViolationNumber");
				ruleCountInfo.LastUpdateEmpid = _ctx.StringValue("GetTaskRuleList.Data["+ i +"].LastUpdateEmpid");
				ruleCountInfo.IsDelete = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].IsDelete");
				ruleCountInfo.HitRate = _ctx.FloatValue("GetTaskRuleList.Data["+ i +"].HitRate");
				ruleCountInfo.Rid = _ctx.StringValue("GetTaskRuleList.Data["+ i +"].Rid");
				ruleCountInfo.CheckNumber = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].CheckNumber");
				ruleCountInfo.TypeName = _ctx.StringValue("GetTaskRuleList.Data["+ i +"].TypeName");
				ruleCountInfo.LastUpdateTime = _ctx.LongValue("GetTaskRuleList.Data["+ i +"].LastUpdateTime");
				ruleCountInfo.Name = _ctx.StringValue("GetTaskRuleList.Data["+ i +"].Name");
				ruleCountInfo.HitRealViolationRate = _ctx.FloatValue("GetTaskRuleList.Data["+ i +"].HitRealViolationRate");
				ruleCountInfo.ReviewNumber = _ctx.IntegerValue("GetTaskRuleList.Data["+ i +"].ReviewNumber");

				getTaskRuleListResponse_data.Add(ruleCountInfo);
			}
			getTaskRuleListResponse.Data = getTaskRuleListResponse_data;
        
			return getTaskRuleListResponse;
        }
    }
}
