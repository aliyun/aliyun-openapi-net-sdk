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
    public class CreateProductDistributeJobResponseUnmarshaller
    {
        public static CreateProductDistributeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateProductDistributeJobResponse createProductDistributeJobResponse = new CreateProductDistributeJobResponse();

			createProductDistributeJobResponse.HttpResponse = _ctx.HttpResponse;
			createProductDistributeJobResponse.RequestId = _ctx.StringValue("CreateProductDistributeJob.RequestId");
			createProductDistributeJobResponse.Success = _ctx.BooleanValue("CreateProductDistributeJob.Success");
			createProductDistributeJobResponse.Code = _ctx.StringValue("CreateProductDistributeJob.Code");
			createProductDistributeJobResponse.ErrorMessage = _ctx.StringValue("CreateProductDistributeJob.ErrorMessage");
			createProductDistributeJobResponse.JobId = _ctx.StringValue("CreateProductDistributeJob.JobId");
        
			return createProductDistributeJobResponse;
        }
    }
}
