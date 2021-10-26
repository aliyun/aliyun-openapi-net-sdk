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
using Aliyun.Acs.quickbi_public.Model.V20200802;

namespace Aliyun.Acs.quickbi_public.Transform.V20200802
{
    public class UpdateUserTagValueResponseUnmarshaller
    {
        public static UpdateUserTagValueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateUserTagValueResponse updateUserTagValueResponse = new UpdateUserTagValueResponse();

			updateUserTagValueResponse.HttpResponse = _ctx.HttpResponse;
			updateUserTagValueResponse.RequestId = _ctx.StringValue("UpdateUserTagValue.RequestId");
			updateUserTagValueResponse.Result = _ctx.BooleanValue("UpdateUserTagValue.Result");
			updateUserTagValueResponse.Success = _ctx.BooleanValue("UpdateUserTagValue.Success");
        
			return updateUserTagValueResponse;
        }
    }
}
