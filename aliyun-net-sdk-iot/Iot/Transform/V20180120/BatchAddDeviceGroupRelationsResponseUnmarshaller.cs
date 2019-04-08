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
        public static BatchAddDeviceGroupRelationsResponse Unmarshall(UnmarshallerContext context)
        {
			BatchAddDeviceGroupRelationsResponse batchAddDeviceGroupRelationsResponse = new BatchAddDeviceGroupRelationsResponse();

			batchAddDeviceGroupRelationsResponse.HttpResponse = context.HttpResponse;
			batchAddDeviceGroupRelationsResponse.RequestId = context.StringValue("BatchAddDeviceGroupRelations.RequestId");
			batchAddDeviceGroupRelationsResponse.Success = context.BooleanValue("BatchAddDeviceGroupRelations.Success");
			batchAddDeviceGroupRelationsResponse.Code = context.StringValue("BatchAddDeviceGroupRelations.Code");
			batchAddDeviceGroupRelationsResponse.ValidDeviceCount = context.IntegerValue("BatchAddDeviceGroupRelations.ValidDeviceCount");
			batchAddDeviceGroupRelationsResponse.ExceedTenGroupDeviceCount = context.IntegerValue("BatchAddDeviceGroupRelations.ExceedTenGroupDeviceCount");
			batchAddDeviceGroupRelationsResponse.AlreadyRelatedGroupDeviceCount = context.IntegerValue("BatchAddDeviceGroupRelations.AlreadyRelatedGroupDeviceCount");
			batchAddDeviceGroupRelationsResponse.SuccessAddedDeviceCount = context.IntegerValue("BatchAddDeviceGroupRelations.SuccessAddedDeviceCount");
			batchAddDeviceGroupRelationsResponse.ErrorMessage = context.StringValue("BatchAddDeviceGroupRelations.ErrorMessage");
        
			return batchAddDeviceGroupRelationsResponse;
        }
    }
}
