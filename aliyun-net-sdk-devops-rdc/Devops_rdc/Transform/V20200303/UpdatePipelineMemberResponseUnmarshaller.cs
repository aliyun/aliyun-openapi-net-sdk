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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class UpdatePipelineMemberResponseUnmarshaller
    {
        public static UpdatePipelineMemberResponse Unmarshall(UnmarshallerContext context)
        {
			UpdatePipelineMemberResponse updatePipelineMemberResponse = new UpdatePipelineMemberResponse();

			updatePipelineMemberResponse.HttpResponse = context.HttpResponse;
			updatePipelineMemberResponse.Success = context.BooleanValue("UpdatePipelineMember.Success");
			updatePipelineMemberResponse.ErrorCode = context.StringValue("UpdatePipelineMember.ErrorCode");
			updatePipelineMemberResponse.ErrorMessage = context.StringValue("UpdatePipelineMember.ErrorMessage");
			updatePipelineMemberResponse.RequestId = context.StringValue("UpdatePipelineMember.RequestId");
			updatePipelineMemberResponse._Object = context.BooleanValue("UpdatePipelineMember.Object");
        
			return updatePipelineMemberResponse;
        }
    }
}
