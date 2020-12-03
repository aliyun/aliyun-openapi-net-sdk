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
    public class QueryConsumerGroupListResponseUnmarshaller
    {
        public static QueryConsumerGroupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryConsumerGroupListResponse queryConsumerGroupListResponse = new QueryConsumerGroupListResponse();

			queryConsumerGroupListResponse.HttpResponse = _ctx.HttpResponse;
			queryConsumerGroupListResponse.RequestId = _ctx.StringValue("QueryConsumerGroupList.RequestId");
			queryConsumerGroupListResponse.Success = _ctx.BooleanValue("QueryConsumerGroupList.Success");
			queryConsumerGroupListResponse.ErrorMessage = _ctx.StringValue("QueryConsumerGroupList.ErrorMessage");
			queryConsumerGroupListResponse.PageSize = _ctx.IntegerValue("QueryConsumerGroupList.PageSize");
			queryConsumerGroupListResponse.PageCount = _ctx.IntegerValue("QueryConsumerGroupList.PageCount");
			queryConsumerGroupListResponse.Total = _ctx.IntegerValue("QueryConsumerGroupList.Total");
			queryConsumerGroupListResponse.CurrentPage = _ctx.IntegerValue("QueryConsumerGroupList.CurrentPage");
			queryConsumerGroupListResponse.Code = _ctx.StringValue("QueryConsumerGroupList.Code");

			List<QueryConsumerGroupListResponse.QueryConsumerGroupList_ConsumerGroupDTO> queryConsumerGroupListResponse_data = new List<QueryConsumerGroupListResponse.QueryConsumerGroupList_ConsumerGroupDTO>();
			for (int i = 0; i < _ctx.Length("QueryConsumerGroupList.Data.Length"); i++) {
				QueryConsumerGroupListResponse.QueryConsumerGroupList_ConsumerGroupDTO consumerGroupDTO = new QueryConsumerGroupListResponse.QueryConsumerGroupList_ConsumerGroupDTO();
				consumerGroupDTO.IotId = _ctx.StringValue("QueryConsumerGroupList.Data["+ i +"].IotId");
				consumerGroupDTO.GroupId = _ctx.StringValue("QueryConsumerGroupList.Data["+ i +"].GroupId");
				consumerGroupDTO.GroupName = _ctx.StringValue("QueryConsumerGroupList.Data["+ i +"].GroupName");
				consumerGroupDTO.Creator = _ctx.StringValue("QueryConsumerGroupList.Data["+ i +"].Creator");
				consumerGroupDTO.CreateTime = _ctx.StringValue("QueryConsumerGroupList.Data["+ i +"].CreateTime");
				consumerGroupDTO.AuthType = _ctx.StringValue("QueryConsumerGroupList.Data["+ i +"].AuthType");
				consumerGroupDTO.CloudCommodityType = _ctx.StringValue("QueryConsumerGroupList.Data["+ i +"].CloudCommodityType");

				queryConsumerGroupListResponse_data.Add(consumerGroupDTO);
			}
			queryConsumerGroupListResponse.Data = queryConsumerGroupListResponse_data;
        
			return queryConsumerGroupListResponse;
        }
    }
}
