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
    public class ListProductQuotaDimensionsResponseUnmarshaller
    {
        public static ListProductQuotaDimensionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProductQuotaDimensionsResponse listProductQuotaDimensionsResponse = new ListProductQuotaDimensionsResponse();

			listProductQuotaDimensionsResponse.HttpResponse = _ctx.HttpResponse;
			listProductQuotaDimensionsResponse.TotalCount = _ctx.IntegerValue("ListProductQuotaDimensions.TotalCount");
			listProductQuotaDimensionsResponse.RequestId = _ctx.StringValue("ListProductQuotaDimensions.RequestId");
			listProductQuotaDimensionsResponse.NextToken = _ctx.StringValue("ListProductQuotaDimensions.NextToken");
			listProductQuotaDimensionsResponse.MaxResults = _ctx.IntegerValue("ListProductQuotaDimensions.MaxResults");

			List<ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem> listProductQuotaDimensionsResponse_quotaDimensions = new List<ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem>();
			for (int i = 0; i < _ctx.Length("ListProductQuotaDimensions.QuotaDimensions.Length"); i++) {
				ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem quotaDimensionsItem = new ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem();
				quotaDimensionsItem.DimensionKey = _ctx.StringValue("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DimensionKey");
				quotaDimensionsItem.Name = _ctx.StringValue("ListProductQuotaDimensions.QuotaDimensions["+ i +"].Name");
				quotaDimensionsItem.Requisite = _ctx.BooleanValue("ListProductQuotaDimensions.QuotaDimensions["+ i +"].Requisite");

				List<string> quotaDimensionsItem_dimensionValues = new List<string>();
				for (int j = 0; j < _ctx.Length("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DimensionValues.Length"); j++) {
					quotaDimensionsItem_dimensionValues.Add(_ctx.StringValue("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DimensionValues["+ j +"]"));
				}
				quotaDimensionsItem.DimensionValues = quotaDimensionsItem_dimensionValues;

				List<string> quotaDimensionsItem_dependentDimensions = new List<string>();
				for (int j = 0; j < _ctx.Length("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DependentDimensions.Length"); j++) {
					quotaDimensionsItem_dependentDimensions.Add(_ctx.StringValue("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DependentDimensions["+ j +"]"));
				}
				quotaDimensionsItem.DependentDimensions = quotaDimensionsItem_dependentDimensions;

				List<ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem.ListProductQuotaDimensions_DimensionValueDetailItem> quotaDimensionsItem_dimensionValueDetail = new List<ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem.ListProductQuotaDimensions_DimensionValueDetailItem>();
				for (int j = 0; j < _ctx.Length("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DimensionValueDetail.Length"); j++) {
					ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem.ListProductQuotaDimensions_DimensionValueDetailItem dimensionValueDetailItem = new ListProductQuotaDimensionsResponse.ListProductQuotaDimensions_QuotaDimensionsItem.ListProductQuotaDimensions_DimensionValueDetailItem();
					dimensionValueDetailItem._Value = _ctx.StringValue("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DimensionValueDetail["+ j +"].Value");
					dimensionValueDetailItem.Name = _ctx.StringValue("ListProductQuotaDimensions.QuotaDimensions["+ i +"].DimensionValueDetail["+ j +"].Name");

					quotaDimensionsItem_dimensionValueDetail.Add(dimensionValueDetailItem);
				}
				quotaDimensionsItem.DimensionValueDetail = quotaDimensionsItem_dimensionValueDetail;

				listProductQuotaDimensionsResponse_quotaDimensions.Add(quotaDimensionsItem);
			}
			listProductQuotaDimensionsResponse.QuotaDimensions = listProductQuotaDimensionsResponse_quotaDimensions;
        
			return listProductQuotaDimensionsResponse;
        }
    }
}
