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
    public class GetCompanyTemplatePictureNewResponseUnmarshaller
    {
        public static GetCompanyTemplatePictureNewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCompanyTemplatePictureNewResponse getCompanyTemplatePictureNewResponse = new GetCompanyTemplatePictureNewResponse();

			getCompanyTemplatePictureNewResponse.HttpResponse = _ctx.HttpResponse;
			getCompanyTemplatePictureNewResponse.Base64Picture = _ctx.StringValue("GetCompanyTemplatePictureNew.Base64Picture");
			getCompanyTemplatePictureNewResponse.JobId = _ctx.StringValue("GetCompanyTemplatePictureNew.JobId");
			getCompanyTemplatePictureNewResponse.Type = _ctx.StringValue("GetCompanyTemplatePictureNew.Type");
			getCompanyTemplatePictureNewResponse.Url = _ctx.StringValue("GetCompanyTemplatePictureNew.Url");
			getCompanyTemplatePictureNewResponse.RequestId = _ctx.StringValue("GetCompanyTemplatePictureNew.RequestId");
			getCompanyTemplatePictureNewResponse.Success = _ctx.BooleanValue("GetCompanyTemplatePictureNew.Success");
			getCompanyTemplatePictureNewResponse.Message = _ctx.StringValue("GetCompanyTemplatePictureNew.Message");
			getCompanyTemplatePictureNewResponse.ErrorCode = _ctx.StringValue("GetCompanyTemplatePictureNew.ErrorCode");
			getCompanyTemplatePictureNewResponse.ErrorMessage = _ctx.StringValue("GetCompanyTemplatePictureNew.ErrorMessage");
			getCompanyTemplatePictureNewResponse.Code = _ctx.StringValue("GetCompanyTemplatePictureNew.Code");
			getCompanyTemplatePictureNewResponse.DynamicCode = _ctx.StringValue("GetCompanyTemplatePictureNew.DynamicCode");
			getCompanyTemplatePictureNewResponse.DynamicMessage = _ctx.StringValue("GetCompanyTemplatePictureNew.DynamicMessage");
        
			return getCompanyTemplatePictureNewResponse;
        }
    }
}
