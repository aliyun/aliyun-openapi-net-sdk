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
using Aliyun.Acs.UniMkt.Model.V20181207;

namespace Aliyun.Acs.UniMkt.Transform.V20181207
{
    public class BrandMessageMigrateResponseUnmarshaller
    {
        public static BrandMessageMigrateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BrandMessageMigrateResponse brandMessageMigrateResponse = new BrandMessageMigrateResponse();

			brandMessageMigrateResponse.HttpResponse = _ctx.HttpResponse;
			brandMessageMigrateResponse.Status = _ctx.IntegerValue("BrandMessageMigrate.Status");
			brandMessageMigrateResponse.Message = _ctx.StringValue("BrandMessageMigrate.Message");
			brandMessageMigrateResponse.Data = _ctx.StringValue("BrandMessageMigrate.Data");
			brandMessageMigrateResponse.RequestId = _ctx.StringValue("BrandMessageMigrate.RequestId");
        
			return brandMessageMigrateResponse;
        }
    }
}
