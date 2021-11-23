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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeColdStorageResponseUnmarshaller
    {
        public static DescribeColdStorageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeColdStorageResponse describeColdStorageResponse = new DescribeColdStorageResponse();

			describeColdStorageResponse.HttpResponse = _ctx.HttpResponse;
			describeColdStorageResponse.OpenStatus = _ctx.StringValue("DescribeColdStorage.OpenStatus");
			describeColdStorageResponse.RequestId = _ctx.StringValue("DescribeColdStorage.RequestId");
			describeColdStorageResponse.PayType = _ctx.StringValue("DescribeColdStorage.PayType");
			describeColdStorageResponse.ColdStorageUsePercent = _ctx.StringValue("DescribeColdStorage.ColdStorageUsePercent");
			describeColdStorageResponse.ColdStorageUseAmount = _ctx.StringValue("DescribeColdStorage.ColdStorageUseAmount");
			describeColdStorageResponse.ColdStorageSize = _ctx.StringValue("DescribeColdStorage.ColdStorageSize");
			describeColdStorageResponse.ColdStorageType = _ctx.StringValue("DescribeColdStorage.ColdStorageType");
			describeColdStorageResponse.ClusterId = _ctx.StringValue("DescribeColdStorage.ClusterId");
        
			return describeColdStorageResponse;
        }
    }
}
