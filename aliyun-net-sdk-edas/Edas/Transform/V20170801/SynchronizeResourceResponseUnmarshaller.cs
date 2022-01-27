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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class SynchronizeResourceResponseUnmarshaller
    {
        public static SynchronizeResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SynchronizeResourceResponse synchronizeResourceResponse = new SynchronizeResourceResponse();

			synchronizeResourceResponse.HttpResponse = _ctx.HttpResponse;
			synchronizeResourceResponse.Code = _ctx.IntegerValue("SynchronizeResource.Code");
			synchronizeResourceResponse.Message = _ctx.StringValue("SynchronizeResource.Message");
			synchronizeResourceResponse.Success = _ctx.BooleanValue("SynchronizeResource.Success");
			synchronizeResourceResponse.Data = _ctx.StringValue("SynchronizeResource.Data");
			synchronizeResourceResponse.RequestId = _ctx.StringValue("SynchronizeResource.RequestId");
        
			return synchronizeResourceResponse;
        }
    }
}
