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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class SetDataWithSignatureResponseUnmarshaller
    {
        public static SetDataWithSignatureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetDataWithSignatureResponse setDataWithSignatureResponse = new SetDataWithSignatureResponse();

			setDataWithSignatureResponse.HttpResponse = _ctx.HttpResponse;
			setDataWithSignatureResponse.Code = _ctx.IntegerValue("SetDataWithSignature.Code");
			setDataWithSignatureResponse.Message = _ctx.StringValue("SetDataWithSignature.Message");
			setDataWithSignatureResponse.Data = _ctx.StringValue("SetDataWithSignature.Data");
			setDataWithSignatureResponse.RequestId = _ctx.StringValue("SetDataWithSignature.RequestId");
			setDataWithSignatureResponse.Success = _ctx.BooleanValue("SetDataWithSignature.Success");
        
			return setDataWithSignatureResponse;
        }
    }
}
