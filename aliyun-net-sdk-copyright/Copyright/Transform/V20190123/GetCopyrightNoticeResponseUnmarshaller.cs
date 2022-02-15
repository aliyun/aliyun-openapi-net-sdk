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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetCopyrightNoticeResponseUnmarshaller
    {
        public static GetCopyrightNoticeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCopyrightNoticeResponse getCopyrightNoticeResponse = new GetCopyrightNoticeResponse();

			getCopyrightNoticeResponse.HttpResponse = _ctx.HttpResponse;
			getCopyrightNoticeResponse.RequestId = _ctx.StringValue("GetCopyrightNotice.RequestId");
			getCopyrightNoticeResponse.Success = _ctx.BooleanValue("GetCopyrightNotice.Success");
			getCopyrightNoticeResponse.ApplyPeople = _ctx.StringValue("GetCopyrightNotice.ApplyPeople");
			getCopyrightNoticeResponse.ModifyInfo = _ctx.StringValue("GetCopyrightNotice.ModifyInfo");
			getCopyrightNoticeResponse.FlowNumber = _ctx.StringValue("GetCopyrightNotice.FlowNumber");
			getCopyrightNoticeResponse.AgentPeople = _ctx.StringValue("GetCopyrightNotice.AgentPeople");
			getCopyrightNoticeResponse.Name = _ctx.StringValue("GetCopyrightNotice.Name");
			getCopyrightNoticeResponse.Owner = _ctx.StringValue("GetCopyrightNotice.Owner");
			getCopyrightNoticeResponse.CreateDate = _ctx.StringValue("GetCopyrightNotice.CreateDate");
			getCopyrightNoticeResponse.AdmissibleNumber = _ctx.StringValue("GetCopyrightNotice.AdmissibleNumber");
			getCopyrightNoticeResponse.FileList = _ctx.StringValue("GetCopyrightNotice.FileList");
        
			return getCopyrightNoticeResponse;
        }
    }
}
