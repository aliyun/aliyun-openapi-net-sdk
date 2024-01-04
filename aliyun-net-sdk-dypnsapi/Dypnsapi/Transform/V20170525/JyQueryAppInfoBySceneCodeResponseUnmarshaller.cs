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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class JyQueryAppInfoBySceneCodeResponseUnmarshaller
    {
        public static JyQueryAppInfoBySceneCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			JyQueryAppInfoBySceneCodeResponse jyQueryAppInfoBySceneCodeResponse = new JyQueryAppInfoBySceneCodeResponse();

			jyQueryAppInfoBySceneCodeResponse.HttpResponse = _ctx.HttpResponse;
			jyQueryAppInfoBySceneCodeResponse.Code = _ctx.StringValue("JyQueryAppInfoBySceneCode.Code");
			jyQueryAppInfoBySceneCodeResponse.Message = _ctx.StringValue("JyQueryAppInfoBySceneCode.Message");
			jyQueryAppInfoBySceneCodeResponse.RequestId = _ctx.StringValue("JyQueryAppInfoBySceneCode.RequestId");

			JyQueryAppInfoBySceneCodeResponse.JyQueryAppInfoBySceneCode_Data data = new JyQueryAppInfoBySceneCodeResponse.JyQueryAppInfoBySceneCode_Data();
			data.CmAppId = _ctx.StringValue("JyQueryAppInfoBySceneCode.Data.CmAppId");
			data.CmAppKey = _ctx.StringValue("JyQueryAppInfoBySceneCode.Data.CmAppKey");
			data.CtAppId = _ctx.StringValue("JyQueryAppInfoBySceneCode.Data.CtAppId");
			data.CtAppKey = _ctx.StringValue("JyQueryAppInfoBySceneCode.Data.CtAppKey");
			jyQueryAppInfoBySceneCodeResponse.Data = data;
        
			return jyQueryAppInfoBySceneCodeResponse;
        }
    }
}
