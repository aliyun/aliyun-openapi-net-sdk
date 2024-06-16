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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class AddUserSourceLogConfigResponseUnmarshaller
    {
        public static AddUserSourceLogConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddUserSourceLogConfigResponse addUserSourceLogConfigResponse = new AddUserSourceLogConfigResponse();

			addUserSourceLogConfigResponse.HttpResponse = _ctx.HttpResponse;
			addUserSourceLogConfigResponse.RequestId = _ctx.StringValue("AddUserSourceLogConfig.RequestId");

			AddUserSourceLogConfigResponse.AddUserSourceLogConfig_Data data = new AddUserSourceLogConfigResponse.AddUserSourceLogConfig_Data();
			data.DiplayLine = _ctx.StringValue("AddUserSourceLogConfig.Data.DiplayLine");
			data.SourceProdCode = _ctx.StringValue("AddUserSourceLogConfig.Data.SourceProdCode");
			data.SourceLogCode = _ctx.StringValue("AddUserSourceLogConfig.Data.SourceLogCode");
			data.Displayed = _ctx.BooleanValue("AddUserSourceLogConfig.Data.Displayed");
			data.Imported = _ctx.BooleanValue("AddUserSourceLogConfig.Data.Imported");
			data.MainUserId = _ctx.LongValue("AddUserSourceLogConfig.Data.MainUserId");
			data.SubUserId = _ctx.LongValue("AddUserSourceLogConfig.Data.SubUserId");
			data.SubUserName = _ctx.StringValue("AddUserSourceLogConfig.Data.SubUserName");
			addUserSourceLogConfigResponse.Data = data;
        
			return addUserSourceLogConfigResponse;
        }
    }
}
