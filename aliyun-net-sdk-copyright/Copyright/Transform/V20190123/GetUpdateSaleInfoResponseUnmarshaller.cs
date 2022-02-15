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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetUpdateSaleInfoResponseUnmarshaller
    {
        public static GetUpdateSaleInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUpdateSaleInfoResponse getUpdateSaleInfoResponse = new GetUpdateSaleInfoResponse();

			getUpdateSaleInfoResponse.HttpResponse = _ctx.HttpResponse;
			getUpdateSaleInfoResponse.RequestId = _ctx.StringValue("GetUpdateSaleInfo.RequestId");
			getUpdateSaleInfoResponse.Success = _ctx.BooleanValue("GetUpdateSaleInfo.Success");
			getUpdateSaleInfoResponse.CommodityCode = _ctx.StringValue("GetUpdateSaleInfo.CommodityCode");
			getUpdateSaleInfoResponse.InstanceId = _ctx.StringValue("GetUpdateSaleInfo.InstanceId");

			List<string> getUpdateSaleInfoResponse_skuList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetUpdateSaleInfo.SkuList.Length"); i++) {
				getUpdateSaleInfoResponse_skuList.Add(_ctx.StringValue("GetUpdateSaleInfo.SkuList["+ i +"]"));
			}
			getUpdateSaleInfoResponse.SkuList = getUpdateSaleInfoResponse_skuList;
        
			return getUpdateSaleInfoResponse;
        }
    }
}
