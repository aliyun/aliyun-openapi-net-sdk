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
using Aliyun.Acs.quickbi_public.Model.V20200807;

namespace Aliyun.Acs.quickbi_public.Transform.V20200807
{
    public class CheckReadableResponseUnmarshaller
    {
        public static CheckReadableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckReadableResponse checkReadableResponse = new CheckReadableResponse();

			checkReadableResponse.HttpResponse = _ctx.HttpResponse;
			checkReadableResponse.RequestId = _ctx.StringValue("CheckReadable.RequestId");
			checkReadableResponse.Success = _ctx.BooleanValue("CheckReadable.Success");
			checkReadableResponse.Result = _ctx.BooleanValue("CheckReadable.Result");
        
			return checkReadableResponse;
        }
    }
}
