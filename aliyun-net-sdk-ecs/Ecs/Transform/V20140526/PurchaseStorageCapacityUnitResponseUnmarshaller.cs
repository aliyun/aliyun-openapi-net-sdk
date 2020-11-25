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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class PurchaseStorageCapacityUnitResponseUnmarshaller
    {
        public static PurchaseStorageCapacityUnitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PurchaseStorageCapacityUnitResponse purchaseStorageCapacityUnitResponse = new PurchaseStorageCapacityUnitResponse();

			purchaseStorageCapacityUnitResponse.HttpResponse = _ctx.HttpResponse;
			purchaseStorageCapacityUnitResponse.RequestId = _ctx.StringValue("PurchaseStorageCapacityUnit.RequestId");
			purchaseStorageCapacityUnitResponse.OrderId = _ctx.StringValue("PurchaseStorageCapacityUnit.OrderId");

			List<string> purchaseStorageCapacityUnitResponse_storageCapacityUnitIds = new List<string>();
			for (int i = 0; i < _ctx.Length("PurchaseStorageCapacityUnit.StorageCapacityUnitIds.Length"); i++) {
				purchaseStorageCapacityUnitResponse_storageCapacityUnitIds.Add(_ctx.StringValue("PurchaseStorageCapacityUnit.StorageCapacityUnitIds["+ i +"]"));
			}
			purchaseStorageCapacityUnitResponse.StorageCapacityUnitIds = purchaseStorageCapacityUnitResponse_storageCapacityUnitIds;
        
			return purchaseStorageCapacityUnitResponse;
        }
    }
}
