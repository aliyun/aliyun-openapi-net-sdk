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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class GetAllInstanceIdListResponseUnmarshaller
    {
        public static GetAllInstanceIdListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAllInstanceIdListResponse getAllInstanceIdListResponse = new GetAllInstanceIdListResponse();

			getAllInstanceIdListResponse.HttpResponse = _ctx.HttpResponse;
			getAllInstanceIdListResponse.Code = _ctx.IntegerValue("GetAllInstanceIdList.Code");
			getAllInstanceIdListResponse.Message = _ctx.StringValue("GetAllInstanceIdList.Message");
			getAllInstanceIdListResponse.InstanceIds = _ctx.StringValue("GetAllInstanceIdList.InstanceIds");
			getAllInstanceIdListResponse.RequestId = _ctx.StringValue("GetAllInstanceIdList.RequestId");
			getAllInstanceIdListResponse.Success = _ctx.BooleanValue("GetAllInstanceIdList.Success");
        
			return getAllInstanceIdListResponse;
        }
    }
}
