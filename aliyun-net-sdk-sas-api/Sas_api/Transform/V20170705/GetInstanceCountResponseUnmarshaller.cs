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
using Aliyun.Acs.Sas_api.Model.V20170705;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class GetInstanceCountResponseUnmarshaller
    {
        public static GetInstanceCountResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceCountResponse getInstanceCountResponse = new GetInstanceCountResponse();

			getInstanceCountResponse.HttpResponse = context.HttpResponse;
			getInstanceCountResponse.Code = context.StringValue("GetInstanceCount.Code");
			getInstanceCountResponse.Message = context.StringValue("GetInstanceCount.Message");
			getInstanceCountResponse.Success = context.BooleanValue("GetInstanceCount.Success");
			getInstanceCountResponse.RequestId = context.StringValue("GetInstanceCount.RequestId");
			getInstanceCountResponse.Data = context.IntegerValue("GetInstanceCount.Data");
        
			return getInstanceCountResponse;
        }
    }
}
