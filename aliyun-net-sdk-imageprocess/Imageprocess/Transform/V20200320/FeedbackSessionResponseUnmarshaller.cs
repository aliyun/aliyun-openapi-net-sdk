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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class FeedbackSessionResponseUnmarshaller
    {
        public static FeedbackSessionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FeedbackSessionResponse feedbackSessionResponse = new FeedbackSessionResponse();

			feedbackSessionResponse.HttpResponse = _ctx.HttpResponse;
			feedbackSessionResponse.RequestId = _ctx.StringValue("FeedbackSession.RequestId");
			feedbackSessionResponse.Code = _ctx.StringValue("FeedbackSession.Code");
			feedbackSessionResponse.Message = _ctx.StringValue("FeedbackSession.Message");

			FeedbackSessionResponse.FeedbackSession_Data data = new FeedbackSessionResponse.FeedbackSession_Data();
			data.Data = _ctx.StringValue("FeedbackSession.Data.Data");
			feedbackSessionResponse.Data = data;
        
			return feedbackSessionResponse;
        }
    }
}
