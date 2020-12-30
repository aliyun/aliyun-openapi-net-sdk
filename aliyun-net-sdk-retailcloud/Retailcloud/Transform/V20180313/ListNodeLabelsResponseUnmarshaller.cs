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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListNodeLabelsResponseUnmarshaller
    {
        public static ListNodeLabelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeLabelsResponse listNodeLabelsResponse = new ListNodeLabelsResponse();

			listNodeLabelsResponse.HttpResponse = _ctx.HttpResponse;
			listNodeLabelsResponse.Code = _ctx.IntegerValue("ListNodeLabels.Code");
			listNodeLabelsResponse.ErrorMsg = _ctx.StringValue("ListNodeLabels.ErrorMsg");
			listNodeLabelsResponse.PageNumber = _ctx.IntegerValue("ListNodeLabels.PageNumber");
			listNodeLabelsResponse.PageSize = _ctx.IntegerValue("ListNodeLabels.PageSize");
			listNodeLabelsResponse.RequestId = _ctx.StringValue("ListNodeLabels.RequestId");
			listNodeLabelsResponse.TotalCount = _ctx.LongValue("ListNodeLabels.TotalCount");

			List<ListNodeLabelsResponse.ListNodeLabels_ListNodeLabelResponse> listNodeLabelsResponse_data = new List<ListNodeLabelsResponse.ListNodeLabels_ListNodeLabelResponse>();
			for (int i = 0; i < _ctx.Length("ListNodeLabels.Data.Length"); i++) {
				ListNodeLabelsResponse.ListNodeLabels_ListNodeLabelResponse listNodeLabelResponse = new ListNodeLabelsResponse.ListNodeLabels_ListNodeLabelResponse();
				listNodeLabelResponse.ClusterId = _ctx.StringValue("ListNodeLabels.Data["+ i +"].ClusterId");
				listNodeLabelResponse.Id = _ctx.LongValue("ListNodeLabels.Data["+ i +"].Id");
				listNodeLabelResponse.LabelKey = _ctx.StringValue("ListNodeLabels.Data["+ i +"].LabelKey");
				listNodeLabelResponse.LabelValue = _ctx.StringValue("ListNodeLabels.Data["+ i +"].LabelValue");

				listNodeLabelsResponse_data.Add(listNodeLabelResponse);
			}
			listNodeLabelsResponse.Data = listNodeLabelsResponse_data;
        
			return listNodeLabelsResponse;
        }
    }
}
