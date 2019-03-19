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
using Aliyun.Acs.cloudwf.Model.V20170328;

namespace Aliyun.Acs.cloudwf.Transform.V20170328
{
    public class GetUmengPagePermission4RootResponseUnmarshaller
    {
        public static GetUmengPagePermission4RootResponse Unmarshall(UnmarshallerContext context)
        {
			GetUmengPagePermission4RootResponse getUmengPagePermission4RootResponse = new GetUmengPagePermission4RootResponse();

			getUmengPagePermission4RootResponse.HttpResponse = context.HttpResponse;
			getUmengPagePermission4RootResponse.RequestId = context.StringValue("GetUmengPagePermission4Root.RequestId");
			getUmengPagePermission4RootResponse.Success = context.BooleanValue("GetUmengPagePermission4Root.Success");
			getUmengPagePermission4RootResponse.Message = context.StringValue("GetUmengPagePermission4Root.Message");
			getUmengPagePermission4RootResponse.Data = context.StringValue("GetUmengPagePermission4Root.Data");
			getUmengPagePermission4RootResponse.ErrorCode = context.IntegerValue("GetUmengPagePermission4Root.ErrorCode");
			getUmengPagePermission4RootResponse.ErrorMsg = context.StringValue("GetUmengPagePermission4Root.ErrorMsg");
        
			return getUmengPagePermission4RootResponse;
        }
    }
}
