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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class QueryEccInfoResponseUnmarshaller
    {
        public static QueryEccInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEccInfoResponse queryEccInfoResponse = new QueryEccInfoResponse();

			queryEccInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryEccInfoResponse.Code = _ctx.IntegerValue("QueryEccInfo.Code");
			queryEccInfoResponse.Message = _ctx.StringValue("QueryEccInfo.Message");
			queryEccInfoResponse.RequestId = _ctx.StringValue("QueryEccInfo.RequestId");

			QueryEccInfoResponse.QueryEccInfo_EccInfo eccInfo = new QueryEccInfoResponse.QueryEccInfo_EccInfo();
			eccInfo.AppId = _ctx.StringValue("QueryEccInfo.EccInfo.AppId");
			eccInfo.EccId = _ctx.StringValue("QueryEccInfo.EccInfo.EccId");
			eccInfo.EcuId = _ctx.StringValue("QueryEccInfo.EccInfo.EcuId");
			eccInfo.GroupId = _ctx.StringValue("QueryEccInfo.EccInfo.GroupId");
			eccInfo.GroupName = _ctx.StringValue("QueryEccInfo.EccInfo.GroupName");
			eccInfo.PackageMd5 = _ctx.StringValue("QueryEccInfo.EccInfo.PackageMd5");
			eccInfo.PackageVersion = _ctx.StringValue("QueryEccInfo.EccInfo.PackageVersion");
			eccInfo.VpcId = _ctx.StringValue("QueryEccInfo.EccInfo.VpcId");
			queryEccInfoResponse.EccInfo = eccInfo;
        
			return queryEccInfoResponse;
        }
    }
}
