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
    public class CopyCompanyTemplateViewResponseUnmarshaller
    {
        public static CopyCompanyTemplateViewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CopyCompanyTemplateViewResponse copyCompanyTemplateViewResponse = new CopyCompanyTemplateViewResponse();

			copyCompanyTemplateViewResponse.HttpResponse = _ctx.HttpResponse;
			copyCompanyTemplateViewResponse.RequestId = _ctx.StringValue("CopyCompanyTemplateView.RequestId");
			copyCompanyTemplateViewResponse.ErrorMessage = _ctx.StringValue("CopyCompanyTemplateView.ErrorMessage");
			copyCompanyTemplateViewResponse.Success = _ctx.BooleanValue("CopyCompanyTemplateView.Success");
			copyCompanyTemplateViewResponse.ErrorCode = _ctx.StringValue("CopyCompanyTemplateView.ErrorCode");
			copyCompanyTemplateViewResponse.Code = _ctx.StringValue("CopyCompanyTemplateView.Code");
			copyCompanyTemplateViewResponse.Message = _ctx.StringValue("CopyCompanyTemplateView.Message");
			copyCompanyTemplateViewResponse.DynamicMessage = _ctx.StringValue("CopyCompanyTemplateView.DynamicMessage");
			copyCompanyTemplateViewResponse.DynamicCode = _ctx.StringValue("CopyCompanyTemplateView.DynamicCode");
        
			return copyCompanyTemplateViewResponse;
        }
    }
}
