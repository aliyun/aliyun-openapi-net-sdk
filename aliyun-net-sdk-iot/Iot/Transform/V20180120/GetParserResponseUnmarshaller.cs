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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetParserResponseUnmarshaller
    {
        public static GetParserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetParserResponse getParserResponse = new GetParserResponse();

			getParserResponse.HttpResponse = _ctx.HttpResponse;
			getParserResponse.RequestId = _ctx.StringValue("GetParser.RequestId");
			getParserResponse.Success = _ctx.BooleanValue("GetParser.Success");
			getParserResponse.Code = _ctx.StringValue("GetParser.Code");
			getParserResponse.ErrorMessage = _ctx.StringValue("GetParser.ErrorMessage");

			GetParserResponse.GetParser_Data data = new GetParserResponse.GetParser_Data();
			data.ParserId = _ctx.LongValue("GetParser.Data.ParserId");
			data.Name = _ctx.StringValue("GetParser.Data.Name");
			data.DataSourceId = _ctx.LongValue("GetParser.Data.DataSourceId");
			data.Status = _ctx.StringValue("GetParser.Data.Status");
			data.UtcCreated = _ctx.StringValue("GetParser.Data.UtcCreated");
			data.UtcModified = _ctx.StringValue("GetParser.Data.UtcModified");
			data.ScriptDraft = _ctx.StringValue("GetParser.Data.ScriptDraft");
			data.Script = _ctx.StringValue("GetParser.Data.Script");
			data.Description = _ctx.StringValue("GetParser.Data.Description");
			getParserResponse.Data = data;
        
			return getParserResponse;
        }
    }
}
