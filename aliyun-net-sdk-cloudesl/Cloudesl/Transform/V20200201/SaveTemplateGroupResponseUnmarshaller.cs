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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class SaveTemplateGroupResponseUnmarshaller
    {
        public static SaveTemplateGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveTemplateGroupResponse saveTemplateGroupResponse = new SaveTemplateGroupResponse();

			saveTemplateGroupResponse.HttpResponse = _ctx.HttpResponse;
			saveTemplateGroupResponse.RequestId = _ctx.StringValue("SaveTemplateGroup.RequestId");
			saveTemplateGroupResponse.Success = _ctx.BooleanValue("SaveTemplateGroup.Success");
			saveTemplateGroupResponse.Message = _ctx.StringValue("SaveTemplateGroup.Message");
			saveTemplateGroupResponse.ErrorCode = _ctx.StringValue("SaveTemplateGroup.ErrorCode");
			saveTemplateGroupResponse.ErrorMessage = _ctx.StringValue("SaveTemplateGroup.ErrorMessage");
			saveTemplateGroupResponse.Code = _ctx.StringValue("SaveTemplateGroup.Code");
			saveTemplateGroupResponse.DynamicCode = _ctx.StringValue("SaveTemplateGroup.DynamicCode");
			saveTemplateGroupResponse.DynamicMessage = _ctx.StringValue("SaveTemplateGroup.DynamicMessage");
        
			return saveTemplateGroupResponse;
        }
    }
}
