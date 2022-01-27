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
    public class CreateGrayEnvironmentResponseUnmarshaller
    {
        public static CreateGrayEnvironmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGrayEnvironmentResponse createGrayEnvironmentResponse = new CreateGrayEnvironmentResponse();

			createGrayEnvironmentResponse.HttpResponse = _ctx.HttpResponse;
			createGrayEnvironmentResponse.RequestId = _ctx.StringValue("CreateGrayEnvironment.RequestId");
			createGrayEnvironmentResponse.Code = _ctx.IntegerValue("CreateGrayEnvironment.Code");
			createGrayEnvironmentResponse.Message = _ctx.StringValue("CreateGrayEnvironment.Message");

			CreateGrayEnvironmentResponse.CreateGrayEnvironment_Data data = new CreateGrayEnvironmentResponse.CreateGrayEnvironment_Data();
			data.AccountId = _ctx.StringValue("CreateGrayEnvironment.Data.AccountId");
			data.PointcutId = _ctx.LongValue("CreateGrayEnvironment.Data.PointcutId");
			data.RegionId = _ctx.StringValue("CreateGrayEnvironment.Data.RegionId");
			data.TenantId = _ctx.StringValue("CreateGrayEnvironment.Data.TenantId");

			CreateGrayEnvironmentResponse.CreateGrayEnvironment_Data.CreateGrayEnvironment_Metadata metadata = new CreateGrayEnvironmentResponse.CreateGrayEnvironment_Data.CreateGrayEnvironment_Metadata();
			metadata.Labels = _ctx.StringValue("CreateGrayEnvironment.Data.Metadata.Labels");
			metadata.Name = _ctx.StringValue("CreateGrayEnvironment.Data.Metadata.Name");
			metadata._Namespace = _ctx.StringValue("CreateGrayEnvironment.Data.Metadata.Namespace");
			metadata.Annotations = _ctx.StringValue("CreateGrayEnvironment.Data.Metadata.Annotations");
			data.Metadata = metadata;
			createGrayEnvironmentResponse.Data = data;
        
			return createGrayEnvironmentResponse;
        }
    }
}
