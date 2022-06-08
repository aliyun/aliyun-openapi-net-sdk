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
    public class GetCompanyTemplatePictureByJobResponseUnmarshaller
    {
        public static GetCompanyTemplatePictureByJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCompanyTemplatePictureByJobResponse getCompanyTemplatePictureByJobResponse = new GetCompanyTemplatePictureByJobResponse();

			getCompanyTemplatePictureByJobResponse.HttpResponse = _ctx.HttpResponse;
			getCompanyTemplatePictureByJobResponse.Base64Picture = _ctx.StringValue("GetCompanyTemplatePictureByJob.Base64Picture");
			getCompanyTemplatePictureByJobResponse.JobId = _ctx.StringValue("GetCompanyTemplatePictureByJob.JobId");
			getCompanyTemplatePictureByJobResponse.Type = _ctx.StringValue("GetCompanyTemplatePictureByJob.Type");
			getCompanyTemplatePictureByJobResponse.Url = _ctx.StringValue("GetCompanyTemplatePictureByJob.Url");
			getCompanyTemplatePictureByJobResponse.RequestId = _ctx.StringValue("GetCompanyTemplatePictureByJob.RequestId");
			getCompanyTemplatePictureByJobResponse.Success = _ctx.BooleanValue("GetCompanyTemplatePictureByJob.Success");
			getCompanyTemplatePictureByJobResponse.Message = _ctx.StringValue("GetCompanyTemplatePictureByJob.Message");
			getCompanyTemplatePictureByJobResponse.ErrorCode = _ctx.StringValue("GetCompanyTemplatePictureByJob.ErrorCode");
			getCompanyTemplatePictureByJobResponse.ErrorMessage = _ctx.StringValue("GetCompanyTemplatePictureByJob.ErrorMessage");
			getCompanyTemplatePictureByJobResponse.Code = _ctx.StringValue("GetCompanyTemplatePictureByJob.Code");
			getCompanyTemplatePictureByJobResponse.DynamicCode = _ctx.StringValue("GetCompanyTemplatePictureByJob.DynamicCode");
			getCompanyTemplatePictureByJobResponse.DynamicMessage = _ctx.StringValue("GetCompanyTemplatePictureByJob.DynamicMessage");
        
			return getCompanyTemplatePictureByJobResponse;
        }
    }
}
