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
    public class InsertApplicationResponseUnmarshaller
    {
        public static InsertApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertApplicationResponse insertApplicationResponse = new InsertApplicationResponse();

			insertApplicationResponse.HttpResponse = _ctx.HttpResponse;
			insertApplicationResponse.Code = _ctx.IntegerValue("InsertApplication.Code");
			insertApplicationResponse.Message = _ctx.StringValue("InsertApplication.Message");
			insertApplicationResponse.RequestId = _ctx.StringValue("InsertApplication.RequestId");

			InsertApplicationResponse.InsertApplication_ApplicationInfo applicationInfo = new InsertApplicationResponse.InsertApplication_ApplicationInfo();
			applicationInfo.AppName = _ctx.StringValue("InsertApplication.ApplicationInfo.AppName");
			applicationInfo.AppId = _ctx.StringValue("InsertApplication.ApplicationInfo.AppId");
			applicationInfo.UserId = _ctx.StringValue("InsertApplication.ApplicationInfo.UserId");
			applicationInfo.Owner = _ctx.StringValue("InsertApplication.ApplicationInfo.Owner");
			applicationInfo.Dockerize = _ctx.BooleanValue("InsertApplication.ApplicationInfo.Dockerize");
			applicationInfo.Port = _ctx.IntegerValue("InsertApplication.ApplicationInfo.Port");
			applicationInfo.RegionName = _ctx.StringValue("InsertApplication.ApplicationInfo.RegionName");
			applicationInfo.ChangeOrderId = _ctx.StringValue("InsertApplication.ApplicationInfo.ChangeOrderId");
			insertApplicationResponse.ApplicationInfo = applicationInfo;
        
			return insertApplicationResponse;
        }
    }
}
