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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class GetConsumerListResponseUnmarshaller
    {
        public static GetConsumerListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetConsumerListResponse getConsumerListResponse = new GetConsumerListResponse();

			getConsumerListResponse.HttpResponse = _ctx.HttpResponse;
			getConsumerListResponse.Code = _ctx.IntegerValue("GetConsumerList.Code");
			getConsumerListResponse.Message = _ctx.StringValue("GetConsumerList.Message");
			getConsumerListResponse.RequestId = _ctx.StringValue("GetConsumerList.RequestId");
			getConsumerListResponse.Success = _ctx.BooleanValue("GetConsumerList.Success");

			List<GetConsumerListResponse.GetConsumerList_ConsumerVO> getConsumerListResponse_consumerList = new List<GetConsumerListResponse.GetConsumerList_ConsumerVO>();
			for (int i = 0; i < _ctx.Length("GetConsumerList.ConsumerList.Length"); i++) {
				GetConsumerListResponse.GetConsumerList_ConsumerVO consumerVO = new GetConsumerListResponse.GetConsumerList_ConsumerVO();
				consumerVO.ConsumerId = _ctx.StringValue("GetConsumerList.ConsumerList["+ i +"].ConsumerId");
				consumerVO.InstanceId = _ctx.StringValue("GetConsumerList.ConsumerList["+ i +"].InstanceId");
				consumerVO.Remark = _ctx.StringValue("GetConsumerList.ConsumerList["+ i +"].Remark");
				consumerVO.RegionId = _ctx.StringValue("GetConsumerList.ConsumerList["+ i +"].RegionId");

				List<GetConsumerListResponse.GetConsumerList_ConsumerVO.GetConsumerList_TagVO> consumerVO_tags = new List<GetConsumerListResponse.GetConsumerList_ConsumerVO.GetConsumerList_TagVO>();
				for (int j = 0; j < _ctx.Length("GetConsumerList.ConsumerList["+ i +"].Tags.Length"); j++) {
					GetConsumerListResponse.GetConsumerList_ConsumerVO.GetConsumerList_TagVO tagVO = new GetConsumerListResponse.GetConsumerList_ConsumerVO.GetConsumerList_TagVO();
					tagVO.Key = _ctx.StringValue("GetConsumerList.ConsumerList["+ i +"].Tags["+ j +"].Key");
					tagVO._Value = _ctx.StringValue("GetConsumerList.ConsumerList["+ i +"].Tags["+ j +"].Value");

					consumerVO_tags.Add(tagVO);
				}
				consumerVO.Tags = consumerVO_tags;

				getConsumerListResponse_consumerList.Add(consumerVO);
			}
			getConsumerListResponse.ConsumerList = getConsumerListResponse_consumerList;
        
			return getConsumerListResponse;
        }
    }
}
