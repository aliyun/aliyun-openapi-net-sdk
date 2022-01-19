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
using Aliyun.Acs.cr.Model.V20160607;

namespace Aliyun.Acs.cr.Transform.V20160607
{
    public class GetRepoTagResponseUnmarshaller
    {
        public static GetRepoTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRepoTagResponse getRepoTagResponse = new GetRepoTagResponse();

			getRepoTagResponse.HttpResponse = _ctx.HttpResponse;
			getRepoTagResponse.RequestId = _ctx.StringValue("GetRepoTag.requestId");
			getRepoTagResponse.Status = _ctx.StringValue("GetRepoTag.status");
			getRepoTagResponse.Tag = _ctx.StringValue("GetRepoTag.tag");
			getRepoTagResponse.Digest = _ctx.StringValue("GetRepoTag.digest");
			getRepoTagResponse.ImageId = _ctx.StringValue("GetRepoTag.imageId");
			getRepoTagResponse.ImageCreate = _ctx.LongValue("GetRepoTag.imageCreate");
			getRepoTagResponse.ImageUpdate = _ctx.LongValue("GetRepoTag.imageUpdate");
			getRepoTagResponse.ImageSize = _ctx.LongValue("GetRepoTag.imageSize");
        
			return getRepoTagResponse;
        }
    }
}
