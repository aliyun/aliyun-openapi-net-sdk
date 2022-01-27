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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class GetUserNetProfileDescriptionResponseUnmarshaller
    {
        public static GetUserNetProfileDescriptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserNetProfileDescriptionResponse getUserNetProfileDescriptionResponse = new GetUserNetProfileDescriptionResponse();

			getUserNetProfileDescriptionResponse.HttpResponse = _ctx.HttpResponse;
			getUserNetProfileDescriptionResponse.RequestId = _ctx.StringValue("GetUserNetProfileDescription.RequestId");
			getUserNetProfileDescriptionResponse.Success = _ctx.BooleanValue("GetUserNetProfileDescription.Success");
			getUserNetProfileDescriptionResponse.Code = _ctx.StringValue("GetUserNetProfileDescription.Code");
			getUserNetProfileDescriptionResponse.ErrorMessage = _ctx.StringValue("GetUserNetProfileDescription.ErrorMessage");

			GetUserNetProfileDescriptionResponse.GetUserNetProfileDescription_Data data = new GetUserNetProfileDescriptionResponse.GetUserNetProfileDescription_Data();
			data.Isolated = _ctx.BooleanValue("GetUserNetProfileDescription.Data.Isolated");
			data.IsoUpdatedRemainingSec = _ctx.LongValue("GetUserNetProfileDescription.Data.IsoUpdatedRemainingSec");
			getUserNetProfileDescriptionResponse.Data = data;
        
			return getUserNetProfileDescriptionResponse;
        }
    }
}
