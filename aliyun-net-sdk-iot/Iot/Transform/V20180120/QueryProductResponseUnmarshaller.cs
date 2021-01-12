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
    public class QueryProductResponseUnmarshaller
    {
        public static QueryProductResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryProductResponse queryProductResponse = new QueryProductResponse();

			queryProductResponse.HttpResponse = _ctx.HttpResponse;
			queryProductResponse.RequestId = _ctx.StringValue("QueryProduct.RequestId");
			queryProductResponse.Success = _ctx.BooleanValue("QueryProduct.Success");
			queryProductResponse.Code = _ctx.StringValue("QueryProduct.Code");
			queryProductResponse.ErrorMessage = _ctx.StringValue("QueryProduct.ErrorMessage");

			QueryProductResponse.QueryProduct_Data data = new QueryProductResponse.QueryProduct_Data();
			data.GmtCreate = _ctx.LongValue("QueryProduct.Data.GmtCreate");
			data.DataFormat = _ctx.IntegerValue("QueryProduct.Data.DataFormat");
			data.Description = _ctx.StringValue("QueryProduct.Data.Description");
			data.DeviceCount = _ctx.IntegerValue("QueryProduct.Data.DeviceCount");
			data.NodeType = _ctx.IntegerValue("QueryProduct.Data.NodeType");
			data.ProductKey = _ctx.StringValue("QueryProduct.Data.ProductKey");
			data.ProductName = _ctx.StringValue("QueryProduct.Data.ProductName");
			data.ProductSecret = _ctx.StringValue("QueryProduct.Data.ProductSecret");
			data.CategoryName = _ctx.StringValue("QueryProduct.Data.CategoryName");
			data.CategoryKey = _ctx.StringValue("QueryProduct.Data.CategoryKey");
			data.AliyunCommodityCode = _ctx.StringValue("QueryProduct.Data.AliyunCommodityCode");
			data.Id2 = _ctx.BooleanValue("QueryProduct.Data.Id2");
			data.ProtocolType = _ctx.StringValue("QueryProduct.Data.ProtocolType");
			data.ProductStatus = _ctx.StringValue("QueryProduct.Data.ProductStatus");
			data.Owner = _ctx.BooleanValue("QueryProduct.Data.Owner");
			data.NetType = _ctx.IntegerValue("QueryProduct.Data.NetType");
			data.AuthType = _ctx.StringValue("QueryProduct.Data.AuthType");
			data.ValidateType = _ctx.IntegerValue("QueryProduct.Data.ValidateType");
			queryProductResponse.Data = data;
        
			return queryProductResponse;
        }
    }
}
