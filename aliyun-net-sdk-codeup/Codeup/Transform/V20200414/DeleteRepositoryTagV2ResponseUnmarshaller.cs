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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class DeleteRepositoryTagV2ResponseUnmarshaller
    {
        public static DeleteRepositoryTagV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRepositoryTagV2Response deleteRepositoryTagV2Response = new DeleteRepositoryTagV2Response();

			deleteRepositoryTagV2Response.HttpResponse = _ctx.HttpResponse;
			deleteRepositoryTagV2Response.ErrorCode = _ctx.StringValue("DeleteRepositoryTagV2.ErrorCode");
			deleteRepositoryTagV2Response.ErrorMessage = _ctx.StringValue("DeleteRepositoryTagV2.ErrorMessage");
			deleteRepositoryTagV2Response.RequestId = _ctx.StringValue("DeleteRepositoryTagV2.RequestId");
			deleteRepositoryTagV2Response.Success = _ctx.BooleanValue("DeleteRepositoryTagV2.Success");

			DeleteRepositoryTagV2Response.DeleteRepositoryTagV2_Result result = new DeleteRepositoryTagV2Response.DeleteRepositoryTagV2_Result();
			result.TagName = _ctx.StringValue("DeleteRepositoryTagV2.Result.TagName");
			deleteRepositoryTagV2Response.Result = result;
        
			return deleteRepositoryTagV2Response;
        }
    }
}
