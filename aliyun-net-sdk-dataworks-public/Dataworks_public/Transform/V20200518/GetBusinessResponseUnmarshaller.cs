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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetBusinessResponseUnmarshaller
    {
        public static GetBusinessResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBusinessResponse getBusinessResponse = new GetBusinessResponse();

			getBusinessResponse.HttpResponse = _ctx.HttpResponse;
			getBusinessResponse.RequestId = _ctx.StringValue("GetBusiness.RequestId");
			getBusinessResponse.Success = _ctx.BooleanValue("GetBusiness.Success");
			getBusinessResponse.ErrorCode = _ctx.StringValue("GetBusiness.ErrorCode");
			getBusinessResponse.ErrorMessage = _ctx.StringValue("GetBusiness.ErrorMessage");
			getBusinessResponse.HttpStatusCode = _ctx.IntegerValue("GetBusiness.HttpStatusCode");

			GetBusinessResponse.GetBusiness_Data data = new GetBusinessResponse.GetBusiness_Data();
			data.BusinessId = _ctx.LongValue("GetBusiness.Data.BusinessId");
			data.BusinessName = _ctx.StringValue("GetBusiness.Data.BusinessName");
			data.ProjectId = _ctx.StringValue("GetBusiness.Data.ProjectId");
			data.Owner = _ctx.StringValue("GetBusiness.Data.Owner");
			data.Description = _ctx.StringValue("GetBusiness.Data.Description");
			data.UseType = _ctx.StringValue("GetBusiness.Data.UseType");
			getBusinessResponse.Data = data;
        
			return getBusinessResponse;
        }
    }
}
