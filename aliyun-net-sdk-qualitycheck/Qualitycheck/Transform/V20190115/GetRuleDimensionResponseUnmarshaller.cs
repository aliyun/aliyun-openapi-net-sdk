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
    public class GetRuleDimensionResponseUnmarshaller
    {
        public static GetRuleDimensionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRuleDimensionResponse getRuleDimensionResponse = new GetRuleDimensionResponse();

			getRuleDimensionResponse.HttpResponse = _ctx.HttpResponse;
			getRuleDimensionResponse.CurrentPage = _ctx.IntegerValue("GetRuleDimension.CurrentPage");
			getRuleDimensionResponse.DataSize = _ctx.IntegerValue("GetRuleDimension.DataSize");
			getRuleDimensionResponse.RequestId = _ctx.StringValue("GetRuleDimension.RequestId");
			getRuleDimensionResponse.Success = _ctx.BooleanValue("GetRuleDimension.Success");
			getRuleDimensionResponse.ReviewStatus = _ctx.IntegerValue("GetRuleDimension.ReviewStatus");
			getRuleDimensionResponse.CompSubTaskCount = _ctx.IntegerValue("GetRuleDimension.CompSubTaskCount");
			getRuleDimensionResponse.Code = _ctx.StringValue("GetRuleDimension.Code");
			getRuleDimensionResponse.TotalSubTaskCount = _ctx.IntegerValue("GetRuleDimension.TotalSubTaskCount");
			getRuleDimensionResponse.Message = _ctx.StringValue("GetRuleDimension.Message");
			getRuleDimensionResponse.PageSize = _ctx.IntegerValue("GetRuleDimension.PageSize");
			getRuleDimensionResponse.TotalCount = _ctx.IntegerValue("GetRuleDimension.TotalCount");

			List<GetRuleDimensionResponse.GetRuleDimension_RuleCountInfo> getRuleDimensionResponse_data = new List<GetRuleDimensionResponse.GetRuleDimension_RuleCountInfo>();
			for (int i = 0; i < _ctx.Length("GetRuleDimension.Data.Length"); i++) {
				GetRuleDimensionResponse.GetRuleDimension_RuleCountInfo ruleCountInfo = new GetRuleDimensionResponse.GetRuleDimension_RuleCountInfo();
				ruleCountInfo.Type = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].Type");
				ruleCountInfo.Status = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].Status");
				ruleCountInfo.PreReviewNumber = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].PreReviewNumber");
				ruleCountInfo.HitNumber = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].HitNumber");
				ruleCountInfo.Select = _ctx.BooleanValue("GetRuleDimension.Data["+ i +"].Select");
				ruleCountInfo.CreateTime = _ctx.StringValue("GetRuleDimension.Data["+ i +"].CreateTime");
				ruleCountInfo.CreateEmpid = _ctx.StringValue("GetRuleDimension.Data["+ i +"].CreateEmpid");
				ruleCountInfo.RealViolationNumber = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].RealViolationNumber");
				ruleCountInfo.LastUpdateEmpid = _ctx.StringValue("GetRuleDimension.Data["+ i +"].LastUpdateEmpid");
				ruleCountInfo.IsDelete = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].IsDelete");
				ruleCountInfo.HitRate = _ctx.FloatValue("GetRuleDimension.Data["+ i +"].HitRate");
				ruleCountInfo.Rid = _ctx.StringValue("GetRuleDimension.Data["+ i +"].Rid");
				ruleCountInfo.CheckNumber = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].CheckNumber");
				ruleCountInfo.TypeName = _ctx.StringValue("GetRuleDimension.Data["+ i +"].TypeName");
				ruleCountInfo.LastUpdateTime = _ctx.StringValue("GetRuleDimension.Data["+ i +"].LastUpdateTime");
				ruleCountInfo.Name = _ctx.StringValue("GetRuleDimension.Data["+ i +"].Name");
				ruleCountInfo.HitRealViolationRate = _ctx.FloatValue("GetRuleDimension.Data["+ i +"].HitRealViolationRate");
				ruleCountInfo.ReviewNumber = _ctx.IntegerValue("GetRuleDimension.Data["+ i +"].ReviewNumber");

				getRuleDimensionResponse_data.Add(ruleCountInfo);
			}
			getRuleDimensionResponse.Data = getRuleDimensionResponse_data;
        
			return getRuleDimensionResponse;
        }
    }
}
