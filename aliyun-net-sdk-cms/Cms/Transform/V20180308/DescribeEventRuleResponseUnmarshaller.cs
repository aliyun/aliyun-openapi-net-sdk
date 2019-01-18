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
    public class DescribeEventRuleResponseUnmarshaller
    {
        public static DescribeEventRuleResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventRuleResponse describeEventRuleResponse = new DescribeEventRuleResponse();

			describeEventRuleResponse.HttpResponse = context.HttpResponse;
			describeEventRuleResponse.Success = context.BooleanValue("DescribeEventRule.Success");
			describeEventRuleResponse.Code = context.StringValue("DescribeEventRule.Code");
			describeEventRuleResponse.Message = context.StringValue("DescribeEventRule.Message");
			describeEventRuleResponse.RequestId = context.StringValue("DescribeEventRule.RequestId");

			DescribeEventRuleResponse.DescribeEventRule_Result result = new DescribeEventRuleResponse.DescribeEventRule_Result();
			result.Description = context.StringValue("DescribeEventRule.Result.Description");
			result.Name = context.StringValue("DescribeEventRule.Result.Name");
			result.EventType = context.StringValue("DescribeEventRule.Result.EventType");
			result.GroupId = context.StringValue("DescribeEventRule.Result.GroupId");
			result.State = context.StringValue("DescribeEventRule.Result.State");

			DescribeEventRuleResponse.DescribeEventRule_Result.DescribeEventRule_EventPattern eventPattern = new DescribeEventRuleResponse.DescribeEventRule_Result.DescribeEventRule_EventPattern();
			eventPattern.Product = context.StringValue("DescribeEventRule.Result.EventPattern.Product");

			List<string> eventPattern_nameList = new List<string>();
			for (int i = 0; i < context.Length("DescribeEventRule.Result.EventPattern.NameList.Length"); i++) {
				eventPattern_nameList.Add(context.StringValue("DescribeEventRule.Result.EventPattern.NameList["+ i +"]"));
			}
			eventPattern.NameList = eventPattern_nameList;

			List<string> eventPattern_statusList = new List<string>();
			for (int i = 0; i < context.Length("DescribeEventRule.Result.EventPattern.StatusList.Length"); i++) {
				eventPattern_statusList.Add(context.StringValue("DescribeEventRule.Result.EventPattern.StatusList["+ i +"]"));
			}
			eventPattern.StatusList = eventPattern_statusList;

			List<string> eventPattern_levelList = new List<string>();
			for (int i = 0; i < context.Length("DescribeEventRule.Result.EventPattern.LevelList.Length"); i++) {
				eventPattern_levelList.Add(context.StringValue("DescribeEventRule.Result.EventPattern.LevelList["+ i +"]"));
			}
			eventPattern.LevelList = eventPattern_levelList;
			result.EventPattern = eventPattern;
			describeEventRuleResponse.Result = result;
        
			return describeEventRuleResponse;
        }
    }
}