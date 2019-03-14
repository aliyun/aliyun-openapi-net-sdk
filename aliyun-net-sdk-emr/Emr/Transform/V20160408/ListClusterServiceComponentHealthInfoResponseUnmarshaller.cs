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
        public static ListClusterServiceComponentHealthInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterServiceComponentHealthInfoResponse listClusterServiceComponentHealthInfoResponse = new ListClusterServiceComponentHealthInfoResponse();

			listClusterServiceComponentHealthInfoResponse.HttpResponse = context.HttpResponse;
			listClusterServiceComponentHealthInfoResponse.RequestId = context.StringValue("ListClusterServiceComponentHealthInfo.RequestId");
			listClusterServiceComponentHealthInfoResponse.ClusterId = context.StringValue("ListClusterServiceComponentHealthInfo.ClusterId");

			List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo> listClusterServiceComponentHealthInfoResponse_healthInfoList = new List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo>();
			for (int i = 0; i < context.Length("ListClusterServiceComponentHealthInfo.HealthInfoList.Length"); i++) {
				ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo healthInfo = new ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo();
				healthInfo.ServiceName = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].ServiceName");
				healthInfo.ComponentName = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].ComponentName");
				healthInfo.HealthLevel = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthLevel");
				healthInfo.StoppedNum = context.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].StoppedNum");
				healthInfo.ManualStoppedNum = context.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].ManualStoppedNum");
				healthInfo.NormalNum = context.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].NormalNum");
				healthInfo.TotalNum = context.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].TotalNum");
				healthInfo.AgentHeartBeatLostNum = context.IntegerValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].AgentHeartBeatLostNum");

				List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail> healthInfo_healthDetailList = new List<ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail>();
				for (int j = 0; j < context.Length("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList.Length"); j++) {
					ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail healthDetail = new ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail();
					healthDetail.Code = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].Code");

					ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail.ListClusterServiceComponentHealthInfo_HealthRuleParam healthRuleParam = new ListClusterServiceComponentHealthInfoResponse.ListClusterServiceComponentHealthInfo_HealthInfo.ListClusterServiceComponentHealthInfo_HealthDetail.ListClusterServiceComponentHealthInfo_HealthRuleParam();
					healthRuleParam.Service = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.Service");
					healthRuleParam.Component = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.Component");
					healthRuleParam.RuleTitle = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.RuleTitle");
					healthRuleParam.Pass = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.Pass");
					healthRuleParam.RuleId = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.RuleId");
					healthRuleParam.RuleDescription = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.RuleDescription");
					healthRuleParam.HostNames = context.StringValue("ListClusterServiceComponentHealthInfo.HealthInfoList["+ i +"].HealthDetailList["+ j +"].HealthRuleParam.HostNames");
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
