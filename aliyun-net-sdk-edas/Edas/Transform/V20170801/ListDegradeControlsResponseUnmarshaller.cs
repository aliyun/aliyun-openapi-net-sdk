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
    public class ListDegradeControlsResponseUnmarshaller
    {
        public static ListDegradeControlsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDegradeControlsResponse listDegradeControlsResponse = new ListDegradeControlsResponse();

			listDegradeControlsResponse.HttpResponse = _ctx.HttpResponse;
			listDegradeControlsResponse.Code = _ctx.IntegerValue("ListDegradeControls.Code");
			listDegradeControlsResponse.Message = _ctx.StringValue("ListDegradeControls.Message");
			listDegradeControlsResponse.RequestId = _ctx.StringValue("ListDegradeControls.RequestId");

			ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap flowControlsMap = new ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap();
			flowControlsMap.AppId = _ctx.StringValue("ListDegradeControls.FlowControlsMap.AppId");
			flowControlsMap.AppName = _ctx.StringValue("ListDegradeControls.FlowControlsMap.AppName");

			ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_RuleList ruleList = new ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_RuleList();
			ruleList.CurrentPage = _ctx.IntegerValue("ListDegradeControls.FlowControlsMap.RuleList.CurrentPage");
			ruleList.PageSize = _ctx.IntegerValue("ListDegradeControls.FlowControlsMap.RuleList.pageSize");
			ruleList.TotalSize = _ctx.IntegerValue("ListDegradeControls.FlowControlsMap.RuleList.TotalSize");

			List<ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_RuleList.ListDegradeControls_Rule> ruleList_ruleResultList = new List<ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_RuleList.ListDegradeControls_Rule>();
			for (int i = 0; i < _ctx.Length("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList.Length"); i++) {
				ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_RuleList.ListDegradeControls_Rule rule = new ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_RuleList.ListDegradeControls_Rule();
				rule.AppId = _ctx.StringValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].AppId");
				rule.RuleId = _ctx.StringValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].RuleId");
				rule.CreateTime = _ctx.LongValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].CreateTime");
				rule.UpdateTime = _ctx.LongValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].UpdateTime");
				rule.Resource = _ctx.StringValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].Resource");
				rule.RtThreshold = _ctx.IntegerValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].RtThreshold");
				rule.Duration = _ctx.IntegerValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].Duration");
				rule.State = _ctx.IntegerValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].State");
				rule.RuleType = _ctx.StringValue("ListDegradeControls.FlowControlsMap.RuleList.RuleResultList["+ i +"].RuleType");

				ruleList_ruleResultList.Add(rule);
			}
			ruleList.RuleResultList = ruleList_ruleResultList;
			flowControlsMap.RuleList = ruleList;

			List<ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_InterfaceMethod> flowControlsMap_interfaceMethods = new List<ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_InterfaceMethod>();
			for (int i = 0; i < _ctx.Length("ListDegradeControls.FlowControlsMap.InterfaceMethods.Length"); i++) {
				ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_InterfaceMethod interfaceMethod = new ListDegradeControlsResponse.ListDegradeControls_FlowControlsMap.ListDegradeControls_InterfaceMethod();
				interfaceMethod.Name = _ctx.StringValue("ListDegradeControls.FlowControlsMap.InterfaceMethods["+ i +"].name");
				interfaceMethod.Version = _ctx.StringValue("ListDegradeControls.FlowControlsMap.InterfaceMethods["+ i +"].Version");

				List<string> interfaceMethod_methods = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDegradeControls.FlowControlsMap.InterfaceMethods["+ i +"].Methods.Length"); j++) {
					interfaceMethod_methods.Add(_ctx.StringValue("ListDegradeControls.FlowControlsMap.InterfaceMethods["+ i +"].Methods["+ j +"]"));
				}
				interfaceMethod.Methods = interfaceMethod_methods;

				flowControlsMap_interfaceMethods.Add(interfaceMethod);
			}
			flowControlsMap.InterfaceMethods = flowControlsMap_interfaceMethods;
			listDegradeControlsResponse.FlowControlsMap = flowControlsMap;
        
			return listDegradeControlsResponse;
        }
    }
}
