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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class GetProduceOrderByTagResponseUnmarshaller
    {
        public static GetProduceOrderByTagResponse Unmarshall(UnmarshallerContext context)
        {
			GetProduceOrderByTagResponse getProduceOrderByTagResponse = new GetProduceOrderByTagResponse();

			getProduceOrderByTagResponse.HttpResponse = context.HttpResponse;
			getProduceOrderByTagResponse.RequestId = context.StringValue("GetProduceOrderByTag.RequestId");
			getProduceOrderByTagResponse.Success = context.BooleanValue("GetProduceOrderByTag.Success");
			getProduceOrderByTagResponse.OrderId = context.StringValue("GetProduceOrderByTag.OrderId");
			getProduceOrderByTagResponse.OrderCode = context.StringValue("GetProduceOrderByTag.OrderCode");
			getProduceOrderByTagResponse.SourceOrderCode = context.StringValue("GetProduceOrderByTag.SourceOrderCode");
			getProduceOrderByTagResponse.CaseId = context.StringValue("GetProduceOrderByTag.CaseId");
			getProduceOrderByTagResponse.CaseCode = context.StringValue("GetProduceOrderByTag.CaseCode");
			getProduceOrderByTagResponse.Tag = context.StringValue("GetProduceOrderByTag.Tag");
			getProduceOrderByTagResponse.Barcode = context.StringValue("GetProduceOrderByTag.Barcode");
			getProduceOrderByTagResponse.SKUId = context.StringValue("GetProduceOrderByTag.SKUId");
			getProduceOrderByTagResponse.ProductId = context.StringValue("GetProduceOrderByTag.ProductId");
			getProduceOrderByTagResponse.ProductCode = context.StringValue("GetProduceOrderByTag.ProductCode");
			getProduceOrderByTagResponse.ProductName = context.StringValue("GetProduceOrderByTag.ProductName");
			getProduceOrderByTagResponse.ProductColorCode = context.StringValue("GetProduceOrderByTag.ProductColorCode");
			getProduceOrderByTagResponse.ProductColorId = context.StringValue("GetProduceOrderByTag.ProductColorId");
			getProduceOrderByTagResponse.ProductColorName = context.StringValue("GetProduceOrderByTag.ProductColorName");
			getProduceOrderByTagResponse.ProductSizeCode = context.StringValue("GetProduceOrderByTag.ProductSizeCode");
			getProduceOrderByTagResponse.ProductSizeId = context.StringValue("GetProduceOrderByTag.ProductSizeId");
			getProduceOrderByTagResponse.ProductSizeName = context.StringValue("GetProduceOrderByTag.ProductSizeName");
			getProduceOrderByTagResponse.SKUName = context.StringValue("GetProduceOrderByTag.SKUName");
        
			return getProduceOrderByTagResponse;
        }
    }
}
