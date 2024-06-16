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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class CreateSchemeConfigResponseUnmarshaller
    {
        public static CreateSchemeConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSchemeConfigResponse createSchemeConfigResponse = new CreateSchemeConfigResponse();

			createSchemeConfigResponse.HttpResponse = _ctx.HttpResponse;
			createSchemeConfigResponse.RequestId = _ctx.StringValue("CreateSchemeConfig.RequestId");
			createSchemeConfigResponse.Message = _ctx.StringValue("CreateSchemeConfig.Message");
			createSchemeConfigResponse.Code = _ctx.StringValue("CreateSchemeConfig.Code");
			createSchemeConfigResponse.Success = _ctx.BooleanValue("CreateSchemeConfig.Success");

			CreateSchemeConfigResponse.CreateSchemeConfig_Model model = new CreateSchemeConfigResponse.CreateSchemeConfig_Model();
			model.SchemeCode = _ctx.StringValue("CreateSchemeConfig.Model.SchemeCode");
			createSchemeConfigResponse.Model = model;
        
			return createSchemeConfigResponse;
        }
    }
}
