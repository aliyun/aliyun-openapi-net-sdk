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
        public static DescribeIntentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIntentResponse describeIntentResponse = new DescribeIntentResponse();

			describeIntentResponse.HttpResponse = _ctx.HttpResponse;
			describeIntentResponse.Code = _ctx.StringValue("DescribeIntent.Code");
			describeIntentResponse.HttpStatusCode = _ctx.IntegerValue("DescribeIntent.HttpStatusCode");
			describeIntentResponse.Message = _ctx.StringValue("DescribeIntent.Message");
			describeIntentResponse.RequestId = _ctx.StringValue("DescribeIntent.RequestId");
			describeIntentResponse.Success = _ctx.BooleanValue("DescribeIntent.Success");

			DescribeIntentResponse.DescribeIntent_Intent intent = new DescribeIntentResponse.DescribeIntent_Intent();
			intent.CreateTime = _ctx.LongValue("DescribeIntent.Intent.CreateTime");
			intent.IntentDescription = _ctx.StringValue("DescribeIntent.Intent.IntentDescription");
			intent.IntentId = _ctx.StringValue("DescribeIntent.Intent.IntentId");
			intent.IntentName = _ctx.StringValue("DescribeIntent.Intent.IntentName");
			intent.Keywords = _ctx.StringValue("DescribeIntent.Intent.Keywords");
			intent.ScriptId = _ctx.StringValue("DescribeIntent.Intent.ScriptId");
			intent.UpdateTime = _ctx.LongValue("DescribeIntent.Intent.UpdateTime");
			intent.Utterances = _ctx.StringValue("DescribeIntent.Intent.Utterances");
			describeIntentResponse.Intent = intent;
        
			return describeIntentResponse;
        }
    }
}
