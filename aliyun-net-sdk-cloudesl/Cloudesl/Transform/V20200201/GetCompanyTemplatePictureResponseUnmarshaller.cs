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
    public class GetCompanyTemplatePictureResponseUnmarshaller
    {
        public static GetCompanyTemplatePictureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCompanyTemplatePictureResponse getCompanyTemplatePictureResponse = new GetCompanyTemplatePictureResponse();

			getCompanyTemplatePictureResponse.HttpResponse = _ctx.HttpResponse;
			getCompanyTemplatePictureResponse.RequestId = _ctx.StringValue("GetCompanyTemplatePicture.RequestId");
			getCompanyTemplatePictureResponse.ErrorMessage = _ctx.StringValue("GetCompanyTemplatePicture.ErrorMessage");
			getCompanyTemplatePictureResponse.Success = _ctx.BooleanValue("GetCompanyTemplatePicture.Success");
			getCompanyTemplatePictureResponse.ErrorCode = _ctx.StringValue("GetCompanyTemplatePicture.ErrorCode");
			getCompanyTemplatePictureResponse.Code = _ctx.StringValue("GetCompanyTemplatePicture.Code");
			getCompanyTemplatePictureResponse.Base64Picture = _ctx.StringValue("GetCompanyTemplatePicture.Base64Picture");
			getCompanyTemplatePictureResponse.Message = _ctx.StringValue("GetCompanyTemplatePicture.Message");
			getCompanyTemplatePictureResponse.DynamicMessage = _ctx.StringValue("GetCompanyTemplatePicture.DynamicMessage");
			getCompanyTemplatePictureResponse.DynamicCode = _ctx.StringValue("GetCompanyTemplatePicture.DynamicCode");
        
			return getCompanyTemplatePictureResponse;
        }
    }
}
