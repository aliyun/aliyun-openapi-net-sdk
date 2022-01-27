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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListFlowControlsResponseUnmarshaller
    {
        public static ListFlowControlsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowControlsResponse listFlowControlsResponse = new ListFlowControlsResponse();

			listFlowControlsResponse.HttpResponse = _ctx.HttpResponse;
			listFlowControlsResponse.Code = _ctx.IntegerValue("ListFlowControls.Code");
			listFlowControlsResponse.Message = _ctx.StringValue("ListFlowControls.Message");
			listFlowControlsResponse.RequestId = _ctx.StringValue("ListFlowControls.RequestId");

			ListFlowControlsResponse.ListFlowControls_FlowControlsMap flowControlsMap = new ListFlowControlsResponse.ListFlowControls_FlowControlsMap();
			flowControlsMap.AppId = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppId");
			flowControlsMap.AppName = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppName");

			ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_RuleList ruleList = new ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_RuleList();
			ruleList.CurrentPage = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.RuleList.CurrentPage");
			ruleList.PageSize = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.RuleList.pageSize");
			ruleList.TotalSize = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.RuleList.TotalSize");

			List<ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_RuleList.ListFlowControls_Rule> ruleList_ruleResultList = new List<ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_RuleList.ListFlowControls_Rule>();
			for (int i = 0; i < _ctx.Length("ListFlowControls.FlowControlsMap.RuleList.RuleResultList.Length"); i++) {
				ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_RuleList.ListFlowControls_Rule rule = new ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_RuleList.ListFlowControls_Rule();
				rule.AppId = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].AppId");
				rule.ConsumerAppId = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].ConsumerAppId");
				rule.CreateTime = _ctx.LongValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].CreateTime");
				rule.Granularity = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].Granularity");
				rule.Id = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].Id");
				rule.Resource = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].Resource");
				rule.RuleId = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].RuleId");
				rule.RuleType = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].RuleType");
				rule.State = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].State");
				rule.Strategy = _ctx.StringValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].Strategy");
				rule.Threshold = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].Threshold");
				rule.UpdateTime = _ctx.LongValue("ListFlowControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].UpdateTime");

				ruleList_ruleResultList.Add(rule);
			}
			ruleList.RuleResultList = ruleList_ruleResultList;
			flowControlsMap.RuleList = ruleList;

			List<ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_InterfaceMethod> flowControlsMap_interfaceMethods = new List<ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_InterfaceMethod>();
			for (int i = 0; i < _ctx.Length("ListFlowControls.FlowControlsMap.InterfaceMethods.Length"); i++) {
				ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_InterfaceMethod interfaceMethod = new ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_InterfaceMethod();
				interfaceMethod.Name = _ctx.StringValue("ListFlowControls.FlowControlsMap.InterfaceMethods["+ i +"].name");
				interfaceMethod.Version = _ctx.StringValue("ListFlowControls.FlowControlsMap.InterfaceMethods["+ i +"].Version");

				List<string> interfaceMethod_methods = new List<string>();
				for (int j = 0; j < _ctx.Length("ListFlowControls.FlowControlsMap.InterfaceMethods["+ i +"].Methods.Length"); j++) {
					interfaceMethod_methods.Add(_ctx.StringValue("ListFlowControls.FlowControlsMap.InterfaceMethods["+ i +"].Methods["+ j +"]"));
				}
				interfaceMethod.Methods = interfaceMethod_methods;

				flowControlsMap_interfaceMethods.Add(interfaceMethod);
			}
			flowControlsMap.InterfaceMethods = flowControlsMap_interfaceMethods;

			List<ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_App> flowControlsMap_appList = new List<ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_App>();
			for (int i = 0; i < _ctx.Length("ListFlowControls.FlowControlsMap.AppList.Length"); i++) {
				ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_App app = new ListFlowControlsResponse.ListFlowControls_FlowControlsMap.ListFlowControls_App();
				app.AppId = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].AppId");
				app.Name = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].Name");
				app.RegionId = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].RegionId");
				app.Description = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].Description");
				app.Owner = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].Owner");
				app.InstanceCount = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].InstanceCount");
				app.RunningInstanceCount = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].RunningInstanceCount");
				app.Port = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].Port");
				app.UserId = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].UserId");
				app.SlbId = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].SlbId");
				app.SlbIp = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].SlbIp");
				app.SlbPort = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].SlbPort");
				app.ExtSlbId = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].ExtSlbId");
				app.ExtSlbIp = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].ExtSlbIp");
				app.ApplicationType = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].ApplicationType");
				app.ClusterType = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].ClusterType");
				app.ClusterId = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].ClusterId");
				app.Dockerize = _ctx.BooleanValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].Dockerize");
				app.Cpu = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].Cpu");
				app.Memory = _ctx.IntegerValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].Memory");
				app.HealthCheckUrl = _ctx.StringValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].HealthCheckUrl");
				app.BuildPackageId = _ctx.LongValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].BuildPackageId");
				app.CreateTime = _ctx.LongValue("ListFlowControls.FlowControlsMap.AppList["+ i +"].CreateTime");

				flowControlsMap_appList.Add(app);
			}
			flowControlsMap.AppList = flowControlsMap_appList;
			listFlowControlsResponse.FlowControlsMap = flowControlsMap;
        
			return listFlowControlsResponse;
        }
    }
}
