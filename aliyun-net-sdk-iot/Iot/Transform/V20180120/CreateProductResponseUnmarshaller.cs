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
        public static CreateProductResponse Unmarshall(UnmarshallerContext context)
        {
			CreateProductResponse createProductResponse = new CreateProductResponse();

			createProductResponse.HttpResponse = context.HttpResponse;
			createProductResponse.RequestId = context.StringValue("CreateProduct.RequestId");
			createProductResponse.Success = context.BooleanValue("CreateProduct.Success");
			createProductResponse.Code = context.StringValue("CreateProduct.Code");
			createProductResponse.ErrorMessage = context.StringValue("CreateProduct.ErrorMessage");
			createProductResponse.ProductKey = context.StringValue("CreateProduct.ProductKey");

			CreateProductResponse.CreateProduct_Data data = new CreateProductResponse.CreateProduct_Data();
			data.DataFormat = context.IntegerValue("CreateProduct.Data.DataFormat");
			data.Description = context.StringValue("CreateProduct.Data.Description");
			data.NodeType = context.IntegerValue("CreateProduct.Data.NodeType");
			data.ProductKey = context.StringValue("CreateProduct.Data.ProductKey");
			data.ProductName = context.StringValue("CreateProduct.Data.ProductName");
			data.AliyunCommodityCode = context.StringValue("CreateProduct.Data.AliyunCommodityCode");
			data.Id2 = context.BooleanValue("CreateProduct.Data.Id2");
			data.ProtocolType = context.StringValue("CreateProduct.Data.ProtocolType");
			data.AuthType = context.StringValue("CreateProduct.Data.AuthType");
			data.ProductSecret = context.StringValue("CreateProduct.Data.ProductSecret");
			createProductResponse.Data = data;
        
			return createProductResponse;
        }
    }
}
