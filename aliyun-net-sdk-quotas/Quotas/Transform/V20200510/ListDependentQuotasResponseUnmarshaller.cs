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
    public class ListDependentQuotasResponseUnmarshaller
    {
        public static ListDependentQuotasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDependentQuotasResponse listDependentQuotasResponse = new ListDependentQuotasResponse();

			listDependentQuotasResponse.HttpResponse = _ctx.HttpResponse;
			listDependentQuotasResponse.RequestId = _ctx.StringValue("ListDependentQuotas.RequestId");

			List<ListDependentQuotasResponse.ListDependentQuotas_QuotasItem> listDependentQuotasResponse_quotas = new List<ListDependentQuotasResponse.ListDependentQuotas_QuotasItem>();
			for (int i = 0; i < _ctx.Length("ListDependentQuotas.Quotas.Length"); i++) {
				ListDependentQuotasResponse.ListDependentQuotas_QuotasItem quotasItem = new ListDependentQuotasResponse.ListDependentQuotas_QuotasItem();
				quotasItem.QuotaActionCode = _ctx.StringValue("ListDependentQuotas.Quotas["+ i +"].QuotaActionCode");
				quotasItem.ProductCode = _ctx.StringValue("ListDependentQuotas.Quotas["+ i +"].ProductCode");
				quotasItem.Scale = _ctx.FloatValue("ListDependentQuotas.Quotas["+ i +"].Scale");

				List<ListDependentQuotasResponse.ListDependentQuotas_QuotasItem.ListDependentQuotas_DimensionsItem> quotasItem_dimensions = new List<ListDependentQuotasResponse.ListDependentQuotas_QuotasItem.ListDependentQuotas_DimensionsItem>();
				for (int j = 0; j < _ctx.Length("ListDependentQuotas.Quotas["+ i +"].Dimensions.Length"); j++) {
					ListDependentQuotasResponse.ListDependentQuotas_QuotasItem.ListDependentQuotas_DimensionsItem dimensionsItem = new ListDependentQuotasResponse.ListDependentQuotas_QuotasItem.ListDependentQuotas_DimensionsItem();
					dimensionsItem.DimensionKey = _ctx.StringValue("ListDependentQuotas.Quotas["+ i +"].Dimensions["+ j +"].DimensionKey");

					List<string> dimensionsItem_dimensionValues = new List<string>();
					for (int k = 0; k < _ctx.Length("ListDependentQuotas.Quotas["+ i +"].Dimensions["+ j +"].DimensionValues.Length"); k++) {
						dimensionsItem_dimensionValues.Add(_ctx.StringValue("ListDependentQuotas.Quotas["+ i +"].Dimensions["+ j +"].DimensionValues["+ k +"]"));
					}
					dimensionsItem.DimensionValues = dimensionsItem_dimensionValues;

					List<string> dimensionsItem_dependentDimension = new List<string>();
					for (int k = 0; k < _ctx.Length("ListDependentQuotas.Quotas["+ i +"].Dimensions["+ j +"].DependentDimension.Length"); k++) {
						dimensionsItem_dependentDimension.Add(_ctx.StringValue("ListDependentQuotas.Quotas["+ i +"].Dimensions["+ j +"].DependentDimension["+ k +"]"));
					}
					dimensionsItem.DependentDimension = dimensionsItem_dependentDimension;

					quotasItem_dimensions.Add(dimensionsItem);
				}
				quotasItem.Dimensions = quotasItem_dimensions;

				listDependentQuotasResponse_quotas.Add(quotasItem);
			}
			listDependentQuotasResponse.Quotas = listDependentQuotasResponse_quotas;
        
			return listDependentQuotasResponse;
        }
    }
}
