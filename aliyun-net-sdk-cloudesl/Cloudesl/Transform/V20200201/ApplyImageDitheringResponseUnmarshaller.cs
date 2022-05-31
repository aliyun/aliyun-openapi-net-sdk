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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class ApplyImageDitheringResponseUnmarshaller
    {
        public static ApplyImageDitheringResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ApplyImageDitheringResponse applyImageDitheringResponse = new ApplyImageDitheringResponse();

			applyImageDitheringResponse.HttpResponse = _ctx.HttpResponse;
			applyImageDitheringResponse.Content = _ctx.StringValue("ApplyImageDithering.Content");
			applyImageDitheringResponse.RequestId = _ctx.StringValue("ApplyImageDithering.RequestId");
			applyImageDitheringResponse.Success = _ctx.BooleanValue("ApplyImageDithering.Success");
			applyImageDitheringResponse.Message = _ctx.StringValue("ApplyImageDithering.Message");
			applyImageDitheringResponse.ErrorCode = _ctx.StringValue("ApplyImageDithering.ErrorCode");
			applyImageDitheringResponse.ErrorMessage = _ctx.StringValue("ApplyImageDithering.ErrorMessage");
			applyImageDitheringResponse.Code = _ctx.StringValue("ApplyImageDithering.Code");
			applyImageDitheringResponse.DynamicCode = _ctx.StringValue("ApplyImageDithering.DynamicCode");
			applyImageDitheringResponse.DynamicMessage = _ctx.StringValue("ApplyImageDithering.DynamicMessage");
        
			return applyImageDitheringResponse;
        }
    }
}
