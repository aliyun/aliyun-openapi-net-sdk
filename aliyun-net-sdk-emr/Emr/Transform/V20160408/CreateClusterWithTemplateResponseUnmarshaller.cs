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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class CreateClusterWithTemplateResponseUnmarshaller
    {
        public static CreateClusterWithTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateClusterWithTemplateResponse createClusterWithTemplateResponse = new CreateClusterWithTemplateResponse();

			createClusterWithTemplateResponse.HttpResponse = _ctx.HttpResponse;
			createClusterWithTemplateResponse.RequestId = _ctx.StringValue("CreateClusterWithTemplate.RequestId");
			createClusterWithTemplateResponse.ClusterId = _ctx.StringValue("CreateClusterWithTemplate.ClusterId");
			createClusterWithTemplateResponse.EmrOrderId = _ctx.StringValue("CreateClusterWithTemplate.EmrOrderId");
			createClusterWithTemplateResponse.MasterOrderId = _ctx.StringValue("CreateClusterWithTemplate.MasterOrderId");
			createClusterWithTemplateResponse.CoreOrderId = _ctx.StringValue("CreateClusterWithTemplate.CoreOrderId");
        
			return createClusterWithTemplateResponse;
        }
    }
}
