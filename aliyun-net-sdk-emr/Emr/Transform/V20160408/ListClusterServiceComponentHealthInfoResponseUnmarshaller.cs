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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListClusterServiceComponentHealthInfoResponseUnmarshaller
    {
        public static ListClusterServiceComponentHealthInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterServiceComponentHealthInfoResponse listClusterServiceComponentHealthInfoResponse = new ListClusterServiceComponentHealthInfoResponse();

			listClusterServiceComponentHealthInfoResponse.HttpResponse = _ctx.HttpResponse;
			listClusterServiceComponentHealthInfoResponse.RequestId = _ctx.StringValue("ListClusterServiceComponentHealthInfo.RequestId");
			listClusterServiceComponentHealthInfoResponse.ClusterId = _ctx.StringValue("ListClusterServiceComponentHealthInfo.ClusterId");

			List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo> listClusterServiceComponentHealthInfoResponse_healthInfoList = new List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo>();
			for (int i = 0; i < _ctx.Length("ListClusterServiceComponentHealthInfo.HealthInfoList.Length"); i++) {
				ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo healthInfo = new ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo();
				healthInfo.ServiceName = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].ServiceName");
				healthInfo.ComponentName = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].ComponentName");
				healthInfo.HealthLevel = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthLevel");
				healthInfo.StoppedNum = _ctx.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].StoppedNum");
				healthInfo.ManualStoppedNum = _ctx.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].ManualStoppedNum");
				healthInfo.NormalNum = _ctx.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].NormalNum");
				healthInfo.TotalNum = _ctx.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].TotalNum");
				healthInfo.AgentHeartBeatLostNum = _ctx.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].AgentHeartBeatLostNum");
				healthInfo.CreatedTime = _ctx.LongValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].CreatedTime");

				List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail> healthInfo_healthDetailList = new List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail>();
				for (int j = 0; j < _ctx.Length("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList.Length"); j++) {
					ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail healthDetail = new ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail();
					healthDetail.Code = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].code");

					ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail.ListClusterServiceComponentHealthInfo_HealthRuleParam healthRuleParam = new ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail.ListClusterServiceComponentHealthInfo_HealthRuleParam();
					healthRuleParam.Service = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.Service");
					healthRuleParam.Component = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.Component");
					healthRuleParam.RuleTitle = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.RuleTitle");
					healthRuleParam.Pass = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.Pass");
					healthRuleParam.RuleId = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.RuleId");
					healthRuleParam.RuleDescription = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.RuleDescription");
					healthRuleParam.HostNames = _ctx.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.HostNames");
					healthDetail.HealthRuleParam = healthRuleParam;

					healthInfo_healthDetailList.Add(healthDetail);
				}
				healthInfo.HealthDetailList = healthInfo_healthDetailList;

				listClusterServiceComponentHealthInfoResponse_healthInfoList.Add(healthInfo);
			}
			listClusterServiceComponentHealthInfoResponse.HealthInfoList = listClusterServiceComponentHealthInfoResponse_healthInfoList;
        
			return listClusterServiceComponentHealthInfoResponse;
        }
    }
}
