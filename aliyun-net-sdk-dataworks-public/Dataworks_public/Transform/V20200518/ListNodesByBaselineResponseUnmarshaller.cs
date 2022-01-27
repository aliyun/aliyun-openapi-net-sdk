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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListNodesByBaselineResponseUnmarshaller
    {
        public static ListNodesByBaselineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesByBaselineResponse listNodesByBaselineResponse = new ListNodesByBaselineResponse();

			listNodesByBaselineResponse.HttpResponse = _ctx.HttpResponse;
			listNodesByBaselineResponse.Success = _ctx.StringValue("ListNodesByBaseline.Success");
			listNodesByBaselineResponse.ErrorCode = _ctx.StringValue("ListNodesByBaseline.ErrorCode");
			listNodesByBaselineResponse.ErrorMessage = _ctx.StringValue("ListNodesByBaseline.ErrorMessage");
			listNodesByBaselineResponse.HttpStatusCode = _ctx.IntegerValue("ListNodesByBaseline.HttpStatusCode");
			listNodesByBaselineResponse.RequestId = _ctx.StringValue("ListNodesByBaseline.RequestId");

			List<ListNodesByBaselineResponse.ListNodesByBaseline_DataItem> listNodesByBaselineResponse_data = new List<ListNodesByBaselineResponse.ListNodesByBaseline_DataItem>();
			for (int i = 0; i < _ctx.Length("ListNodesByBaseline.Data.Length"); i++) {
				ListNodesByBaselineResponse.ListNodesByBaseline_DataItem dataItem = new ListNodesByBaselineResponse.ListNodesByBaseline_DataItem();
				dataItem.NodeId = _ctx.LongValue("ListNodesByBaseline.Data["+ i +"].NodeId");
				dataItem.NodeName = _ctx.StringValue("ListNodesByBaseline.Data["+ i +"].NodeName");
				dataItem.Owner = _ctx.StringValue("ListNodesByBaseline.Data["+ i +"].Owner");
				dataItem.ProjectId = _ctx.LongValue("ListNodesByBaseline.Data["+ i +"].ProjectId");

				listNodesByBaselineResponse_data.Add(dataItem);
			}
			listNodesByBaselineResponse.Data = listNodesByBaselineResponse_data;
        
			return listNodesByBaselineResponse;
        }
    }
}
