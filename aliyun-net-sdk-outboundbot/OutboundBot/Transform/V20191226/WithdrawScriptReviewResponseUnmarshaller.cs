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
    public class WithdrawScriptReviewResponseUnmarshaller
    {
        public static WithdrawScriptReviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			WithdrawScriptReviewResponse withdrawScriptReviewResponse = new WithdrawScriptReviewResponse();

			withdrawScriptReviewResponse.HttpResponse = _ctx.HttpResponse;
			withdrawScriptReviewResponse.Code = _ctx.StringValue("WithdrawScriptReview.Code");
			withdrawScriptReviewResponse.HttpStatusCode = _ctx.IntegerValue("WithdrawScriptReview.HttpStatusCode");
			withdrawScriptReviewResponse.Message = _ctx.StringValue("WithdrawScriptReview.Message");
			withdrawScriptReviewResponse.RequestId = _ctx.StringValue("WithdrawScriptReview.RequestId");
			withdrawScriptReviewResponse.Success = _ctx.BooleanValue("WithdrawScriptReview.Success");

			WithdrawScriptReviewResponse.WithdrawScriptReview_Script script = new WithdrawScriptReviewResponse.WithdrawScriptReview_Script();
			script.DebugStatus = _ctx.StringValue("WithdrawScriptReview.Script.DebugStatus");
			script.Industry = _ctx.StringValue("WithdrawScriptReview.Script.Industry");
			script.IsDebugDrafted = _ctx.BooleanValue("WithdrawScriptReview.Script.IsDebugDrafted");
			script.IsDrafted = _ctx.BooleanValue("WithdrawScriptReview.Script.IsDrafted");
			script.Scene = _ctx.StringValue("WithdrawScriptReview.Script.Scene");
			script.ScriptDescription = _ctx.StringValue("WithdrawScriptReview.Script.ScriptDescription");
			script.ScriptId = _ctx.StringValue("WithdrawScriptReview.Script.ScriptId");
			script.ScriptName = _ctx.StringValue("WithdrawScriptReview.Script.ScriptName");
			script.Status = _ctx.StringValue("WithdrawScriptReview.Script.Status");
			script.UpdateTime = _ctx.LongValue("WithdrawScriptReview.Script.UpdateTime");
			withdrawScriptReviewResponse.Script = script;
        
			return withdrawScriptReviewResponse;
        }
    }
}
