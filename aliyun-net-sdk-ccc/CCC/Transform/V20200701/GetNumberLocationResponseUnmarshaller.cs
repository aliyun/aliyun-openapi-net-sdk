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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetNumberLocationResponseUnmarshaller
    {
        public static GetNumberLocationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNumberLocationResponse getNumberLocationResponse = new GetNumberLocationResponse();

			getNumberLocationResponse.HttpResponse = _ctx.HttpResponse;
			getNumberLocationResponse.Code = _ctx.StringValue("GetNumberLocation.Code");
			getNumberLocationResponse.HttpStatusCode = _ctx.IntegerValue("GetNumberLocation.HttpStatusCode");
			getNumberLocationResponse.Message = _ctx.StringValue("GetNumberLocation.Message");
			getNumberLocationResponse.RequestId = _ctx.StringValue("GetNumberLocation.RequestId");

			GetNumberLocationResponse.GetNumberLocation_Data data = new GetNumberLocationResponse.GetNumberLocation_Data();
			data.City = _ctx.StringValue("GetNumberLocation.Data.City");
			data.Number = _ctx.StringValue("GetNumberLocation.Data.Number");
			data.Province = _ctx.StringValue("GetNumberLocation.Data.Province");
			getNumberLocationResponse.Data = data;
        
			return getNumberLocationResponse;
        }
    }
}
