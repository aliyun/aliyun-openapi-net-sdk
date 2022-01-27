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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class TagResourcesResponseUnmarshaller
    {
        public static TagResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TagResourcesResponse tagResourcesResponse = new TagResourcesResponse();

			tagResourcesResponse.HttpResponse = _ctx.HttpResponse;
			tagResourcesResponse.Code = _ctx.StringValue("TagResources.Code");
			tagResourcesResponse.RequestId = _ctx.StringValue("TagResources.RequestId");
			tagResourcesResponse.Success = _ctx.BooleanValue("TagResources.Success");
			tagResourcesResponse.Message = _ctx.StringValue("TagResources.Message");
			tagResourcesResponse.Data = _ctx.BooleanValue("TagResources.Data");
        
			return tagResourcesResponse;
        }
    }
}
