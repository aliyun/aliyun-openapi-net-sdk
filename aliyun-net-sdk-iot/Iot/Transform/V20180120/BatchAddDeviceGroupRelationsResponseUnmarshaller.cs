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
    public class BatchAddDeviceGroupRelationsResponseUnmarshaller
    {
        public static BatchAddDeviceGroupRelationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchAddDeviceGroupRelationsResponse batchAddDeviceGroupRelationsResponse = new BatchAddDeviceGroupRelationsResponse();

			batchAddDeviceGroupRelationsResponse.HttpResponse = _ctx.HttpResponse;
			batchAddDeviceGroupRelationsResponse.RequestId = _ctx.StringValue("BatchAddDeviceGroupRelations.RequestId");
			batchAddDeviceGroupRelationsResponse.Success = _ctx.BooleanValue("BatchAddDeviceGroupRelations.Success");
			batchAddDeviceGroupRelationsResponse.Code = _ctx.StringValue("BatchAddDeviceGroupRelations.Code");
			batchAddDeviceGroupRelationsResponse.ValidDeviceCount = _ctx.IntegerValue("BatchAddDeviceGroupRelations.ValidDeviceCount");
			batchAddDeviceGroupRelationsResponse.ExceedTenGroupDeviceCount = _ctx.IntegerValue("BatchAddDeviceGroupRelations.ExceedTenGroupDeviceCount");
			batchAddDeviceGroupRelationsResponse.AlreadyRelatedGroupDeviceCount = _ctx.IntegerValue("BatchAddDeviceGroupRelations.AlreadyRelatedGroupDeviceCount");
			batchAddDeviceGroupRelationsResponse.SuccessAddedDeviceCount = _ctx.IntegerValue("BatchAddDeviceGroupRelations.SuccessAddedDeviceCount");
			batchAddDeviceGroupRelationsResponse.ErrorMessage = _ctx.StringValue("BatchAddDeviceGroupRelations.ErrorMessage");
        
			return batchAddDeviceGroupRelationsResponse;
        }
    }
}
