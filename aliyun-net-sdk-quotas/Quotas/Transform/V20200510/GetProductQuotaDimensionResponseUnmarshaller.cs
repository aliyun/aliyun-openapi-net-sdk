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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class GetProductQuotaDimensionResponseUnmarshaller
    {
        public static GetProductQuotaDimensionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProductQuotaDimensionResponse getProductQuotaDimensionResponse = new GetProductQuotaDimensionResponse();

			getProductQuotaDimensionResponse.HttpResponse = _ctx.HttpResponse;
			getProductQuotaDimensionResponse.RequestId = _ctx.StringValue("GetProductQuotaDimension.RequestId");

			GetProductQuotaDimensionResponse.GetProductQuotaDimension_QuotaDimension quotaDimension = new GetProductQuotaDimensionResponse.GetProductQuotaDimension_QuotaDimension();
			quotaDimension.DimensionKey = _ctx.StringValue("GetProductQuotaDimension.QuotaDimension.DimensionKey");
			quotaDimension.Name = _ctx.StringValue("GetProductQuotaDimension.QuotaDimension.Name");

			List<string> quotaDimension_dimensionValues = new List<string>();
			for (int i = 0; i < _ctx.Length("GetProductQuotaDimension.QuotaDimension.DimensionValues.Length"); i++) {
				quotaDimension_dimensionValues.Add(_ctx.StringValue("GetProductQuotaDimension.QuotaDimension.DimensionValues["+ i +"]"));
			}
			quotaDimension.DimensionValues = quotaDimension_dimensionValues;

			List<string> quotaDimension_dependentDimensions = new List<string>();
			for (int i = 0; i < _ctx.Length("GetProductQuotaDimension.QuotaDimension.DependentDimensions.Length"); i++) {
				quotaDimension_dependentDimensions.Add(_ctx.StringValue("GetProductQuotaDimension.QuotaDimension.DependentDimensions["+ i +"]"));
			}
			quotaDimension.DependentDimensions = quotaDimension_dependentDimensions;

			List<GetProductQuotaDimensionResponse.GetProductQuotaDimension_QuotaDimension.GetProductQuotaDimension_DimensionValueDetailItem> quotaDimension_dimensionValueDetail = new List<GetProductQuotaDimensionResponse.GetProductQuotaDimension_QuotaDimension.GetProductQuotaDimension_DimensionValueDetailItem>();
			for (int i = 0; i < _ctx.Length("GetProductQuotaDimension.QuotaDimension.DimensionValueDetail.Length"); i++) {
				GetProductQuotaDimensionResponse.GetProductQuotaDimension_QuotaDimension.GetProductQuotaDimension_DimensionValueDetailItem dimensionValueDetailItem = new GetProductQuotaDimensionResponse.GetProductQuotaDimension_QuotaDimension.GetProductQuotaDimension_DimensionValueDetailItem();
				dimensionValueDetailItem._Value = _ctx.StringValue("GetProductQuotaDimension.QuotaDimension.DimensionValueDetail["+ i +"].Value");
				dimensionValueDetailItem.Name = _ctx.StringValue("GetProductQuotaDimension.QuotaDimension.DimensionValueDetail["+ i +"].Name");

				quotaDimension_dimensionValueDetail.Add(dimensionValueDetailItem);
			}
			quotaDimension.DimensionValueDetail = quotaDimension_dimensionValueDetail;
			getProductQuotaDimensionResponse.QuotaDimension = quotaDimension;
        
			return getProductQuotaDimensionResponse;
        }
    }
}
