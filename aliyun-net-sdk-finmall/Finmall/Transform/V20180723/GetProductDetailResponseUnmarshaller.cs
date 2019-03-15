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
using Aliyun.Acs.finmall.Model.V20180723;

namespace Aliyun.Acs.finmall.Transform.V20180723
{
    public class GetProductDetailResponseUnmarshaller
    {
        public static GetProductDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetProductDetailResponse getProductDetailResponse = new GetProductDetailResponse();

			getProductDetailResponse.HttpResponse = context.HttpResponse;
			getProductDetailResponse.RequestId = context.StringValue("GetProductDetail.RequestId");
			getProductDetailResponse.Message = context.StringValue("GetProductDetail.Message");
			getProductDetailResponse.Code = context.StringValue("GetProductDetail.Code");

			GetProductDetailResponse.GetProductDetail_Data data = new GetProductDetailResponse.GetProductDetail_Data();
			data.ProductId = context.StringValue("GetProductDetail.Data.ProductId");
			data.ProductName = context.StringValue("GetProductDetail.Data.ProductName");
			data.LendingOrganizations = context.StringValue("GetProductDetail.Data.LendingOrganizations");
			data.Terms = context.StringValue("GetProductDetail.Data.Terms");
			data.DailyRate = context.StringValue("GetProductDetail.Data.DailyRate");
			data.YearRate = context.StringValue("GetProductDetail.Data.YearRate");
			data.FoundPartyName = context.StringValue("GetProductDetail.Data.FoundPartyName");
			data.FoundPartyId = context.StringValue("GetProductDetail.Data.FoundPartyId");
			data.InterestRate = context.StringValue("GetProductDetail.Data.InterestRate");
			data.PrincipalLimit = context.StringValue("GetProductDetail.Data.PrincipalLimit");
			data.FinancialInfo = context.StringValue("GetProductDetail.Data.FinancialInfo");
			data.FineAmount = context.StringValue("GetProductDetail.Data.FineAmount");
			data.Comment = context.StringValue("GetProductDetail.Data.Comment");
			getProductDetailResponse.Data = data;
        
			return getProductDetailResponse;
        }
    }
}
