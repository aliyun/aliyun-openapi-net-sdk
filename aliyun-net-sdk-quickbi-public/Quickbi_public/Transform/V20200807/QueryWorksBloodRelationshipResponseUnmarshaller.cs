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
using Aliyun.Acs.quickbi_public.Model.V20200807;

namespace Aliyun.Acs.quickbi_public.Transform.V20200807
{
    public class QueryWorksBloodRelationshipResponseUnmarshaller
    {
        public static QueryWorksBloodRelationshipResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWorksBloodRelationshipResponse queryWorksBloodRelationshipResponse = new QueryWorksBloodRelationshipResponse();

			queryWorksBloodRelationshipResponse.HttpResponse = _ctx.HttpResponse;
			queryWorksBloodRelationshipResponse.Success = _ctx.BooleanValue("QueryWorksBloodRelationship.Success");
			queryWorksBloodRelationshipResponse.RequestId = _ctx.StringValue("QueryWorksBloodRelationship.RequestId");

			List<QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item> queryWorksBloodRelationshipResponse_result = new List<QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item>();
			for (int i = 0; i < _ctx.Length("QueryWorksBloodRelationship.Result.Length"); i++) {
				QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item item = new QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item();
				item.ComponentId = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].ComponentId");
				item.ComponentName = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].ComponentName");
				item.ComponentType = _ctx.IntegerValue("QueryWorksBloodRelationship.Result["+ i +"].ComponentType");
				item.ComponentTypeName = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].ComponentTypeName");
				item.DatasetId = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].DatasetId");

				List<QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item.QueryWorksBloodRelationship_QueryParam> item_queryParams = new List<QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item.QueryWorksBloodRelationship_QueryParam>();
				for (int j = 0; j < _ctx.Length("QueryWorksBloodRelationship.Result["+ i +"].QueryParams.Length"); j++) {
					QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item.QueryWorksBloodRelationship_QueryParam queryParam = new QueryWorksBloodRelationshipResponse.QueryWorksBloodRelationship_Item.QueryWorksBloodRelationship_QueryParam();
					queryParam.Uid = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].QueryParams["+ j +"].Uid");
					queryParam.PathId = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].QueryParams["+ j +"].PathId");
					queryParam.Caption = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].QueryParams["+ j +"].Caption");
					queryParam.DataType = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].QueryParams["+ j +"].DataType");
					queryParam.IsMeasure = _ctx.BooleanValue("QueryWorksBloodRelationship.Result["+ i +"].QueryParams["+ j +"].IsMeasure");
					queryParam.AreaId = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].QueryParams["+ j +"].AreaId");
					queryParam.AreaName = _ctx.StringValue("QueryWorksBloodRelationship.Result["+ i +"].QueryParams["+ j +"].AreaName");

					item_queryParams.Add(queryParam);
				}
				item.QueryParams = item_queryParams;

				queryWorksBloodRelationshipResponse_result.Add(item);
			}
			queryWorksBloodRelationshipResponse.Result = queryWorksBloodRelationshipResponse_result;
        
			return queryWorksBloodRelationshipResponse;
        }
    }
}
