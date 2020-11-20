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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class StartApplicationResponseUnmarshaller
    {
        public static StartApplicationResponse Unmarshall(UnmarshallerContext context)
        {
			StartApplicationResponse startApplicationResponse = new StartApplicationResponse();

			startApplicationResponse.HttpResponse = context.HttpResponse;
			startApplicationResponse.RequestId = context.StringValue("StartApplication.RequestId");
			startApplicationResponse.Code = context.StringValue("StartApplication.Code");
			startApplicationResponse.Success = context.BooleanValue("StartApplication.Success");
			startApplicationResponse.ErrorCode = context.StringValue("StartApplication.ErrorCode");
			startApplicationResponse.Message = context.StringValue("StartApplication.Message");
			startApplicationResponse.TraceId = context.StringValue("StartApplication.TraceId");

			StartApplicationResponse.StartApplication_Data data = new StartApplicationResponse.StartApplication_Data();
			data.ChangeOrderId = context.StringValue("StartApplication.Data.ChangeOrderId");
			startApplicationResponse.Data = data;
        
			return startApplicationResponse;
        }
    }
}
