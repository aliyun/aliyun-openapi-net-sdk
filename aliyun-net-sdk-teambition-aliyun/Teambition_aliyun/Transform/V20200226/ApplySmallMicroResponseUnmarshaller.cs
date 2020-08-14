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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class ApplySmallMicroResponseUnmarshaller
    {
        public static ApplySmallMicroResponse Unmarshall(UnmarshallerContext context)
        {
			ApplySmallMicroResponse applySmallMicroResponse = new ApplySmallMicroResponse();

			applySmallMicroResponse.HttpResponse = context.HttpResponse;
			applySmallMicroResponse.RequestId = context.StringValue("ApplySmallMicro.RequestId");
			applySmallMicroResponse.Code = context.IntegerValue("ApplySmallMicro.code");
			applySmallMicroResponse.Result = context.StringValue("ApplySmallMicro.result");
			applySmallMicroResponse.Message = context.BooleanValue("ApplySmallMicro.message");
			applySmallMicroResponse.Raw = context.BooleanValue("ApplySmallMicro.raw");
        
			return applySmallMicroResponse;
        }
    }
}
