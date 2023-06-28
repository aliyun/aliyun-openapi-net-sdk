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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryLiveStreamingResponseUnmarshaller
    {
        public static QueryLiveStreamingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryLiveStreamingResponse queryLiveStreamingResponse = new QueryLiveStreamingResponse();

			queryLiveStreamingResponse.HttpResponse = _ctx.HttpResponse;
			queryLiveStreamingResponse.Code = _ctx.StringValue("QueryLiveStreaming.Code");
			queryLiveStreamingResponse.ErrorMessage = _ctx.StringValue("QueryLiveStreaming.ErrorMessage");
			queryLiveStreamingResponse.RequestId = _ctx.StringValue("QueryLiveStreaming.RequestId");
			queryLiveStreamingResponse.Success = _ctx.BooleanValue("QueryLiveStreaming.Success");

			QueryLiveStreamingResponse.QueryLiveStreaming_Data data = new QueryLiveStreamingResponse.QueryLiveStreaming_Data();
			data.Path = _ctx.StringValue("QueryLiveStreaming.Data.Path");
			data.RelayDecryptKey = _ctx.StringValue("QueryLiveStreaming.Data.RelayDecryptKey");
			data.StunInfo = _ctx.StringValue("QueryLiveStreaming.Data.StunInfo");
			data.DecryptKey = _ctx.StringValue("QueryLiveStreaming.Data.DecryptKey");
			queryLiveStreamingResponse.Data = data;
        
			return queryLiveStreamingResponse;
        }
    }
}
