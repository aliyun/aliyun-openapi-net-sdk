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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeIntentResponseUnmarshaller
    {
        public static DescribeIntentResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIntentResponse describeIntentResponse = new DescribeIntentResponse();

			describeIntentResponse.HttpResponse = context.HttpResponse;
			describeIntentResponse.RequestId = context.StringValue("DescribeIntent.RequestId");
			describeIntentResponse.Success = context.BooleanValue("DescribeIntent.Success");
			describeIntentResponse.Code = context.StringValue("DescribeIntent.Code");
			describeIntentResponse.Message = context.StringValue("DescribeIntent.Message");
			describeIntentResponse.HttpStatusCode = context.IntegerValue("DescribeIntent.HttpStatusCode");

			DescribeIntentResponse.DescribeIntent_Intent intent = new DescribeIntentResponse.DescribeIntent_Intent();
			intent.IntentId = context.StringValue("DescribeIntent.Intent.IntentId");
			intent.ScriptId = context.StringValue("DescribeIntent.Intent.ScriptId");
			intent.IntentName = context.StringValue("DescribeIntent.Intent.IntentName");
			intent.IntentDescription = context.StringValue("DescribeIntent.Intent.IntentDescription");
			intent.Utterances = context.StringValue("DescribeIntent.Intent.Utterances");
			intent.Keywords = context.StringValue("DescribeIntent.Intent.Keywords");
			intent.CreateTime = context.LongValue("DescribeIntent.Intent.CreateTime");
			intent.UpdateTime = context.LongValue("DescribeIntent.Intent.UpdateTime");
			describeIntentResponse.Intent = intent;
        
			return describeIntentResponse;
        }
    }
}
