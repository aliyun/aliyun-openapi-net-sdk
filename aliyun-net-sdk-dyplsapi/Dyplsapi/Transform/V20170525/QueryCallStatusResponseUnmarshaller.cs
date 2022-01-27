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
using Aliyun.Acs.Dyplsapi.Model.V20170525;

namespace Aliyun.Acs.Dyplsapi.Transform.V20170525
{
    public class QueryCallStatusResponseUnmarshaller
    {
        public static QueryCallStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCallStatusResponse queryCallStatusResponse = new QueryCallStatusResponse();

			queryCallStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryCallStatusResponse.Code = _ctx.StringValue("QueryCallStatus.Code");
			queryCallStatusResponse.Message = _ctx.StringValue("QueryCallStatus.Message");
			queryCallStatusResponse.RequestId = _ctx.StringValue("QueryCallStatus.RequestId");

			QueryCallStatusResponse.QueryCallStatus_SecretCallStatusDTO secretCallStatusDTO = new QueryCallStatusResponse.QueryCallStatus_SecretCallStatusDTO();
			secretCallStatusDTO.CalledNo = _ctx.StringValue("QueryCallStatus.SecretCallStatusDTO.CalledNo");
			secretCallStatusDTO.Status = _ctx.IntegerValue("QueryCallStatus.SecretCallStatusDTO.Status");
			queryCallStatusResponse.SecretCallStatusDTO = secretCallStatusDTO;
        
			return queryCallStatusResponse;
        }
    }
}
