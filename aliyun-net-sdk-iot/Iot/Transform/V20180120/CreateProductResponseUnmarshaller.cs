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
    public class CreateProductResponseUnmarshaller
    {
        public static CreateProductResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateProductResponse createProductResponse = new CreateProductResponse();

			createProductResponse.HttpResponse = _ctx.HttpResponse;
			createProductResponse.RequestId = _ctx.StringValue("CreateProduct.RequestId");
			createProductResponse.Success = _ctx.BooleanValue("CreateProduct.Success");
			createProductResponse.Code = _ctx.StringValue("CreateProduct.Code");
			createProductResponse.ErrorMessage = _ctx.StringValue("CreateProduct.ErrorMessage");
			createProductResponse.ProductKey = _ctx.StringValue("CreateProduct.ProductKey");

			CreateProductResponse.CreateProduct_Data data = new CreateProductResponse.CreateProduct_Data();
			data.DataFormat = _ctx.IntegerValue("CreateProduct.Data.DataFormat");
			data.Description = _ctx.StringValue("CreateProduct.Data.Description");
			data.NodeType = _ctx.IntegerValue("CreateProduct.Data.NodeType");
			data.ProductKey = _ctx.StringValue("CreateProduct.Data.ProductKey");
			data.ProductName = _ctx.StringValue("CreateProduct.Data.ProductName");
			data.AliyunCommodityCode = _ctx.StringValue("CreateProduct.Data.AliyunCommodityCode");
			data.Id2 = _ctx.BooleanValue("CreateProduct.Data.Id2");
			data.ProtocolType = _ctx.StringValue("CreateProduct.Data.ProtocolType");
			data.AuthType = _ctx.StringValue("CreateProduct.Data.AuthType");
			data.ProductSecret = _ctx.StringValue("CreateProduct.Data.ProductSecret");
			createProductResponse.Data = data;
        
			return createProductResponse;
        }
    }
}
