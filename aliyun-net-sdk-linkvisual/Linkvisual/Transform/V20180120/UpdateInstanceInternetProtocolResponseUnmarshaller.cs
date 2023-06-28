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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class UpdateInstanceInternetProtocolResponseUnmarshaller
    {
        public static UpdateInstanceInternetProtocolResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateInstanceInternetProtocolResponse updateInstanceInternetProtocolResponse = new UpdateInstanceInternetProtocolResponse();

			updateInstanceInternetProtocolResponse.HttpResponse = _ctx.HttpResponse;
			updateInstanceInternetProtocolResponse.Code = _ctx.StringValue("UpdateInstanceInternetProtocol.Code");
			updateInstanceInternetProtocolResponse.Data = _ctx.StringValue("UpdateInstanceInternetProtocol.Data");
			updateInstanceInternetProtocolResponse.ErrorMessage = _ctx.StringValue("UpdateInstanceInternetProtocol.ErrorMessage");
			updateInstanceInternetProtocolResponse.RequestId = _ctx.StringValue("UpdateInstanceInternetProtocol.RequestId");
			updateInstanceInternetProtocolResponse.Success = _ctx.BooleanValue("UpdateInstanceInternetProtocol.Success");
        
			return updateInstanceInternetProtocolResponse;
        }
    }
}
