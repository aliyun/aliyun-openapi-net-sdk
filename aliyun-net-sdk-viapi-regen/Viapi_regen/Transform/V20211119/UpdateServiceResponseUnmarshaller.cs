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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class UpdateServiceResponseUnmarshaller
    {
        public static UpdateServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateServiceResponse updateServiceResponse = new UpdateServiceResponse();

			updateServiceResponse.HttpResponse = _ctx.HttpResponse;
			updateServiceResponse.Message = _ctx.StringValue("UpdateService.Message");
			updateServiceResponse.RequestId = _ctx.StringValue("UpdateService.RequestId");
			updateServiceResponse.Code = _ctx.StringValue("UpdateService.Code");

			UpdateServiceResponse.UpdateService_Data data = new UpdateServiceResponse.UpdateService_Data();
			data.Id = _ctx.LongValue("UpdateService.Data.Id");
			data.GmtCreate = _ctx.LongValue("UpdateService.Data.GmtCreate");
			data.ServiceName = _ctx.StringValue("UpdateService.Data.ServiceName");
			data.ServiceDescription = _ctx.StringValue("UpdateService.Data.ServiceDescription");
			data.AuthorizationType = _ctx.StringValue("UpdateService.Data.AuthorizationType");
			data.AuthorizedAccount = _ctx.StringValue("UpdateService.Data.AuthorizedAccount");
			updateServiceResponse.Data = data;
        
			return updateServiceResponse;
        }
    }
}
