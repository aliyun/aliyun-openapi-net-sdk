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
using Aliyun.Acs.alimt.Model.V20181012;

namespace Aliyun.Acs.alimt.Transform.V20181012
{
    public class GetImageDiagnoseResponseUnmarshaller
    {
        public static GetImageDiagnoseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetImageDiagnoseResponse getImageDiagnoseResponse = new GetImageDiagnoseResponse();

			getImageDiagnoseResponse.HttpResponse = _ctx.HttpResponse;
			getImageDiagnoseResponse.Code = _ctx.IntegerValue("GetImageDiagnose.Code");
			getImageDiagnoseResponse.Message = _ctx.StringValue("GetImageDiagnose.Message");
			getImageDiagnoseResponse.RequestId = _ctx.StringValue("GetImageDiagnose.RequestId");

			GetImageDiagnoseResponse.GetImageDiagnose_Data data = new GetImageDiagnoseResponse.GetImageDiagnose_Data();
			data.Language = _ctx.StringValue("GetImageDiagnose.Data.Language");
			getImageDiagnoseResponse.Data = data;
        
			return getImageDiagnoseResponse;
        }
    }
}
