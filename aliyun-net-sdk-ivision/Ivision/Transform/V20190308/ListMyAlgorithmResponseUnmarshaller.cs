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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class ListMyAlgorithmResponseUnmarshaller
    {
        public static ListMyAlgorithmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMyAlgorithmResponse listMyAlgorithmResponse = new ListMyAlgorithmResponse();

			listMyAlgorithmResponse.HttpResponse = _ctx.HttpResponse;
			listMyAlgorithmResponse.Message = _ctx.StringValue("ListMyAlgorithm.Message");
			listMyAlgorithmResponse.RequestId = _ctx.StringValue("ListMyAlgorithm.RequestId");
			listMyAlgorithmResponse.Code = _ctx.StringValue("ListMyAlgorithm.Code");
			listMyAlgorithmResponse.Success = _ctx.BooleanValue("ListMyAlgorithm.Success");

			ListMyAlgorithmResponse.ListMyAlgorithm_Data data = new ListMyAlgorithmResponse.ListMyAlgorithm_Data();
			data.PageSize = _ctx.IntegerValue("ListMyAlgorithm.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("ListMyAlgorithm.Data.PageNumber");
			data.TotalCount = _ctx.IntegerValue("ListMyAlgorithm.Data.TotalCount");

			List<ListMyAlgorithmResponse.ListMyAlgorithm_Data.ListMyAlgorithm_AlgorithmListItem> data_algorithmList = new List<ListMyAlgorithmResponse.ListMyAlgorithm_Data.ListMyAlgorithm_AlgorithmListItem>();
			for (int i = 0; i < _ctx.Length("ListMyAlgorithm.Data.AlgorithmList.Length"); i++) {
				ListMyAlgorithmResponse.ListMyAlgorithm_Data.ListMyAlgorithm_AlgorithmListItem algorithmListItem = new ListMyAlgorithmResponse.ListMyAlgorithm_Data.ListMyAlgorithm_AlgorithmListItem();
				algorithmListItem.AlgorithmName = _ctx.StringValue("ListMyAlgorithm.Data.AlgorithmList["+ i +"].AlgorithmName");
				algorithmListItem.DeployRegion = _ctx.StringValue("ListMyAlgorithm.Data.AlgorithmList["+ i +"].DeployRegion");
				algorithmListItem.CurrentMonthCount = _ctx.IntegerValue("ListMyAlgorithm.Data.AlgorithmList["+ i +"].CurrentMonthCount");
				algorithmListItem.AlgorithmCode = _ctx.StringValue("ListMyAlgorithm.Data.AlgorithmList["+ i +"].AlgorithmCode");
				algorithmListItem.ApiDocUrl = _ctx.StringValue("ListMyAlgorithm.Data.AlgorithmList["+ i +"].ApiDocUrl");
				algorithmListItem.YesterdayCount = _ctx.IntegerValue("ListMyAlgorithm.Data.AlgorithmList["+ i +"].YesterdayCount");
				algorithmListItem.AlgorithmOrder = _ctx.IntegerValue("ListMyAlgorithm.Data.AlgorithmList["+ i +"].AlgorithmOrder");

				data_algorithmList.Add(algorithmListItem);
			}
			data.AlgorithmList = data_algorithmList;
			listMyAlgorithmResponse.Data = data;
        
			return listMyAlgorithmResponse;
        }
    }
}
