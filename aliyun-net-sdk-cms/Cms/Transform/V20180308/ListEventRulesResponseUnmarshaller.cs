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
using Aliyun.Acs.Cms.Model.V20180308;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListEventRulesResponseUnmarshaller
    {
        public static ListEventRulesResponse Unmarshall(UnmarshallerContext context)
        {
			ListEventRulesResponse listEventRulesResponse = new ListEventRulesResponse();

			listEventRulesResponse.HttpResponse = context.HttpResponse;
			listEventRulesResponse.Success = context.BooleanValue("ListEventRules.Success");
			listEventRulesResponse.Code = context.StringValue("ListEventRules.Code");
			listEventRulesResponse.Message = context.StringValue("ListEventRules.Message");
			listEventRulesResponse.RequestId = context.StringValue("ListEventRules.RequestId");
			listEventRulesResponse.Total = context.IntegerValue("ListEventRules.Total");
			listEventRulesResponse.CurrentPage = context.IntegerValue("ListEventRules.CurrentPage");
			listEventRulesResponse.NextToken = context.StringValue("ListEventRules.NextToken");

			List<ListEventRulesResponse.ListEventRules_EventRule> listEventRulesResponse_datapoints = new List<ListEventRulesResponse.ListEventRules_EventRule>();
			for (int i = 0; i < context.Length("ListEventRules.Datapoints.Length"); i++) {
				ListEventRulesResponse.ListEventRules_EventRule eventRule = new ListEventRulesResponse.ListEventRules_EventRule();
				eventRule.Name = context.StringValue("ListEventRules.Datapoints["+ i +"].Name");
				eventRule.GroupId = context.StringValue("ListEventRules.Datapoints["+ i +"].GroupId");
				eventRule.EventType = context.StringValue("ListEventRules.Datapoints["+ i +"].EventType");
				eventRule.State = context.StringValue("ListEventRules.Datapoints["+ i +"].State");
				eventRule.Description = context.StringValue("ListEventRules.Datapoints["+ i +"].Description");

				List<ListEventRulesResponse.ListEventRules_EventRule.ListEventRules_EventPatternItem> eventRule_eventPattern = new List<ListEventRulesResponse.ListEventRules_EventRule.ListEventRules_EventPatternItem>();
				for (int j = 0; j < context.Length("ListEventRules.Datapoints["+ i +"].EventPattern.Length"); j++) {
					ListEventRulesResponse.ListEventRules_EventRule.ListEventRules_EventPatternItem eventPatternItem = new ListEventRulesResponse.ListEventRules_EventRule.ListEventRules_EventPatternItem();
					eventPatternItem.Product = context.StringValue("ListEventRules.Datapoints["+ i +"].EventPattern["+ j +"].Product");

					List<string> eventPatternItem_nameList = new List<string>();
					for (int k = 0; k < context.Length("ListEventRules.Datapoints["+ i +"].EventPattern["+ j +"].NameList.Length"); k++) {
						eventPatternItem_nameList.Add(context.StringValue("ListEventRules.Datapoints["+ i +"].EventPattern["+ j +"].NameList["+ k +"]"));
					}
					eventPatternItem.NameList = eventPatternItem_nameList;

					List<string> eventPatternItem_statusList = new List<string>();
					for (int k = 0; k < context.Length("ListEventRules.Datapoints["+ i +"].EventPattern["+ j +"].StatusList.Length"); k++) {
						eventPatternItem_statusList.Add(context.StringValue("ListEventRules.Datapoints["+ i +"].EventPattern["+ j +"].StatusList["+ k +"]"));
					}
					eventPatternItem.StatusList = eventPatternItem_statusList;

					List<string> eventPatternItem_levelList = new List<string>();
					for (int k = 0; k < context.Length("ListEventRules.Datapoints["+ i +"].EventPattern["+ j +"].LevelList.Length"); k++) {
						eventPatternItem_levelList.Add(context.StringValue("ListEventRules.Datapoints["+ i +"].EventPattern["+ j +"].LevelList["+ k +"]"));
					}
					eventPatternItem.LevelList = eventPatternItem_levelList;

					eventRule_eventPattern.Add(eventPatternItem);
				}
				eventRule.EventPattern = eventRule_eventPattern;

				listEventRulesResponse_datapoints.Add(eventRule);
			}
			listEventRulesResponse.Datapoints = listEventRulesResponse_datapoints;
        
			return listEventRulesResponse;
        }
    }
}