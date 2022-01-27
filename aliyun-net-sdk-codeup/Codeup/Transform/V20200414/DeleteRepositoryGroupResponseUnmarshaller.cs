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
    public class DeleteRepositoryGroupResponseUnmarshaller
    {
        public static DeleteRepositoryGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRepositoryGroupResponse deleteRepositoryGroupResponse = new DeleteRepositoryGroupResponse();

			deleteRepositoryGroupResponse.HttpResponse = _ctx.HttpResponse;
			deleteRepositoryGroupResponse.RequestId = _ctx.StringValue("DeleteRepositoryGroup.RequestId");
			deleteRepositoryGroupResponse.ErrorCode = _ctx.StringValue("DeleteRepositoryGroup.ErrorCode");
			deleteRepositoryGroupResponse.Success = _ctx.BooleanValue("DeleteRepositoryGroup.Success");
			deleteRepositoryGroupResponse.ErrorMessage = _ctx.StringValue("DeleteRepositoryGroup.ErrorMessage");

			DeleteRepositoryGroupResponse.DeleteRepositoryGroup_Result result = new DeleteRepositoryGroupResponse.DeleteRepositoryGroup_Result();
			result.Result = _ctx.BooleanValue("DeleteRepositoryGroup.Result.Result");
			deleteRepositoryGroupResponse.Result = result;
        
			return deleteRepositoryGroupResponse;
        }
    }
}
