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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class PostEventDisposeAndWhiteruleListResponseUnmarshaller
    {
        public static PostEventDisposeAndWhiteruleListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PostEventDisposeAndWhiteruleListResponse postEventDisposeAndWhiteruleListResponse = new PostEventDisposeAndWhiteruleListResponse();

			postEventDisposeAndWhiteruleListResponse.HttpResponse = _ctx.HttpResponse;
			postEventDisposeAndWhiteruleListResponse.Success = _ctx.BooleanValue("PostEventDisposeAndWhiteruleList.Success");
			postEventDisposeAndWhiteruleListResponse.Code = _ctx.IntegerValue("PostEventDisposeAndWhiteruleList.Code");
			postEventDisposeAndWhiteruleListResponse.Message = _ctx.StringValue("PostEventDisposeAndWhiteruleList.Message");
			postEventDisposeAndWhiteruleListResponse.RequestId = _ctx.StringValue("PostEventDisposeAndWhiteruleList.RequestId");
			postEventDisposeAndWhiteruleListResponse.Data = _ctx.StringValue("PostEventDisposeAndWhiteruleList.Data");
        
			return postEventDisposeAndWhiteruleListResponse;
        }
    }
}
