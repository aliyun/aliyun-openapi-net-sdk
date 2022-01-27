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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class CreatePersistentVolumeClaimResponseUnmarshaller
    {
        public static CreatePersistentVolumeClaimResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePersistentVolumeClaimResponse createPersistentVolumeClaimResponse = new CreatePersistentVolumeClaimResponse();

			createPersistentVolumeClaimResponse.HttpResponse = _ctx.HttpResponse;
			createPersistentVolumeClaimResponse.Code = _ctx.IntegerValue("CreatePersistentVolumeClaim.Code");
			createPersistentVolumeClaimResponse.RequestId = _ctx.StringValue("CreatePersistentVolumeClaim.RequestId");
			createPersistentVolumeClaimResponse.ErrMsg = _ctx.StringValue("CreatePersistentVolumeClaim.ErrMsg");

			CreatePersistentVolumeClaimResponse.CreatePersistentVolumeClaim_Result result = new CreatePersistentVolumeClaimResponse.CreatePersistentVolumeClaim_Result();
			result.PersistentVolumeClaimId = _ctx.LongValue("CreatePersistentVolumeClaim.Result.PersistentVolumeClaimId");
			createPersistentVolumeClaimResponse.Result = result;
        
			return createPersistentVolumeClaimResponse;
        }
    }
}
